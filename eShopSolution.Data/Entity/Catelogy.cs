using eShopSolution.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class Catelogy
    {
       public int Id { set; get; }
       public int SortOrder  { set; get; }
       public bool IsShowOnHome  { set; get; }
       public int ParenId  { set; get; }
       public Status Status { set; get; }
    }
}
