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
    public partial class frmEstadistica : Form
    {
        public frmEstadistica()
        {
            InitializeComponent();
        }

        private void frmEstadistica_Load(object sender, EventArgs e)
        {
            AutomotorDataSetTableAdapters.AutomotorTableAdapter ta = new AutomotorDataSetTableAdapters.AutomotorTableAdapter();
            AutomotorDataSet.AutomotorDataTable dt = new AutomotorDataSet.AutomotorDataTable();
            ta.Fill(dt);
            List<Automotor> oListAutomotor = new List<Automotor>();
            oListAutomotor = data.ConvertDataTable <Automotor>(dt) ;
            int ContFord = 0;
            int ContFiat = 0;
            int ContOtros = 0;

            foreach (Automotor item in oListAutomotor)
            {
                if (item.Marca.ToUpper() == "FORD")
                {
                    if (item.Estado == 1)
                        ContFord++;
                    else ContOtros++;
                }
                if (item.Marca.ToUpper() == "FIAT")
                {
                    if (item.Estado == 1)
                        ContFiat++;
                    else ContOtros++;
                }
                if (item.Marca.ToUpper() != "FIAT" && item.Marca.ToUpper() != "FORD")
                    ContOtros++;
            }
            lblTotalAutomotor.Text = oListAutomotor.Count.ToString();
            lblCantFordAct.Text = ContFord.ToString();
            lblCantFiatAct.Text = ContFiat.ToString();
            lblOtros.Text = ContOtros.ToString();

        }
    }
}
