using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Consult
    {
        public int Id { get; set; }
        public int IdContainer { get; set; }
        public bool Principal { get; set; }
        public string Select { get; set; }
        public string From { get; set; }
        public string Where { get; set; }
        public string GroupBy { get; set; }
        public string Having { get; set; }
        public string OrderBy { get; set; }
        public int IdUser { get; set; }
    }
}
