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
using Entity = EL;
using BLL;
using System.IO;

namespace UI
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        #region General
        User Usuario = new User();
        #endregion

        public FrmLogin()
        {
            InitializeComponent();
        }

        #region Métodos
        private void CheckFields()
        {
            if (txtUsuario.Text == "" || txtContraseña.Text == "")
                btnInicio.Enabled = false;
            else
                btnInicio.Enabled = true;
        }

        private void CheckRecorder()
        {
            string Dir = Path.GetTempPath() + "POS" + @"\" + txtUsuario.Text + ".txt";
            if (File.Exists(Dir))
            {
                ckRecordar.Checked = true;
                StreamReader Sr = new StreamReader(Dir);

            }
            else
                ckRecordar.Checked = false;
        }
        #endregion

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            #region Lista con los tipos de authentication
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
            #endregion
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
            CheckRecorder();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Entity.User obj = new Entity.User();
            obj.Name = txtUsuario.Text;
            obj.Password = txtContraseña.Text;

            if(LueAutentificacion.ItemIndex == 0)
            {
                Entity.User usr = Usuario.ListBy(obj);
                if(usr.Active == true)
                {
                    string Dir = Path.GetTempPath() + "POS";
                    string FileName = obj.Name;

                    if(ckRecordar.Checked == true)
                    {
                        if(!File.Exists(Dir + "\\" + FileName + ".txt"))
                        {
                            Directory.CreateDirectory(Dir);
                            StreamWriter Sw = new StreamWriter(Dir + @"\" + FileName + ".txt");

                            Security Secure = new Security();
                            Sw.WriteLine(Secure.Encrypt(obj.Password));
                            Sw.Close();
                        }
                    }
                    else
                    {
                        Dir = Dir + @"\" + FileName + ".txt";
                        if (File.Exists(Dir))
                            File.Delete(Dir);
                    }
                    this.Hide();
                }
            }
        }
    }
}
