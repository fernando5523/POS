using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class InventoryOutputInputItem
    {
        public int Id { get; set; }
        public int IdInventoryOutputInput { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public int IdUser { get; set; }
    }
}
