using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eShopSolution.Data.Entity
{
    [Table("Products")]
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock{ get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCroated { get; set; }
        public string SeoAlias { get; set; }

        public List<ProductInCatelogy> productInCatelogies { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
        public List<Cart> carts { get; set; }
        public List<ProductTranslation> productTranslations { get; set; }




    }
}
