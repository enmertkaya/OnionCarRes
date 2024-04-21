using Microsoft.AspNetCore.Mvc;

namespace OnionCarRes.WebUI.ViewComponents.CommentViewComponents
{
    public class _AddCommentComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
