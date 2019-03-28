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
    public partial class FrmCoding : FormRepository
    {
        private CodingModel codingRepository;
        public FrmCoding()
        {
            InitializeComponent();
        }

        private void FrmCoding_Load(object sender, EventArgs e)
        {
            try
            {
                var containerList = new ContainerModel().GetContainerCombo();
                DataTable dt = new DataTable();
                dt.Columns.Add("Id");
                dt.Columns.Add("Contenedor");
                foreach (var item in containerList)
                    dt.Rows.Add(item.Id, item.Description);

                txtContainer.Properties.DataSource = dt;
                txtContainer.Properties.DisplayMember = "Contenedor";
                txtContainer.Properties.ValueMember = "Id";

                codingRepository = new CodingModel().GetId(Id);
                if (codingRepository != null)
                {
                    codingRepository.State = EntityState.Modified;
                    txtContainer.ItemIndex = codingRepository.ContainerID;
                    txtText.Text = codingRepository.Text;
                    txtNumber.Text = codingRepository.Number.ToString();
                    txtNumberLength.Text = codingRepository.Numberlength.ToString();
                    cbeActive.Checked = codingRepository.Active;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            try
            {
                if (Id == 0)
                {
                    codingRepository = new CodingModel();
                    codingRepository.State = EntityState.Added;
                }
                codingRepository.ContainerID = Convert.ToInt32(txtContainer.ItemIndex);
                codingRepository.Text = txtText.Text;
                codingRepository.Number = Convert.ToInt32(txtNumber.Text);
                codingRepository.Numberlength = Convert.ToInt32(txtNumberLength.Text);
                codingRepository.Active = cbeActive.Checked;
                codingRepository.UserID = ConstantData.Login.Id;
                codingRepository.SaveChanges();

                Page.LoadPage(NamePage, TextPage);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
