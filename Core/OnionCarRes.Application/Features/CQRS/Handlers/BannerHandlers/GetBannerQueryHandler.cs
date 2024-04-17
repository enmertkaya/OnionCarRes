using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarRes.Application.Features.CQRS.Results.BannerResults;
using OnionCarRes.Domain.Entities;
using OnionCarRes.Application.Interfaces;

namespace OnionCarRes.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerQueryHandler
    {
        private readonly IRepository<Banner> _repository;
        public GetBannerQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetBannerQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBannerQueryResult
            {
                BannerID = x.BannerID,
                Description = x.Description,
                Title = x.Title,
                VideoDescription = x.VideoDescription,
                VideoUrl = x.VideoUrl
            }).ToList();
        }
    }
}
