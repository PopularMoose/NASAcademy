using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NASA.Core.Constants;
using NASA.Core.Contracts;
using NASA.Core.Models.Teacher;
using NASA_for_beginners.Extensions;

namespace NASA_for_beginners.Controllers
{
    [Authorize]
    public class TeacherController : Controller
    {
        private readonly ITeacher teacherService;

        public TeacherController(ITeacher _teacherService)
        {
            teacherService = _teacherService;
        }

        [HttpGet]
        public async Task<IActionResult> Become()
        {
            if (await teacherService.ExistsById(User.Id()))
            {
                TempData[MessageConstant.ErrorMessage] = "Вие вече сте Учител";

                return RedirectToAction("Index", "Home");
            }

            var model = new BecomeTeacher();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeTeacher model)
        {
            var userId = User.Id();

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await teacherService.ExistsById(userId))
            {
                TempData[MessageConstant.ErrorMessage] = "Вие вече сте Учител";

                return RedirectToAction("Index", "Home");
            }

            if (await teacherService.TeacherWithPhoneNumberExists(model.PhoneNumber))
            {
                TempData[MessageConstant.ErrorMessage] = "Телефона вече съществува";

                return RedirectToAction("Index", "Home");
            }

            if (await teacherService.TeacherWithPhoneNumberExists(model.Name))
            {
                TempData[MessageConstant.ErrorMessage] = "Името вече съществува";

                return RedirectToAction("Index", "Home");
            }


            if (await teacherService.TeacherHasCourses(userId))
            {
                TempData[MessageConstant.ErrorMessage] = "Не трябва да имате курсове за да станете учител";

                return RedirectToAction("Index", "Home");
            }

            await teacherService.Create(userId, model.PhoneNumber, model.Email, model.Name);

            



            return RedirectToAction("All", "Course");
        }
    }
}
