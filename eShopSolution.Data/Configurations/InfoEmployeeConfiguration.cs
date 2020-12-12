using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class InfoEmployeeConfiguration : IEntityTypeConfiguration<InfoEmployee>
    {
        public void Configure(EntityTypeBuilder<InfoEmployee> builder)
        {
            builder.ToTable("InfoEmployees");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}