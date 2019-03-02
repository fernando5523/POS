using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public int IdPerson { get; set; }
        public int IdEmployeePosition { get; set; }
        public DateTime AdmissionDate { get; set; }
        public int IdUser { get; set; }
    }
}
