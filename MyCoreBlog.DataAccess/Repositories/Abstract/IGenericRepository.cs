using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.DataAccess.Repositories.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<List<T>> GetAllAsync(Expression<Func<T,bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsyncs(int id);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

        Task<int> CountAsync(Expression<Func<T, int>> predicate = null);
    }
}
