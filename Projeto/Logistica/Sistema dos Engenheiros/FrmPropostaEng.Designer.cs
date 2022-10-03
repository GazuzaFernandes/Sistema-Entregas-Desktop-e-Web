namespace Projeto.Logistica.Sistema_dos_Engenheiros
{
    partial class FrmPropostaEng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPropostaEng));
            this.dgvitensProposta = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDeletarProposta = new System.Windows.Forms.Button();
            this.btnSalvarProposta = new System.Windows.Forms.Button();
            this.rtbComentario = new System.Windows.Forms.RichTextBox();
            this.rbCancelado = new System.Windows.Forms.RadioButton();
            this.rbFinalizado = new System.Windows.Forms.RadioButton();
            this.rbPendente = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbComentado = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtObra = new System.Windows.Forms.TextBox();
            this.txtProposta = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEngResponsavel = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtItensPropostaId = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.btnDeletarComentario = new System.Windows.Forms.Button();
            this.btnLimparComentario = new System.Windows.Forms.Button();
            this.txtIdHistorico = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dtpHistorico = new System.Windows.Forms.DateTimePicker();
            this.dtpDataPedido = new System.Windows.Forms.DateTimePicker();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnGerarId = new System.Windows.Forms.Button();
            this.mtSalvarComentario = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSalvarConteudos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mtSalvarProposta = new System.Windows.Forms.ToolStripMenuItem();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPropostId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label29 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbMaterial = new System.Windows.Forms.RichTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtQtdUndCaixa = new System.Windows.Forms.TextBox();
            this.txtQtdCaixas = new System.Windows.Forms.TextBox();
            this.txtUndMedida = new System.Windows.Forms.TextBox();
            this.txtCodigoItensMaterial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitensProposta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.cmsSalvarConteudos.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvitensProposta
            // 
            this.dgvitensProposta.AllowUserToAddRows = false;
            this.dgvitensProposta.AllowUserToDeleteRows = false;
            this.dgvitensProposta.BackgroundColor = System.Drawing.Color.White;
            this.dgvitensProposta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvitensProposta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvitensProposta.Location = new System.Drawing.Point(0, 0);
            this.dgvitensProposta.Name = "dgvitensProposta";
            this.dgvitensProposta.ReadOnly = true;
            this.dgvitensProposta.RowHeadersWidth = 51;
            this.dgvitensProposta.RowTemplate.Height = 29;
            this.dgvitensProposta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvitensProposta.Size = new System.Drawing.Size(1419, 272);
            this.dgvitensProposta.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(11, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 31);
            this.label14.TabIndex = 11;
            this.label14.Text = "Material:";
            // 
            // btnDeletarProposta
            // 
            this.btnDeletarProposta.ForeColor = System.Drawing.Color.Red;
            this.btnDeletarProposta.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarProposta.Image")));
            this.btnDeletarProposta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeletarProposta.Location = new System.Drawing.Point(1071, 521);
            this.btnDeletarProposta.Name = "btnDeletarProposta";
            this.btnDeletarProposta.Size = new System.Drawing.Size(159, 75);
            this.btnDeletarProposta.TabIndex = 15;
            this.btnDeletarProposta.Text = "Proposta";
            this.btnDeletarProposta.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDeletarProposta.UseVisualStyleBackColor = true;
            this.btnDeletarProposta.Click += new System.EventHandler(this.btnDeletarProposta_Click);
            // 
            // btnSalvarProposta
            // 
            this.btnSalvarProposta.ForeColor = System.Drawing.Color.Red;
            this.btnSalvarProposta.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarProposta.Image")));
            this.btnSalvarProposta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalvarProposta.Location = new System.Drawing.Point(1071, 399);
            this.btnSalvarProposta.Name = "btnSalvarProposta";
            this.btnSalvarProposta.Size = new System.Drawing.Size(159, 75);
            this.btnSalvarProposta.TabIndex = 15;
            this.btnSalvarProposta.Text = "Salvar";
            this.btnSalvarProposta.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSalvarProposta.UseVisualStyleBackColor = true;
            this.btnSalvarProposta.Click += new System.EventHandler(this.btnSalvarProposta_Click);
            // 
            // rtbComentario
            // 
            this.rtbComentario.Location = new System.Drawing.Point(36, 373);
            this.rtbComentario.Name = "rtbComentario";
            this.rtbComentario.Size = new System.Drawing.Size(1013, 223);
            this.rtbComentario.TabIndex = 14;
            this.rtbComentario.Text = "";
            // 
            // rbCancelado
            // 
            this.rbCancelado.AutoSize = true;
            this.rbCancelado.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCancelado.ForeColor = System.Drawing.Color.Red;
            this.rbCancelado.Location = new System.Drawing.Point(1084, 292);
            this.rbCancelado.Name = "rbCancelado";
            this.rbCancelado.Size = new System.Drawing.Size(180, 42);
            this.rbCancelado.TabIndex = 13;
            this.rbCancelado.TabStop = true;
            this.rbCancelado.Text = "Cancelado.";
            this.rbCancelado.UseVisualStyleBackColor = true;
            // 
            // rbFinalizado
            // 
            this.rbFinalizado.AutoSize = true;
            this.rbFinalizado.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbFinalizado.ForeColor = System.Drawing.Color.Lime;
            this.rbFinalizado.Location = new System.Drawing.Point(1084, 232);
            this.rbFinalizado.Name = "rbFinalizado";
            this.rbFinalizado.Size = new System.Drawing.Size(179, 42);
            this.rbFinalizado.TabIndex = 13;
            this.rbFinalizado.TabStop = true;
            this.rbFinalizado.Text = "Finalizado.";
            this.rbFinalizado.UseVisualStyleBackColor = true;
            // 
            // rbPendente
            // 
            this.rbPendente.AutoSize = true;
            this.rbPendente.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbPendente.ForeColor = System.Drawing.Color.Yellow;
            this.rbPendente.Location = new System.Drawing.Point(1084, 164);
            this.rbPendente.Name = "rbPendente";
            this.rbPendente.Size = new System.Drawing.Size(159, 42);
            this.rbPendente.TabIndex = 13;
            this.rbPendente.TabStop = true;
            this.rbPendente.Text = "Em Obra.";
            this.rbPendente.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1262, 491);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(320, 106);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 31);
            this.label21.TabIndex = 11;
            this.label21.Text = "R$";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(142, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 31);
            this.label15.TabIndex = 11;
            this.label15.Text = "Qtd:";
            // 
            // cbComentado
            // 
            this.cbComentado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComentado.FormattingEnabled = true;
            this.cbComentado.Items.AddRange(new object[] {
            "Adriana",
            "Elias",
            "Rodrigo",
            "Alex"});
            this.cbComentado.Location = new System.Drawing.Point(786, 307);
            this.cbComentado.Name = "cbComentado";
            this.cbComentado.Size = new System.Drawing.Size(243, 39);
            this.cbComentado.TabIndex = 11;
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Location = new System.Drawing.Point(515, 101);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(534, 38);
            this.txtCliente.TabIndex = 10;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(480, 106);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(152, 31);
            this.label22.TabIndex = 11;
            this.label22.Text = "Und Medida:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvitensProposta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 272);
            this.panel1.TabIndex = 0;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1082, 99);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(182, 38);
            this.txtTotal.TabIndex = 14;
            // 
            // txtObra
            // 
            this.txtObra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObra.Location = new System.Drawing.Point(111, 242);
            this.txtObra.Name = "txtObra";
            this.txtObra.Size = new System.Drawing.Size(852, 38);
            this.txtObra.TabIndex = 10;
            // 
            // txtProposta
            // 
            this.txtProposta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProposta.Enabled = false;
            this.txtProposta.Location = new System.Drawing.Point(665, 24);
            this.txtProposta.Name = "txtProposta";
            this.txtProposta.Size = new System.Drawing.Size(191, 38);
            this.txtProposta.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefone.Location = new System.Drawing.Point(662, 168);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(301, 38);
            this.txtTelefone.TabIndex = 10;
            // 
            // txtEngResponsavel
            // 
            this.txtEngResponsavel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEngResponsavel.Location = new System.Drawing.Point(180, 168);
            this.txtEngResponsavel.Name = "txtEngResponsavel";
            this.txtEngResponsavel.Size = new System.Drawing.Size(344, 38);
            this.txtEngResponsavel.TabIndex = 10;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpresa.Location = new System.Drawing.Point(134, 101);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(263, 38);
            this.txtEmpresa.TabIndex = 10;
            // 
            // txtItensPropostaId
            // 
            this.txtItensPropostaId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtItensPropostaId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtItensPropostaId.Location = new System.Drawing.Point(1465, 6);
            this.txtItensPropostaId.Name = "txtItensPropostaId";
            this.txtItensPropostaId.Size = new System.Drawing.Size(62, 38);
            this.txtItensPropostaId.TabIndex = 14;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(468, 84);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(407, 45);
            this.label27.TabIndex = 20;
            this.label27.Text = "Historico de Comentario.";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage3.Controls.Add(this.dgvHistorico);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.btnDeletarComentario);
            this.tabPage3.Controls.Add(this.btnLimparComentario);
            this.tabPage3.Controls.Add(this.txtIdHistorico);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1425, 624);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Historico da Proposta";
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.AllowUserToAddRows = false;
            this.dgvHistorico.AllowUserToDeleteRows = false;
            this.dgvHistorico.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHistorico.Location = new System.Drawing.Point(0, 88);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.ReadOnly = true;
            this.dgvHistorico.RowHeadersWidth = 51;
            this.dgvHistorico.RowTemplate.Height = 29;
            this.dgvHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorico.Size = new System.Drawing.Size(1425, 536);
            this.dgvHistorico.TabIndex = 21;
            this.dgvHistorico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorico_CellDoubleClick);
            // 
            // btnDeletarComentario
            // 
            this.btnDeletarComentario.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletarComentario.ForeColor = System.Drawing.Color.Black;
            this.btnDeletarComentario.Location = new System.Drawing.Point(700, 22);
            this.btnDeletarComentario.Name = "btnDeletarComentario";
            this.btnDeletarComentario.Size = new System.Drawing.Size(159, 38);
            this.btnDeletarComentario.TabIndex = 19;
            this.btnDeletarComentario.Text = "Deletar";
            this.btnDeletarComentario.UseVisualStyleBackColor = true;
            this.btnDeletarComentario.Click += new System.EventHandler(this.btnDeletarComentario_Click);
            // 
            // btnLimparComentario
            // 
            this.btnLimparComentario.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimparComentario.ForeColor = System.Drawing.Color.Black;
            this.btnLimparComentario.Location = new System.Drawing.Point(523, 22);
            this.btnLimparComentario.Name = "btnLimparComentario";
            this.btnLimparComentario.Size = new System.Drawing.Size(159, 38);
            this.btnLimparComentario.TabIndex = 18;
            this.btnLimparComentario.Text = "Limpar";
            this.btnLimparComentario.UseVisualStyleBackColor = true;
            this.btnLimparComentario.Click += new System.EventHandler(this.btnLimparComentario_Click);
            // 
            // txtIdHistorico
            // 
            this.txtIdHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIdHistorico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdHistorico.Enabled = false;
            this.txtIdHistorico.Location = new System.Drawing.Point(444, 22);
            this.txtIdHistorico.Name = "txtIdHistorico";
            this.txtIdHistorico.Size = new System.Drawing.Size(62, 38);
            this.txtIdHistorico.TabIndex = 17;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(1012, 106);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 31);
            this.label24.TabIndex = 11;
            this.label24.Text = "Total";
            // 
            // dtpHistorico
            // 
            this.dtpHistorico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpHistorico.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHistorico.Location = new System.Drawing.Point(428, 309);
            this.dtpHistorico.Name = "dtpHistorico";
            this.dtpHistorico.Size = new System.Drawing.Size(148, 34);
            this.dtpHistorico.TabIndex = 3;
            // 
            // dtpDataPedido
            // 
            this.dtpDataPedido.AccessibleDescription = "";
            this.dtpDataPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpDataPedido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataPedido.Location = new System.Drawing.Point(376, 26);
            this.dtpDataPedido.Name = "dtpDataPedido";
            this.dtpDataPedido.Size = new System.Drawing.Size(148, 34);
            this.dtpDataPedido.TabIndex = 3;
            // 
            // txtPreco
            // 
            this.txtPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(365, 99);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(106, 38);
            this.txtPreco.TabIndex = 13;
            this.txtPreco.Text = "0,0";
            // 
            // txtMaterial
            // 
            this.txtMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaterial.Enabled = false;
            this.txtMaterial.Location = new System.Drawing.Point(205, 32);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(987, 38);
            this.txtMaterial.TabIndex = 13;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(760, 106);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 31);
            this.label23.TabIndex = 11;
            this.label23.Text = "Qtd Caixas:";
            // 
            // btnGerarId
            // 
            this.btnGerarId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGerarId.ForeColor = System.Drawing.Color.Red;
            this.btnGerarId.Location = new System.Drawing.Point(134, 26);
            this.btnGerarId.Name = "btnGerarId";
            this.btnGerarId.Size = new System.Drawing.Size(97, 38);
            this.btnGerarId.TabIndex = 2;
            this.btnGerarId.Text = "Gerar ID";
            this.btnGerarId.UseVisualStyleBackColor = true;
            this.btnGerarId.Click += new System.EventHandler(this.btnGerarId_Click);
            // 
            // mtSalvarComentario
            // 
            this.mtSalvarComentario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtSalvarComentario.ForeColor = System.Drawing.Color.Red;
            this.mtSalvarComentario.Name = "mtSalvarComentario";
            this.mtSalvarComentario.Size = new System.Drawing.Size(206, 24);
            this.mtSalvarComentario.Text = "Salvar Comentario";
            this.mtSalvarComentario.Click += new System.EventHandler(this.mtSalvarComentario_Click);
            // 
            // cmsSalvarConteudos
            // 
            this.cmsSalvarConteudos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSalvarConteudos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtSalvarProposta,
            this.mtSalvarComentario});
            this.cmsSalvarConteudos.Name = "contextMenuStrip1";
            this.cmsSalvarConteudos.Size = new System.Drawing.Size(207, 52);
            // 
            // mtSalvarProposta
            // 
            this.mtSalvarProposta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtSalvarProposta.ForeColor = System.Drawing.Color.Red;
            this.mtSalvarProposta.Name = "mtSalvarProposta";
            this.mtSalvarProposta.Size = new System.Drawing.Size(206, 24);
            this.mtSalvarProposta.Text = "Salvar Proposta";
            this.mtSalvarProposta.Click += new System.EventHandler(this.mtSalvarProposta_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(205, 99);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(106, 38);
            this.txtQuantidade.TabIndex = 13;
            this.txtQuantidade.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(36, 311);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(386, 31);
            this.label16.TabIndex = 0;
            this.label16.Text = "Comentario e Data do Comentario.";
            // 
            // txtPropostId
            // 
            this.txtPropostId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPropostId.Enabled = false;
            this.txtPropostId.Location = new System.Drawing.Point(31, 26);
            this.txtPropostId.Name = "txtPropostId";
            this.txtPropostId.Size = new System.Drawing.Size(97, 38);
            this.txtPropostId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(279, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pedido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(592, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Comentado por:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1433, 668);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage1.Controls.Add(this.btnDeletarProposta);
            this.tabPage1.Controls.Add(this.btnSalvarProposta);
            this.tabPage1.Controls.Add(this.rtbComentario);
            this.tabPage1.Controls.Add(this.rbCancelado);
            this.tabPage1.Controls.Add(this.rbFinalizado);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Controls.Add(this.rbPendente);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.cbComentado);
            this.tabPage1.Controls.Add(this.txtCliente);
            this.tabPage1.Controls.Add(this.txtObra);
            this.tabPage1.Controls.Add(this.txtProposta);
            this.tabPage1.Controls.Add(this.txtTelefone);
            this.tabPage1.Controls.Add(this.txtEngResponsavel);
            this.tabPage1.Controls.Add(this.txtEmpresa);
            this.tabPage1.Controls.Add(this.dtpHistorico);
            this.tabPage1.Controls.Add(this.dtpDataPedido);
            this.tabPage1.Controls.Add(this.btnGerarId);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.txtPropostId);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1425, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados da Proposta";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.ForeColor = System.Drawing.Color.Blue;
            this.radioButton1.Location = new System.Drawing.Point(1084, 68);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(187, 80);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pendente \r\nde entrega.";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(536, 172);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(111, 31);
            this.label29.TabIndex = 0;
            this.label29.Text = "Telefone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(36, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 31);
            this.label11.TabIndex = 0;
            this.label11.Text = "Obra:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(26, 172);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(151, 31);
            this.label28.TabIndex = 0;
            this.label28.Text = "Responsavel:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(536, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "Proposta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(415, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fábrica:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage2.Controls.Add(this.rtbMaterial);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.txtQtdUndCaixa);
            this.tabPage2.Controls.Add(this.txtQtdCaixas);
            this.tabPage2.Controls.Add(this.txtUndMedida);
            this.tabPage2.Controls.Add(this.txtPreco);
            this.tabPage2.Controls.Add(this.txtQuantidade);
            this.tabPage2.Controls.Add(this.txtMaterial);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.txtTotal);
            this.tabPage2.Controls.Add(this.txtItensPropostaId);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.txtCodigoItensMaterial);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1425, 624);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Itens da Propsota";
            // 
            // rtbMaterial
            // 
            this.rtbMaterial.Enabled = false;
            this.rtbMaterial.Location = new System.Drawing.Point(151, 197);
            this.rtbMaterial.Name = "rtbMaterial";
            this.rtbMaterial.Size = new System.Drawing.Size(833, 122);
            this.rtbMaterial.TabIndex = 18;
            this.rtbMaterial.Text = "";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(151, 152);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(222, 31);
            this.label26.TabIndex = 17;
            this.label26.Text = "Informe o Material:";
            // 
            // txtQtdUndCaixa
            // 
            this.txtQtdUndCaixa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdUndCaixa.Enabled = false;
            this.txtQtdUndCaixa.Location = new System.Drawing.Point(1209, 32);
            this.txtQtdUndCaixa.Name = "txtQtdUndCaixa";
            this.txtQtdUndCaixa.Size = new System.Drawing.Size(88, 38);
            this.txtQtdUndCaixa.TabIndex = 13;
            // 
            // txtQtdCaixas
            // 
            this.txtQtdCaixas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQtdCaixas.Enabled = false;
            this.txtQtdCaixas.Location = new System.Drawing.Point(897, 99);
            this.txtQtdCaixas.Name = "txtQtdCaixas";
            this.txtQtdCaixas.Size = new System.Drawing.Size(106, 38);
            this.txtQtdCaixas.TabIndex = 13;
            this.txtQtdCaixas.Text = "0";
            // 
            // txtUndMedida
            // 
            this.txtUndMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUndMedida.Enabled = false;
            this.txtUndMedida.Location = new System.Drawing.Point(635, 99);
            this.txtUndMedida.Name = "txtUndMedida";
            this.txtUndMedida.Size = new System.Drawing.Size(106, 38);
            this.txtUndMedida.TabIndex = 13;
            this.txtUndMedida.Text = "m²";
            // 
            // txtCodigoItensMaterial
            // 
            this.txtCodigoItensMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCodigoItensMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoItensMaterial.Enabled = false;
            this.txtCodigoItensMaterial.Location = new System.Drawing.Point(124, 32);
            this.txtCodigoItensMaterial.Name = "txtCodigoItensMaterial";
            this.txtCodigoItensMaterial.Size = new System.Drawing.Size(62, 38);
            this.txtCodigoItensMaterial.TabIndex = 14;
            // 
            // FrmPropostaEng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1433, 668);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPropostaEng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações da Proposta";
            this.Load += new System.EventHandler(this.FrmPropostaEng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvitensProposta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.cmsSalvarConteudos.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvitensProposta;
        private Label label14;
        private Button btnDeletarProposta;
        private Button btnSalvarProposta;
        private RichTextBox rtbComentario;
        private RadioButton rbCancelado;
        private RadioButton rbFinalizado;
        private RadioButton rbPendente;
        private PictureBox pictureBox1;
        private Label label21;
        private Label label15;
        private ComboBox cbComentado;
        private TextBox txtCliente;
        private Label label22;
        private Panel panel1;
        private TextBox txtTotal;
        private TextBox txtObra;
        private TextBox txtProposta;
        private TextBox txtTelefone;
        private TextBox txtEngResponsavel;
        private TextBox txtEmpresa;
        private TextBox txtItensPropostaId;
        private Label label27;
        private TabPage tabPage3;
        private DataGridView dgvHistorico;
        private Button btnDeletarComentario;
        private Button btnLimparComentario;
        private TextBox txtIdHistorico;
        private Label label24;
        private DateTimePicker dtpHistorico;
        private DateTimePicker dtpDataPedido;
        private TextBox txtPreco;
        private TextBox txtMaterial;
        private Label label23;
        private Button btnGerarId;
        private ToolStripMenuItem mtSalvarComentario;
        private ContextMenuStrip cmsSalvarConteudos;
        private ToolStripMenuItem mtSalvarProposta;
        private TextBox txtQuantidade;
        private Label label16;
        private TextBox txtPropostId;
        private Label label2;
        private Label label6;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label29;
        private Label label11;
        private Label label28;
        private Label label10;
        private Label label7;
        private Label label1;
        private TabPage tabPage2;
        private RichTextBox rtbMaterial;
        private Label label26;
        private TextBox txtQtdUndCaixa;
        private TextBox txtQtdCaixas;
        private TextBox txtUndMedida;
        private RadioButton radioButton1;
        private TextBox txtCodigoItensMaterial;
    }
}