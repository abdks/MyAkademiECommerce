using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyAkademiECommerce.Order.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetByIdAsync(int id);
        Task<List<T>> CreateAsync(T entity);
        Task<List<T>> UpdateAsync(T entity);
        Task<List<T>> DeleteAsync(int id);
        Task<List<T>> GetOrderByFilter(Expression<Func<T, bool>> filter);
    }
}
