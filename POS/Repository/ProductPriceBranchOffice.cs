//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductPriceBranchOffice
    {
        public int Id { get; set; }
        public int IdProductPrice { get; set; }
        public int IdBranchOffice { get; set; }
        public int IdUser { get; set; }
        public System.DateTime Starting { get; set; }
        public System.DateTime Ending { get; set; }
    
        public virtual BranchOffice BranchOffice { get; set; }
        public virtual ProductPrice ProductPrice { get; set; }
    }
}