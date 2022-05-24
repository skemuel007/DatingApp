using Dating.App.API.Entities;
using Dating.App.API.Interfaces;
using Dating.App.API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dating.App.API.Extensions
{
    // don't create an instance to use the class
    public static class ApplicationServiceExtensions
    {
        // this collects the item we are extending
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            // added to user secrets
            // dotnet user-secrets init
            // dotnet user-secrets set "ConnectionString:DataContext" "Server=localhost\\SQLEXPRESS;Database=DatingAppDB;User ID=sa;Password=12345;"
            // dotnet ef migrations add InitialCreate -o Data/Migrations
            var connectionString = config.GetSection("ConnectionString").Get<ConnectionSettings>();
            services.AddDbContext<DataContext>(options =>
                    options.UseSqlServer(connectionString.DataContext));

            return services;
        }
    }
}
