using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Provider
    {
        public int Id { get; set; }
        public int IdCreditModality { get; set; }
        public decimal CreditLine { get; set; }
        public int IdUser { get; set; }
    }
}
