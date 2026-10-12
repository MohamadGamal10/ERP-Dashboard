using ERP_Dashboard.Service.Abstracts;
using ERP_Dashboard.Service.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace ERP_Dashboard.Service
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ISupplierService, SupplierService>();
            return services;
        }
    }
}
