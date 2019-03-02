using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class HistoryInventoryWarehouse
    {
        public int Id { get; set; }
        public int IdSalesItem { get; set; }
        public int IdPurchaseItem { get; set; }
        public int IdInventoryOutputInputItem { get; set; }
        public DateTime Date { get; set; }
        public int IdProduct { get; set; }
        public int IdWarehouse { get; set; }
        public int Stock { get; set; }
        public int IdUser { get; set; }
    }
}
