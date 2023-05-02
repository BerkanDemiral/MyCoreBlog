using Microsoft.EntityFrameworkCore;
using MyCoreBlog.DataAccess.Context;
using MyCoreBlog.DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.DataAccess.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _appDbContext;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        private DbSet<T> Table
        {
            get=>_appDbContext.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await Table.AnyAsync(predicate);
        }

        public async Task<int> CountAsync(Expression<Func<T, int>> predicate = null)
        {
            return await Table.CountAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => Table.Remove(entity)); ;

        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            if(predicate != null)
            {
                query = query.Where(predicate);
            }
            if(includeProperties.Any())
            {
                foreach(var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }

            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsyncs(int id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity)); ;
            return entity;
        }
    }
}
