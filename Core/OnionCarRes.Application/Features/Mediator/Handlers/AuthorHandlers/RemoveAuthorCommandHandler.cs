﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarRes.Application.Features.Mediator.Commands.AuthorCommands;
using OnionCarRes.Application.Interfaces;
using OnionCarRes.Domain.Entities;

namespace OnionCarRes.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class RemovePricingCommandHandler : IRequestHandler<RemoveAuthorCommand>
    {
        private readonly IRepository<Author> _repository;

        public RemovePricingCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveAuthorCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
