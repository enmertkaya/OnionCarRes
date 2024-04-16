using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCarRes.Application
{
    public  interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int ıd);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);

    }
}
