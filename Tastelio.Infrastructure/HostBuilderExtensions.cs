using Microsoft.Extensions.DependencyInjection;
using Tastelio.Domain.Repositories;
using Tastelio.Infrastructure.Repositories;

namespace Tastelio.Infrastructure;

public static class HostBuilderExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

        services.AddScoped<IEstablishmentRepository, EstablishmentRepository>();
        services.AddScoped<IPatronRepository, PatronRepository>();
        services.AddScoped<IReservationRepository, ReservationRepository>();

        return services;
    }
}
