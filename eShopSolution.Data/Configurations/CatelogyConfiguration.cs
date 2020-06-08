using eShopSolution.Data.Entity;
using eShopSolution.Data.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class CatelogyConfiguration : IEntityTypeConfiguration<Catelogy>
    {
        public void Configure(EntityTypeBuilder<Catelogy> builder)
        {
            builder.ToTable("Catelogys");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);


        }
    }
}
