using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyWebAppWithSwagger.Context;
using System;
using Microsoft.EntityFrameworkCore;
namespace MyWebAppWithSwagger.Infrastructure
{
    public static class DatabaseScaffold
    {
        public static IHost Migrate(this IHost host)
        {
            var ServiceScopeFactory = (IServiceScopeFactory)host.Services.GetService(typeof(IServiceScopeFactory));

            using (var scope = ServiceScopeFactory.CreateScope())
            {
                var service = scope.ServiceProvider;
                var dbContext = service.GetRequiredService<MyWebAppWithSwaggerContext>();
                dbContext.Database.Migrate();
            }
            return host;
        }
    }
}
