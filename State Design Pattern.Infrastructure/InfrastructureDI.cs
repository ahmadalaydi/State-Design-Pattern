using Microsoft.Extensions.DependencyInjection;
using State_Design_Pattern.Domain.Interfaces;
using State_Design_Pattern.Infrastructure.Repositories;

namespace State_Design_Pattern.Infrastructure;
public static class InfrastructureDI
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    => services.AddScoped<IUserRepository, UserRepository>();
}