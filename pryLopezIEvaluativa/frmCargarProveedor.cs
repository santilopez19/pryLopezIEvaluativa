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
    public partial class frmCargarProveedor : Form
    {
        public frmCargarProveedor()
        {
            InitializeComponent();
        }

        int numGuia = 6;
        clseArchivo grabado = new clseArchivo();
        private void frmMostrarProveedor_Load(object sender, EventArgs e)
        {

            txtGuardarNumero.Text = numGuia.ToString();
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {



            if (txtGuardarEntidad.Text == "")
            {
                MessageBox.Show("Campo Entidad vacio");
                txtGuardarEntidad.Focus();
            }
            else
            {
                if (txtGuardarApertura.Text == "")
                {
                    MessageBox.Show("Campo Apertura vacio");
                    txtGuardarApertura.Focus();
                }
                else
                {
                    if (txtGuardarNExpediente.Text == "")
                    {
                        MessageBox.Show("Campo número de expediente vacio");
                        txtGuardarNExpediente.Focus();
                    }
                    else
                    {
                        if (txtGuardarJuzgado.Text == "")
                        {
                            MessageBox.Show("Campo Juzgado vacio");
                            txtGuardarJuzgado.Focus();
                        }
                        else
                        {
                            if (txtGuardarJurisdiccion.Text == "")
                            {
                                MessageBox.Show("Campo Jurisdiccion vacio");
                                txtGuardarJurisdiccion.Focus();
                            }
                            else
                            {
                                if (txtGuardarDireccion.Text == "")
                                {
                                    MessageBox.Show("Campo Direccion vacio");
                                    txtGuardarDireccion.Focus();
                                }
                                else
                                {
                                    if (txtGuardarLiquidadorResponsable.Text == "")
                                    {
                                        MessageBox.Show("Campo Liquidador responsable vacio");
                                        txtGuardarLiquidadorResponsable.Focus();
                                    }
                                    else
                                    {
                                        string[] datosProveedores = new string[] { numGuia.ToString(), txtGuardarEntidad.Text, txtGuardarApertura.Text, txtGuardarNExpediente.Text, txtGuardarJuzgado.Text, txtGuardarJurisdiccion.Text, txtGuardarDireccion.Text, txtGuardarLiquidadorResponsable.Text };

                                        string datosConcatenados = string.Join(";", datosProveedores);

                                        grabado.Grabar(datosConcatenados);

                                        numGuia++;
                                        txtGuardarNumero.Text = numGuia.ToString();
                                        txtGuardarEntidad.Clear();
                                        txtGuardarApertura.Clear();
                                        txtGuardarNExpediente.Clear();
                                        txtGuardarJuzgado.Clear();
                                        txtGuardarJurisdiccion.Clear();
                                        txtGuardarDireccion.Clear();
                                        txtGuardarLiquidadorResponsable.Clear();
                                        MessageBox.Show("Proveedor cargado");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            frmMenu Menusovich = new frmMenu();
            this.Hide();
            Menusovich.Show();
        }
    }
}
