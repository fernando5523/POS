using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    using BLL.Model;
    using BLL.ValueObjects;
    using UI.Helpers;
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
                btnAceptar.Enabled = true;
            else
            {
                btnAceptar.Enabled = false;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel objectModel = ConstantData.Login;
                objectModel.Password = txtNueva.Text;
                objectModel.State = EntityState.Modified;
                ConstantData.MessageInformation(objectModel.SaveChanges());
                ConstantData.Login = objectModel;
                Close();
            }
            catch (Exception ex)
            {
                ConstantData.MessageError(ex.Message);
            }
        }
    }
}
