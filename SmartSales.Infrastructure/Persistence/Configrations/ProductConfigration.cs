using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SmartSales.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSales.Infrastructure.Persistence.Configrations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Description)
                .HasMaxLength(500);

            builder.Property(x => x.Price)
                .HasDefaultValue(0)
                .HasPrecision(18, 2);

            builder.Property(x => x.StockQuantity)
                .HasDefaultValue(0)
                .HasPrecision(18, 2);
            builder.Property(x => x.Cost)
                .HasDefaultValue(0)
                .HasPrecision(18, 2);

            builder.Property(x => x.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            builder.HasIndex(x => x.Name)
                .IsUnique();
        }
    }
}
