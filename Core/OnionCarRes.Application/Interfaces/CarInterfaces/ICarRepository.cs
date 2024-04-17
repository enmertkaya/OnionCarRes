using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarRes.Domain.Entities;

namespace OnionCarRes.Application.Interfaces.CarInterfaces
{
    public interface ICarRepository
    {
        List<Car> GetCarsListWithBrands();
        List<Car> GetLast5CarsWithBrands();
        int GetCarCount();
    }
}
