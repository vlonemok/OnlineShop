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
        public DbSet<Order> Orders { get; set; }

        public Context()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Item>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Item>()
                .HasOne(x => x.Order)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.OrderId);

            modelBuilder.Entity<Order>()
                .HasOne(x => x.Client)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=OnlineShopDB;Trusted_Connection=True;");
            }
        }
    }
}
