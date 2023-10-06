namespace pryLopezIEvaluativa
{
    partial class frmProveedores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.tvwProveedores = new System.Windows.Forms.TreeView();
            this.imageListTreeViewProveedores = new System.Windows.Forms.ImageList(this.components);
            this.lstProveedores = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // tvwProveedores
            // 
            this.tvwProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwProveedores.ImageIndex = 0;
            this.tvwProveedores.ImageList = this.imageListTreeViewProveedores;
            this.tvwProveedores.Location = new System.Drawing.Point(13, 13);
            this.tvwProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.tvwProveedores.Name = "tvwProveedores";
            this.tvwProveedores.SelectedImageIndex = 0;
            this.tvwProveedores.Size = new System.Drawing.Size(358, 298);
            this.tvwProveedores.TabIndex = 3;
            this.tvwProveedores.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwProveedores_NodeMouseClick);
            // 
            // imageListTreeViewProveedores
            // 
            this.imageListTreeViewProveedores.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreeViewProveedores.ImageStream")));
            this.imageListTreeViewProveedores.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTreeViewProveedores.Images.SetKeyName(0, "carpeta_pryIE1-removebg-preview.png");
            this.imageListTreeViewProveedores.Images.SetKeyName(1, "archivo_pryIE1-removebg-preview.png");
            // 
            // lstProveedores
            // 
            this.lstProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProveedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstProveedores.HideSelection = false;
            this.lstProveedores.LargeImageList = this.imageListTreeViewProveedores;
            this.lstProveedores.Location = new System.Drawing.Point(378, 13);
            this.lstProveedores.Name = "lstProveedores";
            this.lstProveedores.Size = new System.Drawing.Size(526, 298);
            this.lstProveedores.SmallImageList = this.imageListTreeViewProveedores;
            this.lstProveedores.TabIndex = 10;
            this.lstProveedores.UseCompatibleStateImageBehavior = false;
            this.lstProveedores.View = System.Windows.Forms.View.Details;
            this.lstProveedores.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstProveedores_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ult. Modificacion";
            this.columnHeader3.Width = 118;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToOrderColumns = true;
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(13, 318);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.Size = new System.Drawing.Size(891, 171);
            this.dgvProveedores.TabIndex = 11;
            this.dgvProveedores.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProveedores_CellClick);
            this.dgvProveedores.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProveedores_CellClick);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolver.Location = new System.Drawing.Point(13, 497);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 534);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.lstProveedores);
            this.Controls.Add(this.tvwProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.TreeView tvwProveedores;
        private System.Windows.Forms.ListView lstProveedores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ImageList imageListTreeViewProveedores;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}