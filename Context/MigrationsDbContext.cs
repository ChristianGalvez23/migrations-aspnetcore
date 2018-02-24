using System;
using migrations_example.Context.EntitiesConfiguration;
using migrations_example.Entities;
using Microsoft.EntityFrameworkCore;

namespace migrations_example.Context {
    public class MigrationsDbContext : DbContext {
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }

        public MigrationsDbContext (DbContextOptions options) : base (options) {

        }

        protected override void OnModelCreating (ModelBuilder builder) {
            builder.ApplyConfiguration<Agency> (new AgencyConfiguration ());
            builder.ApplyConfiguration<Customer> (new CustomerConfiguration ());
            builder.ApplyConfiguration<Car> (new CarConfiguration ());
            builder.ApplyConfiguration<Sale> (new SaleConfiguration ());
        }

    }
}