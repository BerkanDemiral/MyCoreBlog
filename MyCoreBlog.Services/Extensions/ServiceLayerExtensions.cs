using Microsoft.Extensions.DependencyInjection;
using MyCoreBlog.Services.Abstract;
using MyCoreBlog.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.Services.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly(); // mevcut katmanı alıyoruz.
            services.AddScoped<IArticleService, ArticleService>();
            services.AddAutoMapper(assembly); // tüm automapperler ile dependectInjection yapısını kurar.
            return services;

        }
    }
}
