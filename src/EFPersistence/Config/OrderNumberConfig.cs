using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EFPersistence.Config
{
    public class OrderNumberConfig
    {
        public OrderNumberConfig(EntityTypeBuilder<OrderNumber> entitybuilder)
        {
            entitybuilder.HasKey(x => x.Year);
            entitybuilder.HasData(new OrderNumber
            {
                Year = DateTime.Now.Year,
                Value = 0
            });
        }
    }
}
