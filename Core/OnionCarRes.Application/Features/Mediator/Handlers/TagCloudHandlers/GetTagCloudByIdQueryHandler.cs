using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarRes.Application.Features.Mediator.Queries.TagCloudQueries;
using OnionCarRes.Application.Features.Mediator.Results.FeatureResults;
using OnionCarRes.Application.Features.Mediator.Results.TagCloudResults;
using OnionCarRes.Application.Interfaces;
using OnionCarRes.Domain.Entities;

namespace OnionCarRes.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetPricingByIdQueryHandler : IRequestHandler<GetTagCloudByIdQuery, GetTagCloudByIdQueryResult>
    {
        private readonly IRepository<TagCloud> _repository;
        public GetPricingByIdQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task<GetTagCloudByIdQueryResult> Handle(GetTagCloudByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetTagCloudByIdQueryResult
            {
                TagCloudID = values.TagCloudID,
                Title = values.Title,
                BlogID = values.BlogID
            };
        }
    }
}
