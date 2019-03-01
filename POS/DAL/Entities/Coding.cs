using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Coding
    {
        public int Id { get; set; }
        public string Entity { get; set; }
        public string Text { get; set; }
        public int Number { get; set; }
        public int NumberLength { get; set; }
        public bool Active { get; set; }
        public int IdUser { get; set; }
    }
}
