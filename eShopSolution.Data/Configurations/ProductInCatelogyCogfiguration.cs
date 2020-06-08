using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductInCatelogyCogfiguration : IEntityTypeConfiguration<ProductInCatelogy>
    {
        public void Configure(EntityTypeBuilder<ProductInCatelogy> builder)
        {
            builder.HasKey(t => new { t.ProductId, t.CatelogyId });
            builder.ToTable("ProductInCatelogies");
            builder.HasOne(t => t.product).WithMany(pc => pc.productInCatelogies)
                .HasForeignKey(pc=>pc.ProductId);
            builder.HasOne(t => t.catelogy).WithMany(pc => pc.productInCatelogies)
                .HasForeignKey(pc => pc.CatelogyId);



        }
    }
}
