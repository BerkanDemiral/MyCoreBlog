using MyCoreBlog.DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.DataAccess.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T>  where T : class
    {

    }
}
