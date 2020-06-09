using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class CatelogyTranslation
    {
        public int Id { set; get; }
        public int CatelogyId { set; get; }
        public string Name { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string LanguageId { set; get; }
        public string SeoAlias { set; get; }
        public Language language { get; set; }
        public Catelogy catelogy { get; set; }
    }
}
