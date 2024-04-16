using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionCarRes.Application.Features.CQRS.Commands.AboutCommands;
using OnionCarRes.Application.Features.CQRS.Handlers.AboutHandlers;
using OnionCarRes.Application.Features.CQRS.Queries.AboutQueries;

namespace OnionCarRes.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly CreateAboutCommandHandler _createCommandHandler;
        private readonly UpdateAboutCommandHandler _updateCommandHandler;
        private readonly RemoveAboutCommandHandler _removeCommandHandler;
        private readonly GetAboutByIdQueryHandler _getAboutByIdQueryHandler;
        private readonly GetAboutQueryHandler _getAboutQueryHandler;

        public AboutsController(CreateAboutCommandHandler createCommandHandler, UpdateAboutCommandHandler updateCommandHandler, RemoveAboutCommandHandler removeCommandHandler, GetAboutByIdQueryHandler getAboutByIdQueryHandler, GetAboutQueryHandler getAboutQueryHandler)
        {
            _createCommandHandler = createCommandHandler;
            _updateCommandHandler = updateCommandHandler;
            _removeCommandHandler = removeCommandHandler;
            _getAboutByIdQueryHandler = getAboutByIdQueryHandler;
            _getAboutQueryHandler = getAboutQueryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values = await _getAboutQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult>GetAbout(int id)
        {
            var values = await _getAboutByIdQueryHandler.Handle(new GetAboutByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommand command)
        {
            await _createCommandHandler.Handle(command);
            return Ok("Hakkımda bilgisi eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult>RemoveAbout(int id)
        {
            await _removeCommandHandler.Handle(new RemoveAboutCommand(id));
            return Ok("Hakkımda bilgisi silindi");
        }
        [HttpPut]
        public async Task<IActionResult>UpdateAbout (UpdateAboutCommand command)
        {
            await _updateCommandHandler.Handle(command);
            return Ok("Hakkımda bilgisi güncellendi");
        }
    }
}
