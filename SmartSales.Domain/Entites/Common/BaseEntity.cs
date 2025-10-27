namespace SmartSales.Domain.Common;
public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid UpdatedAt { get; set; }
}