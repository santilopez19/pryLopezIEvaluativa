using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLopezIEvaluativa
{
    public partial class frmCargaInicio : Form
    {
        public frmCargaInicio()
        {
            InitializeComponent();
        }

        private void timerCarga_Tick(object sender, EventArgs e)
        {
            prbCarga.Increment(5);
            if (prbCarga.Value < 100)
            {
                prbCarga.Value++;
            }
            if (prbCarga.Value == 100)
            {
                timerCarga.Enabled = false;
                frmMenu frmMenu = new frmMenu();
                this.Hide();
                frmMenu.Show();
            }
        }

    }
}