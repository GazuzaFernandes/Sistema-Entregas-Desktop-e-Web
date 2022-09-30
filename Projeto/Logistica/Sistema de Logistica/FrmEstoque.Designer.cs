namespace Projeto.Logistica.Sistema_de_Logistica
{
    partial class FrmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoque));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvSaidaMaterial = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimparSaida = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtCodigoMaterial = new System.Windows.Forms.TextBox();
            this.txtTotalEstoqueSaida = new System.Windows.Forms.TextBox();
            this.txtCalcularSaida = new System.Windows.Forms.TextBox();
            this.txtMedidaSaida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaidaMaterial = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnLimparEntrada = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.txtTotalCaixas = new System.Windows.Forms.TextBox();
            this.txtTotalEntrada = new System.Windows.Forms.TextBox();
            this.txtUnidadeMedida = new System.Windows.Forms.TextBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtQuantidadePct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDevolucao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFabrica = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGerarId = new System.Windows.Forms.Button();
            this.txtGerarId = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDataId = new System.Windows.Forms.TextBox();
            this.cmsSalvarConteudos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeletar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletarDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaidaMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.cmsSalvarConteudos.SuspendLayout();
            this.cmsDeletar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1163, 701);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage1.Controls.Add(this.dgvSaidaMaterial);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnLimparSaida);
            this.tabPage1.Controls.Add(this.btnInserir);
            this.tabPage1.Controls.Add(this.txtCodigoMaterial);
            this.tabPage1.Controls.Add(this.txtTotalEstoqueSaida);
            this.tabPage1.Controls.Add(this.txtCalcularSaida);
            this.tabPage1.Controls.Add(this.txtMedidaSaida);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtSaidaMaterial);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1155, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Saida de Material";
            // 
            // dgvSaidaMaterial
            // 
            this.dgvSaidaMaterial.AllowUserToAddRows = false;
            this.dgvSaidaMaterial.AllowUserToDeleteRows = false;
            this.dgvSaidaMaterial.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaidaMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaidaMaterial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSaidaMaterial.Location = new System.Drawing.Point(3, 250);
            this.dgvSaidaMaterial.Name = "dgvSaidaMaterial";
            this.dgvSaidaMaterial.ReadOnly = true;
            this.dgvSaidaMaterial.RowHeadersWidth = 51;
            this.dgvSaidaMaterial.RowTemplate.Height = 29;
            this.dgvSaidaMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaidaMaterial.Size = new System.Drawing.Size(1149, 404);
            this.dgvSaidaMaterial.TabIndex = 38;
            this.dgvSaidaMaterial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaidaMaterial_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1002, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimparSaida
            // 
            this.btnLimparSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimparSaida.ForeColor = System.Drawing.Color.Black;
            this.btnLimparSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparSaida.Image")));
            this.btnLimparSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparSaida.Location = new System.Drawing.Point(614, 156);
            this.btnLimparSaida.Name = "btnLimparSaida";
            this.btnLimparSaida.Size = new System.Drawing.Size(122, 62);
            this.btnLimparSaida.TabIndex = 33;
            this.btnLimparSaida.Text = "Limpar";
            this.btnLimparSaida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparSaida.UseVisualStyleBackColor = true;
            this.btnLimparSaida.Click += new System.EventHandler(this.btnLimparSaida_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInserir.ForeColor = System.Drawing.Color.Black;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(429, 156);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(122, 62);
            this.btnInserir.TabIndex = 36;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtCodigoMaterial
            // 
            this.txtCodigoMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCodigoMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoMaterial.Enabled = false;
            this.txtCodigoMaterial.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoMaterial.Location = new System.Drawing.Point(8, 25);
            this.txtCodigoMaterial.Name = "txtCodigoMaterial";
            this.txtCodigoMaterial.Size = new System.Drawing.Size(62, 38);
            this.txtCodigoMaterial.TabIndex = 31;
            // 
            // txtTotalEstoqueSaida
            // 
            this.txtTotalEstoqueSaida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalEstoqueSaida.Enabled = false;
            this.txtTotalEstoqueSaida.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalEstoqueSaida.Location = new System.Drawing.Point(703, 82);
            this.txtTotalEstoqueSaida.Name = "txtTotalEstoqueSaida";
            this.txtTotalEstoqueSaida.Size = new System.Drawing.Size(98, 38);
            this.txtTotalEstoqueSaida.TabIndex = 32;
            this.txtTotalEstoqueSaida.Text = "0";
            // 
            // txtCalcularSaida
            // 
            this.txtCalcularSaida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCalcularSaida.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCalcularSaida.Location = new System.Drawing.Point(429, 82);
            this.txtCalcularSaida.Name = "txtCalcularSaida";
            this.txtCalcularSaida.Size = new System.Drawing.Size(98, 38);
            this.txtCalcularSaida.TabIndex = 32;
            this.txtCalcularSaida.Text = "0";
            this.txtCalcularSaida.TextChanged += new System.EventHandler(this.txtCalcularSaida_TextChanged);
            // 
            // txtMedidaSaida
            // 
            this.txtMedidaSaida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMedidaSaida.Enabled = false;
            this.txtMedidaSaida.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedidaSaida.Location = new System.Drawing.Point(1030, 22);
            this.txtMedidaSaida.Name = "txtMedidaSaida";
            this.txtMedidaSaida.Size = new System.Drawing.Size(98, 38);
            this.txtMedidaSaida.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(533, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 31);
            this.label3.TabIndex = 30;
            this.label3.Text = "Total Estoque:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(299, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 31);
            this.label2.TabIndex = 30;
            this.label2.Text = "Qtd Saida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(872, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Und Medida:";
            // 
            // txtSaidaMaterial
            // 
            this.txtSaidaMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaidaMaterial.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSaidaMaterial.Location = new System.Drawing.Point(299, 25);
            this.txtSaidaMaterial.Name = "txtSaidaMaterial";
            this.txtSaidaMaterial.Size = new System.Drawing.Size(563, 38);
            this.txtSaidaMaterial.TabIndex = 32;
            this.txtSaidaMaterial.TextChanged += new System.EventHandler(this.txtSaidaMaterial_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(76, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 31);
            this.label11.TabIndex = 30;
            this.label11.Text = "Pesquisar Material:";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage2.Controls.Add(this.dtpData);
            this.tabPage2.Controls.Add(this.btnLimparEntrada);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.dgvData);
            this.tabPage2.Controls.Add(this.txtTotalCaixas);
            this.tabPage2.Controls.Add(this.txtTotalEntrada);
            this.tabPage2.Controls.Add(this.txtUnidadeMedida);
            this.tabPage2.Controls.Add(this.txtEntrada);
            this.tabPage2.Controls.Add(this.txtQuantidadePct);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtDevolucao);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtMaterial);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtFabrica);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnGerarId);
            this.tabPage2.Controls.Add(this.txtGerarId);
            this.tabPage2.Controls.Add(this.btnDeletar);
            this.tabPage2.Controls.Add(this.btnSalvar);
            this.tabPage2.Controls.Add(this.txtDataId);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1155, 657);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Entrada de Material";
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(565, 19);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(148, 37);
            this.dtpData.TabIndex = 46;
            // 
            // btnLimparEntrada
            // 
            this.btnLimparEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimparEntrada.ForeColor = System.Drawing.Color.Black;
            this.btnLimparEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparEntrada.Image")));
            this.btnLimparEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparEntrada.Location = new System.Drawing.Point(709, 394);
            this.btnLimparEntrada.Name = "btnLimparEntrada";
            this.btnLimparEntrada.Size = new System.Drawing.Size(129, 68);
            this.btnLimparEntrada.TabIndex = 44;
            this.btnLimparEntrada.Text = "Limpar";
            this.btnLimparEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparEntrada.UseVisualStyleBackColor = true;
            this.btnLimparEntrada.Click += new System.EventHandler(this.btnLimparEntrada_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(972, 524);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(51, 281);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 29;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(645, 359);
            this.dgvData.TabIndex = 42;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // txtTotalCaixas
            // 
            this.txtTotalCaixas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalCaixas.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalCaixas.Location = new System.Drawing.Point(1052, 91);
            this.txtTotalCaixas.Name = "txtTotalCaixas";
            this.txtTotalCaixas.Size = new System.Drawing.Size(73, 38);
            this.txtTotalCaixas.TabIndex = 41;
            this.txtTotalCaixas.Text = "0";
            // 
            // txtTotalEntrada
            // 
            this.txtTotalEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalEntrada.Enabled = false;
            this.txtTotalEntrada.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalEntrada.Location = new System.Drawing.Point(443, 167);
            this.txtTotalEntrada.Name = "txtTotalEntrada";
            this.txtTotalEntrada.Size = new System.Drawing.Size(73, 38);
            this.txtTotalEntrada.TabIndex = 41;
            this.txtTotalEntrada.Text = "0";
            // 
            // txtUnidadeMedida
            // 
            this.txtUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidadeMedida.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnidadeMedida.Location = new System.Drawing.Point(687, 167);
            this.txtUnidadeMedida.Name = "txtUnidadeMedida";
            this.txtUnidadeMedida.Size = new System.Drawing.Size(73, 38);
            this.txtUnidadeMedida.TabIndex = 41;
            this.txtUnidadeMedida.Text = "M²";
            // 
            // txtEntrada
            // 
            this.txtEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEntrada.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEntrada.Location = new System.Drawing.Point(255, 167);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(73, 38);
            this.txtEntrada.TabIndex = 41;
            this.txtEntrada.Text = "0";
            this.txtEntrada.TextChanged += new System.EventHandler(this.txtEntrada_TextChanged);
            // 
            // txtQuantidadePct
            // 
            this.txtQuantidadePct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantidadePct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantidadePct.Location = new System.Drawing.Point(869, 91);
            this.txtQuantidadePct.Name = "txtQuantidadePct";
            this.txtQuantidadePct.Size = new System.Drawing.Size(73, 38);
            this.txtQuantidadePct.TabIndex = 41;
            this.txtQuantidadePct.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(364, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 31);
            this.label9.TabIndex = 40;
            this.label9.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(529, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 31);
            this.label10.TabIndex = 40;
            this.label10.Text = "Und Medida:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(147, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 31);
            this.label8.TabIndex = 40;
            this.label8.Text = "Entrada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(958, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 31);
            this.label7.TabIndex = 40;
            this.label7.Text = "Caixas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(720, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 31);
            this.label6.TabIndex = 40;
            this.label6.Text = "Qtd por pct:";
            // 
            // txtDevolucao
            // 
            this.txtDevolucao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDevolucao.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDevolucao.Location = new System.Drawing.Point(161, 226);
            this.txtDevolucao.Name = "txtDevolucao";
            this.txtDevolucao.Size = new System.Drawing.Size(612, 38);
            this.txtDevolucao.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(22, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 31);
            this.label12.TabIndex = 40;
            this.label12.Text = "Devolução:";
            // 
            // txtMaterial
            // 
            this.txtMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaterial.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaterial.Location = new System.Drawing.Point(138, 91);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(573, 38);
            this.txtMaterial.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 40;
            this.label5.Text = "Material:";
            // 
            // txtFabrica
            // 
            this.txtFabrica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFabrica.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFabrica.Location = new System.Drawing.Point(149, 18);
            this.txtFabrica.Name = "txtFabrica";
            this.txtFabrica.Size = new System.Drawing.Size(299, 38);
            this.txtFabrica.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(465, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 31);
            this.label13.TabIndex = 40;
            this.label13.Text = "Pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 31);
            this.label4.TabIndex = 40;
            this.label4.Text = "Fabrica:";
            // 
            // btnGerarId
            // 
            this.btnGerarId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGerarId.ForeColor = System.Drawing.Color.Red;
            this.btnGerarId.Location = new System.Drawing.Point(1037, 18);
            this.btnGerarId.Name = "btnGerarId";
            this.btnGerarId.Size = new System.Drawing.Size(97, 38);
            this.btnGerarId.TabIndex = 39;
            this.btnGerarId.Text = "Gerar ID";
            this.btnGerarId.UseVisualStyleBackColor = true;
            this.btnGerarId.Click += new System.EventHandler(this.btnGerarId_Click);
            // 
            // txtGerarId
            // 
            this.txtGerarId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtGerarId.Enabled = false;
            this.txtGerarId.Location = new System.Drawing.Point(934, 18);
            this.txtGerarId.Name = "txtGerarId";
            this.txtGerarId.Size = new System.Drawing.Size(97, 38);
            this.txtGerarId.TabIndex = 38;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeletar.ForeColor = System.Drawing.Color.Black;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(709, 500);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(129, 68);
            this.btnDeletar.TabIndex = 36;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(709, 281);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(129, 68);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDataId
            // 
            this.txtDataId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDataId.Enabled = false;
            this.txtDataId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataId.Location = new System.Drawing.Point(6, 281);
            this.txtDataId.Name = "txtDataId";
            this.txtDataId.Size = new System.Drawing.Size(39, 27);
            this.txtDataId.TabIndex = 38;
            this.txtDataId.Visible = false;
            // 
            // cmsSalvarConteudos
            // 
            this.cmsSalvarConteudos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSalvarConteudos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem,
            this.salvarDataToolStripMenuItem});
            this.cmsSalvarConteudos.Name = "contextMenuStrip1";
            this.cmsSalvarConteudos.Size = new System.Drawing.Size(174, 60);
            this.cmsSalvarConteudos.Opening += new System.ComponentModel.CancelEventHandler(this.cmsSalvarConteudos_Opening);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.sToolStripMenuItem.Text = "Salvar Data";
            // 
            // salvarDataToolStripMenuItem
            // 
            this.salvarDataToolStripMenuItem.Name = "salvarDataToolStripMenuItem";
            this.salvarDataToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.salvarDataToolStripMenuItem.Text = "Salvar Entrada";
            // 
            // cmsDeletar
            // 
            this.cmsDeletar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDeletar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarDataToolStripMenuItem,
            this.deletarItemToolStripMenuItem});
            this.cmsDeletar.Name = "cmsDeletar";
            this.cmsDeletar.Size = new System.Drawing.Size(164, 52);
            this.cmsDeletar.Opening += new System.ComponentModel.CancelEventHandler(this.cmsDeletar_Opening);
            // 
            // deletarDataToolStripMenuItem
            // 
            this.deletarDataToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.deletarDataToolStripMenuItem.Name = "deletarDataToolStripMenuItem";
            this.deletarDataToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.deletarDataToolStripMenuItem.Text = "Deletar Data";
            // 
            // deletarItemToolStripMenuItem
            // 
            this.deletarItemToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.deletarItemToolStripMenuItem.Name = "deletarItemToolStripMenuItem";
            this.deletarItemToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.deletarItemToolStripMenuItem.Text = "Deletar Item";
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1163, 701);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstoque";
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaidaMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.cmsSalvarConteudos.ResumeLayout(false);
            this.cmsDeletar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvSaidaMaterial;
        private PictureBox pictureBox1;
        private Button btnLimparSaida;
        private Button btnInserir;
        private TextBox txtCodigoMaterial;
        private TextBox txtTotalEstoqueSaida;
        private TextBox txtCalcularSaida;
        private TextBox txtMedidaSaida;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtSaidaMaterial;
        private Label label11;
        private Button btnDeletar;
        private Button btnSalvar;
        private Button btnGerarId;
        private TextBox txtGerarId;
        private Button btnLimparEntrada;
        private PictureBox pictureBox2;
        private DataGridView dgvData;
        private TextBox txtTotalCaixas;
        private TextBox txtTotalEntrada;
        private TextBox txtUnidadeMedida;
        private TextBox txtEntrada;
        private TextBox txtQuantidadePct;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtMaterial;
        private Label label5;
        private TextBox txtFabrica;
        private Label label4;
        private TextBox txtDataId;
        private TextBox txtDevolucao;
        private Label label12;
        private DateTimePicker dtpData;
        private Label label13;
        private ContextMenuStrip cmsSalvarConteudos;
        private ToolStripMenuItem sToolStripMenuItem;
        private ToolStripMenuItem salvarDataToolStripMenuItem;
        private ContextMenuStrip cmsDeletar;
        private ToolStripMenuItem deletarDataToolStripMenuItem;
        private ToolStripMenuItem deletarItemToolStripMenuItem;
    }
}