using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionCarRes.Application.Features.CQRS.Commands.BrandCommands;
using OnionCarRes.Application.Features.CQRS.Commands.CarCommands;
using OnionCarRes.Application.Features.CQRS.Handlers.BrandHandlers;
using OnionCarRes.Application.Features.CQRS.Handlers.CarHandlers;
using OnionCarRes.Application.Features.CQRS.Queries.BrandQueries;
using OnionCarRes.Application.Features.CQRS.Queries.CarQueries;

namespace OnionCarRes.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        private readonly UpdateCarCommandHandler _updateCarCommandHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
        private readonly GetCarQueryHandler _getCarQueryHandler;

        public CarsController(CreateCarCommandHandler createCommandHandler, UpdateCarCommandHandler updateCommandHandler, RemoveCarCommandHandler removeCommandHandler, GetCarByIdQueryHandler getCarByIdQueryHandler, GetCarQueryHandler getCarQueryHandler)
        {
            _createCarCommandHandler = createCommandHandler;
            _updateCarCommandHandler = updateCommandHandler;
            _removeCarCommandHandler = removeCommandHandler;
            _getCarByIdQueryHandler = getCarByIdQueryHandler;
            _getCarQueryHandler = getCarQueryHandler;
        }
        [HttpGet]
        public async Task<IActionResult> BrandList()
        {
            var values = await _getCarQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrand(int id)
        {
            var value = await _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            await _createCarCommandHandler.Handle(command);
            return Ok("Marka Bilgisi Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCar(int id)
        {
            await _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
            return Ok("Marka Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            await _updateCarCommandHandler.Handle(command);
            return Ok("Marka Bilgisi Güncellendi");
        }
    }
}
