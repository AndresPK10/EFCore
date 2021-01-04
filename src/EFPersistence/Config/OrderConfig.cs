using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPersistence.Config
{
    public class OrderConfig
    {
       public OrderConfig(EntityTypeBuilder<Order> entitybuilder)
        {
            entitybuilder.Property(x => x.OrderId).IsRequired();
        }
    }
}
