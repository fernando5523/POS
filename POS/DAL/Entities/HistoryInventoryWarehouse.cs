//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistoryInventoryWarehouse
    {
        public int Id { get; set; }
        public int IdSalesItem { get; set; }
        public int IdPurchaseItem { get; set; }
        public int IdInventoryOutputInputItem { get; set; }
        public System.DateTime Date { get; set; }
        public int IdProduct { get; set; }
        public int IdWarehouse { get; set; }
        public int Stock { get; set; }
        public int IdUser { get; set; }
        public System.DateTime Starting { get; set; }
        public System.DateTime Ending { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual PurchaseItem PurchaseItem { get; set; }
        public virtual SalesItem SalesItem { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual InventoryOutputInputItem InventoryOutputInputItem { get; set; }
    }
}
