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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Phone)
                .HasMaxLength(50);

            builder.Property(x => x.Address)
                .HasMaxLength(500);

            builder.Property(x => x.Balance)
                .HasDefaultValue(0)
                .HasPrecision(18, 2);

            builder.Property(x => x.CreatedAt)
                .HasDefaultValueSql("GETDATE()");

            builder.HasIndex(x => x.Name)
                .IsUnique();

            builder.Property(x => x.IsActive)
                .HasDefaultValue(true);
        }
    }
}
