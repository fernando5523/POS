using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UI.Repository
{
    public class FormRepository: XtraForm
    {
        public int Id { get; set; }
        public IPages Page { get; set; }
        public string NamePage { get; set; }
        public string TextPage { get; set; }
    }
}
