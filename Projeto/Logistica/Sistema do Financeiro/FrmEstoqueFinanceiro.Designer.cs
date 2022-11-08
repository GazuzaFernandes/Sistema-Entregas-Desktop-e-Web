namespace Projeto.Logistica.Sistema_do_Financeiro
{
    partial class FrmEstoqueFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoqueFinanceiro));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtIdSaida = new System.Windows.Forms.TextBox();
            this.txtTotalEstoqueSaida = new System.Windows.Forms.TextBox();
            this.txtUndMedidaSaida = new System.Windows.Forms.TextBox();
            this.txtSaidaEstoque = new System.Windows.Forms.TextBox();
            this.txtMaterialSaida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSaidaMaterial = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnLimparSaida = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bntLimparEntrada = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.rbComercio = new System.Windows.Forms.RadioButton();
            this.rbEngenharia = new System.Windows.Forms.RadioButton();
            this.rbPisos = new System.Windows.Forms.RadioButton();
            this.btnGerarId = new System.Windows.Forms.Button();
            this.txtDataId = new System.Windows.Forms.TextBox();
            this.txtIdEntrada = new System.Windows.Forms.TextBox();
            this.txtTotalEntrada = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEntradaEstoque = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUndMedidaEntrada = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaterialEntrada = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFabrica = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataPedido = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmsSalvar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSalvarDatas = new System.Windows.Forms.ToolStripMenuItem();
            this.cmSalvarMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeletar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeletarData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeletarMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaidaMaterial)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmsSalvar.SuspendLayout();
            this.cmsDeletar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1227, 693);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.txtIdSaida);
            this.tabPage1.Controls.Add(this.txtTotalEstoqueSaida);
            this.tabPage1.Controls.Add(this.txtUndMedidaSaida);
            this.tabPage1.Controls.Add(this.txtSaidaEstoque);
            this.tabPage1.Controls.Add(this.txtMaterialSaida);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dgvSaidaMaterial);
            this.tabPage1.Controls.Add(this.btnInserir);
            this.tabPage1.Controls.Add(this.btnLimparSaida);
            this.tabPage1.Location = new System.Drawing.Point(4, 43);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1219, 646);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Saida Material";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnImprimir.Location = new System.Drawing.Point(999, 143);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(59, 54);
            this.btnImprimir.TabIndex = 39;
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1064, 95);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // txtIdSaida
            // 
            this.txtIdSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIdSaida.Enabled = false;
            this.txtIdSaida.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdSaida.Location = new System.Drawing.Point(8, 15);
            this.txtIdSaida.Name = "txtIdSaida";
            this.txtIdSaida.Size = new System.Drawing.Size(59, 38);
            this.txtIdSaida.TabIndex = 36;
            // 
            // txtTotalEstoqueSaida
            // 
            this.txtTotalEstoqueSaida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalEstoqueSaida.Enabled = false;
            this.txtTotalEstoqueSaida.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalEstoqueSaida.ForeColor = System.Drawing.Color.Red;
            this.txtTotalEstoqueSaida.Location = new System.Drawing.Point(830, 86);
            this.txtTotalEstoqueSaida.Name = "txtTotalEstoqueSaida";
            this.txtTotalEstoqueSaida.Size = new System.Drawing.Size(126, 38);
            this.txtTotalEstoqueSaida.TabIndex = 35;
            // 
            // txtUndMedidaSaida
            // 
            this.txtUndMedidaSaida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUndMedidaSaida.Enabled = false;
            this.txtUndMedidaSaida.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUndMedidaSaida.ForeColor = System.Drawing.Color.Red;
            this.txtUndMedidaSaida.Location = new System.Drawing.Point(527, 86);
            this.txtUndMedidaSaida.Name = "txtUndMedidaSaida";
            this.txtUndMedidaSaida.Size = new System.Drawing.Size(67, 38);
            this.txtUndMedidaSaida.TabIndex = 35;
            // 
            // txtSaidaEstoque
            // 
            this.txtSaidaEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaidaEstoque.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSaidaEstoque.ForeColor = System.Drawing.Color.Red;
            this.txtSaidaEstoque.Location = new System.Drawing.Point(281, 86);
            this.txtSaidaEstoque.Name = "txtSaidaEstoque";
            this.txtSaidaEstoque.Size = new System.Drawing.Size(67, 38);
            this.txtSaidaEstoque.TabIndex = 35;
            this.txtSaidaEstoque.Text = "0";
            this.txtSaidaEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaidaEstoque_KeyPress);
            // 
            // txtMaterialSaida
            // 
            this.txtMaterialSaida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaterialSaida.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaterialSaida.Location = new System.Drawing.Point(325, 27);
            this.txtMaterialSaida.Name = "txtMaterialSaida";
            this.txtMaterialSaida.Size = new System.Drawing.Size(572, 38);
            this.txtMaterialSaida.TabIndex = 35;
            this.txtMaterialSaida.TextChanged += new System.EventHandler(this.txtMaterialSaida_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(614, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 31);
            this.label3.TabIndex = 34;
            this.label3.Text = "Total em Estoque:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(852, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 31);
            this.label7.TabIndex = 34;
            this.label7.Text = "Rb Pisos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(683, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 31);
            this.label6.TabIndex = 34;
            this.label6.Text = "Rb Comercio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(490, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 31);
            this.label5.TabIndex = 34;
            this.label5.Text = "Rb Engenharia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(369, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "Und Medida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(197, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "Saida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(197, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 31);
            this.label4.TabIndex = 34;
            this.label4.Text = "Pesquisar:";
            // 
            // dgvSaidaMaterial
            // 
            this.dgvSaidaMaterial.AllowUserToAddRows = false;
            this.dgvSaidaMaterial.AllowUserToDeleteRows = false;
            this.dgvSaidaMaterial.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaidaMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaidaMaterial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSaidaMaterial.Location = new System.Drawing.Point(3, 238);
            this.dgvSaidaMaterial.Name = "dgvSaidaMaterial";
            this.dgvSaidaMaterial.ReadOnly = true;
            this.dgvSaidaMaterial.RowHeadersWidth = 51;
            this.dgvSaidaMaterial.RowTemplate.Height = 29;
            this.dgvSaidaMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaidaMaterial.Size = new System.Drawing.Size(1213, 405);
            this.dgvSaidaMaterial.TabIndex = 33;
            this.dgvSaidaMaterial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaidaMaterial_CellDoubleClick);
            this.dgvSaidaMaterial.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSaidaMaterial_DataBindingComplete);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInserir.ForeColor = System.Drawing.Color.Black;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(90, 153);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(159, 52);
            this.btnInserir.TabIndex = 29;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnLimparSaida
            // 
            this.btnLimparSaida.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimparSaida.ForeColor = System.Drawing.Color.Black;
            this.btnLimparSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparSaida.Image")));
            this.btnLimparSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparSaida.Location = new System.Drawing.Point(299, 153);
            this.btnLimparSaida.Name = "btnLimparSaida";
            this.btnLimparSaida.Size = new System.Drawing.Size(159, 52);
            this.btnLimparSaida.TabIndex = 30;
            this.btnLimparSaida.Text = "Limpar";
            this.btnLimparSaida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparSaida.UseVisualStyleBackColor = true;
            this.btnLimparSaida.Click += new System.EventHandler(this.btnLimparSaida_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage2.Controls.Add(this.bntLimparEntrada);
            this.tabPage2.Controls.Add(this.dgvData);
            this.tabPage2.Controls.Add(this.rbComercio);
            this.tabPage2.Controls.Add(this.rbEngenharia);
            this.tabPage2.Controls.Add(this.rbPisos);
            this.tabPage2.Controls.Add(this.btnGerarId);
            this.tabPage2.Controls.Add(this.txtDataId);
            this.tabPage2.Controls.Add(this.txtIdEntrada);
            this.tabPage2.Controls.Add(this.txtTotalEntrada);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtEntradaEstoque);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtUndMedidaEntrada);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtMaterialEntrada);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtFabrica);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dtpDataPedido);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnDeletar);
            this.tabPage2.Controls.Add(this.btnSalvar);
            this.tabPage2.Location = new System.Drawing.Point(4, 43);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1219, 646);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Entrada Material";
            // 
            // bntLimparEntrada
            // 
            this.bntLimparEntrada.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntLimparEntrada.ForeColor = System.Drawing.Color.Black;
            this.bntLimparEntrada.Image = ((System.Drawing.Image)(resources.GetObject("bntLimparEntrada.Image")));
            this.bntLimparEntrada.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bntLimparEntrada.Location = new System.Drawing.Point(803, 483);
            this.bntLimparEntrada.Name = "bntLimparEntrada";
            this.bntLimparEntrada.Size = new System.Drawing.Size(159, 75);
            this.bntLimparEntrada.TabIndex = 50;
            this.bntLimparEntrada.Text = "Limpar";
            this.bntLimparEntrada.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bntLimparEntrada.UseVisualStyleBackColor = true;
            this.bntLimparEntrada.Click += new System.EventHandler(this.bntLimparEntrada_Click);
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(55, 266);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 29;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(730, 292);
            this.dgvData.TabIndex = 49;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            // 
            // rbComercio
            // 
            this.rbComercio.AutoSize = true;
            this.rbComercio.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbComercio.ForeColor = System.Drawing.Color.Lime;
            this.rbComercio.Location = new System.Drawing.Point(671, 147);
            this.rbComercio.Name = "rbComercio";
            this.rbComercio.Size = new System.Drawing.Size(213, 42);
            this.rbComercio.TabIndex = 46;
            this.rbComercio.TabStop = true;
            this.rbComercio.Text = "Rb Comercio.";
            this.rbComercio.UseVisualStyleBackColor = true;
            // 
            // rbEngenharia
            // 
            this.rbEngenharia.AutoSize = true;
            this.rbEngenharia.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbEngenharia.ForeColor = System.Drawing.Color.Cyan;
            this.rbEngenharia.Location = new System.Drawing.Point(418, 144);
            this.rbEngenharia.Name = "rbEngenharia";
            this.rbEngenharia.Size = new System.Drawing.Size(236, 42);
            this.rbEngenharia.TabIndex = 47;
            this.rbEngenharia.TabStop = true;
            this.rbEngenharia.Text = "Rb Engenharia.";
            this.rbEngenharia.UseVisualStyleBackColor = true;
            // 
            // rbPisos
            // 
            this.rbPisos.AutoSize = true;
            this.rbPisos.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbPisos.ForeColor = System.Drawing.Color.Yellow;
            this.rbPisos.Location = new System.Drawing.Point(903, 147);
            this.rbPisos.Name = "rbPisos";
            this.rbPisos.Size = new System.Drawing.Size(155, 42);
            this.rbPisos.TabIndex = 48;
            this.rbPisos.TabStop = true;
            this.rbPisos.Text = "Rb Pisos.";
            this.rbPisos.UseVisualStyleBackColor = true;
            // 
            // btnGerarId
            // 
            this.btnGerarId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGerarId.ForeColor = System.Drawing.Color.Red;
            this.btnGerarId.Location = new System.Drawing.Point(118, 21);
            this.btnGerarId.Name = "btnGerarId";
            this.btnGerarId.Size = new System.Drawing.Size(97, 38);
            this.btnGerarId.TabIndex = 45;
            this.btnGerarId.Text = "Gerar ID";
            this.btnGerarId.UseVisualStyleBackColor = true;
            this.btnGerarId.Click += new System.EventHandler(this.btnGerarId_Click);
            // 
            // txtDataId
            // 
            this.txtDataId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDataId.Enabled = false;
            this.txtDataId.Location = new System.Drawing.Point(55, 222);
            this.txtDataId.Name = "txtDataId";
            this.txtDataId.Size = new System.Drawing.Size(47, 38);
            this.txtDataId.TabIndex = 44;
            // 
            // txtIdEntrada
            // 
            this.txtIdEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIdEntrada.Enabled = false;
            this.txtIdEntrada.Location = new System.Drawing.Point(15, 21);
            this.txtIdEntrada.Name = "txtIdEntrada";
            this.txtIdEntrada.Size = new System.Drawing.Size(97, 38);
            this.txtIdEntrada.TabIndex = 44;
            // 
            // txtTotalEntrada
            // 
            this.txtTotalEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalEntrada.Enabled = false;
            this.txtTotalEntrada.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalEntrada.Location = new System.Drawing.Point(141, 144);
            this.txtTotalEntrada.Name = "txtTotalEntrada";
            this.txtTotalEntrada.Size = new System.Drawing.Size(164, 38);
            this.txtTotalEntrada.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(239, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(314, 31);
            this.label14.TabIndex = 42;
            this.label14.Text = "Tabela de entrada por datas.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(55, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 31);
            this.label13.TabIndex = 42;
            this.label13.Text = "Total:";
            // 
            // txtEntradaEstoque
            // 
            this.txtEntradaEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEntradaEstoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEntradaEstoque.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEntradaEstoque.ForeColor = System.Drawing.Color.Red;
            this.txtEntradaEstoque.Location = new System.Drawing.Point(951, 84);
            this.txtEntradaEstoque.Name = "txtEntradaEstoque";
            this.txtEntradaEstoque.Size = new System.Drawing.Size(106, 38);
            this.txtEntradaEstoque.TabIndex = 43;
            this.txtEntradaEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntradaEstoque_KeyPress_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(849, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 31);
            this.label12.TabIndex = 42;
            this.label12.Text = "Entrada:";
            // 
            // txtUndMedidaEntrada
            // 
            this.txtUndMedidaEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUndMedidaEntrada.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUndMedidaEntrada.Location = new System.Drawing.Point(738, 84);
            this.txtUndMedidaEntrada.Name = "txtUndMedidaEntrada";
            this.txtUndMedidaEntrada.Size = new System.Drawing.Size(89, 38);
            this.txtUndMedidaEntrada.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(580, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 31);
            this.label11.TabIndex = 42;
            this.label11.Text = "Und Medida:";
            // 
            // txtMaterialEntrada
            // 
            this.txtMaterialEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaterialEntrada.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaterialEntrada.Location = new System.Drawing.Point(145, 84);
            this.txtMaterialEntrada.Name = "txtMaterialEntrada";
            this.txtMaterialEntrada.Size = new System.Drawing.Size(408, 38);
            this.txtMaterialEntrada.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(29, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 31);
            this.label10.TabIndex = 42;
            this.label10.Text = "Material:";
            // 
            // txtFabrica
            // 
            this.txtFabrica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFabrica.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFabrica.Location = new System.Drawing.Point(335, 21);
            this.txtFabrica.Name = "txtFabrica";
            this.txtFabrica.Size = new System.Drawing.Size(218, 38);
            this.txtFabrica.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(233, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 31);
            this.label9.TabIndex = 42;
            this.label9.Text = "Fabrica:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(603, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 31);
            this.label8.TabIndex = 41;
            this.label8.Text = "Pedido:";
            // 
            // dtpDataPedido
            // 
            this.dtpDataPedido.AccessibleDescription = "";
            this.dtpDataPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpDataPedido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataPedido.Location = new System.Drawing.Point(703, 23);
            this.dtpDataPedido.Name = "dtpDataPedido";
            this.dtpDataPedido.Size = new System.Drawing.Size(148, 34);
            this.dtpDataPedido.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1044, 448);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletar.ForeColor = System.Drawing.Color.Black;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeletar.Location = new System.Drawing.Point(803, 370);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(159, 75);
            this.btnDeletar.TabIndex = 33;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalvar.Location = new System.Drawing.Point(799, 261);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(159, 75);
            this.btnSalvar.TabIndex = 34;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmsSalvar
            // 
            this.cmsSalvar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSalvar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSalvarDatas,
            this.cmSalvarMaterial});
            this.cmsSalvar.Name = "cmsSalvar";
            this.cmsSalvar.Size = new System.Drawing.Size(212, 68);
            // 
            // cmsSalvarDatas
            // 
            this.cmsSalvarDatas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmsSalvarDatas.ForeColor = System.Drawing.Color.Red;
            this.cmsSalvarDatas.Name = "cmsSalvarDatas";
            this.cmsSalvarDatas.Size = new System.Drawing.Size(211, 32);
            this.cmsSalvarDatas.Text = "Salvar Datas";
            this.cmsSalvarDatas.Click += new System.EventHandler(this.cmsSalvarDatas_Click);
            // 
            // cmSalvarMaterial
            // 
            this.cmSalvarMaterial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmSalvarMaterial.ForeColor = System.Drawing.Color.Red;
            this.cmSalvarMaterial.Name = "cmSalvarMaterial";
            this.cmSalvarMaterial.Size = new System.Drawing.Size(211, 32);
            this.cmSalvarMaterial.Text = "Salvar Material";
            this.cmSalvarMaterial.Click += new System.EventHandler(this.cmSalvarMaterial_Click);
            // 
            // cmsDeletar
            // 
            this.cmsDeletar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDeletar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDeletarData,
            this.cmsDeletarMaterial});
            this.cmsDeletar.Name = "cmsDeletar";
            this.cmsDeletar.Size = new System.Drawing.Size(187, 52);
            // 
            // cmsDeletarData
            // 
            this.cmsDeletarData.ForeColor = System.Drawing.Color.Red;
            this.cmsDeletarData.Name = "cmsDeletarData";
            this.cmsDeletarData.Size = new System.Drawing.Size(186, 24);
            this.cmsDeletarData.Text = "Deletar Data";
            this.cmsDeletarData.Click += new System.EventHandler(this.cmsDeletarData_Click);
            // 
            // cmsDeletarMaterial
            // 
            this.cmsDeletarMaterial.ForeColor = System.Drawing.Color.Red;
            this.cmsDeletarMaterial.Name = "cmsDeletarMaterial";
            this.cmsDeletarMaterial.Size = new System.Drawing.Size(186, 24);
            this.cmsDeletarMaterial.Text = "Deletar Material";
            this.cmsDeletarMaterial.Click += new System.EventHandler(this.cmsDeletarMaterial_Click);
            // 
            // FrmEstoqueFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1227, 693);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstoqueFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de estoque de Materiais";
            this.Load += new System.EventHandler(this.FrmEstoqueFinanceiro_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaidaMaterial)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmsSalvar.ResumeLayout(false);
            this.cmsDeletar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtMaterialSaida;
        private Label label4;
        private Button btnInserir;
        private Button btnLimparSaida;
        private TextBox txtIdSaida;
        private TextBox txtTotalEstoqueSaida;
        private TextBox txtUndMedidaSaida;
        private TextBox txtSaidaEstoque;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDeletar;
        private Button btnSalvar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtFabrica;
        private Label label9;
        private Label label8;
        private DateTimePicker dtpDataPedido;
        private Button btnGerarId;
        private TextBox txtIdEntrada;
        private TextBox txtTotalEntrada;
        private Label label13;
        private TextBox txtEntradaEstoque;
        private Label label12;
        private TextBox txtUndMedidaEntrada;
        private Label label11;
        private TextBox txtMaterialEntrada;
        private Label label10;
        private RadioButton rbComercio;
        private RadioButton rbEngenharia;
        private RadioButton rbPisos;
        private Button bntLimparEntrada;
        private DataGridView dgvData;
        private Label label14;
        private ContextMenuStrip cmsSalvar;
        private ToolStripMenuItem cmsSalvarDatas;
        private ToolStripMenuItem cmSalvarMaterial;
        private ContextMenuStrip cmsDeletar;
        private ToolStripMenuItem cmsDeletarData;
        private ToolStripMenuItem cmsDeletarMaterial;
        private TextBox txtDataId;
        private Button btnImprimir;
        private DataGridView dgvSaidaMaterial;
    }
}