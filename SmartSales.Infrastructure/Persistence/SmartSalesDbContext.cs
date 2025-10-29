using Microsoft.EntityFrameworkCore;
using SmartSales.Domain.Entites;

namespace SmartSales.Infrastructure.Persistence;

public class SmartSalesDbContext : DbContext
{
    public SmartSalesDbContext(DbContextOptions<SmartSalesDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }

}

