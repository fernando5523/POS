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
    using DevExpress.XtraGrid.Columns;
    using DevExpress.XtraGrid.Views.Grid;
    using DevExpress.XtraGrid.Views.BandedGrid;

    public partial class FrmContainer : FormRepository
    {
        private ContainerModel containerRepository;
        private List<int> DeleteRecords = new List<int>();
        private List<ConsultModel> UpdateRecords = new List<ConsultModel>();
        private List<ConsultModel> CreateRecords = new List<ConsultModel>();
        public FrmContainer()
        {
            InitializeComponent();
        }

        private void FrmContainer_Load(object sender, EventArgs e)
        {
            try
            {
                containerRepository = new ContainerModel().GetId(Id);
                DataTable dt = new DataTable();
                dt.Columns.Add("Temp", typeof(string));
                dt.Columns.Add("State", typeof(string));
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("ContainerID", typeof(int));
                dt.Columns.Add("Principal", typeof(bool));
                dt.Columns.Add("Select", typeof(string));
                dt.Columns.Add("From", typeof(string));
                dt.Columns.Add("Where", typeof(string));
                dt.Columns.Add("GroupBy", typeof(string));
                dt.Columns.Add("Having", typeof(string));
                dt.Columns.Add("OrderBy", typeof(string));
                dt.Columns.Add("UserID", typeof(string));

                gridView1.OptionsBehavior.ReadOnly = false;
                gridView1.OptionsBehavior.AutoPopulateColumns = true;
                gridView1.OptionsView.ColumnAutoWidth = false;
                gridView1.OptionsBehavior.Editable = true;
                gridView1.OptionsView.ShowGroupPanel = false;
                gridView1.OptionsView.ShowAutoFilterRow = false;
                gridView1.OptionsView.ShowFooter = false;
                gridView1.OptionsSelection.MultiSelect = true;
                gridView1.OptionsView.ShowIndicator = true;

                foreach(var item in containerRepository.Consult)
                {
                    DataRow row = dt.NewRow();
                    row["Temp"] = "NoTemp";
                    row["State"] = "";
                    row["Id"] = item.Id;
                    row["ContainerID"] = item.ContainerID;
                    row["Principal"] = item.Principal;
                    row["Select"] = item.Select;
                    row["From"] = item.From;
                    row["Where"] = item.Where;
                    row["GroupBy"] = item.GroupBy;
                    row["Having"] = item.Having;
                    row["OrderBy"] = item.OrderBy;
                    row["UserID"] = item.UserID;
                    dt.Rows.Add(row);
                }
                gcConsultas.DataSource = dt;

                gridView1.Columns["Temp"].Visible = true;
                gridView1.Columns["State"].Visible = true;
                gridView1.Columns["Id"].Visible = true;
                gridView1.Columns["ContainerID"].Visible = true;
                gridView1.Columns["UserID"].Visible = true;

                if (containerRepository != null)
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
            DataTable table = (DataTable)gcConsultas.DataSource;
            DataRow row = table.NewRow();
            row["Temp"] = "Temp";
            row["State"] = "";
            row["Id"] = 0;
            row["ContainerID"] = Id;
            table.Rows.Add(row);
            gcConsultas.DataSource = table;
            //gridView1.AddNewRow();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int[] selRows = gridView1.GetSelectedRows();
            foreach (int i in selRows)
            {
                var item = (DataRowView)gcConsultas.MainView.GetRow(i);
                if ((int)item.Row["Id"] != 0)
                    DeleteRecords.Add((int)item["Id"]);
            }

            gridView1.DeleteSelectedRows();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            BandedGridView view = sender as BandedGridView;
            if (view == null) return;
            string column = e.Column.Name;
            int index = e.RowHandle;
            string value = e.Value.ToString();
            view.SetRowCellValue(e.RowHandle, view.Columns["State"], "Modified");
            
            //int[] selRows = gridView1.GetSelectedRows();
            //foreach (int i in selRows)
            //{
            //    var item = (DataRowView)gcConsultas.MainView.GetRow(i);
            //    if ((int)item.Row["Id"] != 0)
            //    {
            //        ConsultModel Objects = new ConsultModel();
            //        Objects.Id = (int)item["Id"];
            //        Objects.ContainerID = (int)item["ContainerID"];
            //        Objects.Principal = (bool)item["Principal"];
            //        Objects.Select = item["Select"].ToString();
            //        Objects.From = item["From"].ToString();
            //        Objects.Where = item["Where"].ToString();
            //        Objects.GroupBy = item["GroupBy"].ToString();
            //        Objects.Having = item["Having"].ToString();
            //        Objects.OrderBy = item["OrderBy"].ToString();
            //        Objects.UserID = ConstantData.Login.Id;

            //        UpdateRecords.Add(Objects);
            //    }
            //}
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }
    }
}