using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.ViewComponents.RentACarFilterViewComponents
{
    public class _RentACarFilterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke (string v)
        {
            TempData["deger"] = v;
            ViewBag.V = v;
            return View();
        }
    }
}
