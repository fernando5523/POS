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
    
    public partial class Document
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Document()
        {
            this.InventoryOutputInput = new HashSet<InventoryOutputInput>();
            this.Purchase = new HashSet<Purchase>();
            this.Sales = new HashSet<Sales>();
        }
    
        public int Id { get; set; }
        public int IdBrachOffice { get; set; }
        public int IdDocumentType { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Series { get; set; }
        public int SeriesLength { get; set; }
        public int Number { get; set; }
        public int NumberLength { get; set; }
        public int Box { get; set; }
        public int Inventory { get; set; }
        public int IdUser { get; set; }
        public System.DateTime Starting { get; set; }
        public System.DateTime Ending { get; set; }
    
        public virtual DocumentType DocumentType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryOutputInput> InventoryOutputInput { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase> Purchase { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
