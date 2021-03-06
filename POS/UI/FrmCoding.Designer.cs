﻿namespace UI
{
    partial class FrmCoding
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumberLength = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbeActive = new DevExpress.XtraEditors.CheckEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.txtContainer = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContainer.Properties)).BeginInit();
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
            this.labelControl4.Size = new System.Drawing.Size(163, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Propiedades de condificación";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Contenedor";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(142, 60);
            this.txtText.Name = "txtText";
            this.txtText.Properties.AutoHeight = false;
            this.txtText.Size = new System.Drawing.Size(160, 23);
            this.txtText.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(44, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Texto";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(142, 89);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Properties.AutoHeight = false;
            this.txtNumber.Size = new System.Drawing.Size(160, 23);
            this.txtNumber.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(44, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Número";
            // 
            // txtNumberLength
            // 
            this.txtNumberLength.Location = new System.Drawing.Point(142, 118);
            this.txtNumberLength.Name = "txtNumberLength";
            this.txtNumberLength.Properties.AutoHeight = false;
            this.txtNumberLength.Size = new System.Drawing.Size(160, 23);
            this.txtNumberLength.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(44, 122);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(92, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Tamaño de número";
            // 
            // cbeActive
            // 
            this.cbeActive.EditValue = true;
            this.cbeActive.Location = new System.Drawing.Point(227, 147);
            this.cbeActive.Name = "cbeActive";
            this.cbeActive.Properties.Caption = "Active";
            this.cbeActive.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.cbeActive.Size = new System.Drawing.Size(75, 20);
            this.cbeActive.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(229, 173);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 33);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Appearance.Options.UseFont = true;
            this.btnAceptar.Location = new System.Drawing.Point(142, 173);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(79, 33);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtContainer
            // 
            this.txtContainer.Location = new System.Drawing.Point(142, 34);
            this.txtContainer.Name = "txtContainer";
            this.txtContainer.Properties.AutoHeight = false;
            this.txtContainer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtContainer.Size = new System.Drawing.Size(160, 23);
            this.txtContainer.TabIndex = 14;
            // 
            // FrmCoding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 226);
            this.Controls.Add(this.txtContainer);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbeActive);
            this.Controls.Add(this.txtNumberLength);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCoding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codificación";
            this.Load += new System.EventHandler(this.FrmCoding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContainer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtText;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNumber;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNumberLength;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit cbeActive;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.LookUpEdit txtContainer;
    }
}