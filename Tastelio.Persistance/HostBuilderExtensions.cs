using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Tastelio.Persistence;

public static class HostBuilderExtensions
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<Context>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("TastelioDb"));
        });

        return services;
    }
}
