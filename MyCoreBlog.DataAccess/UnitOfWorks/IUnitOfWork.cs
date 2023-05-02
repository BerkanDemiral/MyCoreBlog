using MyCoreBlog.Core.Models;
using MyCoreBlog.DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.DataAccess.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : class, IBaseEntity, new();
        Task<int> SaveAsync();
        int Save();
    }
}
