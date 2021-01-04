using Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPersistence.Config
{
    public class ClientConfig
    {
        public ClientConfig(EntityTypeBuilder<Client> entityBuilder)
        {
            entityBuilder.Property(x => x.ClientNumber).IsRequired().HasMaxLength(30);
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(200);
        }
    }
}
