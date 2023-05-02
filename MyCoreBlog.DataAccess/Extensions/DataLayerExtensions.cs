using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyCoreBlog.DataAccess.Context;
using MyCoreBlog.DataAccess.Repositories.Abstract;
using MyCoreBlog.DataAccess.Repositories.Concrete;
using MyCoreBlog.DataAccess.UnitOfWorks;

namespace MyCoreBlog.DataAccess.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();


            return services;

        }
    }
}
