using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using N5.Domain.Entities;
using N5.Persistance.Sql;

namespace N5.Configuration.Providers
{
    public static class PersistanceConfiguration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration, bool addHealthCheck = true)
        {

            services.AddDbContext<N5DbContext>(options =>
                                      options.UseSqlServer(configuration.GetConnectionString("SqlConnection")));

            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Password.RequiredLength = 6;
                options.Password.RequireUppercase = true;
            })
                .AddEntityFrameworkStores<N5DbContext>()
                .AddDefaultTokenProviders();

            return services;
        }
    }
}
