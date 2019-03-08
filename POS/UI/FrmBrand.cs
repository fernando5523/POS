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
            brandRepository = new BrandModel().GetId(this.Id);
            if (this.Id > 0)
            {
                brandRepository.State = EntityState.Modified;
                txtCode.Text = brandRepository.Code;
                txtDescription.Text = brandRepository.Description;
                cbeActive.Checked = brandRepository.Active;
                txtDescription.Focus();
            }
            else
                brandRepository.State = EntityState.Added;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            brandRepository.Code = txtCode.Text.Trim();
            brandRepository.Description = txtDescription.Text.Trim();
            brandRepository.Active = cbeActive.Checked;
            brandRepository.IdUser = ConstantData.Login.Id;
            
            brandRepository.SaveChanges();
            Page.LoadPage(this.NamePage, this.TextPage);
            this.Close();
        }
    }
}
