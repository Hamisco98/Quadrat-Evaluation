using Microsoft.AspNetCore.Mvc;

namespace Qudurat.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult UsersManagement()
        {
            return View();
        }
    }
}
