using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Inventory
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdWarehouse { get; set; }
        public int Stock { get; set; }
        public int IdUser { get; set; }
    }
}
