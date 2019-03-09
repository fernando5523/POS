using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class PersonDocument
    {
        public int Id { get; set; }
        public int IdPersonDocumentType { get; set; }
        public int IdPerson { get; set; }
        public string Number { get; set; }
        public bool Principal { get; set; }
        public int IdUser { get; set; }
    }
}
