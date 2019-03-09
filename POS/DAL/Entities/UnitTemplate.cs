using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class UnitTemplate
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Abreviation { get; set; }
        public int Factor { get; set; }
        public string Description { get; set; }
        public int IdUser { get; set; }
    }
}
