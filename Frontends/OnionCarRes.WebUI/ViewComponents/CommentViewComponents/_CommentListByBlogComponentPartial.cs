using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnionCarRes.Dto.CommentDtos;
using OnionCarRes.Dto.TagCloudDtos;

namespace OnionCarRes.WebUI.ViewComponents.CommentViewComponents
{
    public class _CommentListByBlogComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _CommentListByBlogComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
