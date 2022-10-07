namespace Projeto.Logistica.Sistema_de_Logistica
{
    partial class FrmEstoqueMadeira
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoqueMadeira));
            this.cmsDeletarMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDeletar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsDeletarData = new System.Windows.Forms.ToolStripMenuItem();
            this.cmSalvarMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSalvarDatas = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSalvar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnLimparEntrada = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rbPendente = new System.Windows.Forms.RadioButton();
            this.btnGerarId = new System.Windows.Forms.Button();
            this.txtDataId = new System.Windows.Forms.TextBox();
            this.txtIdEntrada = new System.Windows.Forms.TextBox();
            this.txtTotalM3Entrada = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalM2Entrada = new System.Windows.Forms.TextBox();
            this.txtMetroEntrada = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLarguraEntrada = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEspessuraEntrada = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaterialEntrada = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtTotalM2Saida = new System.Windows.Forms.TextBox();
            this.dgvSaidaMaterial = new System.Windows.Forms.DataGridView();
            this.btnBaixarEstoque = new System.Windows.Forms.Button();
            this.btnLimparSaida = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbCancelado = new System.Windows.Forms.RadioButton();
            this.rtbSaida = new System.Windows.Forms.RichTextBox();
            this.txtTotalM3Saida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMetroSaida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLarguraSaida = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEspessuraSaida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaterialSaida = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtIdSaida = new System.Windows.Forms.TextBox();
            this.cmsDeletar.SuspendLayout();
            this.cmsSalvar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaidaMaterial)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsDeletarMaterial
            // 
            this.cmsDeletarMaterial.ForeColor = System.Drawing.Color.Red;
            this.cmsDeletarMaterial.Name = "cmsDeletarMaterial";
            this.cmsDeletarMaterial.Size = new System.Drawing.Size(186, 24);
            this.cmsDeletarMaterial.Text = "Deletar Material";
            this.cmsDeletarMaterial.Click += new System.EventHandler(this.cmsDeletarMaterial_Click);
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
            // cmSalvarMaterial
            // 
            this.cmSalvarMaterial.ForeColor = System.Drawing.Color.Red;
            this.cmSalvarMaterial.Name = "cmSalvarMaterial";
            this.cmSalvarMaterial.Size = new System.Drawing.Size(177, 24);
            this.cmSalvarMaterial.Text = "Salvar Material";
            this.cmSalvarMaterial.Click += new System.EventHandler(this.cmSalvarMaterial_Click);
            // 
            // cmsSalvarDatas
            // 
            this.cmsSalvarDatas.ForeColor = System.Drawing.Color.Red;
            this.cmsSalvarDatas.Name = "cmsSalvarDatas";
            this.cmsSalvarDatas.Size = new System.Drawing.Size(177, 24);
            this.cmsSalvarDatas.Text = "Salvar Datas";
            this.cmsSalvarDatas.Click += new System.EventHandler(this.cmsSalvarDatas_Click);
            // 
            // cmsSalvar
            // 
            this.cmsSalvar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSalvar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSalvarDatas,
            this.cmSalvarMaterial});
            this.cmsSalvar.Name = "cmsSalvar";
            this.cmsSalvar.Size = new System.Drawing.Size(178, 52);
            // 
            // btnLimparEntrada
            // 
            this.btnLimparEntrada.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimparEntrada.ForeColor = System.Drawing.Color.Black;
            this.btnLimparEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparEntrada.Image")));
            this.btnLimparEntrada.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimparEntrada.Location = new System.Drawing.Point(818, 530);
            this.btnLimparEntrada.Name = "btnLimparEntrada";
            this.btnLimparEntrada.Size = new System.Drawing.Size(159, 75);
            this.btnLimparEntrada.TabIndex = 50;
            this.btnLimparEntrada.Text = "Limpar";
            this.btnLimparEntrada.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimparEntrada.UseVisualStyleBackColor = true;
            this.btnLimparEntrada.Click += new System.EventHandler(this.bntLimparEntrada_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(55, 308);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 29;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(730, 341);
            this.dgvData.TabIndex = 49;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
            this.dgvData.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvData_DataBindingComplete);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage2.Controls.Add(this.rbPendente);
            this.tabPage2.Controls.Add(this.btnLimparEntrada);
            this.tabPage2.Controls.Add(this.dgvData);
            this.tabPage2.Controls.Add(this.btnGerarId);
            this.tabPage2.Controls.Add(this.txtDataId);
            this.tabPage2.Controls.Add(this.txtIdEntrada);
            this.tabPage2.Controls.Add(this.txtTotalM3Entrada);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtTotalM2Entrada);
            this.tabPage2.Controls.Add(this.txtMetroEntrada);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtLarguraEntrada);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtEspessuraEntrada);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtMaterialEntrada);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dtpEntrada);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnDeletar);
            this.tabPage2.Controls.Add(this.btnSalvar);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1229, 670);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Entrada Material";
            // 
            // rbPendente
            // 
            this.rbPendente.AutoSize = true;
            this.rbPendente.Checked = true;
            this.rbPendente.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbPendente.ForeColor = System.Drawing.Color.Lime;
            this.rbPendente.Location = new System.Drawing.Point(818, 237);
            this.rbPendente.Name = "rbPendente";
            this.rbPendente.Size = new System.Drawing.Size(147, 42);
            this.rbPendente.TabIndex = 52;
            this.rbPendente.TabStop = true;
            this.rbPendente.Text = "Entrada.";
            this.rbPendente.UseVisualStyleBackColor = true;
            // 
            // btnGerarId
            // 
            this.btnGerarId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGerarId.ForeColor = System.Drawing.Color.Red;
            this.btnGerarId.Location = new System.Drawing.Point(118, 21);
            this.btnGerarId.Name = "btnGerarId";
            this.btnGerarId.Size = new System.Drawing.Size(97, 38);
            this.btnGerarId.TabIndex = 45;
            this.btnGerarId.Text = "Liberar";
            this.btnGerarId.UseVisualStyleBackColor = true;
            this.btnGerarId.Click += new System.EventHandler(this.btnGerarId_Click);
            // 
            // txtDataId
            // 
            this.txtDataId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDataId.Enabled = false;
            this.txtDataId.Location = new System.Drawing.Point(791, 611);
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
            // txtTotalM3Entrada
            // 
            this.txtTotalM3Entrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalM3Entrada.Enabled = false;
            this.txtTotalM3Entrada.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalM3Entrada.Location = new System.Drawing.Point(1064, 174);
            this.txtTotalM3Entrada.Name = "txtTotalM3Entrada";
            this.txtTotalM3Entrada.Size = new System.Drawing.Size(118, 38);
            this.txtTotalM3Entrada.TabIndex = 43;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.Yellow;
            this.label17.Location = new System.Drawing.Point(983, 333);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(223, 155);
            this.label17.TabIndex = 42;
            this.label17.Text = "Und Medida mm:\r\n1,8cm = 18mm\r\n20cm = 200mm\r\nApenas para\r\nEspessura e Largura\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(55, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(344, 31);
            this.label14.TabIndex = 42;
            this.label14.Text = "Tabela de Entrada de Madeiras.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(714, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 31);
            this.label5.TabIndex = 42;
            this.label5.Text = "Total m²:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(947, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 31);
            this.label13.TabIndex = 42;
            this.label13.Text = "Total m³:";
            // 
            // txtTotalM2Entrada
            // 
            this.txtTotalM2Entrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalM2Entrada.Enabled = false;
            this.txtTotalM2Entrada.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalM2Entrada.Location = new System.Drawing.Point(829, 175);
            this.txtTotalM2Entrada.Name = "txtTotalM2Entrada";
            this.txtTotalM2Entrada.Size = new System.Drawing.Size(88, 38);
            this.txtTotalM2Entrada.TabIndex = 43;
            this.txtTotalM2Entrada.TextChanged += new System.EventHandler(this.txtTotalM2Entrada_TextChanged);
            // 
            // txtMetroEntrada
            // 
            this.txtMetroEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMetroEntrada.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMetroEntrada.Location = new System.Drawing.Point(628, 174);
            this.txtMetroEntrada.Name = "txtMetroEntrada";
            this.txtMetroEntrada.Size = new System.Drawing.Size(73, 38);
            this.txtMetroEntrada.TabIndex = 43;
            this.txtMetroEntrada.TextChanged += new System.EventHandler(this.txtMetroEntrada_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(454, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 31);
            this.label12.TabIndex = 42;
            this.label12.Text = "Metro Linear:";
            // 
            // txtLarguraEntrada
            // 
            this.txtLarguraEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLarguraEntrada.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLarguraEntrada.Location = new System.Drawing.Point(359, 174);
            this.txtLarguraEntrada.Name = "txtLarguraEntrada";
            this.txtLarguraEntrada.Size = new System.Drawing.Size(89, 38);
            this.txtLarguraEntrada.TabIndex = 43;
            this.txtLarguraEntrada.TextChanged += new System.EventHandler(this.txtLarguraEntrada_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(251, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 31);
            this.label11.TabIndex = 42;
            this.label11.Text = "Largura:";
            // 
            // txtEspessuraEntrada
            // 
            this.txtEspessuraEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEspessuraEntrada.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEspessuraEntrada.Location = new System.Drawing.Point(153, 174);
            this.txtEspessuraEntrada.Name = "txtEspessuraEntrada";
            this.txtEspessuraEntrada.Size = new System.Drawing.Size(80, 38);
            this.txtEspessuraEntrada.TabIndex = 43;
            this.txtEspessuraEntrada.TextChanged += new System.EventHandler(this.txtEspessuraEntrada_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(24, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 31);
            this.label10.TabIndex = 42;
            this.label10.Text = "Espessura:";
            // 
            // txtMaterialEntrada
            // 
            this.txtMaterialEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaterialEntrada.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaterialEntrada.Location = new System.Drawing.Point(243, 104);
            this.txtMaterialEntrada.Name = "txtMaterialEntrada";
            this.txtMaterialEntrada.Size = new System.Drawing.Size(955, 38);
            this.txtMaterialEntrada.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(22, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 31);
            this.label9.TabIndex = 42;
            this.label9.Text = "Nome da Madeira:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(353, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 31);
            this.label8.TabIndex = 41;
            this.label8.Text = "Data de Entrada:";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.AccessibleDescription = "";
            this.dtpEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEntrada.Location = new System.Drawing.Point(549, 26);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(148, 34);
            this.dtpEntrada.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1051, 539);
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
            this.btnDeletar.Location = new System.Drawing.Point(818, 413);
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
            this.btnSalvar.Location = new System.Drawing.Point(818, 297);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(159, 75);
            this.btnSalvar.TabIndex = 34;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtTotalM2Saida
            // 
            this.txtTotalM2Saida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalM2Saida.Enabled = false;
            this.txtTotalM2Saida.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalM2Saida.Location = new System.Drawing.Point(851, 85);
            this.txtTotalM2Saida.Name = "txtTotalM2Saida";
            this.txtTotalM2Saida.Size = new System.Drawing.Size(118, 38);
            this.txtTotalM2Saida.TabIndex = 43;
            // 
            // dgvSaidaMaterial
            // 
            this.dgvSaidaMaterial.AllowUserToAddRows = false;
            this.dgvSaidaMaterial.AllowUserToDeleteRows = false;
            this.dgvSaidaMaterial.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaidaMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaidaMaterial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSaidaMaterial.Location = new System.Drawing.Point(3, 282);
            this.dgvSaidaMaterial.Name = "dgvSaidaMaterial";
            this.dgvSaidaMaterial.ReadOnly = true;
            this.dgvSaidaMaterial.RowHeadersWidth = 51;
            this.dgvSaidaMaterial.RowTemplate.Height = 29;
            this.dgvSaidaMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaidaMaterial.Size = new System.Drawing.Size(1223, 385);
            this.dgvSaidaMaterial.TabIndex = 33;
            this.dgvSaidaMaterial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaidaMaterial_CellDoubleClick);
            // 
            // btnBaixarEstoque
            // 
            this.btnBaixarEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBaixarEstoque.ForeColor = System.Drawing.Color.Black;
            this.btnBaixarEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnBaixarEstoque.Image")));
            this.btnBaixarEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaixarEstoque.Location = new System.Drawing.Point(13, 183);
            this.btnBaixarEstoque.Name = "btnBaixarEstoque";
            this.btnBaixarEstoque.Size = new System.Drawing.Size(159, 60);
            this.btnBaixarEstoque.TabIndex = 29;
            this.btnBaixarEstoque.Text = "Baixa";
            this.btnBaixarEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaixarEstoque.UseVisualStyleBackColor = true;
            this.btnBaixarEstoque.Click += new System.EventHandler(this.btnBaixarEstoque_Click);
            // 
            // btnLimparSaida
            // 
            this.btnLimparSaida.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimparSaida.ForeColor = System.Drawing.Color.Black;
            this.btnLimparSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparSaida.Image")));
            this.btnLimparSaida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparSaida.Location = new System.Drawing.Point(198, 183);
            this.btnLimparSaida.Name = "btnLimparSaida";
            this.btnLimparSaida.Size = new System.Drawing.Size(190, 60);
            this.btnLimparSaida.TabIndex = 30;
            this.btnLimparSaida.Text = "Limpar";
            this.btnLimparSaida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparSaida.UseVisualStyleBackColor = true;
            this.btnLimparSaida.Click += new System.EventHandler(this.btnLimparSaida_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1237, 714);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage1.Controls.Add(this.rbCancelado);
            this.tabPage1.Controls.Add(this.rtbSaida);
            this.tabPage1.Controls.Add(this.txtTotalM2Saida);
            this.tabPage1.Controls.Add(this.txtTotalM3Saida);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtMetroSaida);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtLarguraSaida);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtEspessuraSaida);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtMaterialSaida);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtpSaida);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.txtIdSaida);
            this.tabPage1.Controls.Add(this.dgvSaidaMaterial);
            this.tabPage1.Controls.Add(this.btnBaixarEstoque);
            this.tabPage1.Controls.Add(this.btnLimparSaida);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1229, 670);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Saida Material";
            // 
            // rbCancelado
            // 
            this.rbCancelado.AutoSize = true;
            this.rbCancelado.Checked = true;
            this.rbCancelado.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCancelado.ForeColor = System.Drawing.Color.Red;
            this.rbCancelado.Location = new System.Drawing.Point(19, 128);
            this.rbCancelado.Name = "rbCancelado";
            this.rbCancelado.Size = new System.Drawing.Size(117, 42);
            this.rbCancelado.TabIndex = 57;
            this.rbCancelado.TabStop = true;
            this.rbCancelado.Text = "Saida.";
            this.rbCancelado.UseVisualStyleBackColor = true;
            // 
            // rtbSaida
            // 
            this.rtbSaida.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbSaida.Location = new System.Drawing.Point(416, 183);
            this.rtbSaida.Name = "rtbSaida";
            this.rtbSaida.Size = new System.Drawing.Size(611, 76);
            this.rtbSaida.TabIndex = 56;
            this.rtbSaida.Text = "";
            // 
            // txtTotalM3Saida
            // 
            this.txtTotalM3Saida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalM3Saida.Enabled = false;
            this.txtTotalM3Saida.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalM3Saida.Location = new System.Drawing.Point(1092, 84);
            this.txtTotalM3Saida.Name = "txtTotalM3Saida";
            this.txtTotalM3Saida.Size = new System.Drawing.Size(118, 38);
            this.txtTotalM3Saida.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(731, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 44;
            this.label1.Text = "Total m²:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(975, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 45;
            this.label2.Text = "Total m³:";
            // 
            // txtMetroSaida
            // 
            this.txtMetroSaida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMetroSaida.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMetroSaida.Location = new System.Drawing.Point(640, 84);
            this.txtMetroSaida.Name = "txtMetroSaida";
            this.txtMetroSaida.Size = new System.Drawing.Size(73, 38);
            this.txtMetroSaida.TabIndex = 52;
            this.txtMetroSaida.TextChanged += new System.EventHandler(this.txtMetroSaida_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(466, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 31);
            this.label3.TabIndex = 46;
            this.label3.Text = "Metro Linear:";
            // 
            // txtLarguraSaida
            // 
            this.txtLarguraSaida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLarguraSaida.Enabled = false;
            this.txtLarguraSaida.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLarguraSaida.Location = new System.Drawing.Point(349, 84);
            this.txtLarguraSaida.Name = "txtLarguraSaida";
            this.txtLarguraSaida.Size = new System.Drawing.Size(89, 38);
            this.txtLarguraSaida.TabIndex = 53;
            this.txtLarguraSaida.TextChanged += new System.EventHandler(this.txtLarguraSaida_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(570, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(288, 31);
            this.label16.TabIndex = 47;
            this.label16.Text = "Observação sobre a saida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(241, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 31);
            this.label4.TabIndex = 47;
            this.label4.Text = "Largura:";
            // 
            // txtEspessuraSaida
            // 
            this.txtEspessuraSaida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEspessuraSaida.Enabled = false;
            this.txtEspessuraSaida.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEspessuraSaida.Location = new System.Drawing.Point(142, 84);
            this.txtEspessuraSaida.Name = "txtEspessuraSaida";
            this.txtEspessuraSaida.Size = new System.Drawing.Size(80, 38);
            this.txtEspessuraSaida.TabIndex = 54;
            this.txtEspessuraSaida.TextChanged += new System.EventHandler(this.txtEspessuraSaida_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 31);
            this.label7.TabIndex = 48;
            this.label7.Text = "Espessura:";
            // 
            // txtMaterialSaida
            // 
            this.txtMaterialSaida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaterialSaida.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaterialSaida.Location = new System.Drawing.Point(290, 18);
            this.txtMaterialSaida.Name = "txtMaterialSaida";
            this.txtMaterialSaida.Size = new System.Drawing.Size(612, 38);
            this.txtMaterialSaida.TabIndex = 55;
            this.txtMaterialSaida.TextChanged += new System.EventHandler(this.txtMaterialSaida_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(73, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(211, 31);
            this.label15.TabIndex = 49;
            this.label15.Text = "Nome da Madeira:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(908, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 31);
            this.label6.TabIndex = 43;
            this.label6.Text = "Data Saida:";
            // 
            // dtpSaida
            // 
            this.dtpSaida.AccessibleDescription = "";
            this.dtpSaida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaida.Location = new System.Drawing.Point(1048, 22);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(148, 34);
            this.dtpSaida.TabIndex = 42;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1063, 149);
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
            // FrmEstoqueMadeira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1237, 714);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstoqueMadeira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de madeiras em estoque.";
            this.Load += new System.EventHandler(this.FrmEstoqueMadeira_Load);
            this.Click += new System.EventHandler(this.FrmEstoqueMadeira_Click);
            this.cmsDeletar.ResumeLayout(false);
            this.cmsSalvar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaidaMaterial)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStripMenuItem cmsDeletarMaterial;
        private ContextMenuStrip cmsDeletar;
        private ToolStripMenuItem cmsDeletarData;
        private ToolStripMenuItem cmSalvarMaterial;
        private ToolStripMenuItem cmsSalvarDatas;
        private ContextMenuStrip cmsSalvar;
        private Button btnLimparEntrada;
        private DataGridView dgvData;
        private TabPage tabPage2;
        private Button btnGerarId;
        private TextBox txtDataId;
        private TextBox txtIdEntrada;
        private TextBox txtTotalM3Entrada;
        private Label label14;
        private Label label13;
        private TextBox txtMetroEntrada;
        private Label label12;
        private TextBox txtLarguraEntrada;
        private Label label11;
        private TextBox txtEspessuraEntrada;
        private Label label10;
        private TextBox txtMaterialEntrada;
        private Label label9;
        private Label label8;
        private DateTimePicker dtpEntrada;
        private PictureBox pictureBox1;
        private Button btnDeletar;
        private Button btnSalvar;
        private DataGridView dgvSaidaMaterial;
        private Button btnBaixarEstoque;
        private Button btnLimparSaida;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private PictureBox pictureBox2;
        private TextBox txtIdSaida;
        private TextBox txtTotalM2Saida;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpSaida;
        private RichTextBox rtbSaida;
        private TextBox txtTotalM2Entrada;
        private TextBox txtTotalM3Saida;
        private Label label1;
        private Label label2;
        private TextBox txtMetroSaida;
        private Label label3;
        private TextBox txtLarguraSaida;
        private Label label16;
        private Label label4;
        private TextBox txtEspessuraSaida;
        private Label label7;
        private TextBox txtMaterialSaida;
        private Label label15;
        private Label label17;
        private RadioButton rbPendente;
        private RadioButton rbCancelado;
    }
}