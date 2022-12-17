using NASA.Core.Models.Course;

namespace NASA.Core.Contracts
{
    public interface ICourseService
    {
        Task<IEnumerable<CourseHome>> LastThreeCourses();

        Task<IEnumerable<CourseCategory>> AllCategories();

        Task<bool> CategoryExists(int categoryId);

        Task<int> Create(CourseModel model, int teacherId);

        Task<CoursesQuery> All(
            string? category = null,
            string? searchTerm = null,
            CourseSorting sorting = CourseSorting.Newest,
            int currentPage = 1,
            int coursesPerPage = 1);

        Task<IEnumerable<string>> AllCategoriesNames();

        Task<IEnumerable<CourseServiceModel>> AllCoursesByTeacherId(int id);

        Task<IEnumerable<CourseServiceModel>> AllCoursesByUserId(string userId);

        Task<CourseDetails> CourseDetailsById(int id);

        Task<bool> Exists(int id);

        Task Edit(int courseId, CourseModel model);

        Task<bool> HasTeacherWithId(int courseId, string currentUserId);

        Task<int> GetCourseCategoryId(int courseId);

        Task Delete(int courseId);

        Task<bool> IsBooked(int courseId);

        Task<bool> IsBookedByUserWithId(int courseId, string currentUserId);

        Task Book(int courseId, string currentUserId);
        Task Leave(int courseId);
    }
}
