using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoreBlog.Services.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            // services.AddScoped<IArticleService, ArticleService>();
            return services;

        }
    }
}
