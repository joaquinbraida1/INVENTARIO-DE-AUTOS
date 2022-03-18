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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void automotorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.automotorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.automotorDataSet);

        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'automotorDataSet.Automotor' Puede moverla o quitarla según sea necesario.
            this.automotorTableAdapter.Fill(this.automotorDataSet.Automotor);

        }
    }
}
