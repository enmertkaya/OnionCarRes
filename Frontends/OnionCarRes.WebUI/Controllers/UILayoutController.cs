using Microsoft.AspNetCore.Mvc;

namespace OnionCarRes.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
