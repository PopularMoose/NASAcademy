using Microsoft.AspNetCore.Mvc;
using NASA_for_beginners.Models;
using System.Diagnostics;

namespace NASA_for_beginners.Controllers
{
    public class HomeController : Controller
    {
     
        
        public IActionResult Index()
        {
            return View();
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}