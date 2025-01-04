using TimeTracker.Application.Common.Abstractions;
using TimeTracker.Infrastructure.Persistance;
using TimeTracker.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TimeTracker.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>();

        services.AddTransient(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
        services.AddTransient<IUserRolesRepository, UserRolesRepository>();
        services.AddTransient<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
