namespace UI
{
    partial class FrmUserPassword
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
            if(disposing && (components != null))
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
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNueva = new DevExpress.XtraEditors.TextEdit();
            this.txtRepetir = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.txtActual = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNueva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepetir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActual.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Appearance.Options.UseFont = true;
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(149, 113);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 33);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(242, 112);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 33);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(44, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(126, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Cambio de contraseña";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Contraseña actual";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(43, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Nueva contraseña";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 87);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Repetir contraseña";
            // 
            // txtNueva
            // 
            this.txtNueva.Location = new System.Drawing.Point(149, 57);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.Properties.AutoHeight = false;
            this.txtNueva.Properties.PasswordChar = '●';
            this.txtNueva.Size = new System.Drawing.Size(169, 23);
            this.txtNueva.TabIndex = 2;
            this.txtNueva.TextChanged += new System.EventHandler(this.txtNueva_TextChanged);
            // 
            // txtRepetir
            // 
            this.txtRepetir.Location = new System.Drawing.Point(149, 83);
            this.txtRepetir.Name = "txtRepetir";
            this.txtRepetir.Properties.AutoHeight = false;
            this.txtRepetir.Properties.PasswordChar = '●';
            this.txtRepetir.Size = new System.Drawing.Size(169, 23);
            this.txtRepetir.TabIndex = 4;
            this.txtRepetir.TextChanged += new System.EventHandler(this.txtRepetir_TextChanged);
            // 
            // txtActual
            // 
            this.txtActual.Location = new System.Drawing.Point(149, 31);
            this.txtActual.Name = "txtActual";
            this.txtActual.Properties.AutoHeight = false;
            this.txtActual.Properties.PasswordChar = '●';
            this.txtActual.Size = new System.Drawing.Size(169, 23);
            this.txtActual.TabIndex = 6;
            this.txtActual.TextChanged += new System.EventHandler(this.txtActual_TextChanged);
            // 
            // FrmUserPassword
            // 
            this.AcceptButton = this.btnAceptar;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(364, 160);
            this.Controls.Add(this.txtRepetir);
            this.Controls.Add(this.txtNueva);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtActual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmUserPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de contraseña";
            this.Load += new System.EventHandler(this.FrmUserPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNueva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepetir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActual.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNueva;
        private DevExpress.XtraEditors.TextEdit txtRepetir;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TextEdit txtActual;
    }
}