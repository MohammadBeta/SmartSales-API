using Microsoft.Extensions.DependencyInjection;
using SmartSales.Application.Mapping;
using SmartSales.Application.Services.Auth;

public static class DependecyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        services.AddAutoMapper(cfg=> cfg.AddProfile<MappingProfile>());
        services.AddScoped<IAuthService, AuthService>();

        return services;
    }
}