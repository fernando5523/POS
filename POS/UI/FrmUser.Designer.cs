namespace UI
{
    partial class FrmUser
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
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtContraseña = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbeActive = new DevExpress.XtraEditors.CheckEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeActive.Properties)).BeginInit();
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
            this.labelControl4.Size = new System.Drawing.Size(132, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Propiedades de usuario";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.AutoHeight = false;
            this.txtNombre.Size = new System.Drawing.Size(196, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Nombre";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(109, 60);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Properties.AutoHeight = false;
            this.txtContraseña.Properties.PasswordChar = '●';
            this.txtContraseña.Size = new System.Drawing.Size(196, 23);
            this.txtContraseña.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(44, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Contraseña";
            // 
            // cbeActive
            // 
            this.cbeActive.EditValue = true;
            this.cbeActive.Location = new System.Drawing.Point(230, 89);
            this.cbeActive.Name = "cbeActive";
            this.cbeActive.Properties.Caption = "Active";
            this.cbeActive.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cbeActive.Size = new System.Drawing.Size(75, 20);
            this.cbeActive.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(232, 114);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 33);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Appearance.Options.UseFont = true;
            this.btnAceptar.Location = new System.Drawing.Point(147, 114);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(79, 33);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "&Aceptar";
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 164);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbeActive);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContraseña.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeActive.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtContraseña;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit cbeActive;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
    }
}