using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.ListViewItem;
using static System.Net.WebRequestMethods;
using System.Runtime.ConstrainedExecution;
using System.Collections;

namespace pryLopezIEvaluativa
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();

            //Llama al método PopulateTreeView que se encarga de llenar el TreeView con información sobre archivos y carpetas.
            PopulateTreeView();
        }
        //frmModificarProveedor modificarProveedor = new frmModificarProveedor();: Crea una instancia del formulario frmModificarProveedor.Esto generalmente se hace para abrir el formulario frmModificarProveedor más adelante en la aplicación.
        frmModificarProveedor modificarProveedor = new frmModificarProveedor();

        //public void PopulateTreeView(): Este método se encarga de llenar el TreeView con información sobre archivos y carpetas.Aquí está lo que hace cada línea dentro del método:

        public void PopulateTreeView()
        {

            //TreeNode rootNode;: Declara una variable rootNode que representará el nodo raíz del TreeView.
            TreeNode rootNode;


            //DirectoryInfo info = new DirectoryInfo(@"../../Resources");: Crea un objeto DirectoryInfo que apunta a la carpeta "../../Resources" en el sistema de archivos.
            DirectoryInfo info = new DirectoryInfo(@"../../Resources");

            //if (info.Exists): Verifica si la carpeta especificada en info realmente existe en el sistema de archivos.
            if (info.Exists)
            {

                //        rootNode = new TreeNode(info.Name);: Crea un nodo en el TreeView con el nombre de la carpeta info.Name.
                rootNode = new TreeNode(info.Name);

                //rootNode.Tag = info;: Asigna el objeto info como un "tag" al nodo rootNode.Esto a menudo se usa para adjuntar información adicional a un nodo.
                rootNode.Tag = info;

                //GetDirectories(info.GetDirectories(), rootNode);: Llama al método GetDirectories() para llenar los nodos del TreeView con subdirectorios y archivos dentro de info.
                GetDirectories(info.GetDirectories(), rootNode);

                //tvwProveedores.Nodes.Add(rootNode);: Agrega el nodo rootNode al TreeView llamado tvwProveedores.
                tvwProveedores.Nodes.Add(rootNode);
            }
        }

        //public void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo): Este método se encarga de llenar el TreeView con subdirectorios y archivos dentro de un directorio específico.Aquí está lo que hace cada línea dentro del método:
        public void GetDirectories(DirectoryInfo[] subDirs,

            TreeNode nodeToAddTo)
        {

            //TreeNode aNode;: Declara una variable aNode que representará un nodo del TreeView.
            TreeNode aNode;

            //DirectoryInfo[] subSubDirs;: Declara un arreglo de objetos DirectoryInfo que representarán subdirectorios dentro del directorio actual.
            DirectoryInfo[] subSubDirs;

            //foreach (DirectoryInfo subDir in subDirs): Inicia un bucle foreach para iterar a través de los directorios subDir en el arreglo subDirs.
            foreach (DirectoryInfo subDir in subDirs)
            {

                //        aNode = new TreeNode(subDir.Name, 0, 0);: Crea un nodo con el nombre del directorio subDir.Name y le asigna una imagen predeterminada.
                aNode = new TreeNode(subDir.Name, 0, 0);

                //        aNode.Tag = subDir;: Asigna el objeto subDir como un "tag" al nodo aNode para adjuntar información adicional.
                aNode.Tag = subDir;

                //aNode.ImageKey = "folder";: Establece la clave de imagen del nodo aNode a "folder". Esto podría usarse para mostrar un ícono de carpeta en el TreeView.
                aNode.ImageKey = "folder";

                //subSubDirs = subDir.GetDirectories();: Obtiene los subdirectorios dentro del directorio actual y los almacena en subSubDirs.
                subSubDirs = subDir.GetDirectories();

                //if (subSubDirs.Length != 0): Verifica si hay subdirectorios dentro del directorio actual.
                if (subSubDirs.Length != 0)
                {

                    //GetDirectories(subSubDirs, aNode);: Llama recursivamente al método GetDirectories para llenar los subdirectorios del directorio actual.
                    GetDirectories(subSubDirs, aNode);
                }

                //nodeToAddTo.Nodes.Add(aNode);: Agrega el nodo aNode al nodo padre nodeToAddTo, que es un nodo del TreeView.
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        //En resumen, este código se utiliza para llenar un TreeView con información de archivos y carpetas en un directorio específico y sus subdirectorios.La función GetDirectories es recursiva y se llama para cada subdirectorio para construir la estructura completa del TreeView.




        private void btnVolver_Click(object sender, EventArgs e)
        {
        frmMenu Menusovich = new frmMenu();
        this.Hide();
        Menusovich.Show();
        }

        //        El fragmento de código que proporcionaste se encuentra dentro del método tvwProveedores_NodeMouseClick y se ejecuta cuando se hace clic en un nodo del TreeView.Aquí está la descripción de cada línea de ese código:
        public void tvwProveedores_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            {

                //TreeNode newSelected = e.Node;: Esta línea crea una variable newSelected y la inicializa con el nodo que se ha seleccionado en el TreeView.El objeto e es un argumento de evento que contiene información sobre el evento de clic en el nodo(NodeMouseClickEventArgs), y e.Node representa el nodo en el que se hizo clic.
                TreeNode newSelected = e.Node;

                //lstProveedores.Items.Clear();: Esta línea borra todos los elementos existentes en el ListView llamado lstProveedores.Esto se hace para limpiar cualquier contenido anterior antes de mostrar los nuevos datos.
                lstProveedores.Items.Clear();

                //DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;: Aquí se obtiene el objeto DirectoryInfo que se adjuntó al nodo newSelected como un "tag". En otras palabras, el "tag" del nodo contiene información sobre el directorio que representa ese nodo.
                DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;

                //ListViewItem.ListViewSubItem[] subItems;: Se declara un arreglo de objetos ListViewSubItem, que se utilizarán para agregar subelementos a los elementos del ListView.
                ListViewItem.ListViewSubItem[] subItems;

                //ListViewItem item = null;: Se declara una variable item que se utilizará para representar cada elemento del ListView.Se inicializa como null.
                ListViewItem item = null;

                //foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories()): Inicia un bucle foreach para iterar a través de los subdirectorios del directorio representado por nodeDirInfo.
                foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
                {

                    //item = new ListViewItem(dir.Name, 0);: En cada iteración del bucle, se crea un nuevo elemento ListViewItem con el nombre del subdirectorio dir.Name y se le asigna una imagen con índice 0.

                    item = new ListViewItem(dir.Name, 0);

                    //subItems = new ListViewItem.ListViewSubItem[] { ... };: Se crea un arreglo de objetos ListViewSubItem llamado subItems que contiene información adicional para el elemento del ListView.En este caso, se agrega un subelemento con la etiqueta "Directory" y la fecha de último acceso del subdirectorio.
                    subItems = new ListViewItem.ListViewSubItem[]
                    
                        {new ListViewItem.ListViewSubItem(item, "Directory"),
                        
             new ListViewItem.ListViewSubItem(item,

                dir.LastAccessTime.ToShortDateString())};

                    //item.SubItems.AddRange(subItems);: Se agregan los subelementos contenidos en el arreglo subItems al elemento item.
                    item.SubItems.AddRange(subItems);

                    //lstProveedores.Items.Add(item);: Se agrega el elemento item al ListView llamado lstProveedores.
                    lstProveedores.Items.Add(item);
                }



                //El segundo bucle foreach es similar al primero, pero esta vez itera a través de los archivos en el directorio representado por nodeDirInfo.Se crea un elemento ListViewItem para cada archivo y se agregan subelementos con la etiqueta "File" y la fecha de último acceso.
                foreach (FileInfo file in nodeDirInfo.GetFiles())
                {
                    item = new ListViewItem(file.Name, 1);

                    subItems = new ListViewItem.ListViewSubItem[]
                        { new ListViewItem.ListViewSubItem(item, "File"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                    item.SubItems.AddRange(subItems);
                    lstProveedores.Items.Add(item);
                }

                //lstProveedores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);: Esta línea ajusta automáticamente el tamaño de las columnas del ListView para que se ajusten al contenido.En este caso, se utiliza HeaderSize, lo que significa que el tamaño se ajusta según el encabezado de la columna.Esto asegura que las columnas se ajusten correctamente al contenido de los elementos.
                lstProveedores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        //En resumen, este código se encarga de actualizar el contenido del ListView (lstProveedores) en función del nodo seleccionado en el TreeView.Muestra los subdirectorios y archivos contenidos en el directorio representado por el nodo seleccionado, con información adicional como etiquetas y fechas de acceso.





        string leerLinea;
        string[] separarDatos;
        private bool grillaCreada = false;
        public static int pos = 0;

        //pos = dgvProveedores.CurrentRow.Index;: Esta línea obtiene el índice de la fila actualmente seleccionada en el DataGridView(dgvProveedores) y lo almacena en la variable pos.El índice se refiere a la posición de la fila en el DataGridView.

        public void dgvProveedores_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //modificarProveedor.txtModificarNumero.Text = dgvProveedores[0, pos].Value.ToString();: Asigna el valor de la celda en la columna 0 (primera columna) de la fila con el índice pos al campo de texto txtModificarNumero en el formulario modificarProveedor.Esto parece ser una operación para mostrar información relacionada con un proveedor en el formulario de modificación
            pos = dgvProveedores.CurrentRow.Index;

            //Líneas similares a la línea 2: Estas líneas asignan valores de celdas específicas en el DataGridView a campos de texto en el formulario modificarProveedor.Cada línea se refiere a una columna diferente en el DataGridView, y los valores se extraen de la fila seleccionada con el índice pos.
            modificarProveedor.txtModificarNumero.Text = dgvProveedores[0, pos].Value.ToString();
            modificarProveedor.txtModificarEntidad.Text = dgvProveedores[1, pos].Value.ToString();
            modificarProveedor.txtModificarApertura.Text = dgvProveedores[2, pos].Value.ToString();
            modificarProveedor.txtModificarNExpediente.Text = dgvProveedores[3, pos].Value.ToString();
            modificarProveedor.txtModificarJuzgado.Text = dgvProveedores[4, pos].Value.ToString();
            modificarProveedor.txtModificarJurisdiccion.Text = dgvProveedores[5, pos].Value.ToString();
            modificarProveedor.txtModificarDireccion.Text = dgvProveedores[6, pos].Value.ToString();
            modificarProveedor.txtModificarLiquidadorResponsable.Text = dgvProveedores[7, pos].Value.ToString();

            //this.Hide();: Oculta el formulario actual(frmProveedores) después de que se hayan extraído los datos de la fila seleccionada en el DataGridView.
            this.Hide();

            //modificarProveedor.Show();: Muestra el formulario modificarProveedor, que probablemente sea un formulario de edición o modificación de datos de proveedores.Esto permite al usuario realizar cambios en los datos del proveedor seleccionado en el DataGridView.
            modificarProveedor.Show();
        }
        
//En resumen, este código se utiliza para capturar los datos de una fila seleccionada en el DataGridView y mostrarlos en el formulario modificarProveedor para que el usuario pueda realizar modificaciones en esos datos.Después de obtener los datos y mostrar el formulario de modificación, el formulario actual se oculta (Hide()) para que el usuario pueda interactuar con el formulario de modificación.





        private void lstProveedores_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!grillaCreada)
            {
                StreamReader sr = new StreamReader(@"../../Resources/Lista.csv");
                string leerLinea;
                string[] separarDatos;
                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');
                for (int indice = 0; indice < separarDatos.Length; indice++)
                {
                    dgvProveedores.Columns.Add(separarDatos[indice], separarDatos[indice]);
                }
                while (sr.EndOfStream == false)
                {
                    leerLinea = sr.ReadLine();
                    separarDatos = leerLinea.Split(';');
                    dgvProveedores.Rows.Add(separarDatos);
                }
                sr.Close();
                grillaCreada = true;
            }
            else
            {
                dgvProveedores.Rows.Clear();
                dgvProveedores.Columns.Clear();
                StreamReader sr = new StreamReader("../../Resources/Lista.csv");
                string leerLinea;
                string[] separarDatos;
                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');
                for (int indice = 0; indice < separarDatos.Length; indice++)
                {
                    dgvProveedores.Columns.Add(separarDatos[indice], separarDatos[indice]);
                }
                while (sr.EndOfStream == false)
                {
                    leerLinea = sr.ReadLine();
                    separarDatos = leerLinea.Split(';');
                    dgvProveedores.Rows.Add(separarDatos);
                }
                sr.Close();
            }
        }

//        El código que proporcionaste parece estar relacionado con la carga y visualización de datos en un DataGridView llamado dgvProveedores desde un archivo CSV.A continuación, se describe cada línea de código:

//if (!grillaCreada): Esto verifica si la variable booleana grillaCreada es false. Si es la primera vez que se carga la grilla(es decir, grillaCreada es false), se ejecutará el código dentro de este bloque.

//{: Inicio del bloque de código que se ejecuta si grillaCreada es false.

//StreamReader sr = new StreamReader(@"../../Resources/Lista.csv");: Se crea un objeto StreamReader llamado sr para leer el archivo CSV llamado "Lista.csv". El camino al archivo se especifica como../../Resources/Lista.csv.Esto asume que el archivo se encuentra en un directorio relativo a la ubicación de la aplicación.

//string leerLinea;: Declara una variable leerLinea para almacenar una línea del archivo CSV.

//string[] separarDatos;: Declara un arreglo de cadenas llamado separarDatos para dividir los datos de una línea en campos separados por el carácter; (punto y coma).

//leerLinea = sr.ReadLine();: Lee la primera línea del archivo CSV y la almacena en la variable leerLinea.

//separarDatos = leerLinea.Split(';');: Divide la línea leída en campos utilizando el carácter ; como delimitador y almacena los campos en el arreglo separarDatos.Esto se hace asumiendo que el archivo CSV tiene campos separados por punto y coma.

//for (int indice = 0; indice<separarDatos.Length; indice++): Inicia un bucle for que recorre los elementos en el arreglo separarDatos.

//dgvProveedores.Columns.Add(separarDatos[indice], separarDatos[indice]);: Agrega una columna al DataGridView(dgvProveedores) utilizando el valor en separarDatos[indice] como nombre de la columna.Esto crea las columnas en el DataGridView basadas en los encabezados del archivo CSV.

//while (sr.EndOfStream == false): Inicia un bucle while que se ejecuta mientras no se llegue al final del archivo CSV.

//leerLinea = sr.ReadLine();: Lee la siguiente línea del archivo CSV y la almacena en la variable leerLinea.

//separarDatos = leerLinea.Split(';');: Divide la nueva línea en campos y almacena los campos en el arreglo separarDatos.

//dgvProveedores.Rows.Add(separarDatos);: Agrega una nueva fila al DataGridView(dgvProveedores) utilizando los datos en separarDatos.

//sr.Close();: Cierra el archivo CSV después de leer todos los datos.

//grillaCreada = true;: Establece la variable grillaCreada como true para indicar que la grilla se ha creado y cargado con los datos del archivo CSV.

//}: Fin del bloque de código que se ejecuta si grillaCreada es false.

//else: Inicio del bloque de código que se ejecuta si grillaCreada es true.

//dgvProveedores.Rows.Clear();: Borra todas las filas del DataGridView(dgvProveedores) para limpiar los datos existentes.

//dgvProveedores.Columns.Clear();: Borra todas las columnas del DataGridView para limpiar los encabezados de columna existentes.

//Se repite el proceso desde el punto 3 para abrir nuevamente el archivo CSV, leer los encabezados y datos, y agregarlos al DataGridView.

//sr.Close();: Cierra el archivo CSV después de leer todos los datos nuevamente.

//En resumen, este código carga y muestra datos desde un archivo CSV en un DataGridView, y si la grilla ya se ha creado(grillaCreada es true), se borran las filas y columnas existentes antes de cargar los datos nuevamente desde el archivo CSV.

    }
}
