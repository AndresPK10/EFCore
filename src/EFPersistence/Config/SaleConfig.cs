using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPersistence.Config
{
    public class SaleConfig
    {
        public SaleConfig(EntityTypeBuilder<Sale> entitybuilder)
        {
            entitybuilder.HasKey(x => new
            {
                x.Year,
                x.Month 
            }) ;
        }
    }
}
