using Microsoft.AspNetCore.Mvc;
using NASA.Core.Contracts.Admin;

namespace NASA_for_beginners.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService userService;

        public UserController(IUserService _userService)
        {
            userService = _userService;
        }
        public async Task<IActionResult> All()
        {
            var model = await userService.All();

            return View(model);
        }
    }
}
