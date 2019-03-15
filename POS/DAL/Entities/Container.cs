using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Container : DefaultProperties
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Form { get; set; }
        public bool Active { get; set; }
    }
}
