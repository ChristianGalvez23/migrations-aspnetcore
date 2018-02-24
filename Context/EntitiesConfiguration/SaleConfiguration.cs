using System;
using migrations_example.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace migrations_example.Context.EntitiesConfiguration {
    public class SaleConfiguration : IEntityTypeConfiguration<Sale> {
        public void Configure (EntityTypeBuilder<Sale> builder) {
            builder.ToTable ("Sale");
            builder.HasKey (k => k.CarSerie);
            builder.Property (p => p.CarSerie).HasMaxLength (30).IsRequired ();
            builder.Property (p => p.SaleDate).HasColumnType ("Date").IsRequired ();

            builder.HasOne (s => s.Customer).WithMany (s => s.CarsOwned).HasForeignKey (s => s.IdCustomer);
            builder.HasOne (s => s.Car).WithMany (s => s.Sales).HasForeignKey (s => s.CarId);
        }
    }
}