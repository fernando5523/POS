using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProductPriceBranchOffice
    {
        public int Id { get; set; }
        public int IdProductPrice { get; set; }
        public int IdBranchOffice { get; set; }
        public int IdUser { get; set; }S
    }
}
