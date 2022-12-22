using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static NASA_for_beginners.Areas.Constants.AdminConstants;

namespace NASA_for_beginners.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Route("/Admin/[controller]/[Action]/{id?}")]
    [Authorize(Roles = AdminRoleName)]

    public class BaseController : Controller
    {
    }
}
