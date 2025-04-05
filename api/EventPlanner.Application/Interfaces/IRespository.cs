using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<bool> Add(T entity);
        Task<T> AddAndGetId(T entity);
        Task<bool> Add(IList<T> entities);
        Task<bool> Update(T entity);
        Task<bool> Update(IList<T> entities);
        Task<bool> Delete(T entity);
        Task<bool> Delete(IList<T> entities);
        IQueryable<T> TableNoTracking { get; }
    }
}
