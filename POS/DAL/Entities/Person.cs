using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public int IdPersonType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime BirthdayDate { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public bool Foreigner { get; set; }
        public bool Active { get; set; }
        public int IdUser { get; set; }
    }
}
