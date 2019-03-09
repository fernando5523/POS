using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProductPrice
    {
        public int Id { get; set; }
        public int IdProductUnit { get; set; }
        public decimal Margin { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal Discount { get; set; }
        public int IdUser { get; set; }
    }
}
