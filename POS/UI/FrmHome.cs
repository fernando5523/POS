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
using DevExpress.XtraNavBar;

namespace UI
{
    public partial class FrmHome : DevExpress.XtraEditors.XtraForm, IPages
    {
        public ContainerModel Containers = new ContainerModel();
        public ConsultModel Consult = new ConsultModel();
        public FilterModel Filter = new FilterModel();
        public ImageModel Images = new ImageModel();
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
            if (xtcPages.SelectedTabPage != null)
            {
                if (ItemSelect().Count > 0)
                {
                    int id = ItemSelect()[0];
                    OpenForm(id);
                }
                else
                    ConstantData.MessageInformation("Es necesario seleccionar un item de la vista administrativa.");
            }
            else
                ConstantData.MessageInformation("Es necesario seleccionar la operación que desea realizar.");
        }
        public void RemoveCommand()
        {
            if (xtcPages.SelectedTabPage != null)
            {
                DialogResult Resultado = MessageBox.Show("Seguro que desea eliminar los items seleccionados?", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resultado == DialogResult.Yes)
                {
                    List<int> items = ItemSelect();
                    foreach (int item in items)
                        MessageBox.Show(ItemDelete(item));
                    LoadPage(xtcPages.SelectedTabPage.Name, xtcPages.SelectedTabPage.Text);
                }
            }
            else
                ConstantData.MessageInformation("Es necesario seleccionar la operación que desea realizar.");
        }
        public void RefreshCommand()
        {
            if (xtcPages.SelectedTabPage != null)
                LoadPage(xtcPages.SelectedTabPage.Name, xtcPages.SelectedTabPage.Text);
            else
                ConstantData.MessageInformation("Es necesario seleccionar la operación que desea realizar.");
        }
        public void FilterCommand()
        {
            if (xtcPages.SelectedTabPage != null)
            {
                FrmFiltro Filtro = new FrmFiltro(xtcPages.SelectedTabPage.Name, xtcPages.SelectedTabPage.Text, ConstantData.Login.Id);
                Filtro.Pages = this;
                Filtro.Show();
            }
            else
                ConstantData.MessageInformation("Es necesario seleccionar la operación que desea realizar.");
        }
        #endregion

        #region Métodos
        private void LoadModule()
        {
            var Modules = Containers.GetContainerModule();
            foreach(var item in Modules)
            {
                TreeView GroupView = new TreeView();
                GroupView.Name = item.Name;
                GroupView.Dock = DockStyle.Fill;
                GroupView.BorderStyle = BorderStyle.None;
                GroupView.ImageList = imgIcon;
                GroupView.AfterSelect += new TreeViewEventHandler(treeview_AfterSelect);
                LoadTreeView(item.Id, null, GroupView);

                NavBarGroup GroupItem = nbcModuls.Groups.Add();
                GroupItem.GroupStyle = NavBarGroupStyle.ControlContainer;
                GroupItem.Name = item.Name;
                GroupItem.Caption = item.Description;

                if(item.IdImage != null)
                {
                    int idimage = (int)item.IdImage;
                    var objects = Images.GetId(idimage);
                    GroupItem.ImageOptions.SmallImage = ConstantData.GetBase64Image(objects.Chain);
                }
                GroupItem.ControlContainer.Controls.Add(GroupView);
            }
        }

        private void LoadTreeView(int? IdRoot, TreeNode Node, TreeView View)
        {
            var Operations = Containers.GetAll().Where(e => e.IdContainer == IdRoot).ToList();
            foreach (var Operation in Operations)
            {
                TreeNode NewNode = new TreeNode();
                NewNode.Name = Operation.Name;
                NewNode.Text = Operation.Description;
                NewNode.ImageIndex = 0;
                NewNode.Tag = Operation.IsView;
                if (Node == null)
                    View.Nodes.Add(NewNode);
                else
                    Node.Nodes.Add(NewNode);
                LoadTreeView(Operation.Id, NewNode, View);
            }
        }

        private void OpenForm(int id = 0)
        {
            if (xtcPages.SelectedTabPage != null)
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
            else
                ConstantData.MessageInformation("Es necesario seleccionar la operación que desea realizar.");
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

        public string ItemDelete(int Id)
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

                    #region GridControl
                    GridControl grid = (GridControl)con.Controls[xtcPages.SelectedTabPage.Name];
                    grid.DataSource = LoadView(name);
                    #endregion

                    exist = true;
                }
            }

            if (!exist)
            {
                var Page = new XtraTabPage();
                Page.Name = name;
                Page.Text = text;

                #region TreeView
                #endregion

                #region GridControl
                //Creamos el control tipo lista para el contenedor
                GridView gView = new GridView();
                gView.OptionsBehavior.ReadOnly = true;
                gView.OptionsBehavior.AutoPopulateColumns = true;
                gView.OptionsView.ColumnAutoWidth = false;
                gView.OptionsBehavior.Editable = false;
                gView.OptionsView.ShowGroupPanel = true;
                gView.OptionsView.ShowAutoFilterRow = true;
                gView.OptionsView.ShowFooter = true;
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

                //Número de columna
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
            FilterModel FilterObject = Filter.GetUser(ConstantData.Login.Id, consultDataModel.Id);

            string where;
            if (!string.IsNullOrWhiteSpace(consultDataModel.Where))
                where = " AND " + FilterObject.Condition;
            if (FilterObject == null)
                where = "";
            else
                where = " WHERE " + FilterObject.Condition;

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
            if ((bool)e.Node.Tag)
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
            LoadModule();
            #region Eventos
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
