using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Filter
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdConsult { get; set; }
        public string Condition { get; set; }
        public string ConditionDev { get; set; }
    }
}
