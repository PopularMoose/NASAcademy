using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NASA.Core.Contracts;
using NASA.Core.Exceptions;
using NASA.Core.Models.Course;
using NASA.Infrastructure.Data;
using NASA.Infrastructure.Data.Common;

namespace NASA.Core.Services
{
    public class CoursesService : ICourseService
    {
        private readonly IRepository repo;

        private readonly IGuard guard;

        private readonly ILogger logger;

        public CoursesService(
            IRepository _repo,
            IGuard _guard,
            ILogger<CoursesService> _logger)
        {
            repo = _repo;
            guard = _guard;
            logger = _logger;
        }

        public async Task<CoursesQuery> All(string? category = null, string? searchTerm = null, CourseSorting sorting = CourseSorting.Newest, int currentPage = 1, int coursesPerPage = 1)
        {
            var result = new CoursesQuery();
            var courses = repo.AllReadonly<Course>()
                .Where(h => h.IsActive);

            if (string.IsNullOrEmpty(category) == false)
            {
                courses = courses
                    .Where(h => h.Category.Name == category);
            }

            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                searchTerm = $"%{searchTerm.ToLower()}%";

                courses = courses
                    .Where(h => EF.Functions.Like(h.Title.ToLower(), searchTerm) ||
  
                        EF.Functions.Like(h.Description.ToLower(), searchTerm));
            }

            //switch (sorting)
            //{
            //    case CourseSorting.Price:
            //        houses = houses
            //        .OrderBy(h => h.PricePerMonth);
            //        break;
            //    case CourseSorting.NotRentedFirst:
            //        houses = houses
            //        .OrderBy(h => h.RenterId);
            //        break;
            //    default:
            //        houses = houses.OrderByDescending(h => h.Id);
            //        break;
            //}

            courses = sorting switch
            {
                CourseSorting.Price => courses
                    .OrderBy(h => h.PricePerCourse),
                CourseSorting.NotTakenFirst => courses
                    .OrderBy(h => h.StudentId),
                _ => courses.OrderByDescending(h => h.Id)
            };

            result.Courses = await courses
                .Skip((currentPage - 1) * coursesPerPage)
                .Take(coursesPerPage)
                .Select(h => new CourseServiceModel() 
                {
                    Id = h.Id,
                    IsBooked = h.StudentId != null,
                    PricePerCourse = h.PricePerCourse,
                    Title = h.Title
                })
                .ToListAsync();

            result.TotalCoursesCount = await courses.CountAsync();

            return result;
        }

        public async Task<IEnumerable<CourseCategory>> AllCategories()
        {
            return await repo.AllReadonly<Category>()
                .OrderBy(c => c.Name)
                .Select(c => new CourseCategory() 
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> AllCategoriesNames()
        {
            return await repo.AllReadonly<Category>()
                .Select(c => c.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<IEnumerable<CourseServiceModel>> AllCoursesByTeacherId(int id)
        {
            return await repo.AllReadonly<Course>()
                .Where(c => c.IsActive)
                .Where(c => c.TeacherId == id)
                .Select(c => new CourseServiceModel() 
                {
                    
                    Id = c.Id,
                   
                    IsBooked = c.StudentId != null,
                    PricePerCourse = c.PricePerCourse,
                    Title = c.Title
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<CourseServiceModel>> AllCoursesByUserId(string userId)
        {
            return await repo.AllReadonly<Course>()
                .Where(c => c.StudentId == userId)
                .Where(c => c.IsActive)
                .Select(c => new CourseServiceModel()
                {
                  
                    Id = c.Id,
                    
                    IsBooked = c.StudentId != null,
                    PricePerCourse = c.PricePerCourse,
                    Title = c.Title
                })
                .ToListAsync();
        }

        public async Task<bool> CategoryExists(int categoryId)
        {
            return await repo.AllReadonly<Category>()
                .AnyAsync(c => c.Id == categoryId);
        }

        public async Task<int> Create(CourseModel model, int teacherId)
        {
            var course = new Course()
            {
                
                CategoryId = model.CategoryId,
                Description = model.Description,
               
                PricePerCourse= model.PricePerCourse,
                Title = model.Title,
                TeacherId = teacherId
            };

            try
            {
                await repo.AddAsync(course);
                await repo.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                logger.LogError(nameof(Create), ex);
                throw new ApplicationException("Database failed to save info", ex);
            }

            return course.Id;
        }

        public async Task Delete(int courseId)
        {
            var house = await repo.GetByIdAsync<Course>(courseId);
            house.IsActive = false;

            await repo.SaveChangesAsync();
        }

        public async Task Edit(int courseId, CourseModel model)
        {
            var house = await repo.GetByIdAsync<Course>(courseId);

            house.Description = model.Description;
            
            house.PricePerCourse = model.PricePerCourse;
            house.Title = model.Title;
            
            house.CategoryId = model.CategoryId;

            await repo.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await repo.AllReadonly<Course>()
                .AnyAsync(h => h.Id == id && h.IsActive);
        }

        public async Task<int> GetCourseCategoryId(int courseId)
        {
            return (await repo.GetByIdAsync<Course>(courseId)).CategoryId;
        }

        public async Task<bool> HasTeacherWithId(int courseId, string currentUserId)
        {
            bool result = false;
            var course = await repo.AllReadonly<Course>()
                .Where(h => h.IsActive)
                .Where(h => h.Id == courseId)
                .Include(h => h.Teacher)
                .FirstOrDefaultAsync();

            if (course?.Teacher != null && course.Teacher.UserId == currentUserId)
            {
                result = true;
            }

            return result;
        }

        public async Task<CourseDetails> CourseDetailsById(int id)
        {
            return await repo.AllReadonly<Course>()
                .Where(h => h.IsActive)
                .Where(h => h.Id == id)
                .Select(h => new CourseDetails() 
                {
                    
                    Category = h.Category.Name,
                    Description = h.Description,
                    Id = id,
                   
                    IsBooked = h.StudentId != null,
                    PricePerCourse= h.PricePerCourse,
                    Title = h.Title,
                    Teacher = new NASA.Core.Models.Teacher.TeacherServiceModel() 
                    {
                        Email = h.Teacher.User.Email,
                        PhoneNumber = h.Teacher.PhoneNumber
                    }
                    
                })
                .FirstAsync();
        }

        public async Task<bool> IsBooked(int courseId)
        {
            return (await repo.GetByIdAsync<Course>(courseId)).StudentId != null; 
        }

        public async Task<bool> IsBookedByUserWithId(int courseId, string currentUserId)
        {
            bool result = false;
            var course = await repo.AllReadonly<Course>()
                .Where(h => h.IsActive)
                .Where(h => h.Id == courseId)
                .FirstOrDefaultAsync();

            if (course != null && course.StudentId == currentUserId)
            {
                result = true;
            }

            return result;
        }

        public async Task<IEnumerable<CourseHome>> LastThreeCourses()
        {
            return await repo.AllReadonly<Course>()
                .Where(h => h.IsActive)
                .OrderByDescending(h => h.Id)
                .Select(h => new CourseHome() 
                {
                    Id = h.Id,
                   
                    Title = h.Title,
                   
                })
                .Take(3)
                .ToListAsync();
        }

        public async Task Leave(int courseId)
        {
            var course = await repo.GetByIdAsync<Course>(courseId);
            guard.AgainstNull(course, "Course can not be found");
            course.StudentId = null;

            await repo.SaveChangesAsync();
        }

        public async Task Book(int courseId, string currentUserId)
        {
            var course = await repo.GetByIdAsync<Course>(courseId);

            if (course != null && course.StudentId != null)
            {
                throw new ArgumentException("Course is already booked");
            }

            guard.AgainstNull(course, "Course can not be found");
            course.StudentId = currentUserId;

            await repo.SaveChangesAsync();
        }
    }
}
