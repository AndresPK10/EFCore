using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPersistence.Config
{
    public class ProductConfig
    {
        public ProductConfig(EntityTypeBuilder<Product> entitybuilder)
        {
            entitybuilder.Property(x => x.Name).IsRequired().HasMaxLength(300);
            entitybuilder.Property(x => x.Price).IsRequired();
        }
    }
}
