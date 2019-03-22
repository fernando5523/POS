using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Repository;

namespace UI
{
    using UI.Repository;
    using UI.Helpers;
    using BLL.Model;
    using BLL.ValueObjects;
    public partial class FrmUser : FormRepository
    {
        private UserModel userRepository;
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            userRepository = new UserModel().GetId(Id);
            if (userRepository != null)
            {
                userRepository.State = EntityState.Modified;
                txtNombre.Text = userRepository.Name;
                txtContraseña.Text = userRepository.Password;
                cbeActive.Checked = userRepository.Active;
                txtNombre.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Seguro que desea cerrar la ventana?", "RetailPOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
                Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                userRepository = new UserModel();
                userRepository.State = EntityState.Added;
            }

            userRepository.Name = txtNombre.Text.Trim();
            userRepository.Password = txtContraseña.Text;
            userRepository.Active = cbeActive.Checked;
            userRepository.IdUser = ConstantData.Login.Id;
            userRepository.SaveChanges();

            Page.LoadPage(NamePage, TextPage);
            Close();
        }
    }
}
