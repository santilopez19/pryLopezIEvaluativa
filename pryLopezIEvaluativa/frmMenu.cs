﻿using System;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void listaDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores Proveedores = new frmProveedores();
            this.Hide();
            Proveedores.Show();
        }

        private void cargarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCargarProveedor CargarProveedores = new frmCargarProveedor();
            this.Hide();
            CargarProveedores.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
