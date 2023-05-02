using MyCoreBlog.DataAccess.Context;
using MyCoreBlog.DataAccess.Repositories.Abstract;
using MyCoreBlog.DataAccess.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.DataAccess.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public void DisposeAsync()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        ValueTask IAsyncDisposable.DisposeAsync()
        {
            return _context.DisposeAsync();
        }

        IGenericRepository<T> IUnitOfWork.GetRepository<T>()
        {
            return new GenericRepository<T>(_context);
        }
    }
}
