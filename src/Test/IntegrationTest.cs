using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using N5.Persistance.Sql;
using N5;
using System.Net.Http;

namespace N5.Test
{
    public class IntegrationTest
    {
        protected readonly HttpClient _httpClient;
        public IntegrationTest()
        {
            _httpClient = new HttpClient();            
            var appFactory = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(webHostBuilder => {
                    webHostBuilder.ConfigureServices(services =>
                    {
                        services.RemoveAll(typeof(N5DbContext));                        
                        services.AddDbContext<N5DbContext>(options => {
                            options.UseInMemoryDatabase(databaseName: "N5Test");
                        });
                        
                    });
                });            
            _httpClient = appFactory.CreateClient();            
        }
    }
}
