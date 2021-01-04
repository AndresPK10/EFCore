using EFPersistence.Config;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace EFPersistence
{
    public class EFContext : DbContext
    {
        public EFContext()
        {

        }
        public EFContext(DbContextOptions<EFContext> options) :
            base(options)
        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderNumber> OrderNumbers { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Parameters.ConnectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new ClientConfig(modelBuilder.Entity<Client>());
            new ProductConfig(modelBuilder.Entity<Product>());
            new OrderConfig(modelBuilder.Entity<Order>());
            new OrderDetailConfig(modelBuilder.Entity<OrderDetail>());
            new OrderNumberConfig(modelBuilder.Entity<OrderNumber>());
            new SaleConfig(modelBuilder.Entity<Sale>());
        }
    }
}
