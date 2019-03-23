using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Coding : DefaultProperties
    {
        public int  IdContainer { get; set; }
        public string Text { get; set; }
        public int Number { get; set; }
        public int NumberLength { get; set; }
        public bool Active { get; set; }
    }
}
