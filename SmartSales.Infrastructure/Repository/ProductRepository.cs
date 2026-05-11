using SmartSales.Domain.Interfaces;
using SmartSales.Domain.Entities;
using SmartSales.Infrastructure.Presistence;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(SmartSalesDbContext context) : base(context)
    {
    }

    public Task<IEnumerable<Product>> GetProductsByPriceRangeAsync(decimal minPrice, decimal maxPrice)
    {
        throw new NotImplementedException();
    }
}