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
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoices");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.InvoiceNumber)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.InvoiceDate)
                .IsRequired();

            builder.Property(x => x.SubTotal)
                .HasPrecision(18, 2);

            builder.Property(x => x.Discount)
                .HasPrecision(18, 2);

            builder.Property(x => x.Tax)
                .HasPrecision(18, 2);

            builder.Property(x => x.Total)
                .HasPrecision(18, 2);

            builder.Property(x => x.Status)
                .IsRequired();

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Invoices)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => x.InvoiceNumber)
                .IsUnique();

            builder.HasIndex(x => x.InvoiceDate);
        }
    }
}
