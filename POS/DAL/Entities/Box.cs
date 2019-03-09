using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Box
    {
        public int Id { get; set; }
        public int IdBranchOffice { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AccountNumber { get; set; }
        public decimal BeginningBalance { get; set; }
        public decimal Balance { get; set; }
        public decimal AvailableBalance { get; set; }
        public bool ItsBank { get; set; }
        public bool Active { get; set; }
        public int IdUser { get; set; }
    }
}
