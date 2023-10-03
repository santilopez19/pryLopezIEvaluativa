namespace pryLopezIEvaluativa
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.msProveedores = new System.Windows.Forms.MenuStrip();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msProveedores
            // 
            this.msProveedores.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.msProveedores.Dock = System.Windows.Forms.DockStyle.Left;
            this.msProveedores.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msProveedores.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msProveedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem});
            this.msProveedores.Location = new System.Drawing.Point(0, 0);
            this.msProveedores.Name = "msProveedores";
            this.msProveedores.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msProveedores.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msProveedores.Size = new System.Drawing.Size(110, 453);
            this.msProveedores.TabIndex = 1;
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeProveedoresToolStripMenuItem,
            this.cargarProveedorToolStripMenuItem});
            this.proveedoresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // listaDeProveedoresToolStripMenuItem
            // 
            this.listaDeProveedoresToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listaDeProveedoresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listaDeProveedoresToolStripMenuItem.Name = "listaDeProveedoresToolStripMenuItem";
            this.listaDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.listaDeProveedoresToolStripMenuItem.Text = "Lista de Proveedores";
            this.listaDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.listaDeProveedoresToolStripMenuItem_Click);
            // 
            // cargarProveedorToolStripMenuItem
            // 
            this.cargarProveedorToolStripMenuItem.Name = "cargarProveedorToolStripMenuItem";
            this.cargarProveedorToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.cargarProveedorToolStripMenuItem.Text = "Cargar Proveedor";
            this.cargarProveedorToolStripMenuItem.Click += new System.EventHandler(this.cargarProveedorToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Seguros FL";
            this.msProveedores.ResumeLayout(false);
            this.msProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msProveedores;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem cargarProveedorToolStripMenuItem;
    }
}