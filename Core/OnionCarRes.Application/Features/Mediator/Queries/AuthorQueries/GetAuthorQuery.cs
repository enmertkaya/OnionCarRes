using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarRes.Application.Features.Mediator.Results.AuthorResults;

namespace OnionCarRes.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorQuery : IRequest<List<GetAuthorQueryResult>>
    {
    }
}
