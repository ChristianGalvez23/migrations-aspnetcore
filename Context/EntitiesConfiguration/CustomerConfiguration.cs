using System;
using migrations_example.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace migrations_example.Context.EntitiesConfiguration {
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer> {
        public void Configure (EntityTypeBuilder<Customer> builder) {
            builder.ToTable ("Customer");
            builder.HasKey (k => k.Id);
            builder.Property (p => p.Name).HasMaxLength (100).IsRequired ();
            builder.Property (p => p.BornDate).HasColumnType ("Date").IsRequired ();
            builder.Property (p => p.Address).HasMaxLength (100).IsRequired ();
            builder.Property (p => p.State).HasMaxLength (50).IsRequired ();
            builder.Property (p => p.City).HasMaxLength (50).IsRequired ();
        }
    }
}