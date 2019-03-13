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
    using BLL.Model;
    using BLL.ValueObjects;
    using UI.Helpers;
    public partial class FrmUnitTemplate : FormRepository
    {
        private UnitTemplateModel objectModel;
        public FrmUnitTemplate()
        {
            InitializeComponent();
        }

        private void FrmUnitTemplate_Load(object sender, EventArgs e)
        {
            if (Id == 0)
                objectModel = new UnitTemplateModel();
            else
            {
                objectModel = new UnitTemplateModel().GetId(Id);
                objectModel.State = EntityState.Modified;
                txtCode.Text = objectModel.Code;
                txtNombre.Text = objectModel.Name;
                txtAbreviacion.Text = objectModel.Abbreviation;
                txtFactor.Text = objectModel.Factor.ToString();
                txtDescripcion.Text = objectModel.Description;
            }
            txtNombre.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            objectModel.Id = Id;
            objectModel.Code = txtCode.Text;
            objectModel.Name = txtNombre.Text;
            objectModel.Abbreviation = txtAbreviacion.Text;
            objectModel.Factor = Convert.ToInt32(txtFactor.Text);
            objectModel.Description = txtDescripcion.Text;
            objectModel.IdUser = ConstantData.Login.Id;
            MessageBox.Show(objectModel.SaveChanges());
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
