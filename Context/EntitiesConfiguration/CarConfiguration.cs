using System;
using migrations_example.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace migrations_example.Context.EntitiesConfiguration {
    public class CarConfiguration : IEntityTypeConfiguration<Car> {
        public void Configure (EntityTypeBuilder<Car> builder) {
            builder.ToTable ("Car");
            builder.HasKey (k => k.Id);
            builder.Property (p => p.Name).HasMaxLength (50).IsRequired ();
            builder.Property (p => p.Version).HasMaxLength (20).IsRequired ();
            builder.Property (p => p.Year).HasColumnType ("int");
            builder.Property (p => p.Price).HasColumnType ("int");
            builder.Property (p => p.SignUpDate).HasColumnType ("date").IsRequired ();
        }
    }
}