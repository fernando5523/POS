using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormComunication
{
    public partial class Hijo : Form
    {
        public IContract contrato { get; set; }
        public Hijo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contrato.Ejecutar(textBox1.Text);
        }
    }
}
