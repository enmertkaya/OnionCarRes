﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarRes.Application.Features.CQRS.Commands.BrandCommands;
using OnionCarRes.Application.Features.CQRS.Commands.CarCommands;
using OnionCarRes.Application;
using OnionCarRes.Domain.Entities;

namespace OnionCarRes.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;
        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BigImageUrl = command.BigImageUrl,
                Luggage = command.Luggage,
                Km = command.Km,
                Model = command.Model,
                Seat = command.Seat,
                Transmission = command.Transmission,
                CoverImageUrl = command.CoverImageUrl,
                BrandID = command.BrandID,
                Fuel = command.Fuel
            });
        }
    }
}
