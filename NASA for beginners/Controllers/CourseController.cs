using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NASA.Core.Contracts;
using NASA.Core.Models.Course;
using NASA_for_beginners.Models;
using NASA_for_beginners.Extensions;
using NASA.Core.Extensions;
using static NASA_for_beginners.Areas.Constants.AdminConstants;

namespace NASA_for_beginners.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private readonly ICourseService courseService;

        private readonly ITeacher teacherService;

        private readonly ILogger logger;

        public CourseController(
            ICourseService _courseService,
            ITeacher _teacherService,
            ILogger<CourseController> _logger)
        {
            courseService = _courseService;
            teacherService = _teacherService;
            logger = _logger;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllCoursesQuery query)
        {
            var result = await courseService.All(
                query.Category,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                AllCoursesQuery.CoursesPerPage);

            query.TotalCoursesCount = result.TotalCoursesCount;
            query.Categories = await courseService.AllCategoriesNames();
            query.Courses = result.Courses;

            return View(query);
        }

        public async Task<IActionResult> Mine()
        {
            if (User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Mine", "Course", new { area = AreaName});
            }

            IEnumerable<CourseServiceModel> myCourses;
            var userId = User.Id();

            if (await teacherService.ExistsById(userId))
            {
                int teacherId = await teacherService.GetTeacherId(userId);
                myCourses = await courseService.AllCoursesByTeacherId(teacherId);
            }
            else
            {
                myCourses = await courseService.AllCoursesByUserId(userId);
            }

            return View(myCourses);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id, string information)
        {
            if ((await courseService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            var model = await courseService.CourseDetailsById(id);

            if (information != model.GetInformation())
            {
                TempData["ErrorMessage"] = "Don't touch my slug!";

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add() 
        {
            if ((await teacherService.ExistsById(User.Id())) == false)
            {
                return RedirectToAction(nameof(TeacherController.Become), "Teacher");
            }

            var course = new CourseModel()
            {
                CourseCategories = await courseService.AllCategories()
            };

            return View(course);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CourseModel model)
        {
            if ((await teacherService.ExistsById(User.Id())) == false)
            {
                return RedirectToAction(nameof(TeacherController.Become), "Teacher");
            }

            if ((await courseService.CategoryExists(model.CategoryId)) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exists");
            }

            if (!ModelState.IsValid)
            {
                model.CourseCategories = await courseService.AllCategories();

                return View(model);
            }

            int teacherId = await teacherService.GetTeacherId(User.Id());

            int id = await courseService.Create(model, teacherId);

            return RedirectToAction(nameof(Details), new { id = id, information = model.GetInformation()  });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if ((await courseService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await courseService.HasTeacherWithId(id, User.Id())) == false)
            {
                logger.LogInformation("User with id {0} attempted to open other agent house", User.Id());

                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            var course = await courseService.CourseDetailsById(id);
            var categoryId = await courseService.GetCourseCategoryId(id);

            var model = new CourseModel()
            {
                Id = id,
                ImageUrl = course.ImageUrl,
                CategoryId = categoryId,    
                Description = course.Description,
               
                PricePerCourse = course.PricePerCourse,
                Title = course.Title,
                CourseCategories = await courseService.AllCategories()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CourseModel model)
        {
            if (id != model.Id)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            if ((await courseService.Exists(model.Id)) == false)
            {
                ModelState.AddModelError("", "Course does not exist");
                model.CourseCategories = await courseService.AllCategories();

                return View(model);
            }

            if ((await courseService.HasTeacherWithId(model.Id, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            if ((await courseService.CategoryExists(model.CategoryId)) == false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist");
                model.CourseCategories = await courseService.AllCategories();

                return View(model);
            }

            if (ModelState.IsValid == false)
            {
                model.CourseCategories = await courseService.AllCategories();

                return View(model);
            }

            await courseService.Edit(model.Id, model);

            return RedirectToAction(nameof(Details), new { id = model.Id, information = model.GetInformation() });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if ((await courseService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await courseService.HasTeacherWithId(id, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            var course = await courseService.CourseDetailsById(id);
            var model = new CourseDetailsView()
            {

                ImageUrl = course.ImageUrl,
                Title = course.Title
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id, CourseDetailsView model)
        {
            if ((await courseService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if ((await courseService.HasTeacherWithId(id, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            await courseService.Delete(id);

            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<IActionResult> Book(int id)
        {
            if ((await courseService.Exists(id)) == false)
            {
                return RedirectToAction(nameof(All));
            }

            if (!User.IsInRole(AdminRoleName) && await teacherService.ExistsById(User.Id()))
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            if (await courseService.IsBooked(id))
            {
                return RedirectToAction(nameof(All));
            }

            await courseService.Book(id, User.Id());

            return RedirectToAction(nameof(Mine));
        }

        [HttpPost]
        public async Task<IActionResult> Leave(int id)
        {
            if ((await courseService.Exists(id)) == false)
                
            {
                return RedirectToAction(nameof(All));
            }

            if ((await courseService.IsBookedByUserWithId(id, User.Id())) == false)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            await courseService.Leave(id);

            return RedirectToAction(nameof(Mine));
        }
    }
}
