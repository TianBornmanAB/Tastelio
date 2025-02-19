using Microsoft.Extensions.DependencyInjection;
using Tastelio.Application.Services;
using Tastelio.Application.Services.Abstractions;

namespace Tastelio.Application;

public static class HostBuilderExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IEstablishmentService, EstablishmentService>();
        services.AddScoped<IPatronService, PatronService>();

        return services;
    }
}
