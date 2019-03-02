using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Document
    {
        public int Id { get; set; }
        public int IdBranchOffice { get; set; }
        public int IdDocumentType { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Series { get; set; }
        public int SeriesLength { get; set; }
        public int Number { get; set; }
        public int NumberLength { get; set; }
        public int Box { get; set; }
        public int Inventory { get; set; }
        public int IdUser { get; set; }
    }
}
