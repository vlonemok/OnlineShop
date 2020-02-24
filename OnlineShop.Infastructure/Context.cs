using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.IO;
using OnlineShop.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineShop.Infastructure
{
    public class Context : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=OnlineShopDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder fluent)
        {
            fluent.Entity<Item>(ItemConfig);
            fluent.Entity<Cart>(CartConfig);
            fluent.Entity<Order>(OrderConfig);
            fluent.Entity<Client>(ClientConfig);
        }
        public void ItemConfig(EntityTypeBuilder<Item> pfluent)
        {
            pfluent.HasKey(i => i.Id);
            pfluent.HasIndex(i => i.Id).IsUnique();
            pfluent.Property(i => i.Id).IsRequired();
            pfluent.Property(i => i.Id).HasColumnType("int");
        }
        public void CartConfig(EntityTypeBuilder<Cart> cfluent)
        {
            cfluent.HasKey(ca => ca.Id);
            cfluent.Property(ca => ca.Id).IsRequired();
            cfluent.Property(ca => ca.Id).HasColumnType("int");
        }
        public void OrderConfig(EntityTypeBuilder<Order> ofluent)
        {
            ofluent.HasKey(o => o.Id);
            ofluent.Property(o => o.Id).IsRequired();
            ofluent.Property(o => o.Id).HasColumnType("int");
        }
        public void ClientConfig(EntityTypeBuilder<Client> cfluent)
        {
            cfluent.HasIndex(c => c.Id).IsUnique();
            cfluent.HasKey(c => c.Id);
            cfluent.Property(c => c.Id).IsRequired();
            cfluent.Property(c => c.Id).HasColumnType("int");
        }
    }
}
