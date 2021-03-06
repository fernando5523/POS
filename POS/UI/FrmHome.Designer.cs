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
            this.nbcModuls = new DevExpress.XtraNavBar.NavBarControl();
            this.imgIcon = new System.Windows.Forms.ImageList(this.components);
            this.xtcPages = new DevExpress.XtraTab.XtraTabControl();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsFiltro = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsModificar = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.nbcModuls)).BeginInit();
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
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
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
            this.btnFiltro.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I));
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFiltro_ItemClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Caption = "Actualizar";
            this.btnActualizar.Id = 9;
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.LargeImage")));
            this.btnActualizar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActualizar_ItemClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Id = 6;
            this.btnNuevo.ImageOptions.Image = global::UI.Properties.Resources.Add;
            this.btnNuevo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.LargeImage")));
            this.btnNuevo.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 7;
            this.btnEliminar.ImageOptions.Image = global::UI.Properties.Resources.Delete;
            this.btnEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.LargeImage")));
            this.btnEliminar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Caption = "Modificar";
            this.btnModificar.Id = 8;
            this.btnModificar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.ImageOptions.Image")));
            this.btnModificar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.ImageOptions.LargeImage")));
            this.btnModificar.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M));
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModificar_ItemClick);
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
            this.bar4.DockRow = 1;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.FloatLocation = new System.Drawing.Point(-1465, 195);
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
            this.barDockControlTop.Size = new System.Drawing.Size(894, 48);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 542);
            this.barDockControlBottom.Manager = this.bmStatusMenu;
            this.barDockControlBottom.Size = new System.Drawing.Size(894, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 48);
            this.barDockControlLeft.Manager = this.bmStatusMenu;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 494);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(894, 48);
            this.barDockControlRight.Manager = this.bmStatusMenu;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 494);
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
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("d834598c-fd73-4213-a60a-97e9b5434611");
            this.dockPanel1.Location = new System.Drawing.Point(0, 48);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(274, 200);
            this.dockPanel1.Size = new System.Drawing.Size(274, 494);
            this.dockPanel1.Text = "Módulos";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.nbcModuls);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 30);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(267, 461);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // nbcModuls
            // 
            this.nbcModuls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nbcModuls.Font = new System.Drawing.Font("Tahoma", 8.2F);
            this.nbcModuls.Location = new System.Drawing.Point(0, 0);
            this.nbcModuls.Name = "nbcModuls";
            this.nbcModuls.OptionsNavPane.ExpandedWidth = 267;
            this.nbcModuls.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.nbcModuls.Size = new System.Drawing.Size(267, 461);
            this.nbcModuls.StoreDefaultPaintStyleName = true;
            this.nbcModuls.TabIndex = 5;
            this.nbcModuls.Text = "navBarControl1";
            // 
            // imgIcon
            // 
            this.imgIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcon.ImageStream")));
            this.imgIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcon.Images.SetKeyName(0, "tree.png");
            // 
            // xtcPages
            // 
            this.xtcPages.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtcPages.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageAndTabControlHeader;
            this.xtcPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcPages.Location = new System.Drawing.Point(274, 48);
            this.xtcPages.Name = "xtcPages";
            this.xtcPages.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtcPages.Size = new System.Drawing.Size(620, 494);
            this.xtcPages.TabIndex = 5;
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsFiltro,
            this.cmsActualizar,
            this.toolStripSeparator2,
            this.cmsNuevo,
            this.cmsEliminar,
            this.cmsModificar});
            this.cmsMenu.Name = "contextMenuStrip1";
            this.cmsMenu.ShowCheckMargin = true;
            this.cmsMenu.Size = new System.Drawing.Size(193, 120);
            // 
            // cmsFiltro
            // 
            this.cmsFiltro.Image = global::UI.Properties.Resources.MasterFilter_16x16;
            this.cmsFiltro.Name = "cmsFiltro";
            this.cmsFiltro.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.cmsFiltro.Size = new System.Drawing.Size(192, 22);
            this.cmsFiltro.Text = "Filtro";
            this.cmsFiltro.Click += new System.EventHandler(this.cmsFiltro_Click);
            // 
            // cmsActualizar
            // 
            this.cmsActualizar.Image = global::UI.Properties.Resources.Refresh_16x16;
            this.cmsActualizar.Name = "cmsActualizar";
            this.cmsActualizar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.cmsActualizar.Size = new System.Drawing.Size(192, 22);
            this.cmsActualizar.Text = "Actualizar";
            this.cmsActualizar.Click += new System.EventHandler(this.cmsActualizar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // cmsNuevo
            // 
            this.cmsNuevo.Image = global::UI.Properties.Resources.Add;
            this.cmsNuevo.Name = "cmsNuevo";
            this.cmsNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.cmsNuevo.Size = new System.Drawing.Size(192, 22);
            this.cmsNuevo.Text = "Nuevo";
            this.cmsNuevo.Click += new System.EventHandler(this.cmsNuevo_Click);
            // 
            // cmsEliminar
            // 
            this.cmsEliminar.Image = global::UI.Properties.Resources.Delete;
            this.cmsEliminar.Name = "cmsEliminar";
            this.cmsEliminar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.cmsEliminar.Size = new System.Drawing.Size(192, 22);
            this.cmsEliminar.Text = "Eliminar";
            this.cmsEliminar.Click += new System.EventHandler(this.cmsEliminar_Click);
            // 
            // cmsModificar
            // 
            this.cmsModificar.Image = global::UI.Properties.Resources.Edit_16x16;
            this.cmsModificar.Name = "cmsModificar";
            this.cmsModificar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.cmsModificar.Size = new System.Drawing.Size(192, 22);
            this.cmsModificar.Text = "Modificar";
            this.cmsModificar.Click += new System.EventHandler(this.cmsModificar_Click);
            // 
            // mnuFiltro
            // 
            this.mnuFiltro.Image = global::UI.Properties.Resources.MasterFilter_16x16;
            this.mnuFiltro.Name = "mnuFiltro";
            this.mnuFiltro.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuFiltro.Size = new System.Drawing.Size(180, 22);
            this.mnuFiltro.Text = "Filtro";
            // 
            // mnuActualizar
            // 
            this.mnuActualizar.Image = global::UI.Properties.Resources.Refresh_16x16;
            this.mnuActualizar.Name = "mnuActualizar";
            this.mnuActualizar.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuActualizar.Size = new System.Drawing.Size(180, 22);
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
            // 
            // mnuModificar
            // 
            this.mnuModificar.Image = ((System.Drawing.Image)(resources.GetObject("mnuModificar.Image")));
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
            this.ClientSize = new System.Drawing.Size(894, 566);
            this.Controls.Add(this.xtcPages);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHome_FormClosing);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dmPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmStatusMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbcModuls)).EndInit();
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
        private DevExpress.XtraNavBar.NavBarControl nbcModuls;
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
        private System.Windows.Forms.ToolStripMenuItem cmsFiltro;
        private System.Windows.Forms.ToolStripMenuItem cmsActualizar;
        private System.Windows.Forms.ToolStripMenuItem cmsNuevo;
        private System.Windows.Forms.ToolStripMenuItem cmsEliminar;
        private System.Windows.Forms.ToolStripMenuItem cmsModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}