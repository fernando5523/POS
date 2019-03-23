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
    using UI.Repository;
    using UI.Helpers;
    using BLL.Model;
    using BLL.ValueObjects;
    public partial class FrmBrand : FormRepository
    {
        private BrandModel brandRepository;
        public FrmBrand()
        {
            InitializeComponent();
        }

        private void FrmBrand_Load(object sender, EventArgs e)
        {
            brandRepository = new BrandModel().GetId(Id);
            if (brandRepository != null)
            {
                brandRepository.State = EntityState.Modified;
                txtCode.Text = brandRepository.Code;
                txtDescription.Text = brandRepository.Description;
                cbeActive.Checked = brandRepository.Active;
                txtDescription.Focus();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                //var codingRepository = new CodingModel().GetEntity("Brand");
                //brandRepository = new BrandModel();
                //brandRepository.Code = codingRepository.Code;
                //codingRepository.Number += 1;
                //codingRepository.State = EntityState.Added;
                //codingRepository.SaveChanges();
            }
            brandRepository.Description = txtDescription.Text.Trim();
            brandRepository.Active = cbeActive.Checked;
            brandRepository.IdUser = ConstantData.Login.Id;
            
            brandRepository.SaveChanges();
            Page.LoadPage(NamePage, TextPage);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Seguro que desea cerrar la ventana?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
                Close();
        }
    }
}
