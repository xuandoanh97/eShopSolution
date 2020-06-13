using eShopSolution.Data.Entity;
using eShopSolution.Data.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;


namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //appconfig
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home of eShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution " },
                new AppConfig() { Key = "HomeDescription", Value = "This is descreiption of eShopSolution" }
                );
            //Language
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false });
            //Catelogy
            modelBuilder.Entity<Catelogy>().HasData(
                new Catelogy()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                new Catelogy()
                
                {
                    Id = 2,
                    IsShowOnHome = true,
                    SortOrder = 2,
                    Status = Status.Active,
                }
 
                );
            modelBuilder.Entity<CatelogyTranslation>().HasData(
                new CatelogyTranslation()
                { Id = 1, CatelogyId = 1, Name = "Áo nữ", LanguageId = "vi-VN", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm thời trang nữ", SeoTitle = "Sản phẩm áo thời trang nữ" },
                new CatelogyTranslation()
                { Id = 2, CatelogyId = 1, Name = "Women shirt", LanguageId = "vi-VN", SeoAlias = "Women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" },

                new CatelogyTranslation()
                { Id = 3, CatelogyId = 2, Name = "Áo nữ", LanguageId = "vi-VN", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm thời trang nữ", SeoTitle = "Sản phẩm áo thời trang nữ" },
                new CatelogyTranslation()
                { Id = 4, CatelogyId = 2, Name = "Women shirt", LanguageId = "vi-VN", SeoAlias = "Women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" }
            );
            //Product
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCroated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,
                },
                new Product()
                {
                    Id = 2,
                    DateCroated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,
                });
            modelBuilder.Entity<ProductTranslation>().HasData(
                        new ProductTranslation()
                        {
                            Id = 1,
                            ProductId = 1,
                            Name = "Áo sơ mi nam trắng Việt Tiến",
                            LanguageId = "vi-VN",
                            SeoAlias = "ao-so-mi-nam-trang-viet-tien",
                            SeoDescription = "Sản phẩm thời trang nam",
                            SeoTitle = "Áo sơ mi nam trắng Việt Tiến",
                            Details = "Áo sơ mi nam trắng Việt Tiến",
                            Description = "Áo sơ mi nam trắng Việt Tiến"
                        }
                        ,
                        new ProductTranslation()
                        {
                            Id = 2,
                            ProductId = 2,
                            Name = "Viet Tien men t-shirt",
                            LanguageId = "vi-VN",
                            SeoAlias = "viet-tien-men-t-shirt ",
                            SeoDescription = "The shirt products for men",
                            SeoTitle = "Viet Tien men t-shirt",
                            Details = "Viet Tien men t-shirt",
                            Description = "Viet Tien men t-shirt"
                        },
                        new ProductTranslation()
                        {
                            Id = 3,
                            ProductId = 1,
                            Name = "Adam store",
                            LanguageId = "vi-VN",
                            SeoAlias = "adam-store",
                            SeoDescription = "The suit for men",
                            SeoTitle = "The suit for men",
                            Details = "The suit for men",
                            Description = "The suit for men",
                        }
                    );
   
            modelBuilder.Entity<ProductInCatelogy>().HasData(
                new ProductInCatelogy() {CatelogyId = 1, ProductId = 1}
                );
        }
    }

}
