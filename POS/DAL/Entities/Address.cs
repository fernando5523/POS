using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public int IdEntity { get; set; }
        public string Description { get; set; }
        public bool Principal { get; set; }
        public int IdUser { get; set; }
    }
}
