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
            this.btnDeletarProposta = new System.Windows.Forms.Button();
            this.btnSalvarProposta = new System.Windows.Forms.Button();
            this.rtbComentario = new System.Windows.Forms.RichTextBox();
            this.rbCancelado = new System.Windows.Forms.RadioButton();
            this.rbFinalizado = new System.Windows.Forms.RadioButton();
            this.rbPendente = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbComentado = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtObra = new System.Windows.Forms.TextBox();
            this.txtProposta = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEngResponsavel = new System.Windows.Forms.TextBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.btnDeletarComentario = new System.Windows.Forms.Button();
            this.btnLimparComentario = new System.Windows.Forms.Button();
            this.txtIdHistorico = new System.Windows.Forms.TextBox();
            this.dtpHistorico = new System.Windows.Forms.DateTimePicker();
            this.dtpDataIncluido = new System.Windows.Forms.DateTimePicker();
            this.btnGerarId = new System.Windows.Forms.Button();
            this.mtSalvarComentario = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSalvarConteudos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mtSalvarProposta = new System.Windows.Forms.ToolStripMenuItem();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPropostId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.cmsSalvarConteudos.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeletarProposta
            // 
            this.btnDeletarProposta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletarProposta.ForeColor = System.Drawing.Color.Black;
            this.btnDeletarProposta.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarProposta.Image")));
            this.btnDeletarProposta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeletarProposta.Location = new System.Drawing.Point(1071, 502);
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
            this.btnSalvarProposta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarProposta.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarProposta.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarProposta.Image")));
            this.btnSalvarProposta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalvarProposta.Location = new System.Drawing.Point(1071, 373);
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
            this.rbCancelado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCancelado.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCancelado.ForeColor = System.Drawing.Color.Red;
            this.rbCancelado.Location = new System.Drawing.Point(1071, 311);
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
            this.rbFinalizado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFinalizado.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbFinalizado.ForeColor = System.Drawing.Color.Lime;
            this.rbFinalizado.Location = new System.Drawing.Point(1071, 241);
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
            this.rbPendente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPendente.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbPendente.ForeColor = System.Drawing.Color.Yellow;
            this.rbPendente.Location = new System.Drawing.Point(1071, 172);
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
            // cbComentado
            // 
            this.cbComentado.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.txtCliente.Location = new System.Drawing.Point(180, 96);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(534, 38);
            this.txtCliente.TabIndex = 10;
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
            // txtFuncionario
            // 
            this.txtFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFuncionario.Location = new System.Drawing.Point(929, 96);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(263, 38);
            this.txtFuncionario.TabIndex = 10;
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
            this.btnDeletarComentario.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnLimparComentario.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.txtIdHistorico.Visible = false;
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
            // dtpDataIncluido
            // 
            this.dtpDataIncluido.AccessibleDescription = "";
            this.dtpDataIncluido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpDataIncluido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataIncluido.Location = new System.Drawing.Point(376, 26);
            this.dtpDataIncluido.Name = "dtpDataIncluido";
            this.dtpDataIncluido.Size = new System.Drawing.Size(148, 34);
            this.dtpDataIncluido.TabIndex = 3;
            // 
            // btnGerarId
            // 
            this.btnGerarId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGerarId.ForeColor = System.Drawing.Color.Red;
            this.btnGerarId.Location = new System.Drawing.Point(36, 26);
            this.btnGerarId.Name = "btnGerarId";
            this.btnGerarId.Size = new System.Drawing.Size(195, 38);
            this.btnGerarId.TabIndex = 2;
            this.btnGerarId.Text = "Gerar Proposta";
            this.btnGerarId.UseVisualStyleBackColor = true;
            this.btnGerarId.Click += new System.EventHandler(this.btnGerarId_Click);
            // 
            // mtSalvarComentario
            // 
            this.mtSalvarComentario.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtSalvarComentario.ForeColor = System.Drawing.Color.Red;
            this.mtSalvarComentario.Name = "mtSalvarComentario";
            this.mtSalvarComentario.Size = new System.Drawing.Size(280, 36);
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
            this.cmsSalvarConteudos.Size = new System.Drawing.Size(281, 76);
            // 
            // mtSalvarProposta
            // 
            this.mtSalvarProposta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtSalvarProposta.ForeColor = System.Drawing.Color.Red;
            this.mtSalvarProposta.Name = "mtSalvarProposta";
            this.mtSalvarProposta.Size = new System.Drawing.Size(280, 36);
            this.mtSalvarProposta.Text = "Salvar Proposta";
            this.mtSalvarProposta.Click += new System.EventHandler(this.mtSalvarProposta_Click_1);
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
            this.txtPropostId.Location = new System.Drawing.Point(11, 100);
            this.txtPropostId.Name = "txtPropostId";
            this.txtPropostId.Size = new System.Drawing.Size(25, 38);
            this.txtPropostId.TabIndex = 1;
            this.txtPropostId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(262, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Incluido:";
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
            this.tabPage1.Controls.Add(this.rbPendente);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.cbComentado);
            this.tabPage1.Controls.Add(this.txtCliente);
            this.tabPage1.Controls.Add(this.txtObra);
            this.tabPage1.Controls.Add(this.txtProposta);
            this.tabPage1.Controls.Add(this.txtTelefone);
            this.tabPage1.Controls.Add(this.txtEngResponsavel);
            this.tabPage1.Controls.Add(this.txtFuncionario);
            this.tabPage1.Controls.Add(this.dtpHistorico);
            this.tabPage1.Controls.Add(this.dtpDataIncluido);
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
            this.label7.Location = new System.Drawing.Point(80, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(775, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionario:";
            // 
            // FrmPropostaEng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1433, 668);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPropostaEng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações da Proposta";
            this.Load += new System.EventHandler(this.FrmPropostaEng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.cmsSalvarConteudos.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnDeletarProposta;
        private Button btnSalvarProposta;
        private RichTextBox rtbComentario;
        private RadioButton rbCancelado;
        private RadioButton rbFinalizado;
        private RadioButton rbPendente;
        private PictureBox pictureBox1;
        private ComboBox cbComentado;
        private TextBox txtCliente;
        private TextBox txtObra;
        private TextBox txtProposta;
        private TextBox txtTelefone;
        private TextBox txtEngResponsavel;
        private TextBox txtFuncionario;
        private Label label27;
        private TabPage tabPage3;
        private DataGridView dgvHistorico;
        private Button btnDeletarComentario;
        private Button btnLimparComentario;
        private TextBox txtIdHistorico;
        private DateTimePicker dtpHistorico;
        private DateTimePicker dtpDataIncluido;
        private Button btnGerarId;
        private ToolStripMenuItem mtSalvarComentario;
        private ContextMenuStrip cmsSalvarConteudos;
        private ToolStripMenuItem mtSalvarProposta;
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
    }
}