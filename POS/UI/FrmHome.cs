using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entity = EL;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraGrid;
using BLL;
using DevExpress.XtraGrid.Views.Grid;

namespace UI
{
    public partial class FrmHome : DevExpress.XtraEditors.XtraForm
    {
        public Entity.User Usuario;
        public FrmHome()
        {
            InitializeComponent();
        }

        #region Métodos
        private void LoadPage(string name, string text)
        {
            bool exist = false;
            for(int i = 0; i < xtcPages.TabPages.Count; i++)
            {
                if(xtcPages.TabPages[i].Name == name)
                {
                    xtcPages.SelectedTabPage = xtcPages.TabPages[i];
                    exist = true;
                }
            }

            if (!exist)
            {
                XtraTabPage Page = new XtraTabPage();
                Page.Name = name;
                Page.Text = text;

                //Obtenemos el contenedor
                BLL.Container Container = new BLL.Container();
                Entity.Container Contenedor = Container.GetBy(name);

                //Obtenemos la consulta
                Consult Consult = new Consult();
                DataTable Dt = Consult.GetView(Contenedor);

                //Creamos el control tipo lista para el contenedor
                GridView gView = new GridView();
                gView.OptionsBehavior.ReadOnly = true;

                GridControl Grid = new GridControl();
                Grid.Dock = DockStyle.Fill;
                Grid.ContextMenuStrip = cmsMenu;

                Grid.ViewCollection.Add(gView);
                Grid.MainView = gView;
                Grid.BindingContext = new BindingContext();
                Grid.DataSource = Dt;

                gView.PopulateColumns();
                Grid.ForceInitialize();
                gView.Columns["Id"].Visible = false;
                gView.OptionsSelection.MultiSelect = true;

                //gridControl1.DataSource = Dt;
                Page.Controls.Add(Grid);

                xtcPages.TabPages.Add(Page);
                xtcPages.SelectedTabPage = Page;
            }
        }
        #endregion

        #region Eventos
        private void treeview_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView tree = (TreeView)sender;
            if(e.Node.Tag.ToString() != "0")
                LoadPage(tree.SelectedNode.Name, tree.SelectedNode.Text);
        }

        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            xtcPages.TabPages.Remove(xtcPages.SelectedTabPage);
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

        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            tvCompra.AfterSelect += new TreeViewEventHandler(treeview_AfterSelect);
            tvInventario.AfterSelect += new TreeViewEventHandler(treeview_AfterSelect);
            tvVenta.AfterSelect += new TreeViewEventHandler(treeview_AfterSelect);
            tvConfiguracion.AfterSelect += new TreeViewEventHandler(treeview_AfterSelect);
            xtcPages.CloseButtonClick += new EventHandler(xtraTabControl_CloseButtonClick);

            btnUsuario.Caption = "Usuario :" + Usuario.Name;
            txtFecha.Caption = "Fecha : " + DateTime.Now.ToString("dd/MM/yyyy");
            txtHora.Caption = "Hora : " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnFiltro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFiltro Filtro = new FrmFiltro();
            Filtro.Page = xtcPages.SelectedTabPage.Name;
            Filtro.Show();
        }

        private void tmTiempo_Tick(object sender, EventArgs e)
        {
            txtHora.Caption = "Hora : " + DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
