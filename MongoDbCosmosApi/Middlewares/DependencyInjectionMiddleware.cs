using Microsoft.Extensions.DependencyInjection;
using MongoDbCosmosApi.Domain;
using MongoDbCosmosApi.Repository.Base;
using MongoDbCosmosApi.Repository.Interfaces;
using MongoDBCosmosDBApi.Services;
using MongoDBCosmosDBApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbCosmosApi.Middlewares
{
    public static class DependencyInjectionMiddleware
    {
        public static void AddDependencyInjection(this IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            services.AddSingleton<IRepository<Product>, Repository<Product>>();
            services.AddTransient<IProductService, ProductService>();
        }
    }
}
