namespace UI
{
    partial class FrmContainer
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbeActive = new DevExpress.XtraEditors.CheckEdit();
            this.gcConsultas = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.txtFormulario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormulario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(44, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(158, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Propiedades del contenedor";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(104, 31);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.AutoHeight = false;
            this.txtCode.Properties.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(79, 23);
            this.txtCode.TabIndex = 16;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(44, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Código";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.AutoHeight = false;
            this.txtNombre.Size = new System.Drawing.Size(394, 23);
            this.txtNombre.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(104, 87);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.AutoHeight = false;
            this.txtDescripcion.Size = new System.Drawing.Size(394, 23);
            this.txtDescripcion.TabIndex = 20;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(44, 91);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Descripción";
            // 
            // cbeActive
            // 
            this.cbeActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbeActive.EditValue = true;
            this.cbeActive.Location = new System.Drawing.Point(821, 120);
            this.cbeActive.Name = "cbeActive";
            this.cbeActive.Properties.Caption = "Active";
            this.cbeActive.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cbeActive.Size = new System.Drawing.Size(75, 19);
            this.cbeActive.TabIndex = 21;
            // 
            // gcConsultas
            // 
            this.gcConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcConsultas.Location = new System.Drawing.Point(44, 145);
            this.gcConsultas.MainView = this.gridView1;
            this.gcConsultas.Name = "gcConsultas";
            this.gcConsultas.Size = new System.Drawing.Size(852, 296);
            this.gcConsultas.TabIndex = 22;
            this.gcConsultas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcConsultas;
            this.gridView1.Name = "gridView1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Location = new System.Drawing.Point(44, 447);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(79, 33);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.Text = "Nuevo";
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Location = new System.Drawing.Point(129, 447);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(79, 33);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.Location = new System.Drawing.Point(214, 447);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(79, 33);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(817, 447);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 33);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Appearance.Options.UseFont = true;
            this.btnAceptar.Location = new System.Drawing.Point(732, 447);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(79, 33);
            this.btnAceptar.TabIndex = 27;
            this.btnAceptar.Text = "Aceptar";
            // 
            // txtFormulario
            // 
            this.txtFormulario.Location = new System.Drawing.Point(104, 116);
            this.txtFormulario.Name = "txtFormulario";
            this.txtFormulario.Properties.AutoHeight = false;
            this.txtFormulario.Size = new System.Drawing.Size(394, 23);
            this.txtFormulario.TabIndex = 29;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(44, 120);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 28;
            this.labelControl5.Text = "Formulario";
            // 
            // FrmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 492);
            this.Controls.Add(this.txtFormulario);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gcConsultas);
            this.Controls.Add(this.cbeActive);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl4);
            this.Name = "FrmContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contenedor";
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormulario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit cbeActive;
        private DevExpress.XtraGrid.GridControl gcConsultas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.TextEdit txtFormulario;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}