using Microsoft.EntityFrameworkCore;
using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    class CatelogyTranslationConfiguration : IEntityTypeConfiguration<CatelogyTranslation>
    {
        public void Configure(EntityTypeBuilder<CatelogyTranslation> builder)
        {
            builder.ToTable("CategoryTranslations");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();


            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoDescription).HasMaxLength(500);

            builder.Property(x => x.SeoTitle).HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.language).WithMany(x => x.catelogyTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.catelogy).WithMany(x => x.catelogyTranslations).HasForeignKey(x => x.CatelogyId);
        }
    }
}
