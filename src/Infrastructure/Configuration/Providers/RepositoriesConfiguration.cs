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
            // Repositories
            //services.AddScoped<IItemRepository, ItermRepository>();
            //services.AddScoped<IUserRepository, UserRepository>();
            //unit of work
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            // new repositories
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeePermissionRepository, EmployeePermissionRepository>();
            services.AddScoped<IPermissionRepository,PermissionRepositoryy>();
            services.AddScoped<IPermissionTypeRepository, PermissionTypeRepository>();

            // Query
            //services.AddScoped<IItemQuery, ItemQuery>();
            //services.AddScoped<IUserQuery, UserQuery>();
            //new queries
            services.AddScoped<IEmployeeQuery, EmployeeQuery>();
            services.AddScoped<IEmployeePermissionQuery, EmployeePermissionQuery>();
            services.AddScoped<IPermissionQuery, PermissionQuery>();
            services.AddScoped<IPermissionTypeQuery, PermissionTypeQuery>();


            return services;
        }
    }  
}