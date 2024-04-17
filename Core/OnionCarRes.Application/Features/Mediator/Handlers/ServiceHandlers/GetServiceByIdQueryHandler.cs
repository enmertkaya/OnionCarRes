using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarRes.Application.Features.Mediator.Queries.ServiceQueries;
using OnionCarRes.Application.Features.Mediator.Results.FeatureResults;
using OnionCarRes.Application.Features.Mediator.Results.ServiceResults;
using OnionCarRes.Application.Interfaces;
using OnionCarRes.Domain.Entities;

namespace OnionCarRes.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetPricingByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;
        public GetPricingByIdQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResult
            {
                ServiceID = values.ServiceID,
                Description = values.Description,
                Title = values.Title,
                IconUrl = values.IconUrl
            };
        }
    }
}
