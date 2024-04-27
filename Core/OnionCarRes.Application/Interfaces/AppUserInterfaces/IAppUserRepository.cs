using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OnionCarRes.Domain.Entities;

namespace OnionCarRes.Application.Interfaces.AppUserInterfaces
{
    public interface IAppUserRepository
    {
        Task<List<AppUser>> GetByFilterAsync(Expression<Func<AppUser, bool>> filter);
    }
}
