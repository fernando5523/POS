using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Contracts;

namespace DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public int IdUser { get; set; }
    }
}
