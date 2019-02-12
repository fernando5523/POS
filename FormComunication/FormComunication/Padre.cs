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
    public partial class Padre : Form, IContract
    {
        public Padre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hijo hijo = new Hijo();
            hijo.contrato = this;
            hijo.Show();
        }

        public void Ejecutar(string texto)
        {
            label2.Text = texto;
        }
    }
}
