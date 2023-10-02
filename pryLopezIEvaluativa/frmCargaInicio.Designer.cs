namespace pryLopezIEvaluativa
{
    partial class frmCargaInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaInicio));
            this.timerCarga = new System.Windows.Forms.Timer(this.components);
            this.prbCarga = new System.Windows.Forms.ProgressBar();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // timerCarga
            // 
            this.timerCarga.Enabled = true;
            this.timerCarga.Tick += new System.EventHandler(this.timerCarga_Tick);
            // 
            // prbCarga
            // 
            this.prbCarga.BackColor = System.Drawing.Color.Black;
            this.prbCarga.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prbCarga.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.prbCarga.Location = new System.Drawing.Point(0, 422);
            this.prbCarga.Margin = new System.Windows.Forms.Padding(4);
            this.prbCarga.Name = "prbCarga";
            this.prbCarga.Size = new System.Drawing.Size(707, 28);
            this.prbCarga.Step = 100;
            this.prbCarga.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbCarga.TabIndex = 3;
            // 
            // pctLogo
            // 
            this.pctLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(0, 0);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(707, 422);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 4;
            this.pctLogo.TabStop = false;
            // 
            // frmCargaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.prbCarga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguros FL";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerCarga;
        private System.Windows.Forms.ProgressBar prbCarga;
        private System.Windows.Forms.PictureBox pctLogo;
    }
}

