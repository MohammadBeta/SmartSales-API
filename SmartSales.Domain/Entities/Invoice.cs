using SmartSales.Domain.Common;
using SmartSales.Domain.Enums;

namespace SmartSales.Domain.Entities;
public class Invoice : BaseEntity
{
    public string InvoiceNumber { get; set; } = null!;

    public Guid CustomerId { get; set; }

    public DateTime InvoiceDate { get; set; }

    public decimal SubTotal { get; set; }

    public decimal Discount { get; set; }

    public decimal Tax { get; set; }

    public decimal Total { get; set; }

    public InvoiceStatus Status { get; set; }
    public Customer Customer { get; set; } = null!;

    public ICollection<InvoiceItem> Items { get; set; } = null!;
}