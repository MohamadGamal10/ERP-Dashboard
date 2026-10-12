using ERP_Dashboard.Infrastructure.Abstracts;
using ERP_Dashboard.Infrastructure.InfrastructureBases;
using ERP_Dashboard.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ERP_Dashboard.Infrastructure
{
    public static class ModuleInfrustructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ISupplierRepository, SupplierRepository>();
            return services;
        }
    }
}
