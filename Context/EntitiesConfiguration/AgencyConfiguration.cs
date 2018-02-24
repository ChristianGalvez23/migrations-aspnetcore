using System;
using migrations_example.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace migrations_example.Context.EntitiesConfiguration {
    public class AgencyConfiguration : IEntityTypeConfiguration<Agency> {
        public void Configure (EntityTypeBuilder<Agency> builder) {
            builder.ToTable ("Agency");
            builder.HasKey (k => k.Id);
            builder.Property (p => p.Name).HasMaxLength (100).IsRequired ();
            builder.Property (p => p.Brand).HasMaxLength (50).IsRequired ();
            builder.Property (p => p.State).HasMaxLength (50).IsRequired ();
            builder.Property (p => p.City).HasMaxLength (50).IsRequired ();
            builder.Property (p => p.Address).HasMaxLength (100).IsRequired ();
            builder.Property (p => p.SignUpDate).HasColumnType ("Date").IsRequired ();

            builder.HasMany (c => c.Cars).WithOne (a => a.Agency).HasForeignKey (c => c.AgencyId);
        }
    }
}