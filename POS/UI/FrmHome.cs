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
using BLL.ValueObjects;

using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraGrid;
using BLL;
using UI.Helpers;
using UI.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace UI
{
    public partial class FrmHome : DevExpress.XtraEditors.XtraForm, IPages
    {
        public ContainerModel Containers = new ContainerModel();
        public ConsultModel Consult = new ConsultModel();
        public FilterModel Filter = new FilterModel();
        public FrmHome()
        {
            InitializeComponent();
        }

        #region Comandos
        public void NewCommand()
        {
            OpenForm();
        }
        public void EditCommand()
        {
            if (ItemSelect().Count > 0)
            {
                int id = ItemSelect()[0];
                OpenForm(id);
            }
            else
                MessageBox.Show("Es necesario seleccionar un item de la vista administrativa.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void RemoveCommand()
        {
            DialogResult Resultado = MessageBox.Show("Seguro que desea eliminar los items seleccionados?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                List<int> items = ItemSelect();
                foreach (int item in items)
                    ItemDelete(item);
                LoadPage(xtcPages.SelectedTabPage.Name, xtcPages.SelectedTabPage.Text);
            }
        }
        public void RefreshCommand()
        {
            LoadPage(xtcPages.SelectedTabPage.Name, xtcPages.SelectedTabPage.Text);
        }
        public void FilterCommand()
        {
            FrmFiltro Filtro = new FrmFiltro(xtcPages.SelectedTabPage.Name, xtcPages.SelectedTabPage.Text, ConstantData.Login.Id);
            Filtro.Pages = this;
            Filtro.Show();
        }
        #endregion

        #region Métodos
        private void OpenForm(int id = 0)
        {
            ContainerModel containerDataModel = Containers.GetContainerName(xtcPages.SelectedTabPage.Name);
            var _formName = (from t in System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                             where t.Name.Equals(containerDataModel.Form)
                             select t.FullName).Single();
            var _form = (FormRepository)Activator.CreateInstance(Type.GetType(_formName));
            if (_form != null)
            {
                _form.Id = id;
                _form.Page = this;
                _form.NamePage = xtcPages.SelectedTabPage.Name;
                _form.TextPage = xtcPages.SelectedTabPage.Text;
                _form.Show();
            }
        }

        private List<int> ItemSelect()
        {
            XtraTabPage con = (XtraTabPage)this.Controls["xtcPages"].Controls[xtcPages.SelectedTabPage.Name];
            GridControl grid = (GridControl)con.Controls[xtcPages.SelectedTabPage.Name];
            List<int> items = new List<int>();

            int[] selRows = ((GridView)grid.MainView).GetSelectedRows();

            foreach (int i in selRows)
            {
                DataRowView selRow = (DataRowView)(((GridView)grid.MainView).GetRow(i));
                //DataRowView selRow = (DataRowView)(((GridView)grid.MainView).GetRow(selRows[i]));
                items.Add((int)selRow["Id"]);
            }
            return items;
        }

        public bool ItemDelete(int Id)
        {
            string entidad = xtcPages.SelectedTabPage.Name;
            return ConstantData.DeleteItem(entidad, Id);
        }
        public void LoadPage(string name, string text)
        {
            //Revisamos si existe el page seleccionado en el panel.
            bool exist = false;
            for (int i = 0; i < xtcPages.TabPages.Count; i++)
            {
                if (xtcPages.TabPages[i].Name == name)
                {
                    xtcPages.SelectedTabPage = xtcPages.TabPages[i];

                    XtraTabPage con = (XtraTabPage)this.Controls["xtcPages"].Controls[xtcPages.SelectedTabPage.Name];
                    GridControl grid = (GridControl)con.Controls[xtcPages.SelectedTabPage.Name];
                    grid.DataSource = LoadView(name);
                    exist = true;
                }
            }

            if (!exist)
            {
                var Page = new XtraTabPage();
                Page.Name = name;
                Page.Text = text;

                //Creamos el control tipo lista para el contenedor
                GridView gView = new GridView();
                gView.OptionsBehavior.ReadOnly = true;
                gView.OptionsBehavior.AutoPopulateColumns = true;
                gView.OptionsView.ColumnAutoWidth = false;
                gView.OptionsBehavior.Editable = false;
                gView.OptionsView.ShowGroupPanel = false;
                gView.OptionsView.ShowAutoFilterRow = true;
                gView.DoubleClick += gridView_DoubleClick;
                gView.KeyDown += GridView_KeyDown;

                GridControl grid = new GridControl();
                grid.Name = name;

                grid.Dock = DockStyle.Fill;
                grid.ContextMenuStrip = cmsMenu;

                grid.ViewCollection.Add(gView);
                grid.MainView = gView;
                grid.BindingContext = new BindingContext();
                grid.DataSource = LoadView(name);

                gView.PopulateColumns();
                gView.BestFitColumns();
                grid.ForceInitialize();
                if (gView.Columns["Id"] != null)
                    gView.Columns["Id"].Visible = false;
                gView.OptionsSelection.MultiSelect = true;

                #region Número de columna
                //GridColumn colCounter = gView.Columns.AddVisible("Nro.");
                //colCounter.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
                //colCounter.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                //gView.CustomUnboundColumnData += (sender, e) =>
                //{
                //    GridView view = sender as GridView;
                //    if (e.Column.FieldName == "Nro." && e.IsGetData)
                //        e.Value = view.GetRowHandle(e.ListSourceRowIndex) + 1;
                //};
                #endregion

                Page.Controls.Add(grid);

                xtcPages.TabPages.Add(Page);
                xtcPages.SelectedTabPage = Page;
            }
        }
        public DataTable LoadView(string name)
        {
            //Obtenemos el contenedor, consulta y el filtro
            ContainerModel containerDataModel = Containers.GetContainerName(name);
            ConsultModel consultDataModel = Consult.GetIdContainer(containerDataModel.Id);
            FilterModel filterDataModel = Filter.GetUser(ConstantData.Login.Id, consultDataModel.Id);

            string where;
            if (!string.IsNullOrWhiteSpace(consultDataModel.Where))
                where = " AND " + filterDataModel.Condition;
            if (string.IsNullOrWhiteSpace(filterDataModel.Condition))
                where = "";
            else
                where = " WHERE " + filterDataModel.Condition;

            string transactSql = consultDataModel.Select + " " + consultDataModel.From + " " + where + " " + consultDataModel.GroupBy + " " + consultDataModel.Having + " " + consultDataModel.OrderBy;
            return Filter.Execute(transactSql);
        }

        #endregion

        #region Eventos
        private void GridView_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EditCommand();
        }
        private void treeview_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView tree = (TreeView)sender;
            if (e.Node.Tag.ToString() != "0")
                LoadPage(tree.SelectedNode.Name, tree.SelectedNode.Text);
        }

        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            xtcPages.TabPages.Remove(xtcPages.SelectedTabPage);
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            List<int> item = ItemSelect();
            if (item.Count > 0)
                OpenForm(ItemSelect()[0]);
        }

        #endregion

        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Seguro que desea salir de la aplicación", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }

        private void btnUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUserPassword UserPassword = new FrmUserPassword();
            UserPassword.ShowDialog();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            Text += ConstantData.Enterprise;
            #region Eventos
            tvCompra.AfterSelect += new TreeViewEventHandler(treeview_AfterSelect);
            tvInventario.AfterSelect += new TreeViewEventHandler(treeview_AfterSelect);
            tvVenta.AfterSelect += new TreeViewEventHandler(treeview_AfterSelect);
            tvConfiguracion.AfterSelect += new TreeViewEventHandler(treeview_AfterSelect);
            xtcPages.CloseButtonClick += new EventHandler(xtraTabControl_CloseButtonClick);
            #endregion

            //Footer
            btnUsuario.Caption = "Usuario :" + ConstantData.Login.Name;
            txtFecha.Caption = "Fecha : " + DateTime.Now.ToString("dd/MM/yyyy");
            txtHora.Caption = "Hora : " + DateTime.Now.ToString("HH:mm:ss");
        }


        private void tmTiempo_Tick(object sender, EventArgs e)
        {
            txtHora.Caption = "Hora : " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshCommand();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RemoveCommand();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewCommand();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditCommand();
        }

        private void btnFiltro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FilterCommand();
        }

        private void cmsFiltro_Click(object sender, EventArgs e)
        {
            FilterCommand();
        }

        private void cmsActualizar_Click(object sender, EventArgs e)
        {
            RefreshCommand();
        }

        private void cmsNuevo_Click(object sender, EventArgs e)
        {
            NewCommand();
        }

        private void cmsEliminar_Click(object sender, EventArgs e)
        {
            RemoveCommand();
        }

        private void cmsModificar_Click(object sender, EventArgs e)
        {
            EditCommand();
        }
    }
}
