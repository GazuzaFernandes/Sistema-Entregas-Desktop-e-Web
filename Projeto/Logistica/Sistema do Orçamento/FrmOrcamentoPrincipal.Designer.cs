namespace Logistica.Sistema_do_Orçamento
{
    partial class FrmOrcamentoPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrcamentoPrincipal));
            this.dgvValores = new System.Windows.Forms.DataGridView();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvValores
            // 
            this.dgvValores.BackgroundColor = System.Drawing.Color.White;
            this.dgvValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvValores.Location = new System.Drawing.Point(0, 171);
            this.dgvValores.Name = "dgvValores";
            this.dgvValores.RowHeadersWidth = 51;
            this.dgvValores.RowTemplate.Height = 29;
            this.dgvValores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvValores.Size = new System.Drawing.Size(1121, 553);
            this.dgvValores.TabIndex = 0;
            this.dgvValores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvValores_CellDoubleClick);
            // 
            // btnProduto
            // 
            this.btnProduto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProduto.Location = new System.Drawing.Point(344, 82);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(264, 63);
            this.btnProduto.TabIndex = 51;
            this.btnProduto.Text = "Cadastrar Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparPesquisa.Image")));
            this.btnLimparPesquisa.Location = new System.Drawing.Point(635, 22);
            this.btnLimparPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(38, 38);
            this.btnLimparPesquisa.TabIndex = 49;
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnLimparPesquisa_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(591, 22);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(38, 38);
            this.btnPesquisar.TabIndex = 50;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisar.Location = new System.Drawing.Point(165, 22);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(410, 38);
            this.txtPesquisar.TabIndex = 48;
            this.txtPesquisar.Text = "Digite para pesquisar:";
            this.txtPesquisar.Click += new System.EventHandler(this.txtPesquisar_Click);
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // FrmOrcamentoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1121, 724);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnLimparPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvValores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrcamentoPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar preços de Produtos.";
            this.Load += new System.EventHandler(this.FrmOrcamentoPrincipal_Load);
            this.Click += new System.EventHandler(this.FrmOrcamentoPrincipal_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvValores;
        private Button btnProduto;
        private Button btnLimparPesquisa;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private PictureBox pictureBox1;
    }
}