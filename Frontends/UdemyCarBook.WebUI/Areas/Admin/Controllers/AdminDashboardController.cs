using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AdminDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
