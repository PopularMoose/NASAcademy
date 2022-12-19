using Microsoft.AspNetCore.Mvc;
using NASA.Core.Contracts;
using NASA_for_beginners.Areas.Admin.Models;
using NASA_for_beginners.Extensions;

namespace NASA_for_beginners.Areas.Admin.Controllers
{
    public class CourseController : BaseController
    {
        private readonly ICourseService courseService;

        private readonly ITeacher teacherService;

        public CourseController(ICourseService _courseService, ITeacher _teacherService)
        {
            courseService = _courseService;
            teacherService = _teacherService;
        }

        public async Task<IActionResult> Mine()
        {
            var myCourses = new MyCourseViewModel();
            var adminId = User.Id();

            myCourses.BookedCourses = await courseService.AllCoursesByUserId(adminId);
            var teacherId = await teacherService.GetTeacherId(adminId);
            myCourses.AddedCourses = await courseService.AllCoursesByTeacherId(teacherId);


            return View(myCourses);
        }
    }
}
