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
            PopulateTreeView();
        }
        frmModificarProveedor modificarProveedor = new frmModificarProveedor();
        public void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"../../Resources");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                tvwProveedores.Nodes.Add(rootNode);
            }
        }
        public void GetDirectories(DirectoryInfo[] subDirs,
            TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }
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
    }
}
