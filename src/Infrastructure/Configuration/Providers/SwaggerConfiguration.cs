using Microsoft.Extensions.DependencyInjection;

namespace N5.Configuration.Providers
{
    public static class SwaggerConfiguration
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "N5 challenge",
                    Version = "v1",
                    Description = "REST API Employee - Permissions"
                });
            });

            return services;
        }
    }
}
