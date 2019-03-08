using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Model;
using UI.Helpers;

namespace UI
{
    public partial class FrmUserPassword:DevExpress.XtraEditors.XtraForm
    {
        public FrmUserPassword()
        {
            InitializeComponent();
        }

        #region Métodos
        private void ValidatePassword()
        {
            if(txtActual.Text == ConstantData.Login.Password && txtNueva.Text == txtRepetir.Text && txtNueva.Text != string.Empty && txtRepetir.Text != string.Empty)
            {
                btnContraseña.Enabled = true;
            }
            else
            {
                btnContraseña.Enabled = false;
                txtActual.Text = ConstantData.Login.Password;
            }
        }
        #endregion

        private void FrmUserPassword_Load(object sender,EventArgs e)
        {
            txtActual.Text = ConstantData.Login.Password;
        }

        private void txtNueva_TextChanged(object sender,EventArgs e)
        {
            ValidatePassword();
        }

        private void txtActual_TextChanged(object sender,EventArgs e)
        {
            ValidatePassword();
        }

        private void txtRepetir_TextChanged(object sender,EventArgs e)
        {
            ValidatePassword();
        }

        private void txtActual_ButtonClick(object sender,DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(txtActual.Properties.PasswordChar.ToString() != "")
            {
                //txtActual.Properties.PasswordChar;
            }
        }
    }
}
