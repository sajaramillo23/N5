﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using N5.Configuration.Providers;
using N5.Persistance.Sql;

namespace N5.Configuration
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //INFRASTRUCTURE
            services.ConfigurePersistenceServices(configuration);

            services.AddPersonConfiguration();
            services.AddServiceConfiguration();
            services.AddMediatorConfiguration();
            services.AddSwaggerConfiguration();

            return services;
        }


        public static void Configure(
            this IApplicationBuilder app,
            IConfiguration configuration)
        {
            using (var serviceScope = app.ApplicationServices
                             .GetRequiredService<IServiceScopeFactory>()
                             .CreateScope())
            {
                using var context = serviceScope.ServiceProvider.GetService<N5DbContext>();
                context.Database.Migrate();
            }

            app.UseSwagger();
            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "N5 Challenge Api V1");
            });

            app.UseAuthentication();
        }
    }
}
