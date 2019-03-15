using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class UnitTemplate : DefaultProperties
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public int Factor { get; set; }
        public string Description { get; set; }
    }
}
