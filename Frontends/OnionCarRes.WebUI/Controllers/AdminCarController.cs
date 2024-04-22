using Microsoft.AspNetCore.Mvc;

namespace OnionCarRes.WebUI.Controllers
{
    public class AdminCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
