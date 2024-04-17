using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarRes.Application.Features.CQRS.Commands.AboutCommands;
using OnionCarRes.Domain.Entities;
using OnionCarRes.Application.Interfaces;

namespace OnionCarRes.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _repository;
        public UpdateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateAboutCommand command)
        {
            var values = await _repository.GetByIdAsync(command.AboutID);
            values.Description = command.Description;
            values.Title = command.Title;
            values.ImageUrl = command.ImageUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
