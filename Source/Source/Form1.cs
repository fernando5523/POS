using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Source
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddDgv(new Point(0,0), "Uno");
        }

        private void AddDgv(Point point, string name)
        {
            DataGridView dgv = new DataGridView();
            dgv.Name = name;
            dgv.Size = new Size(400, 200);
            dgv.Location = point;
            dgv.ContextMenuStrip = contextMenuStrip1;
            this.Controls.Add(dgv);

            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "Columna 1";
            columna1.Width = 200;

            DataGridViewCheckBoxColumn columna2 = new DataGridViewCheckBoxColumn();
            columna2.HeaderText = "Activo";
            columna2.Width = 50;

            dgv.Columns.Add(columna1);
            dgv.Columns.Add(columna2);

            dgv.Rows.Add("Hola", true);
            dgv.Rows.Add("como", false);
            dgv.Rows.Add("estas", true);

            dgv.CellClick += Dgv_CellClick;
            dgv.ContextMenuStrip.Click += ContextMenuStrip_Click;
        }

        private void ContextMenuStrip_Click(object sender, EventArgs e)
        {
            DataGridView control = (DataGridView)this.Controls["Dos"];
            Dgv_CellClick(control, null);
        }

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView obj = (DataGridView)sender;
            MessageBox.Show(obj.CurrentCell.Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDgv(new Point(200, 200), "Dos");
        }

        private void quitarSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
