using MyCoreBlog.DataAccess.Context;
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

        public void Dispose()
        {
            _context.Dispose();
        }

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync() // must be used %99 for performance of db and memmory
        {
            await _context.SaveChangesAsync();
        }
    }
}
