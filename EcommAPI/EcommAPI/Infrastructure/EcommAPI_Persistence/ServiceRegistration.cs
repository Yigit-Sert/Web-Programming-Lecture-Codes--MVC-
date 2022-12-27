using EcommAPI_Application.Abstractions;
using EcommAPI_Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommAPI_Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection service)
        {
            service.AddSingleton<IProductService, ProductService>();
        }
    }
}
