using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarRes.Application.Features.CQRS.Commands.ContactCommands;
using OnionCarRes.Application.Interfaces;
using OnionCarRes.Domain.Entities;

namespace OnionCarRes.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class CreateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;
        public CreateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateContactCommand command)
        {
            await _repository.CreateAsync(new Contact
            {
                Name = command.Name,
                Email= command.Email,
                Message = command.Message,
                SendDate = command.SendDate,
                Subject = command.Subject
            });
        }
    }
}
