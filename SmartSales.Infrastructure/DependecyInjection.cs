using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartSales.Domain.Interface;
using SmartSales.Domain.Interface.Repositroy;
using SmartSales.Infrastructure.Persistence;
using SmartSales.Infrastructure.Persistence.Repository;
using SmartSales.Infrastructure.Persistence.UnitOfWork;

public static class DependencyInjection
{

    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<SmartSalesDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("SmartSalesConnectionString")));


        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}