using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Filter : DefaultProperties
    {
        public int IdConsult{ get; set; }
        public string Condition { get; set; }
        public string ConditionDev { get; set; }
    }
}
