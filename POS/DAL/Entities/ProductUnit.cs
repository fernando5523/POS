using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProductUnit
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdUnitTemplate { get; set; }
        public string Code { get; set; }
        public bool Sale { get; set; }
        public bool Purchase { get; set; }
        public bool Inventory { get; set; }
        public bool Reference { get; set; }
        public decimal Weight { get; set; }
        public decimal Volume { get; set; }
        public decimal Long { get; set; }
        public decimal Width { get; set; }
        public decimal High { get; set; }
        public bool Active { get; set; }
        public int IdUser { get; set; }
    }
}
