using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class ProductInCatelogy
    {
        public int ProductId { get; set; }

        public Product product { get; set; }
        public int CatelogyId { get; set; }
        public Catelogy catelogy { get; set; }

    }
}
