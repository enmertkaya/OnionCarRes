﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarRes.Application.Features.CQRS.Queries.BannerQueries;
using OnionCarRes.Application.Features.CQRS.Queries.BrandQueries;
using OnionCarRes.Application.Features.CQRS.Results.BannerResults;
using OnionCarRes.Application.Features.CQRS.Results.BrandResults;
using OnionCarRes.Domain.Entities;
using OnionCarRes.Application.Interfaces;

namespace OnionCarRes.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;
        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetBrandByIdQueryResult
            {
                BrandID = values.BrandID,
                Name = values.Name
            };
        }
    }
}
