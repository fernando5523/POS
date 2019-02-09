using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.Data.Filtering;

namespace UI
{
    public partial class FrmFiltro : DevExpress.XtraEditors.XtraForm
    {
        private string page;

        public string Page
        {
            get
            {
                return page;
            }

            set
            {
                page = value;
            }
        }

        public FrmFiltro()
        {
            InitializeComponent();
        }

        private void FrmFiltro_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Code", typeof(string));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("Active", typeof(bool));

            fcFilter.SourceControl = table;
            //filterControl1.FilterCriteria = CriteriaOperator.Parse("StartsWith([Name], 'r') OR [Age]=10 OR [Age]<= 5");
            textEdit1.Text = this.Page;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var tsql = CriteriaToWhereClauseHelper.GetMsSqlWhere(fcFilter.FilterCriteria);
            textEdit1.Text = tsql;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
