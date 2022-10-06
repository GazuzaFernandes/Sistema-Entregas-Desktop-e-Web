namespace Logistica.Sistema_do_Financeiro
{
    partial class FrmPrincipalFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalFinanceiro));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.rbNotaFiscal = new System.Windows.Forms.RadioButton();
            this.rbProposta = new System.Windows.Forms.RadioButton();
            this.rbEndereco = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvNotaFiscais = new System.Windows.Forms.DataGridView();
            this.cbEmpresas = new System.Windows.Forms.ComboBox();
            this.msNotasFiscais = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msInserir = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaFiscais)).BeginInit();
            this.msNotasFiscais.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1130, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparPesquisa.Image")));
            this.btnLimparPesquisa.Location = new System.Drawing.Point(709, 28);
            this.btnLimparPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(38, 38);
            this.btnLimparPesquisa.TabIndex = 19;
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnLimparPesquisa_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(655, 28);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(38, 38);
            this.btnPesquisar.TabIndex = 20;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // rbNotaFiscal
            // 
            this.rbNotaFiscal.AutoSize = true;
            this.rbNotaFiscal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbNotaFiscal.ForeColor = System.Drawing.Color.White;
            this.rbNotaFiscal.Location = new System.Drawing.Point(365, 81);
            this.rbNotaFiscal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNotaFiscal.Name = "rbNotaFiscal";
            this.rbNotaFiscal.Size = new System.Drawing.Size(153, 35);
            this.rbNotaFiscal.TabIndex = 16;
            this.rbNotaFiscal.TabStop = true;
            this.rbNotaFiscal.Text = "Nota Fiscal";
            this.rbNotaFiscal.UseVisualStyleBackColor = true;
            // 
            // rbProposta
            // 
            this.rbProposta.AutoSize = true;
            this.rbProposta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbProposta.ForeColor = System.Drawing.Color.White;
            this.rbProposta.Location = new System.Drawing.Point(541, 81);
            this.rbProposta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbProposta.Name = "rbProposta";
            this.rbProposta.Size = new System.Drawing.Size(131, 35);
            this.rbProposta.TabIndex = 17;
            this.rbProposta.TabStop = true;
            this.rbProposta.Text = "Proposta";
            this.rbProposta.UseVisualStyleBackColor = true;
            // 
            // rbEndereco
            // 
            this.rbEndereco.AutoSize = true;
            this.rbEndereco.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbEndereco.ForeColor = System.Drawing.Color.White;
            this.rbEndereco.Location = new System.Drawing.Point(202, 81);
            this.rbEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbEndereco.Name = "rbEndereco";
            this.rbEndereco.Size = new System.Drawing.Size(133, 35);
            this.rbEndereco.TabIndex = 18;
            this.rbEndereco.TabStop = true;
            this.rbEndereco.Text = "Endereço";
            this.rbEndereco.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisar.Location = new System.Drawing.Point(202, 28);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(431, 38);
            this.txtPesquisar.TabIndex = 15;
            this.txtPesquisar.Text = "Digite para pesquisar:";
            this.txtPesquisar.Click += new System.EventHandler(this.txtPesquisar_Click);
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // dgvNotaFiscais
            // 
            this.dgvNotaFiscais.AllowUserToAddRows = false;
            this.dgvNotaFiscais.AllowUserToDeleteRows = false;
            this.dgvNotaFiscais.BackgroundColor = System.Drawing.Color.White;
            this.dgvNotaFiscais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotaFiscais.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNotaFiscais.Location = new System.Drawing.Point(0, 144);
            this.dgvNotaFiscais.Name = "dgvNotaFiscais";
            this.dgvNotaFiscais.ReadOnly = true;
            this.dgvNotaFiscais.RowHeadersWidth = 51;
            this.dgvNotaFiscais.RowTemplate.Height = 29;
            this.dgvNotaFiscais.Size = new System.Drawing.Size(1280, 570);
            this.dgvNotaFiscais.TabIndex = 26;
            this.dgvNotaFiscais.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotaFiscais_CellDoubleClick);
            this.dgvNotaFiscais.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvNotaFiscais_DataBindingComplete);
            // 
            // cbEmpresas
            // 
            this.cbEmpresas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresas.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEmpresas.ForeColor = System.Drawing.Color.Red;
            this.cbEmpresas.FormattingEnabled = true;
            this.cbEmpresas.Items.AddRange(new object[] {
            "Rb Pisos",
            "Rb Engenharia",
            "Rb Comercio"});
            this.cbEmpresas.Location = new System.Drawing.Point(806, 77);
            this.cbEmpresas.Name = "cbEmpresas";
            this.cbEmpresas.Size = new System.Drawing.Size(224, 39);
            this.cbEmpresas.TabIndex = 27;
            // 
            // msNotasFiscais
            // 
            this.msNotasFiscais.Dock = System.Windows.Forms.DockStyle.None;
            this.msNotasFiscais.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.msNotasFiscais.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msNotasFiscais.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msNotasFiscais.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ferramentasToolStripMenuItem,
            this.tutorialToolStripMenuItem});
            this.msNotasFiscais.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.msNotasFiscais.Location = new System.Drawing.Point(9, 9);
            this.msNotasFiscais.Name = "msNotasFiscais";
            this.msNotasFiscais.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msNotasFiscais.Size = new System.Drawing.Size(143, 121);
            this.msNotasFiscais.TabIndex = 28;
            this.msNotasFiscais.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msInserir});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 35);
            this.toolStripMenuItem1.Text = "Nota Fiscal";
            // 
            // msInserir
            // 
            this.msInserir.Name = "msInserir";
            this.msInserir.Size = new System.Drawing.Size(283, 36);
            this.msInserir.Text = "Inserir Nota Fiscal";
            this.msInserir.Click += new System.EventHandler(this.msInserir_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msEstoque});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(139, 35);
            this.ferramentasToolStripMenuItem.Text = "Estoque";
            // 
            // msEstoque
            // 
            this.msEstoque.Name = "msEstoque";
            this.msEstoque.Size = new System.Drawing.Size(280, 36);
            this.msEstoque.Text = "Atualizar Estoque";
            this.msEstoque.Click += new System.EventHandler(this.msEstoque_Click);
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCliente});
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(139, 35);
            this.tutorialToolStripMenuItem.Text = "Clientes";
            // 
            // msCliente
            // 
            this.msCliente.Name = "msCliente";
            this.msCliente.Size = new System.Drawing.Size(287, 36);
            this.msCliente.Text = "Cadastrar Clientes";
            this.msCliente.Click += new System.EventHandler(this.msCliente_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(806, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 31);
            this.label11.TabIndex = 29;
            this.label11.Text = "Informe a empresa:";
            // 
            // FrmPrincipalFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1280, 714);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.msNotasFiscais);
            this.Controls.Add(this.cbEmpresas);
            this.Controls.Add(this.dgvNotaFiscais);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimparPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.rbNotaFiscal);
            this.Controls.Add(this.rbProposta);
            this.Controls.Add(this.rbEndereco);
            this.Controls.Add(this.txtPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipalFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notas Fiscais lançadas.";
            this.Load += new System.EventHandler(this.FrmPrincipalFinanceiro_Load);
            this.Click += new System.EventHandler(this.FrmPrincipalFinanceiro_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotaFiscais)).EndInit();
            this.msNotasFiscais.ResumeLayout(false);
            this.msNotasFiscais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnLimparPesquisa;
        private Button btnPesquisar;
        private RadioButton rbNotaFiscal;
        private RadioButton rbProposta;
        private RadioButton rbEndereco;
        private TextBox txtPesquisar;
        private DataGridView dgvNotaFiscais;
        private ComboBox cbEmpresas;
        private MenuStrip msNotasFiscais;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem msInserir;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private ToolStripMenuItem msEstoque;
        private ToolStripMenuItem tutorialToolStripMenuItem;
        private ToolStripMenuItem msCliente;
        private Label label11;
    }
}