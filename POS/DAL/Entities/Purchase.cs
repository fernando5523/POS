using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        public int IdBox { get; set; }
        public int IdEmployee { get; set; }
        public int IdDocument { get; set; }
        public int IdProvider { get; set; }
        public int IdBranchOffice { get; set; }
        public int IdWarehouse { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public DateTime BroadcastDate { get; set; }
        public DateTime Hour { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public bool Canceled { get; set; }
        public int IdUser { get; set; }
    }
}
