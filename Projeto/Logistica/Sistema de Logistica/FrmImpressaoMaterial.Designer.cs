namespace Projeto.Logistica.Sistema_de_Logistica
{
    partial class FrmImpressaoMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImpressaoMaterial));
            this.rvMaterial = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvMaterial
            // 
            this.rvMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvMaterial.Location = new System.Drawing.Point(0, 0);
            this.rvMaterial.Name = "ReportViewer";
            this.rvMaterial.ServerReport.BearerToken = null;
            this.rvMaterial.Size = new System.Drawing.Size(396, 246);
            this.rvMaterial.TabIndex = 0;
            // 
            // FrmImpressaoMaterial
            // 
            this.Controls.Add(this.rvMaterial);
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(770, 732);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmImpressaoMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão do estoque de madeiras.";
            this.Load += new System.EventHandler(this.FrmImpressaoMaterial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer rvMaterial;
    }
}