﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OnionCarRes.Dto.AuthorDtos;
using OnionCarRes.Dto.TagCloudDtos;

namespace OnionCarRes.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsAuthorAboutComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _BlogDetailsAuthorAboutComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IViewComponentResult Invoke()
        {

            return View();
        }
    
    }
}