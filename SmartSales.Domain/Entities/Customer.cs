using SmartSales.Domain.Common;

namespace SmartSales.Domain.Entities;
public class Customer : BaseEntity
{
    public string Name { get; set; } = null!;

    public string Phone { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    public decimal Balance { get; set; } = 0;

    public bool IsActive { get; set; } = true;

    public ICollection<Invoice> Invoices { get; set; }
}