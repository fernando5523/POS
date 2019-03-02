using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int IdBrand { get; set; }
        public int IdCategory { get; set; }
        public int IdProductType { get; set; }
        public int IdProvider { get; set; }
        public string Code { get; set; }
        public string FactoryCode { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int IdUser { get; set; }
    }
}
