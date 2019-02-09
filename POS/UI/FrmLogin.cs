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

                Security Secure = new Security();
                StreamReader Sr = new StreamReader(Dir);
                string Text = Sr.ReadToEnd();
                Sr.Close();

                txtContraseña.Text = Secure.Decrypt(Text);
            }
            else
            {
                ckRecordar.Checked = false;
                txtContraseña.Text = "";
            }
                
        }

        private void CreateTempRecorder(string UserName, string Password)
        {
            string Dir = Path.GetTempPath() + "POS";
            string FileName = UserName;

            if (!File.Exists(Dir + "\\" + FileName + ".txt"))
            {
                Directory.CreateDirectory(Dir);
                StreamWriter Sw = new StreamWriter(Dir + @"\" + FileName + ".txt");

                Security Secure = new Security();
                Sw.WriteLine(Secure.Encrypt(Password));
                Sw.Close();
            }
        }

        private void DeleteTempRecorder(string UserName)
        {
            string Dir = Path.GetTempPath() + "POS";
            string FileName = UserName;

            Dir = Dir + @"\" + FileName + ".txt";
            if (File.Exists(Dir))
                File.Delete(Dir);
        }
        #endregion

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            #region Lista con los tipos de authentication
            DataTable Auth = new DataTable();
            Auth.Columns.Add("Id", typeof(int));
            Auth.Columns.Add("Name", typeof(string));

            Auth.Rows.Add(0, "Microsoft SQL Server");
            //Auth.Rows.Add(1, "Windows Active Directory");

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
                //Válidamos el usuario
                Entity.User usr = Usuario.ListBy(obj);
                if(usr.Active == true)
                {
                    if(ckRecordar.Checked == true)
                        CreateTempRecorder(obj.Name, obj.Password);
                    else
                        DeleteTempRecorder(obj.Name);

                    this.Hide();
                    
                    //Cargamos el formulario Home
                    FrmHome Home = new FrmHome();
                    Home.Usuario = usr;
                    Home.Show();
                }
            }
        }
    }
}
