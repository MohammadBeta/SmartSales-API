using Microsoft.Extensions.DependencyInjection;
using SmartSales.Domain.Interfaces;
using SmartSales.Infrastructure.Repository;
using SmartSales.Infrastructure.Options;
using Microsoft.EntityFrameworkCore;
using SmartSales.Application.Interfaces;
using SmartSales.Infrastructure.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SmartSales.Infrastructure.Presistence;


namespace SmartSales.Infrastructure
{
    public static class DependecyInjection
    {

        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SmartSalesDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            services.Configure<JwtOptions>(configuration.GetSection(JwtOptions.SectionName));
            services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            return services;
        }
    }
}
