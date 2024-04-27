using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OnionCarRes.Application.Interfaces.AppUserInterfaces;
using OnionCarRes.Domain.Entities;
using OnionCarRes.Persistence.Context;

namespace OnionCarRes.Persistence.Repositories.AppUserRepositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly CarBookContext _context;
        public AppUserRepository(CarBookContext context)
        {
            _context = context;
        }
        public Task<List<AppUser>> GetByFilterAsync(Expression<Func<AppUser, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
