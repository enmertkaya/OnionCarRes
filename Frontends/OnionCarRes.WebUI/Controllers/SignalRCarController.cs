using Microsoft.AspNetCore.Mvc;

namespace OnionCarRes.WebUI.Controllers
{
    public class SignalRCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
