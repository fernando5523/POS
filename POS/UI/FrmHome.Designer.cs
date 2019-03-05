﻿namespace UI
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Comprobante de compra");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Comprobante de gasto");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Operaciones", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Proveedor");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Modalidad de crédito");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Configuración", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Punto de venta");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Operaciones", new System.Windows.Forms.TreeNode[] {
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Cliente");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Caja");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Método de pago");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Configuración", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Tipo de persona");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Empleado");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Cargo empleado");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Tipo de documento");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Sucursal");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Contenedores");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Configuración", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Usuario");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Seguridad", new System.Windows.Forms.TreeNode[] {
            treeNode32});
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Comprobante de salida de inventario");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Comprobante de entrada de inventario");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Operaciones", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Producto");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Marca");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Categoría");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Almacén");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Tipo de producto");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Plantilla de unidades");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Lista de precios");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Configuración", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode42});
            this.dmPanel = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.bmStatusMenu = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnFiltro = new DevExpress.XtraBars.BarButtonItem();
            this.btnActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.btnModificar = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.txtFecha = new DevExpress.XtraBars.BarStaticItem();
            this.txtHora = new DevExpress.XtraBars.BarStaticItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.btnImprimir = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.tvCompra = new System.Windows.Forms.TreeView();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.navBarGroupControlContainer3 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.tvVenta = new System.Windows.Forms.TreeView();
            this.navBarGroupControlContainer4 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.tvConfiguracion = new System.Windows.Forms.TreeView();
            this.navBarGroupControlContainer2 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.tvInventario = new System.Windows.Forms.TreeView();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.xtcPages = new DevExpress.XtraTab.XtraTabControl();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuFiltro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tmTiempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dmPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmStatusMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            this.navBarGroupControlContainer3.SuspendLayout();
            this.navBarGroupControlContainer4.SuspendLayout();
            this.navBarGroupControlContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcPages)).BeginInit();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dmPanel
            // 
            this.dmPanel.Form = this;
            this.dmPanel.MenuManager = this.bmStatusMenu;
            this.dmPanel.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dmPanel.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // bmStatusMenu
            // 
            this.bmStatusMenu.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3,
            this.bar4});
            this.bmStatusMenu.DockControls.Add(this.barDockControlTop);
            this.bmStatusMenu.DockControls.Add(this.barDockControlBottom);
            this.bmStatusMenu.DockControls.Add(this.barDockControlLeft);
            this.bmStatusMenu.DockControls.Add(this.barDockControlRight);
            this.bmStatusMenu.DockManager = this.dmPanel;
            this.bmStatusMenu.Form = this;
            this.bmStatusMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barSubItem1,
            this.barButtonItem2,
            this.barStaticItem1,
            this.btnUsuario,
            this.btnFiltro,
            this.btnNuevo,
            this.btnEliminar,
            this.btnModificar,
            this.btnActualizar,
            this.btnImprimir,
            this.btnExcel,
            this.barButtonItem3,
            this.barSubItem2,
            this.txtFecha,
            this.txtHora});
            this.bmStatusMenu.MainMenu = this.bar2;
            this.bmStatusMenu.MaxItemId = 18;
            this.bmStatusMenu.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Herramientas";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Left;
            this.bar1.FloatLocation = new System.Drawing.Point(-1890, 221);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFiltro),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnActualizar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNuevo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEliminar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnModificar)});
            this.bar1.Text = "Herramientas";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Caption = "Filtro";
            this.btnFiltro.Id = 5;
            this.btnFiltro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltro.ImageOptions.Image")));
            this.btnFiltro.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFiltro.ImageOptions.LargeImage")));
            this.btnFiltro.Name = "btnFiltro";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 9;
            this.btnActualizar.ImageOptions.Image = global::UI.Properties.Resources.Window_Refresh;
            this.btnActualizar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.LargeImage")));
            this.btnActualizar.Name = "btnActualizar";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 6;
            this.btnNuevo.ImageOptions.Image = global::UI.Properties.Resources.Add;
            this.btnNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.LargeImage")));
            this.btnNuevo.Name = "btnNuevo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 7;
            this.btnEliminar.ImageOptions.Image = global::UI.Properties.Resources.Delete;
            this.btnEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.LargeImage")));
            this.btnEliminar.Name = "btnEliminar";
            // 
            // btnModificar
            // 
            this.btnModificar.Caption = "Modificar";
            this.btnModificar.Id = 8;
            this.btnModificar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.ImageOptions.Image")));
            this.btnModificar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.ImageOptions.LargeImage")));
            this.btnModificar.Name = "btnModificar";
            // 
            // bar2
            // 
            this.bar2.BarName = "Menú principal";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Menú principal";
            // 
            // bar3
            // 
            this.bar3.BarName = "Barra de estado";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUsuario),
            new DevExpress.XtraBars.LinkPersistInfo(this.txtFecha),
            new DevExpress.XtraBars.LinkPersistInfo(this.txtHora)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Barra de estado";
            // 
            // btnUsuario
            // 
            this.btnUsuario.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.btnUsuario.Caption = "Usuario: administrador";
            this.btnUsuario.Id = 4;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUsuario_ItemClick);
            // 
            // txtFecha
            // 
            this.txtFecha.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txtFecha.Caption = "Fecha: ";
            this.txtFecha.Id = 15;
            this.txtFecha.Name = "txtFecha";
            // 
            // txtHora
            // 
            this.txtHora.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.txtHora.Caption = "Hora: ";
            this.txtHora.Id = 16;
            this.txtHora.Name = "txtHora";
            // 
            // bar4
            // 
            this.bar4.BarName = "Acciones";
            this.bar4.DockCol = 1;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Left;
            this.bar4.FloatLocation = new System.Drawing.Point(-1888, 385);
            this.bar4.FloatSize = new System.Drawing.Size(80, 32);
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnImprimir),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcel)});
            this.bar4.OptionsBar.AllowRename = true;
            this.bar4.Text = "Acciones";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Caption = "Imprimir";
            this.btnImprimir.Id = 10;
            this.btnImprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.ImageOptions.Image")));
            this.btnImprimir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.ImageOptions.LargeImage")));
            this.btnImprimir.Name = "btnImprimir";
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "Exportar a excel";
            this.btnExcel.Id = 11;
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.LargeImage")));
            this.btnExcel.Name = "btnExcel";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bmStatusMenu;
            this.barDockControlTop.Size = new System.Drawing.Size(874, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 538);
            this.barDockControlBottom.Manager = this.bmStatusMenu;
            this.barDockControlBottom.Size = new System.Drawing.Size(874, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.bmStatusMenu;
            this.barDockControlLeft.Size = new System.Drawing.Size(32, 518);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(874, 20);
            this.barDockControlRight.Manager = this.bmStatusMenu;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 518);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.ActAsDropDown = true;
            this.barButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem1.Caption = "Archivo";
            this.barButtonItem1.DropDownControl = this.popupMenu1;
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.bmStatusMenu;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 1;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Crear";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Usuario:";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Archivo";
            this.barButtonItem3.Id = 13;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Archivo";
            this.barSubItem2.Id = 14;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel1.ID = new System.Guid("d834598c-fd73-4213-a60a-97e9b5434611");
            this.dockPanel1.Location = new System.Drawing.Point(600, 20);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(274, 200);
            this.dockPanel1.Size = new System.Drawing.Size(274, 518);
            this.dockPanel1.Text = "Módulos";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.navBarControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 30);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(267, 485);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup4;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer3);
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer4);
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer2);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Font = new System.Drawing.Font("Tahoma", 8.2F);
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup4,
            this.navBarGroup3,
            this.navBarGroup2});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 267;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(267, 485);
            this.navBarControl1.TabIndex = 5;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("The Bezier");
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Gestión de la compra";
            this.navBarGroup4.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGroup4.Expanded = true;
            this.navBarGroup4.GroupClientHeight = 80;
            this.navBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup4.ImageOptions.ImageUri.Uri = "MonthView";
            this.navBarGroup4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup4.ImageOptions.LargeImage")));
            this.navBarGroup4.ImageOptions.SmallImage = global::UI.Properties.Resources.MonthView_16x16;
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer1.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer1.Controls.Add(this.tvCompra);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(267, 264);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // tvCompra
            // 
            this.tvCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCompra.ForeColor = System.Drawing.Color.Black;
            this.tvCompra.ImageIndex = 0;
            this.tvCompra.ImageList = this.imgIcon;
            this.tvCompra.Location = new System.Drawing.Point(0, 0);
            this.tvCompra.Name = "tvCompra";
            treeNode13.Name = "Compra";
            treeNode13.Tag = "1";
            treeNode13.Text = "Comprobante de compra";
            treeNode14.Name = "Gasto";
            treeNode14.Tag = "1";
            treeNode14.Text = "Comprobante de gasto";
            treeNode15.Name = "Nodo0";
            treeNode15.Tag = "0";
            treeNode15.Text = "Operaciones";
            treeNode16.Name = "Provedor";
            treeNode16.Tag = "1";
            treeNode16.Text = "Proveedor";
            treeNode17.Name = "ModalidadCredito";
            treeNode17.Tag = "1";
            treeNode17.Text = "Modalidad de crédito";
            treeNode18.Name = "Nodo0";
            treeNode18.Tag = "0";
            treeNode18.Text = "Configuración";
            this.tvCompra.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode18});
            this.tvCompra.SelectedImageIndex = 0;
            this.tvCompra.Size = new System.Drawing.Size(267, 264);
            this.tvCompra.TabIndex = 0;
            this.tvCompra.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCompra_AfterSelect);
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "tree.png");
            this.imgIcon.Images.SetKeyName(1, "tab.png");
            this.imgIcon.Images.SetKeyName(2, "FolderPanel_16x16.png");
            this.imgIcon.Images.SetKeyName(3, "DataEntry.png");
            this.imgIcon.Images.SetKeyName(4, "Window_16x16.png");
            // 
            // navBarGroupControlContainer3
            // 
            this.navBarGroupControlContainer3.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer3.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer3.Controls.Add(this.tvVenta);
            this.navBarGroupControlContainer3.Name = "navBarGroupControlContainer3";
            this.navBarGroupControlContainer3.Size = new System.Drawing.Size(267, 236);
            this.navBarGroupControlContainer3.TabIndex = 2;
            // 
            // tvVenta
            // 
            this.tvVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvVenta.ImageIndex = 0;
            this.tvVenta.ImageList = this.imgIcon;
            this.tvVenta.Location = new System.Drawing.Point(0, 0);
            this.tvVenta.Name = "tvVenta";
            treeNode19.Name = "PuntoVenta";
            treeNode19.Tag = "1";
            treeNode19.Text = "Punto de venta";
            treeNode20.Name = "Nodo0";
            treeNode20.Tag = "0";
            treeNode20.Text = "Operaciones";
            treeNode21.Name = "Cliente";
            treeNode21.Tag = "1";
            treeNode21.Text = "Cliente";
            treeNode22.Name = "Caja";
            treeNode22.Tag = "1";
            treeNode22.Text = "Caja";
            treeNode23.Name = "MetodoPago";
            treeNode23.Tag = "1";
            treeNode23.Text = "Método de pago";
            treeNode24.Name = "Nodo1";
            treeNode24.Tag = "0";
            treeNode24.Text = "Configuración";
            this.tvVenta.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode24});
            this.tvVenta.SelectedImageIndex = 0;
            this.tvVenta.Size = new System.Drawing.Size(267, 236);
            this.tvVenta.TabIndex = 0;
            // 
            // navBarGroupControlContainer4
            // 
            this.navBarGroupControlContainer4.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer4.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer4.Controls.Add(this.tvConfiguracion);
            this.navBarGroupControlContainer4.Name = "navBarGroupControlContainer4";
            this.navBarGroupControlContainer4.Size = new System.Drawing.Size(265, 182);
            this.navBarGroupControlContainer4.TabIndex = 3;
            // 
            // tvConfiguracion
            // 
            this.tvConfiguracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvConfiguracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvConfiguracion.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tvConfiguracion.ForeColor = System.Drawing.Color.Black;
            this.tvConfiguracion.ImageIndex = 0;
            this.tvConfiguracion.ImageList = this.imgIcon;
            this.tvConfiguracion.Location = new System.Drawing.Point(0, 0);
            this.tvConfiguracion.Name = "tvConfiguracion";
            treeNode25.Name = "TipoPersona";
            treeNode25.Tag = "1";
            treeNode25.Text = "Tipo de persona";
            treeNode26.Name = "Empleado";
            treeNode26.Tag = "1";
            treeNode26.Text = "Empleado";
            treeNode27.Name = "CargoEmpleado";
            treeNode27.Tag = "1";
            treeNode27.Text = "Cargo empleado";
            treeNode28.Name = "TipoDocumento";
            treeNode28.Tag = "1";
            treeNode28.Text = "Tipo de documento";
            treeNode29.Name = "Sucursal";
            treeNode29.Tag = "1";
            treeNode29.Text = "Sucursal";
            treeNode30.Name = "Contenedores";
            treeNode30.Tag = "1";
            treeNode30.Text = "Contenedores";
            treeNode31.Name = "Nodo0";
            treeNode31.Tag = "0";
            treeNode31.Text = "Configuración";
            treeNode32.Name = "Usuario";
            treeNode32.Tag = "1";
            treeNode32.Text = "Usuario";
            treeNode33.Name = "Nodo7";
            treeNode33.Tag = "0";
            treeNode33.Text = "Seguridad";
            this.tvConfiguracion.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode33});
            this.tvConfiguracion.SelectedImageIndex = 0;
            this.tvConfiguracion.Size = new System.Drawing.Size(265, 182);
            this.tvConfiguracion.TabIndex = 0;
            // 
            // navBarGroupControlContainer2
            // 
            this.navBarGroupControlContainer2.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer2.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer2.Controls.Add(this.tvInventario);
            this.navBarGroupControlContainer2.Name = "navBarGroupControlContainer2";
            this.navBarGroupControlContainer2.Size = new System.Drawing.Size(265, 182);
            this.navBarGroupControlContainer2.TabIndex = 4;
            // 
            // tvInventario
            // 
            this.tvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvInventario.ImageIndex = 0;
            this.tvInventario.ImageList = this.imgIcon;
            this.tvInventario.Location = new System.Drawing.Point(0, 0);
            this.tvInventario.Name = "tvInventario";
            treeNode1.Name = "ComprobanteSalida";
            treeNode1.Tag = "1";
            treeNode1.Text = "Comprobante de salida de inventario";
            treeNode2.Name = "ComprobanteEntrada";
            treeNode2.Tag = "1";
            treeNode2.Text = "Comprobante de entrada de inventario";
            treeNode3.Name = "Nodo0";
            treeNode3.Tag = "0";
            treeNode3.Text = "Operaciones";
            treeNode4.Name = "Producto";
            treeNode4.Tag = "1";
            treeNode4.Text = "Producto";
            treeNode5.Name = "C0001";
            treeNode5.Tag = "0001";
            treeNode5.Text = "Marca";
            treeNode6.Name = "C0002";
            treeNode6.Tag = "1";
            treeNode6.Text = "Categoría";
            treeNode34.Name = "Almacen";
            treeNode34.Tag = "1";
            treeNode34.Text = "Almacén";
            treeNode35.Name = "TipoProducto";
            treeNode35.Tag = "1";
            treeNode35.Text = "Tipo de producto";
            treeNode36.Name = "PlantillaUnidad";
            treeNode36.Tag = "1";
            treeNode36.Text = "Plantilla de unidades";
            treeNode42.Name = "ListaPrecios";
            treeNode42.Tag = "1";
            treeNode42.Text = "Lista de precios";
            treeNode43.Name = "Nodo0";
            treeNode43.Tag = "0";
            treeNode43.Text = "Configuración";
            this.tvInventario.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode43});
            this.tvInventario.SelectedImageIndex = 0;
            this.tvInventario.Size = new System.Drawing.Size(265, 182);
            this.tvInventario.TabIndex = 0;
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Gestión de la venta";
            this.navBarGroup1.ControlContainer = this.navBarGroupControlContainer3;
            this.navBarGroup1.GroupClientHeight = 0;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup1.ImageOptions.ImageUri.Uri = "Currency";
            this.navBarGroup1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.ImageOptions.LargeImage")));
            this.navBarGroup1.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.ImageOptions.SmallImage")));
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Gestión de inventario";
            this.navBarGroup3.ControlContainer = this.navBarGroupControlContainer2;
            this.navBarGroup3.GroupClientHeight = 80;
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup3.ImageOptions.ImageUri.Uri = "Paste";
            this.navBarGroup3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup3.ImageOptions.LargeImage")));
            this.navBarGroup3.ImageOptions.SmallImage = global::UI.Properties.Resources.PackageProduct_16x16;
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Gestión de la configuración";
            this.navBarGroup2.ControlContainer = this.navBarGroupControlContainer4;
            this.navBarGroup2.GroupClientHeight = 80;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup2.ImageOptions.ImageUri.Uri = "CustomizeGrid;Colored";
            this.navBarGroup2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.ImageOptions.LargeImage")));
            this.navBarGroup2.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.ImageOptions.SmallImage")));
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // xtcPages
            // 
            this.xtcPages.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtcPages.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageAndTabControlHeader;
            this.xtcPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcPages.Location = new System.Drawing.Point(32, 20);
            this.xtcPages.Name = "xtcPages";
            this.xtcPages.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtcPages.Size = new System.Drawing.Size(568, 518);
            this.xtcPages.TabIndex = 5;
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFiltro,
            this.mnuActualizar,
            this.toolStripSeparator1,
            this.mnuNuevo,
            this.mnuEliminar,
            this.mnuModificar});
            this.cmsMenu.Name = "contextMenuStrip1";
            this.cmsMenu.Size = new System.Drawing.Size(171, 120);
            // 
            // mnuFiltro
            // 
            this.mnuFiltro.Image = global::UI.Properties.Resources.Filter;
            this.mnuFiltro.Name = "mnuFiltro";
            this.mnuFiltro.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuFiltro.Size = new System.Drawing.Size(170, 22);
            this.mnuFiltro.Text = "Filtro";
            // 
            // mnuActualizar
            // 
            this.mnuActualizar.Image = global::UI.Properties.Resources.Window_Refresh;
            this.mnuActualizar.Name = "mnuActualizar";
            this.mnuActualizar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuActualizar.Size = new System.Drawing.Size(170, 22);
            this.mnuActualizar.Text = "Actualizar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // mnuNuevo
            // 
            this.mnuNuevo.Image = global::UI.Properties.Resources.Add;
            this.mnuNuevo.Name = "mnuNuevo";
            this.mnuNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNuevo.Size = new System.Drawing.Size(170, 22);
            this.mnuNuevo.Text = "Nuevo";
            // 
            // mnuEliminar
            // 
            this.mnuEliminar.Image = global::UI.Properties.Resources.Delete;
            this.mnuEliminar.Name = "mnuEliminar";
            this.mnuEliminar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuEliminar.Size = new System.Drawing.Size(170, 22);
            this.mnuEliminar.Text = "Eliminar";
            this.mnuEliminar.Click += new System.EventHandler(this.mnuEliminar_Click);
            // 
            // mnuModificar
            // 
            this.mnuModificar.Image = global::UI.Properties.Resources.Change1;
            this.mnuModificar.Name = "mnuModificar";
            this.mnuModificar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mnuModificar.Size = new System.Drawing.Size(170, 22);
            this.mnuModificar.Text = "Modificar";
            // 
            // tmTiempo
            // 
            this.tmTiempo.Enabled = true;
            this.tmTiempo.Interval = 1000;
            this.tmTiempo.Tick += new System.EventHandler(this.tmTiempo_Tick);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 562);
            this.Controls.Add(this.xtcPages);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS - Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHome_FormClosing);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dmPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmStatusMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.navBarGroupControlContainer3.ResumeLayout(false);
            this.navBarGroupControlContainer4.ResumeLayout(false);
            this.navBarGroupControlContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtcPages)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking.DockManager dmPanel;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager bmStatusMenu;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer4;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer3;
        private System.Windows.Forms.TreeView tvConfiguracion;
        private System.Windows.Forms.TreeView tvCompra;
        private System.Windows.Forms.TreeView tvVenta;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer2;
        private System.Windows.Forms.TreeView tvInventario;
        private System.Windows.Forms.ImageList imgIcon;
        private DevExpress.XtraBars.BarButtonItem btnUsuario;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem btnFiltro;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.BarButtonItem btnActualizar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.BarButtonItem btnModificar;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem btnImprimir;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarStaticItem txtFecha;
        private DevExpress.XtraBars.BarStaticItem txtHora;
        private System.Windows.Forms.Timer tmTiempo;
        private DevExpress.XtraTab.XtraTabControl xtcPages;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFiltro;
        private System.Windows.Forms.ToolStripMenuItem mnuActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevo;
        private System.Windows.Forms.ToolStripMenuItem mnuEliminar;
        private System.Windows.Forms.ToolStripMenuItem mnuModificar;
    }
}