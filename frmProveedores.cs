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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryLopezIEvaluativa
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }
        frmModificarProveedor modificarProveedor = new frmModificarProveedor();
        private void btnVolver_Click(object sender, EventArgs e)
        {
        frmMenu Menusovich = new frmMenu();
        this.Hide();
        Menusovich.Show();
        }
        public void tvwProveedores_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            {
                TreeNode newSelected = e.Node;
                lstProveedores.Items.Clear();
                DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
                ListViewItem.ListViewSubItem[] subItems;
                ListViewItem item = null;

                foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
                {
                    item = new ListViewItem(dir.Name, 0);
                    subItems = new ListViewItem.ListViewSubItem[]
                        {new ListViewItem.ListViewSubItem(item, "Directory"),
             new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                    item.SubItems.AddRange(subItems);
                    lstProveedores.Items.Add(item);
                }
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

                lstProveedores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        string leerLinea;
        string[] separarDatos;
        private bool grillaCreada = false;
        public static int pos = 0;
        public void dgvProveedores_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pos = dgvProveedores.CurrentRow.Index;
            modificarProveedor.txtModificarNumero.Text = dgvProveedores[0, pos].Value.ToString();
            modificarProveedor.txtModificarEntidad.Text = dgvProveedores[1, pos].Value.ToString();
            modificarProveedor.txtModificarApertura.Text = dgvProveedores[2, pos].Value.ToString();
            modificarProveedor.txtModificarNExpediente.Text = dgvProveedores[3, pos].Value.ToString();
            modificarProveedor.txtModificarJuzgado.Text = dgvProveedores[4, pos].Value.ToString();
            modificarProveedor.txtModificarJurisdiccion.Text = dgvProveedores[5, pos].Value.ToString();
            modificarProveedor.txtModificarDireccion.Text = dgvProveedores[6, pos].Value.ToString();
            modificarProveedor.txtModificarLiquidadorResponsable.Text = dgvProveedores[7, pos].Value.ToString();
            this.Hide();
            modificarProveedor.Show();
        }
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

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            string rutaRaiz = "../../Resources/Lista.csv"; // Cambia esto a la ubicación que desees mostrar en el TreeView

            // Agrega un nodo raíz al TreeView
            TreeNode rootNode = new TreeNode(rutaRaiz);
            tvwProveedores.Nodes.Add(rootNode);

            // Llama a una función para llenar el TreeView con los archivos y carpetas
            LlenarTreeView(rootNode, rutaRaiz);
        }
        private void LlenarTreeView(TreeNode parentNode, string ruta)
        {
            try
            {
                // Obtiene la lista de carpetas en la ruta actual
                string[] carpetas = Directory.GetDirectories(ruta);

                // Agrega cada carpeta como un nodo al TreeView
                foreach (string carpeta in carpetas)
                {
                    TreeNode folderNode = new TreeNode(Path.GetFileName(carpeta));
                    parentNode.Nodes.Add(folderNode);

                    // Llama recursivamente a la función para las subcarpetas
                    LlenarTreeView(folderNode, carpeta);
                }

                // Obtiene la lista de archivos en la ruta actual
                string[] archivos = Directory.GetFiles(ruta);

                // Agrega cada archivo como un nodo al TreeView
                foreach (string archivo in archivos)
                {
                    TreeNode fileNode = new TreeNode(Path.GetFileName(archivo));
                    parentNode.Nodes.Add(fileNode);
                }
            }
            finally 
            {}
        }
    }
}
