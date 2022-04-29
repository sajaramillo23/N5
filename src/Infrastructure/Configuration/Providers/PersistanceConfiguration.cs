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
            // add sql server service
            services.AddDbContext<N5DbContext>(options =>
                                      options.UseSqlServer(configuration.GetConnectionString("SqlConnection")));            
            
            return services;
        }
    }
}
