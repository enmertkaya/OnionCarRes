using Microsoft.AspNetCore.Mvc;

namespace OnionCarRes.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
