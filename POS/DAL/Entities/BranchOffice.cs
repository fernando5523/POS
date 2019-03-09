using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class BranchOffice
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Latittud { get; set; }
        public decimal Longitud { get; set; }
        public bool Active { get; set; }
        public int IdUser { get; set; }
    }
}
