using SmartSales.Domain.Common;

namespace SmartSales.Domain.Entities;
public class InvoiceItem : BaseEntity
{
    public int Index { get; set; }

    public Guid InvoiceId { get; set; }

    public Guid ProductId { get; set; }

    public decimal Quantity { get; set; } = 0;

    public decimal Price { get; set; } = 0;

    public decimal Discount { get; set; } = 0;

    public decimal Total { get; set; }

    public Invoice Invoice { get; set; } = null!;
    public Product Product { get; set; } = null!;
}