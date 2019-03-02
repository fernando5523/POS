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
using DevExpress.XtraGrid.Views.Grid;

namespace UI
{
    public partial class FrmHome : DevExpress.XtraEditors.XtraForm, IPages
    {
        public UserModel Login;
        public FrmHome()
        {
            InitializeComponent();
        }

        #region Métodos
        public void LoadPage(string name, string text, bool reset)
        {
            bool exist = false;
            for(int i = 0; i < xtcPages.TabPages.Count; i++)
            {
                if(xtcPages.TabPages[i].Name == name && reset == false)
                {
                    xtcPages.SelectedTabPage = xtcPages.TabPages[i];
                    exist = true;
                }
                if (xtcPages.TabPages[i].Name == name && reset == true)
                {
                    xtcPages.TabPages.Remove(xtcPages.TabPages[i]);
                    exist = false;
                }
            }

            if (!exist)
            {
                //XtraTabPage Page = new XtraTabPage();
                //Page.Name = name;
                //Page.Text = text;

                ////Obtenemos el contenedor
                //BLL.Container Container = new BLL.Container();
                //Entity.Container Contenedor = Container.GetBy(name);

                ////Obtenemos la consulta
                //Consult Consult = new Consult();
                //Entity.Consult objConsult = Consult.GetBy(Contenedor.Id);
                //Filter Filter = new Filter();
                //Entity.Filter objFilter = Filter.GetBy(objConsult.Id);
                //DataTable Dt = Consult.GetView(Contenedor.Id, objFilter.Condition);

                ////Creamos el control tipo lista para el contenedor
                //GridView gView = new GridView();
                //gView.OptionsBehavior.ReadOnly = true;

                //GridControl Grid = new GridControl();
                //Grid.Name = name;
                //Grid.Dock = DockStyle.Fill;
                //Grid.ContextMenuStrip = cmsMenu;

                //Grid.ViewCollection.Add(gView);
                //Grid.MainView = gView;
                //Grid.BindingContext = new BindingContext();
                //Grid.DataSource = Dt;

                //gView.PopulateColumns();
                //Grid.ForceInitialize();
                //gView.Columns["Id"].Visible = false;
                //gView.OptionsSelection.MultiSelect = true;

                //Page.Controls.Add(Grid);

                //xtcPages.TabPages.Add(Page);
                //xtcPages.SelectedTabPage = Page;
            }
        }
        #endregion

        #region Eventos
        private void treeview_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView tree = (TreeView)sender;
            if(e.Node.Tag.ToString() != "0")
                LoadPage(tree.SelectedNode.Name, tree.SelectedNode.Text, false);
        }

        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            xtcPages.TabPages.Remove(xtcPages.SelectedTabPage);
        }

        private void button_Click(object sender, EventArgs e)
        {
            FrmFiltro Filtro = new FrmFiltro();
            Filtro.Name = xtcPages.SelectedTabPage.Name;
            Filtro.Text = xtcPages.SelectedTabPage.Text;
            Filtro.Pages = this;
            Filtro.Show();
        }

        private void button_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFiltro Filtro = new FrmFiltro();
            Filtro.Name = xtcPages.SelectedTabPage.Name;
            Filtro.Text = xtcPages.SelectedTabPage.Text;
            Filtro.Pages = this;
            Filtro.Show();
        }
        #endregion

        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Seguro que desea salir de la aplicación", "POS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {
                try
                {
                    Application.ExitThread();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                e.Cancel = true;
        }

        private void btnUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUserPassword UserPassword = new FrmUserPassword();
            UserPassword.Login = Login;
            UserPassword.ShowDialog();
            Login = UserPassword.Login;
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            #region Eventos
            tvCompra.AfterSelect += new TreeViewEventHandler(treeview_AfterSelect);
            tvInventario.AfterSelect += new TreeViewEventHandler(treeview_AfterSelect);
            tvVenta.AfterSelect += new TreeViewEventHandler(treeview_AfterSelect);
            tvConfiguracion.AfterSelect += new TreeViewEventHandler(treeview_AfterSelect);
            xtcPages.CloseButtonClick += new EventHandler(xtraTabControl_CloseButtonClick);

            //Filtro
            btnFiltro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(button_ItemClick);
            mnuFiltro.Click += new EventHandler(button_Click);

            #endregion

            //Footer
            btnUsuario.Caption = "Usuario :" + Login.Name;
            txtFecha.Caption = "Fecha : " + DateTime.Now.ToString("dd/MM/yyyy");
            txtHora.Caption = "Hora : " + DateTime.Now.ToString("HH:mm:ss");
        }


        private void tmTiempo_Tick(object sender, EventArgs e)
        {
            txtHora.Caption = "Hora : " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void mnuEliminar_Click(object sender, EventArgs e)
        {
            XtraTabPage con =  (XtraTabPage)this.Controls["xtcPages"].Controls[xtcPages.SelectedTabPage.Name];
            GridControl grid = (GridControl)con.Controls[xtcPages.SelectedTabPage.Name];

            int[] selRows = ((GridView)grid.MainView).GetSelectedRows();

            foreach(int i in selRows)
            {
                DataRowView selRow = (DataRowView)(((GridView)grid.MainView).GetRow(i));
                //DataRowView selRow = (DataRowView)(((GridView)grid.MainView).GetRow(selRows[i]));
                MessageBox.Show(selRow["Id"].ToString());
            }
        }

        private void tvCompra_AfterSelect(object sender,TreeViewEventArgs e)
        {

        }
    }
}
