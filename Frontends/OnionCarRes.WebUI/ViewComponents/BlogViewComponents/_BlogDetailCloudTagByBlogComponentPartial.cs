using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnionCarRes.Dto.BlogDtos;
using OnionCarRes.Dto.TagCloudDtos;

namespace OnionCarRes.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailCloudTagByBlogComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _BlogDetailCloudTagByBlogComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
