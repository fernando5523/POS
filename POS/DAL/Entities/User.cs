using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User : DefaultProperties
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
    }
}
