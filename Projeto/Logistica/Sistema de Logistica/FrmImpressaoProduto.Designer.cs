namespace Projeto.Logistica.Sistema_de_Logistica
{
    partial class FrmImpressaoProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImpressaoProduto));
            this.rvProduto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvProduto
            // 
            this.rvProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvProduto.Location = new System.Drawing.Point(0, 0);
            this.rvProduto.Name = "ReportViewer";
            this.rvProduto.ServerReport.BearerToken = null;
            this.rvProduto.Size = new System.Drawing.Size(396, 246);
            this.rvProduto.TabIndex = 0;
            // 
            // FrmImpressaoProduto
            // 
            this.Controls.Add(this.rvProduto);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 709);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImpressaoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão do estoque de produtos.";
            this.Load += new System.EventHandler(this.FrmImpressaoProduto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public Microsoft.Reporting.WinForms.ReportViewer rvProduto;
    }
}