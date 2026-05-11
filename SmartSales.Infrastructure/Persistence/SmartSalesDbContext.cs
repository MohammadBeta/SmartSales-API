using Microsoft.EntityFrameworkCore;
using SmartSales.Domain.Entities;

namespace SmartSales.Infrastructure.Presistence;
public class SmartSalesDbContext : DbContext
{
    public SmartSalesDbContext(DbContextOptions<SmartSalesDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<InvoiceItem> InvoiceItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(SmartSalesDbContext).Assembly);
    }
}