using SmartSales.Domain.Common;

namespace SmartSales.Domain.Entities;
public class Invoice : BaseEntity
{
    public string Number { get; set; } = null!;

    public Guid CustomerId { get; set; }

    public DateTime Date { get; set; }

    public decimal SubTotal { get; set; }

    public decimal Discount { get; set; }

    public decimal Tax { get; set; }

    public decimal FinalTotal { get; set; }

    public Customer Customer { get; set; } = null!;

    public ICollection<InvoiceItem> Items { get; set; } = null!;
}