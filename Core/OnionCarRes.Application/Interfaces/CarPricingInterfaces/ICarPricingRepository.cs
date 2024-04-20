using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using OnionCarRes.Application.ViewModels;
using OnionCarRes.Domain.Entities;

namespace OnionCarRes.Application.Interfaces.CarPricingInterfaces
{
    public interface ICarPricingRepository
    {
        List<CarPricing> GetCarPricingWithCars();
        List<CarPricing> GetCarPricingWithTimePeriod();
        //List<CarPricingViewModel> GetCarPricingWithTimePeriod1();

	}
}
