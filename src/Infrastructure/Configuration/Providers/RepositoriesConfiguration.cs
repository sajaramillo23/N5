using Microsoft.Extensions.DependencyInjection;
using N5.Domain.Interfaces.Command;
using N5.Domain.Interfaces.Query;
using N5.Persistance.Sql;
using N5.Persistance.Sql.Command;
using N5.Persistance.Sql.Interfaces;
using N5.Persistance.Sql.Query;

namespace N5.Configuration.Providers
{
    public static class RepositoryConfiguration 
    {
        public static IServiceCollection AddPersonConfiguration(this IServiceCollection services)
        {            
            //Unit of work
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //Repositories
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeePermissionRepository, EmployeePermissionRepository>();
            services.AddScoped<IPermissionRepository,PermissionRepositoryy>();
            services.AddScoped<IPermissionTypeRepository, PermissionTypeRepository>();

            //Queries
            services.AddScoped<IEmployeeQuery, EmployeeQuery>();
            services.AddScoped<IEmployeePermissionQuery, EmployeePermissionQuery>();
            services.AddScoped<IPermissionQuery, PermissionQuery>();
            services.AddScoped<IPermissionTypeQuery, PermissionTypeQuery>();


            return services;
        }
    }  
}