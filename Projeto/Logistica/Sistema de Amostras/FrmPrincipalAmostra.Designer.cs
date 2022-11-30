namespace Logistica.Sistema_de_Amostras
{
    partial class FrmPrincipalAmostra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalAmostra));
            this.dvgAmostra = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.rbAmostra = new System.Windows.Forms.RadioButton();
            this.rbEndereco = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnAmostra = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAmostra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgAmostra
            // 
            this.dvgAmostra.AllowUserToAddRows = false;
            this.dvgAmostra.AllowUserToDeleteRows = false;
            this.dvgAmostra.BackgroundColor = System.Drawing.Color.White;
            this.dvgAmostra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAmostra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvgAmostra.Location = new System.Drawing.Point(0, 158);
            this.dvgAmostra.Name = "dvgAmostra";
            this.dvgAmostra.ReadOnly = true;
            this.dvgAmostra.RowHeadersWidth = 51;
            this.dvgAmostra.RowTemplate.Height = 29;
            this.dvgAmostra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgAmostra.Size = new System.Drawing.Size(1234, 526);
            this.dvgAmostra.TabIndex = 2;
            this.dvgAmostra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgAmostra_CellDoubleClick);
            this.dvgAmostra.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dvgAmostra_DataBindingComplete);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparPesquisa.Image")));
            this.btnLimparPesquisa.Location = new System.Drawing.Point(666, 25);
            this.btnLimparPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(38, 38);
            this.btnLimparPesquisa.TabIndex = 44;
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnLimparPesquisa_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(622, 25);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(38, 38);
            this.btnPesquisar.TabIndex = 45;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // rbAmostra
            // 
            this.rbAmostra.AutoSize = true;
            this.rbAmostra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAmostra.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbAmostra.ForeColor = System.Drawing.Color.White;
            this.rbAmostra.Location = new System.Drawing.Point(468, 78);
            this.rbAmostra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAmostra.Name = "rbAmostra";
            this.rbAmostra.Size = new System.Drawing.Size(136, 35);
            this.rbAmostra.TabIndex = 41;
            this.rbAmostra.TabStop = true;
            this.rbAmostra.Text = "Amostras";
            this.rbAmostra.UseVisualStyleBackColor = true;
            // 
            // rbEndereco
            // 
            this.rbEndereco.AutoSize = true;
            this.rbEndereco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEndereco.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbEndereco.ForeColor = System.Drawing.Color.White;
            this.rbEndereco.Location = new System.Drawing.Point(319, 78);
            this.rbEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbEndereco.Name = "rbEndereco";
            this.rbEndereco.Size = new System.Drawing.Size(133, 35);
            this.rbEndereco.TabIndex = 42;
            this.rbEndereco.TabStop = true;
            this.rbEndereco.Text = "Endereço";
            this.rbEndereco.UseVisualStyleBackColor = true;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCliente.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCliente.ForeColor = System.Drawing.Color.White;
            this.rbCliente.Location = new System.Drawing.Point(194, 78);
            this.rbCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(110, 35);
            this.rbCliente.TabIndex = 43;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisar.Location = new System.Drawing.Point(194, 25);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(410, 38);
            this.txtPesquisar.TabIndex = 40;
            this.txtPesquisar.Text = "Digite para pesquisar:";
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // btnAmostra
            // 
            this.btnAmostra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmostra.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAmostra.Location = new System.Drawing.Point(744, 51);
            this.btnAmostra.Name = "btnAmostra";
            this.btnAmostra.Size = new System.Drawing.Size(207, 74);
            this.btnAmostra.TabIndex = 46;
            this.btnAmostra.Text = "Amostra";
            this.btnAmostra.UseVisualStyleBackColor = true;
            this.btnAmostra.Click += new System.EventHandler(this.btnAmostra_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEstoque.Location = new System.Drawing.Point(995, 51);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(207, 74);
            this.btnEstoque.TabIndex = 46;
            this.btnEstoque.Text = "Estoque Amostra";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // FrmPrincipalAmostra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1234, 684);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnAmostra);
            this.Controls.Add(this.btnLimparPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.rbAmostra);
            this.Controls.Add(this.rbEndereco);
            this.Controls.Add(this.rbCliente);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dvgAmostra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipalAmostra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico de amostras.";
            this.Load += new System.EventHandler(this.FrmPrincipalAmostra_Load);
            this.Click += new System.EventHandler(this.FrmPrincipalAmostra_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dvgAmostra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dvgAmostra;
        private PictureBox pictureBox1;
        private Button btnLimparPesquisa;
        private Button btnPesquisar;
        private RadioButton rbAmostra;
        private RadioButton rbEndereco;
        private RadioButton rbCliente;
        private TextBox txtPesquisar;
        private Button btnAmostra;
        private Button btnEstoque;
    }
}