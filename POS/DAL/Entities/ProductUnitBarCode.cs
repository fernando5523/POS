using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProductUnitBarCode
    {
        public int Id { get; set; }
        public int IdProductUnit { get; set; }
        public string Code { get; set; }
        public int IdUser { get; set; }
    }
}
