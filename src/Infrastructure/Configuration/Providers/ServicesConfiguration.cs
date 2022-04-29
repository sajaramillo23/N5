using Microsoft.Extensions.DependencyInjection;
using N5.Domain.Interfaces.Services;
using N5.Application.Services;

namespace N5.Configuration.Providers
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddServiceConfiguration(this IServiceCollection services)
        {            
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeePermissionService, EmployeePermissionService>();
            services.AddScoped<IPermissionService, PermissionService>();
            services.AddScoped<IPermissionTypeService, PermissionTypeService>();
            return services;
        }
    }
}
