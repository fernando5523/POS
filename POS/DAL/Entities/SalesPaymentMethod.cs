using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class SalesPaymentMethod
    {
        public int Id { get; set; }
        public int IdSales { get; set; }
        public int IdPaymentMethod { get; set; }
        public string Reference { get; set; }
        public decimal Total { get; set; }
        public int IdUser { get; set; }
    }
}
