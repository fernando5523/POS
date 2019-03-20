using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Container : DefaultProperties
    {
        public int IdContainer { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public string Form { get; set; }
        public string Icon { get; set; }
        public int Sort { get; set; }
        public bool IsView { get; set; }
        public bool Active { get; set; }
    }
}
