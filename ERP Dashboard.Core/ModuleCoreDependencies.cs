using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ERP_Dashboard.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            var coreAssembly = typeof(ModuleCoreDependencies).Assembly;
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(coreAssembly));

            services.AddAutoMapper(cfg => cfg.AddMaps(coreAssembly));

            // Get Validators
            //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            // 
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            return services;
        }
    }
}
