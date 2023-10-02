﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace pryLopezIEvaluativa
{
    public partial class frmModificarProveedor : Form
    {
        public frmModificarProveedor()
        {
            InitializeComponent();
        }

        public static string rutaArchivo = "../../Resources/Listado_de_aseguradores.csv";
        public void btnGrabar_Click(object sender, EventArgs e)
        {
            string posicion = frmProveedores.pos.ToString();
            List<string> lista = new List<string>();
            using (StreamReader leer = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = leer.ReadLine()) != null)
                {
                    string[] parametros = linea.Split(';');

                    if (parametros[0] != posicion)
                    {
                        lista.Add(linea);
                    }
                    else
                    {
                        string lineaDos = txtModificarNumero.Text + ";" + txtModificarEntidad.Text + ";" + txtModificarApertura.Text + ";" + txtModificarNExpediente.Text + ";" + txtModificarJuzgado.Text + ";" + txtModificarJurisdiccion.Text + ";" + txtModificarDireccion.Text + ";" + txtModificarLiquidadorResponsable.Text + ";";
                        lista.Add(lineaDos);
                    }
                }
            }

            using (StreamWriter escribir = new StreamWriter(rutaArchivo))
            {
                foreach (string linea in lista)
                {
                    escribir.WriteLine(linea);
                }
            }

            MessageBox.Show("Proveedor Modificado");
            this.Hide();

            txtModificarNumero.Clear();
            txtModificarEntidad.Clear();
            txtModificarApertura.Clear();
            txtModificarNExpediente.Clear();
            txtModificarJuzgado.Clear();
            txtModificarJurisdiccion.Clear();
            txtModificarDireccion.Clear();
            txtModificarLiquidadorResponsable.Clear();
        }

        private void frmModificarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
