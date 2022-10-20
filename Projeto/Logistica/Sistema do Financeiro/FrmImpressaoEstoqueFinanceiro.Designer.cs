namespace Projeto.Logistica.Sistema_do_Financeiro
{
    partial class FrmImpressaoEstoqueFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImpressaoEstoqueFinanceiro));
            this.rvFinanceiro = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvFinanceiro
            // 
            this.rvFinanceiro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvFinanceiro.Location = new System.Drawing.Point(0, 0);
            this.rvFinanceiro.Name = "ReportViewer";
            this.rvFinanceiro.ServerReport.BearerToken = null;
            this.rvFinanceiro.Size = new System.Drawing.Size(569, 623);
            this.rvFinanceiro.TabIndex = 0;
            // 
            // FrmImpressaoEstoqueFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 623);
            this.Controls.Add(this.rvFinanceiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImpressaoEstoqueFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressão do Estoque para Financeiro";
            this.Load += new System.EventHandler(this.FrmImpressaoEstoqueFinanceiro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public Microsoft.Reporting.WinForms.ReportViewer rvFinanceiro;
    }
}