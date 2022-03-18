using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void estadísticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadistica ofrmEstadistica = new frmEstadistica();
            ofrmEstadistica.MdiParent = this;
            ofrmEstadistica.Show();
        }

        private void automotorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregar ofrmAgregar = new frmAgregar();
            ofrmAgregar.MdiParent = this;
            ofrmAgregar.Show();
        }
    }
}
