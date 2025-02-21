using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using WebStore.Application.Services.Implementation;
using WebStore.Application.Services.Interfaces;
using WebStore.Domain.Intefaces;
using WebStore.Infra.Data.Repositories;

namespace WebStore.IoC.Dependency
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //Application Layer
            service.AddScoped<IProductService, ProductService>();

            // Infra Data Layer

            service.AddScoped<IProductRepository,ProductRepository>();
        }
    }
}
