using Microsoft.Extensions.DependencyInjection;
using SmartSales.Application.Mapping;
using SmartSales.Application.Services.Auth;
namespace SmartSales.Application
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddApplicationDependecyInjection(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
  cfg.AddProfile<AutoMapperProfile>()
);
            services.AddScoped<IAuthService, AuthService>();
            return services;
        }
    }
}
