using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NASA_for_beginners.Areas.Admin.Controllers
{
    
    public class AdminController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
