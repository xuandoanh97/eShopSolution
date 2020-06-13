using eShopSolution.Data.Configurations;
using eShopSolution.Data.Entity;
using eShopSolution.Data.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.EF
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext( DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new AppConfigConfiguaration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CatelogyConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCatelogyCogfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());

            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new CatelogyTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());


            //Data sending
            modelBuilder.Seed();
            //Base.Onmode
        }
        public DbSet<AppConfig> appConfigs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Catelogy> Catelogies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails {get; set;}
        public DbSet<ProductInCatelogy> ProductInCatelogies { get; set;}
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Transaction> transactions { get; set; }
        public DbSet<Language> languages { get; set; }
        public DbSet<CatelogyTranslation> catelogyTranslations { get; set; }
        public DbSet<ProductTranslation> productTranslations { get; set; }
        public DbSet<Promotion> promotions { get; set; }
        public DbSet<Cart> carts { get; set; }
    }
}

