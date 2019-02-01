namespace UI
{
    partial class FrmLogin
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
            this.difTemas = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnInicio = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.faTemas = new DevExpress.XtraBars.FormAssistant();
            this.ckRecordar = new DevExpress.XtraEditors.CheckEdit();
            this.txtContraseña = new DevExpress.XtraEditors.TextEdit();
            this.LueAutentificacion = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckRecordar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LueAutentificacion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // difTemas
            // 
            this.difTemas.EnableBonusSkins = true;
            this.difTemas.LookAndFeel.SkinName = "Office 2007 Blue";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(48, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(125, 14);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Tipo de autentificación";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(48, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nombre de usuario";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(48, 122);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 14);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(182, 89);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.AutoHeight = false;
            this.txtUsuario.Size = new System.Drawing.Size(220, 23);
            this.txtUsuario.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(47, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(232, 29);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "POS - Inicio de sesión";
            // 
            // btnInicio
            // 
            this.btnInicio.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnInicio.Appearance.Options.UseFont = true;
            this.btnInicio.Location = new System.Drawing.Point(182, 173);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(140, 33);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "Iniciar Sesión";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Location = new System.Drawing.Point(328, 173);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 33);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            // 
            // ckRecordar
            // 
            this.ckRecordar.Location = new System.Drawing.Point(256, 147);
            this.ckRecordar.Name = "ckRecordar";
            this.ckRecordar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ckRecordar.Properties.Appearance.Options.UseFont = true;
            this.ckRecordar.Properties.Caption = "Recordar contraseña";
            this.ckRecordar.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ckRecordar.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ckRecordar.Size = new System.Drawing.Size(146, 19);
            this.ckRecordar.TabIndex = 7;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(182, 118);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtContraseña.Properties.Appearance.Options.UseFont = true;
            this.txtContraseña.Properties.AutoHeight = false;
            this.txtContraseña.Properties.PasswordChar = '●';
            this.txtContraseña.Size = new System.Drawing.Size(220, 23);
            this.txtContraseña.TabIndex = 4;
            // 
            // LueAutentificacion
            // 
            this.LueAutentificacion.Location = new System.Drawing.Point(182, 60);
            this.LueAutentificacion.Name = "LueAutentificacion";
            this.LueAutentificacion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LueAutentificacion.Properties.Appearance.Options.UseFont = true;
            this.LueAutentificacion.Properties.AutoHeight = false;
            this.LueAutentificacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LueAutentificacion.Properties.ShowFooter = false;
            this.LueAutentificacion.Properties.ShowHeader = false;
            this.LueAutentificacion.Size = new System.Drawing.Size(220, 23);
            this.LueAutentificacion.TabIndex = 10;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnInicio;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 224);
            this.Controls.Add(this.LueAutentificacion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.ckRecordar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS - Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckRecordar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LueAutentificacion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel difTemas;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnInicio;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraBars.FormAssistant faTemas;
        private DevExpress.XtraEditors.CheckEdit ckRecordar;
        private DevExpress.XtraEditors.TextEdit txtContraseña;
        private DevExpress.XtraEditors.LookUpEdit LueAutentificacion;
    }
}