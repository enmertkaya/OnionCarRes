﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarRes.Application.Features.Mediator.Results.StatisticsResults;

namespace OnionCarRes.Application.Features.Mediator.Queries.StatisticsQueries
{
    public class GetCarCountByKmSmallerThen1000Query:IRequest<GetCarCountByKmSmallerThen1000QueryResult>
    {
    }
}
