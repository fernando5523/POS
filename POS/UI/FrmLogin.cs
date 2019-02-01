using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraEditors.Controls;

namespace UI
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            DataTable Auth = new DataTable();
            Auth.Columns.Add("Id", typeof(int));
            Auth.Columns.Add("Name", typeof(string));

            Auth.Rows.Add(0, "Microsoft SQL Server");
            Auth.Rows.Add(1, "Windows Active Directory");

            LueAutentificacion.Properties.DataSource = Auth;
            LueAutentificacion.Properties.DisplayMember = "Name";
            LueAutentificacion.Properties.ValueMember = "Id";
            LueAutentificacion.EditValue = 0;

            LookUpColumnInfoCollection Col = LueAutentificacion.Properties.Columns;
            Col.Add(new LookUpColumnInfo("Id", "Id", 20));
            Col["Id"].Visible = false;
            Col.Add(new LookUpColumnInfo("Name", "Name", 100));
            
        }
    }
}
