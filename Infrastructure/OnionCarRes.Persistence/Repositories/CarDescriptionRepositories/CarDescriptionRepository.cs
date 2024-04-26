using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCarRes.Application.Interfaces.CarDescriptionInterfaces;
using OnionCarRes.Domain.Entities;
using OnionCarRes.Persistence.Context;

namespace OnionCarRes.Persistence.Repositories.CarDescriptionRepositories
{
    public class CarDescriptionRepository : ICarDescriptionRepository
    {
        private readonly CarBookContext _context;

        public CarDescriptionRepository(CarBookContext context)
        {
            _context = context;
        }

		async Task<CarDescription> ICarDescriptionRepository.GetCarDescription(int carId)
		{
			var values =await _context.CarDescriptions.Where(x => x.CarID == carId).FirstOrDefaultAsync();
			return values;
		}
	}
}
