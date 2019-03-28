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
    public partial class FrmContainer : FormRepository
    {
        private ContainerModel containerRepository;
        public FrmContainer()
        {
            InitializeComponent();
        }

        private void FrmContainer_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Principal");
                dt.Columns.Add("Select");
                dt.Columns.Add("From");
                dt.Columns.Add("Where");
                dt.Columns.Add("GroupBy");
                dt.Columns.Add("Having");
                dt.Columns.Add("OrderBy");

                gcConsultas.DataSource = dt;

                containerRepository = new ContainerModel().GetId(Id);
                if(containerRepository != null)
                {
                    txtCode.Text = containerRepository.Code;
                    txtNombre.Text = containerRepository.Name;
                    txtNivel.Text = containerRepository.Level.ToString();
                    txtOrden.Text = containerRepository.Sort.ToString();
                    txtDescripcion.Text = containerRepository.Description;
                    txtFormulario.Text = containerRepository.Form;
                    cbeActive.Checked = containerRepository.Active;
                    cbeVista.Checked = containerRepository.IsView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
