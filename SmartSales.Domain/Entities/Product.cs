using SmartSales.Domain.Common;

namespace SmartSales.Domain.Entities;
public class Product : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; } = 0;
    public decimal Cost { get; set; } = 0;
    public int StockQuantity { get; set; } = 0;

    public ICollection<InvoiceItem> InvoiceItems { get; set; }
}