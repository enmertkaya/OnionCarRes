using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace OnionCarRes.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _FooterUILayoutComponentPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
