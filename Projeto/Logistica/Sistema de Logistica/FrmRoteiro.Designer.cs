namespace Projeto.Logistica.Sistema_de_Logistica
{
    partial class FrmRoteiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoteiro));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.btnLimparEntrada = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProposta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGerarId = new System.Windows.Forms.Button();
            this.txtGerarId = new System.Windows.Forms.TextBox();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvRoteiroMotorista = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDeletarItens = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtUndMedida = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtSaidaObra = new System.Windows.Forms.TextBox();
            this.txtCodigoItensMaterial = new System.Windows.Forms.TextBox();
            this.btnPesquisarMaterial = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvSaidaMaterial = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoteiroMotorista)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaidaMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 704);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage1.Controls.Add(this.dtpSaida);
            this.tabPage1.Controls.Add(this.btnLimparEntrada);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.txtFuncionario);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtObra);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtProposta);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnGerarId);
            this.tabPage1.Controls.Add(this.txtGerarId);
            this.tabPage1.Controls.Add(this.btnEstoque);
            this.tabPage1.Controls.Add(this.btnDeletar);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.dgvRoteiroMotorista);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(915, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informações da obra";
            // 
            // dtpSaida
            // 
            this.dtpSaida.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaida.Location = new System.Drawing.Point(445, 18);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(148, 37);
            this.dtpSaida.TabIndex = 58;
            // 
            // btnLimparEntrada
            // 
            this.btnLimparEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimparEntrada.ForeColor = System.Drawing.Color.Black;
            this.btnLimparEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparEntrada.Image")));
            this.btnLimparEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparEntrada.Location = new System.Drawing.Point(211, 207);
            this.btnLimparEntrada.Name = "btnLimparEntrada";
            this.btnLimparEntrada.Size = new System.Drawing.Size(129, 68);
            this.btnLimparEntrada.TabIndex = 57;
            this.btnLimparEntrada.Text = "Limpar";
            this.btnLimparEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparEntrada.UseVisualStyleBackColor = true;
            this.btnLimparEntrada.Click += new System.EventHandler(this.btnLimparEntrada_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(702, 165);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFuncionario.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFuncionario.Location = new System.Drawing.Point(182, 140);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(266, 38);
            this.txtFuncionario.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 51;
            this.label1.Text = "Funcionario:";
            // 
            // txtObra
            // 
            this.txtObra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObra.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObra.Location = new System.Drawing.Point(106, 86);
            this.txtObra.Name = "txtObra";
            this.txtObra.Size = new System.Drawing.Size(573, 38);
            this.txtObra.TabIndex = 54;
            this.txtObra.TextChanged += new System.EventHandler(this.txtObra_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 31);
            this.label5.TabIndex = 51;
            this.label5.Text = "Obra:";
            // 
            // txtProposta
            // 
            this.txtProposta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProposta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProposta.Location = new System.Drawing.Point(139, 17);
            this.txtProposta.Name = "txtProposta";
            this.txtProposta.Size = new System.Drawing.Size(171, 38);
            this.txtProposta.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(340, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 31);
            this.label13.TabIndex = 52;
            this.label13.Text = "Saida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 31);
            this.label4.TabIndex = 53;
            this.label4.Text = "Proposta:";
            // 
            // btnGerarId
            // 
            this.btnGerarId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGerarId.ForeColor = System.Drawing.Color.Red;
            this.btnGerarId.Location = new System.Drawing.Point(752, 17);
            this.btnGerarId.Name = "btnGerarId";
            this.btnGerarId.Size = new System.Drawing.Size(97, 38);
            this.btnGerarId.TabIndex = 50;
            this.btnGerarId.Text = "Gerar ID";
            this.btnGerarId.UseVisualStyleBackColor = true;
            this.btnGerarId.Click += new System.EventHandler(this.btnGerarId_Click);
            // 
            // txtGerarId
            // 
            this.txtGerarId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtGerarId.Enabled = false;
            this.txtGerarId.Location = new System.Drawing.Point(649, 19);
            this.txtGerarId.Name = "txtGerarId";
            this.txtGerarId.Size = new System.Drawing.Size(97, 34);
            this.txtGerarId.TabIndex = 49;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEstoque.ForeColor = System.Drawing.Color.Black;
            this.btnEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.Image")));
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(526, 207);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(129, 68);
            this.btnEstoque.TabIndex = 47;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeletar.ForeColor = System.Drawing.Color.Black;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(377, 207);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(129, 68);
            this.btnDeletar.TabIndex = 47;
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
            this.btnSalvar.Location = new System.Drawing.Point(47, 207);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(129, 68);
            this.btnSalvar.TabIndex = 48;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvRoteiroMotorista
            // 
            this.dgvRoteiroMotorista.AllowUserToAddRows = false;
            this.dgvRoteiroMotorista.AllowUserToDeleteRows = false;
            this.dgvRoteiroMotorista.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoteiroMotorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoteiroMotorista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRoteiroMotorista.Location = new System.Drawing.Point(3, 317);
            this.dgvRoteiroMotorista.Name = "dgvRoteiroMotorista";
            this.dgvRoteiroMotorista.ReadOnly = true;
            this.dgvRoteiroMotorista.RowHeadersWidth = 51;
            this.dgvRoteiroMotorista.RowTemplate.Height = 29;
            this.dgvRoteiroMotorista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoteiroMotorista.Size = new System.Drawing.Size(909, 343);
            this.dgvRoteiroMotorista.TabIndex = 0;
            this.dgvRoteiroMotorista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoteiroMotorista_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage2.Controls.Add(this.btnLimpar);
            this.tabPage2.Controls.Add(this.btnDeletarItens);
            this.tabPage2.Controls.Add(this.btnInserir);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtQuantidade);
            this.tabPage2.Controls.Add(this.txtUndMedida);
            this.tabPage2.Controls.Add(this.txtMaterial);
            this.tabPage2.Controls.Add(this.txtSaidaObra);
            this.tabPage2.Controls.Add(this.txtCodigoItensMaterial);
            this.tabPage2.Controls.Add(this.btnPesquisarMaterial);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.dgvSaidaMaterial);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(915, 663);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Saida de material para obra.";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(334, 234);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(159, 43);
            this.btnLimpar.TabIndex = 53;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDeletarItens
            // 
            this.btnDeletarItens.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletarItens.ForeColor = System.Drawing.Color.Black;
            this.btnDeletarItens.Location = new System.Drawing.Point(520, 234);
            this.btnDeletarItens.Name = "btnDeletarItens";
            this.btnDeletarItens.Size = new System.Drawing.Size(159, 43);
            this.btnDeletarItens.TabIndex = 54;
            this.btnDeletarItens.Text = "Deletar";
            this.btnDeletarItens.UseVisualStyleBackColor = true;
            this.btnDeletarItens.Click += new System.EventHandler(this.btnDeletarItens_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInserir.ForeColor = System.Drawing.Color.Black;
            this.btnInserir.Location = new System.Drawing.Point(143, 234);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(159, 43);
            this.btnInserir.TabIndex = 55;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(500, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 31);
            this.label6.TabIndex = 52;
            this.label6.Text = "Qtd:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(134, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 31);
            this.label3.TabIndex = 52;
            this.label3.Text = "Und Medida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 52;
            this.label2.Text = "Material:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(566, 157);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 34);
            this.txtQuantidade.TabIndex = 17;
            this.txtQuantidade.Text = "0,0";
            // 
            // txtUndMedida
            // 
            this.txtUndMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUndMedida.Enabled = false;
            this.txtUndMedida.Location = new System.Drawing.Point(292, 157);
            this.txtUndMedida.Name = "txtUndMedida";
            this.txtUndMedida.Size = new System.Drawing.Size(173, 34);
            this.txtUndMedida.TabIndex = 17;
            // 
            // txtMaterial
            // 
            this.txtMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaterial.Enabled = false;
            this.txtMaterial.Location = new System.Drawing.Point(208, 90);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(458, 34);
            this.txtMaterial.TabIndex = 17;
            // 
            // txtSaidaObra
            // 
            this.txtSaidaObra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSaidaObra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaidaObra.Location = new System.Drawing.Point(8, 15);
            this.txtSaidaObra.Name = "txtSaidaObra";
            this.txtSaidaObra.Size = new System.Drawing.Size(62, 34);
            this.txtSaidaObra.TabIndex = 18;
            // 
            // txtCodigoItensMaterial
            // 
            this.txtCodigoItensMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCodigoItensMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoItensMaterial.Location = new System.Drawing.Point(134, 90);
            this.txtCodigoItensMaterial.Name = "txtCodigoItensMaterial";
            this.txtCodigoItensMaterial.Size = new System.Drawing.Size(62, 34);
            this.txtCodigoItensMaterial.TabIndex = 19;
            // 
            // btnPesquisarMaterial
            // 
            this.btnPesquisarMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarMaterial.Image")));
            this.btnPesquisarMaterial.Location = new System.Drawing.Point(672, 88);
            this.btnPesquisarMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisarMaterial.Name = "btnPesquisarMaterial";
            this.btnPesquisarMaterial.Size = new System.Drawing.Size(38, 38);
            this.btnPesquisarMaterial.TabIndex = 16;
            this.btnPesquisarMaterial.UseVisualStyleBackColor = true;
            this.btnPesquisarMaterial.Click += new System.EventHandler(this.btnPesquisarMaterial_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(-244, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 28);
            this.label14.TabIndex = 15;
            this.label14.Text = "Material:";
            // 
            // dgvSaidaMaterial
            // 
            this.dgvSaidaMaterial.AllowUserToAddRows = false;
            this.dgvSaidaMaterial.AllowUserToDeleteRows = false;
            this.dgvSaidaMaterial.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaidaMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaidaMaterial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSaidaMaterial.Location = new System.Drawing.Point(3, 316);
            this.dgvSaidaMaterial.Name = "dgvSaidaMaterial";
            this.dgvSaidaMaterial.ReadOnly = true;
            this.dgvSaidaMaterial.RowHeadersWidth = 51;
            this.dgvSaidaMaterial.RowTemplate.Height = 29;
            this.dgvSaidaMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaidaMaterial.Size = new System.Drawing.Size(909, 344);
            this.dgvSaidaMaterial.TabIndex = 1;
            this.dgvSaidaMaterial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaidaMaterial_CellDoubleClick);
            // 
            // FrmRoteiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 704);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRoteiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saida de material no roteiro do motorista.";
            this.Load += new System.EventHandler(this.FrmRoteiro_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoteiroMotorista)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaidaMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvRoteiroMotorista;
        private DataGridView dgvSaidaMaterial;
        private DateTimePicker dtpSaida;
        private Button btnLimparEntrada;
        private PictureBox pictureBox2;
        private TextBox txtFuncionario;
        private Label label1;
        private TextBox txtObra;
        private Label label5;
        private TextBox txtProposta;
        private Label label13;
        private Label label4;
        private Button btnGerarId;
        private TextBox txtGerarId;
        private Button btnEstoque;
        private Button btnDeletar;
        private Button btnSalvar;
        private Label label2;
        private TextBox txtMaterial;
        private TextBox txtSaidaObra;
        private TextBox txtCodigoItensMaterial;
        private Button btnPesquisarMaterial;
        private Label label14;
        private Button btnLimpar;
        private Button btnDeletarItens;
        private Button btnInserir;
        private Label label6;
        private Label label3;
        private TextBox txtQuantidade;
        private TextBox txtUndMedida;
    }
}