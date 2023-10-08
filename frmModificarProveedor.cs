using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLopezIEvaluativa
{
    public partial class frmModificarProveedor : Form
    {
        public frmModificarProveedor()
        {
            InitializeComponent();
        }

        //public static string rutaArchivo = "../../Resources/Lista.csv"; En esta línea se declara una variable estática pública llamada rutaArchivo y se le asigna la ruta del archivo "../../Resources/Lista.csv". Esta variable almacena la ruta del archivo CSV que se va a leer y modificar en el resto del código.
        public static string rutaArchivo = "../../Resources/Lista.csv";
        public void btnGrabar_Click(object sender, EventArgs e)
        {

            //string posicion = frmProveedores.pos.ToString(); Se crea una variable llamada posicion que toma el valor de la propiedad pos del formulario frmProveedores y la convierte a una cadena (ToString). La variable pos probablemente almacena algún tipo de posición o identificador.
            string posicion = frmProveedores.pos.ToString();

            //List<string> lista = new List<string>(); Se crea una lista de cadenas llamada lista. Esta lista se utilizará para almacenar las líneas del archivo CSV después de modificarlas.

            List<string> lista = new List<string>();

            //using (StreamReader leer = new StreamReader(rutaArchivo)) Aquí se crea un objeto StreamReader llamado leer para leer el contenido del archivo CSV especificado en rutaArchivo. La instrucción using garantiza que el objeto leer se cierre correctamente después de su uso.
            using (StreamReader leer = new StreamReader(rutaArchivo))
            {

                //string linea; Se declara una variable linea para almacenar cada línea leída del archivo CSV.
                string linea;

                //while ((linea = leer.ReadLine()) != null) Esto inicia un bucle while que leerá cada línea del archivo hasta que no haya más líneas que leer.
                while ((linea = leer.ReadLine()) != null)
                {

                    //string[] parametros = linea.Split(';'); Cada línea se divide en un array de cadenas llamado parametros utilizando el carácter ; como separador. Esto asume que las líneas del archivo CSV están separadas por punto y coma.
                    string[] parametros = linea.Split(';');

                    //if (parametros[0] != posicion) Se verifica si el primer elemento en parametros (probablemente algún tipo de identificador) es diferente de la variable posicion.
                    if (parametros[0] != posicion)
                    {
                        //lista.Add(linea); Si el identificador no coincide, la línea original se agrega a la lista lista.
                        lista.Add(linea);
                    }
                    //else Si el identificador coincide, se crea una nueva línea (lineaDos) concatenando algunos valores de campos de entrada de texto (txtModificarNumero, txtModificarEntidad, etc.) y se agrega al lista.
                    else
                    {
                        //Después de terminar de leer y procesar todas las líneas del archivo CSV, se cierra el objeto StreamReader.
                        string lineaDos = txtModificarNumero.Text + ";" + txtModificarEntidad.Text + ";" + txtModificarApertura.Text + ";" + txtModificarNExpediente.Text + ";" + txtModificarJuzgado.Text + ";" + txtModificarJurisdiccion.Text + ";" + txtModificarDireccion.Text + ";" + txtModificarLiquidadorResponsable.Text + ";";
                        lista.Add(lineaDos);
                    }
                }
            }

            //Luego, se crea un objeto StreamWriter llamado escribir para escribir datos en el mismo archivo (rutaArchivo) en el que se leyeron los datos.
            using (StreamWriter escribir = new StreamWriter(rutaArchivo))
            {

                //Se recorre la lista lista y se escribe cada elemento en el archivo usando escribir.WriteLine(linea).
                foreach (string linea in lista)
                {
                    escribir.WriteLine(linea);
                }
            }

            //Este código está leyendo un archivo CSV, realizando modificaciones en función de un identificador (posicion) y escribiendo las líneas modificadas o no modificadas de vuelta en el mismo archivo CSV.
            MessageBox.Show("Proveedor Modificado");

            txtModificarNumero.Clear();
            txtModificarEntidad.Clear();
            txtModificarApertura.Clear();
            txtModificarNExpediente.Clear();
            txtModificarJuzgado.Clear();
            txtModificarJurisdiccion.Clear();
            txtModificarDireccion.Clear();
            txtModificarLiquidadorResponsable.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            frmProveedores Menusovich = new frmProveedores();
            this.Hide();
            Menusovich.Show();
        }
    }
}










