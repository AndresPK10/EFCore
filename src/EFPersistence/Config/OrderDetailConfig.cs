using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPersistence.Config
{
    public class OrderDetailConfig
    {
        public OrderDetailConfig(EntityTypeBuilder<OrderDetail> entitybuilder)
        {
            entitybuilder.Property(x => x.OrderDetailId).HasMaxLength(50);
        }
    }
}
