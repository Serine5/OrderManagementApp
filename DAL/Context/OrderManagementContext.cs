using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class OrderManagementContext:DbContext
    {
        public OrderManagementContext(DbContextOptions<OrderManagementContext> options) : base(options)
        {

        }
        public DbSet<Models.Suppliers> Suppliers { get; set; }
        public DbSet<Models.Cities> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Suppliers>().HasKey(t => t.SupplierId);
            modelBuilder.Entity<Models.Suppliers>().Property(t => t.AddressLine1);
            modelBuilder.Entity<Models.Suppliers>().Property(t => t.AddressLine2);
            modelBuilder.Entity<Models.Suppliers>().Property(t => t.SupplierName);
            modelBuilder.Entity<Models.Suppliers>().Property(t => t.CityId);

            modelBuilder.Entity<Models.Cities>().HasKey(t => t.CityId);
            modelBuilder.Entity<Models.Cities>().HasKey(t => t.CityName);
            modelBuilder.Entity<Models.Cities>().Property(t => t.PostalCode);
            modelBuilder.Entity<Models.Cities>().Property(t => t.State);

            modelBuilder.Entity<Models.Cities>().HasMany<Models.Suppliers>(g => g.Supplier)
                .WithOne(x => x.City).HasForeignKey(s => s.CityId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=192.168.40.4;Database=SerineDatabase;Trusted_Connection=True;");
        }
    }
}
