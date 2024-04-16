using OnionCarRes.Application.Features.CQRS.Commands.AboutCommands;
using OnionCarRes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarRes.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class CreateAboutCommandHandler
    {
        private readonly IRepository <About> _repository;

        public CreateAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAboutCommand commend)
        {
            await _repository.CreateAsync(new About
            {
                Title = commend.Title,
                Description = commend.Description,
                ImageUrl = commend.ImageUrl
            });
               
        }
    }
}
