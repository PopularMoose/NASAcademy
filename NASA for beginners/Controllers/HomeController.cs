using Microsoft.AspNetCore.Mvc;
using NASA.Core.Contracts;
using NASA_for_beginners.Models;
using System.Diagnostics;
using static NASA_for_beginners.Areas.Constants.AdminConstants;

namespace NASA_for_beginners.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICourseService courseService;

        public HomeController(ICourseService _courseService)
        {
            courseService = _courseService;
        }

        public async Task<IActionResult> Index()
        {
            if (User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Admin", new {area = "Admin"});
            }
            var model = await courseService.LastThreeCourses();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}