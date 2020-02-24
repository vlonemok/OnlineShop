using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Infastructure.Configurations
{
    class OrderItemConfiguration : IEntityTypeConfiguration<OrderItems>
    {
        public void Configure(EntityTypeBuilder<OrderItems> builder)
        {
            builder.HasKey(x => new { x.ItemId, x.OrderId });

            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.OrderId);

            builder
                .HasOne(x => x.Order)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.ItemId);
        }
    }
}
