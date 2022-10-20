namespace Projeto.Logistica.Sistema_do_Financeiro
{
    partial class FrmNotaFiscalFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotaFiscalFinanceiro));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtbObeservacao = new System.Windows.Forms.RichTextBox();
            this.bntLimparDados = new System.Windows.Forms.Button();
            this.btnDeletarDados = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.rbComercio = new System.Windows.Forms.RadioButton();
            this.rbEngenharia = new System.Windows.Forms.RadioButton();
            this.rbPisos = new System.Windows.Forms.RadioButton();
            this.btnGerarId = new System.Windows.Forms.Button();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.txtGerarId = new System.Windows.Forms.TextBox();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.txtProposta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtUndMedida = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtIdMaterial = new System.Windows.Forms.TextBox();
            this.txtCodigoMaterial = new System.Windows.Forms.TextBox();
            this.btnPesquisarMaterial = new System.Windows.Forms.Button();
            this.btnDeletarMaterial = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnLimparMaterial = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1208, 721);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage1.Controls.Add(this.btnPesquisarCliente);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.rtbObeservacao);
            this.tabPage1.Controls.Add(this.bntLimparDados);
            this.tabPage1.Controls.Add(this.btnDeletarDados);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.rbComercio);
            this.tabPage1.Controls.Add(this.rbEngenharia);
            this.tabPage1.Controls.Add(this.rbPisos);
            this.tabPage1.Controls.Add(this.btnGerarId);
            this.tabPage1.Controls.Add(this.txtCodigoCliente);
            this.tabPage1.Controls.Add(this.txtGerarId);
            this.tabPage1.Controls.Add(this.txtNotaFiscal);
            this.tabPage1.Controls.Add(this.txtProposta);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtEndereco);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtCliente);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dtpDataVencimento);
            this.tabPage1.Controls.Add(this.dtpDataEmissao);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1200, 677);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados da Nota Fiscal";
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarCliente.Image")));
            this.btnPesquisarCliente.Location = new System.Drawing.Point(947, 112);
            this.btnPesquisarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(38, 38);
            this.btnPesquisarCliente.TabIndex = 63;
            this.btnPesquisarCliente.UseVisualStyleBackColor = true;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1004, 542);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // rtbObeservacao
            // 
            this.rtbObeservacao.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbObeservacao.Location = new System.Drawing.Point(49, 494);
            this.rtbObeservacao.Name = "rtbObeservacao";
            this.rtbObeservacao.Size = new System.Drawing.Size(765, 158);
            this.rtbObeservacao.TabIndex = 61;
            this.rtbObeservacao.Text = "";
            // 
            // bntLimparDados
            // 
            this.bntLimparDados.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntLimparDados.ForeColor = System.Drawing.Color.Black;
            this.bntLimparDados.Image = ((System.Drawing.Image)(resources.GetObject("bntLimparDados.Image")));
            this.bntLimparDados.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bntLimparDados.Location = new System.Drawing.Point(826, 577);
            this.bntLimparDados.Name = "bntLimparDados";
            this.bntLimparDados.Size = new System.Drawing.Size(159, 75);
            this.bntLimparDados.TabIndex = 60;
            this.bntLimparDados.Text = "Limpar";
            this.bntLimparDados.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.bntLimparDados.UseVisualStyleBackColor = true;
            this.bntLimparDados.Click += new System.EventHandler(this.bntLimparDados_Click);
            // 
            // btnDeletarDados
            // 
            this.btnDeletarDados.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletarDados.ForeColor = System.Drawing.Color.Black;
            this.btnDeletarDados.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarDados.Image")));
            this.btnDeletarDados.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeletarDados.Location = new System.Drawing.Point(826, 494);
            this.btnDeletarDados.Name = "btnDeletarDados";
            this.btnDeletarDados.Size = new System.Drawing.Size(159, 75);
            this.btnDeletarDados.TabIndex = 58;
            this.btnDeletarDados.Text = "Deletar";
            this.btnDeletarDados.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDeletarDados.UseVisualStyleBackColor = true;
            this.btnDeletarDados.Click += new System.EventHandler(this.btnDeletarDados_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalvar.Location = new System.Drawing.Point(826, 413);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(159, 75);
            this.btnSalvar.TabIndex = 59;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // rbComercio
            // 
            this.rbComercio.AutoSize = true;
            this.rbComercio.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbComercio.ForeColor = System.Drawing.Color.Lime;
            this.rbComercio.Location = new System.Drawing.Point(342, 393);
            this.rbComercio.Name = "rbComercio";
            this.rbComercio.Size = new System.Drawing.Size(213, 42);
            this.rbComercio.TabIndex = 55;
            this.rbComercio.TabStop = true;
            this.rbComercio.Text = "Rb Comercio.";
            this.rbComercio.UseVisualStyleBackColor = true;
            // 
            // rbEngenharia
            // 
            this.rbEngenharia.AutoSize = true;
            this.rbEngenharia.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbEngenharia.ForeColor = System.Drawing.Color.Cyan;
            this.rbEngenharia.Location = new System.Drawing.Point(80, 393);
            this.rbEngenharia.Name = "rbEngenharia";
            this.rbEngenharia.Size = new System.Drawing.Size(236, 42);
            this.rbEngenharia.TabIndex = 56;
            this.rbEngenharia.TabStop = true;
            this.rbEngenharia.Text = "Rb Engenharia.";
            this.rbEngenharia.UseVisualStyleBackColor = true;
            // 
            // rbPisos
            // 
            this.rbPisos.AutoSize = true;
            this.rbPisos.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbPisos.ForeColor = System.Drawing.Color.Yellow;
            this.rbPisos.Location = new System.Drawing.Point(576, 393);
            this.rbPisos.Name = "rbPisos";
            this.rbPisos.Size = new System.Drawing.Size(155, 42);
            this.rbPisos.TabIndex = 57;
            this.rbPisos.TabStop = true;
            this.rbPisos.Text = "Rb Pisos.";
            this.rbPisos.UseVisualStyleBackColor = true;
            // 
            // btnGerarId
            // 
            this.btnGerarId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGerarId.ForeColor = System.Drawing.Color.Red;
            this.btnGerarId.Location = new System.Drawing.Point(136, 19);
            this.btnGerarId.Name = "btnGerarId";
            this.btnGerarId.Size = new System.Drawing.Size(97, 38);
            this.btnGerarId.TabIndex = 54;
            this.btnGerarId.Text = "Gerar ID";
            this.btnGerarId.UseVisualStyleBackColor = true;
            this.btnGerarId.Click += new System.EventHandler(this.btnGerarId_Click);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCodigoCliente.Location = new System.Drawing.Point(150, 114);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(53, 34);
            this.txtCodigoCliente.TabIndex = 53;
            this.txtCodigoCliente.TextChanged += new System.EventHandler(this.txtCodigoCliente_TextChanged);
            // 
            // txtGerarId
            // 
            this.txtGerarId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtGerarId.Enabled = false;
            this.txtGerarId.Location = new System.Drawing.Point(24, 21);
            this.txtGerarId.Name = "txtGerarId";
            this.txtGerarId.Size = new System.Drawing.Size(97, 34);
            this.txtGerarId.TabIndex = 53;
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNotaFiscal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNotaFiscal.Location = new System.Drawing.Point(614, 298);
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(201, 38);
            this.txtNotaFiscal.TabIndex = 52;
            // 
            // txtProposta
            // 
            this.txtProposta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProposta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProposta.Location = new System.Drawing.Point(186, 298);
            this.txtProposta.Name = "txtProposta";
            this.txtProposta.Size = new System.Drawing.Size(252, 38);
            this.txtProposta.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(469, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 31);
            this.label10.TabIndex = 51;
            this.label10.Text = "Nota Fiscal:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEndereco.Location = new System.Drawing.Point(49, 235);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(897, 38);
            this.txtEndereco.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(48, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 31);
            this.label7.TabIndex = 51;
            this.label7.Text = "Proposta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(49, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 31);
            this.label6.TabIndex = 51;
            this.label6.Text = "Observação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(49, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 31);
            this.label5.TabIndex = 51;
            this.label5.Text = "Endereço da nota fiscal:";
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCliente.Location = new System.Drawing.Point(209, 112);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(732, 38);
            this.txtCliente.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(49, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 31);
            this.label9.TabIndex = 51;
            this.label9.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(639, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 31);
            this.label4.TabIndex = 50;
            this.label4.Text = "Vencimento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(288, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 31);
            this.label8.TabIndex = 50;
            this.label8.Text = "Emissão:";
            // 
            // dtpDataVencimento
            // 
            this.dtpDataVencimento.AccessibleDescription = "";
            this.dtpDataVencimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpDataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataVencimento.Location = new System.Drawing.Point(793, 45);
            this.dtpDataVencimento.Name = "dtpDataVencimento";
            this.dtpDataVencimento.Size = new System.Drawing.Size(148, 34);
            this.dtpDataVencimento.TabIndex = 49;
            // 
            // dtpDataEmissao
            // 
            this.dtpDataEmissao.AccessibleDescription = "";
            this.dtpDataEmissao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataEmissao.Location = new System.Drawing.Point(400, 45);
            this.dtpDataEmissao.Name = "dtpDataEmissao";
            this.dtpDataEmissao.Size = new System.Drawing.Size(148, 34);
            this.dtpDataEmissao.TabIndex = 49;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtQuantidade);
            this.tabPage2.Controls.Add(this.txtUndMedida);
            this.tabPage2.Controls.Add(this.txtMaterial);
            this.tabPage2.Controls.Add(this.txtIdMaterial);
            this.tabPage2.Controls.Add(this.txtCodigoMaterial);
            this.tabPage2.Controls.Add(this.btnPesquisarMaterial);
            this.tabPage2.Controls.Add(this.btnDeletarMaterial);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.dgvMaterial);
            this.tabPage2.Controls.Add(this.btnInserir);
            this.tabPage2.Controls.Add(this.btnLimparMaterial);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1200, 677);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Material da nota fiscal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(499, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 31);
            this.label3.TabIndex = 64;
            this.label3.Text = "Qtd:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 64;
            this.label1.Text = "Und Medida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 64;
            this.label2.Text = "Material:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(565, 84);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(117, 38);
            this.txtQuantidade.TabIndex = 62;
            // 
            // txtUndMedida
            // 
            this.txtUndMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUndMedida.Enabled = false;
            this.txtUndMedida.Location = new System.Drawing.Point(367, 84);
            this.txtUndMedida.Name = "txtUndMedida";
            this.txtUndMedida.Size = new System.Drawing.Size(112, 38);
            this.txtUndMedida.TabIndex = 62;
            // 
            // txtMaterial
            // 
            this.txtMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaterial.Enabled = false;
            this.txtMaterial.Location = new System.Drawing.Point(277, 28);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(611, 38);
            this.txtMaterial.TabIndex = 62;
            // 
            // txtIdMaterial
            // 
            this.txtIdMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIdMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdMaterial.Enabled = false;
            this.txtIdMaterial.Location = new System.Drawing.Point(8, 6);
            this.txtIdMaterial.Name = "txtIdMaterial";
            this.txtIdMaterial.Size = new System.Drawing.Size(62, 38);
            this.txtIdMaterial.TabIndex = 63;
            // 
            // txtCodigoMaterial
            // 
            this.txtCodigoMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCodigoMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoMaterial.Enabled = false;
            this.txtCodigoMaterial.Location = new System.Drawing.Point(209, 28);
            this.txtCodigoMaterial.Name = "txtCodigoMaterial";
            this.txtCodigoMaterial.Size = new System.Drawing.Size(62, 38);
            this.txtCodigoMaterial.TabIndex = 63;
            // 
            // btnPesquisarMaterial
            // 
            this.btnPesquisarMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarMaterial.Image")));
            this.btnPesquisarMaterial.Location = new System.Drawing.Point(894, 28);
            this.btnPesquisarMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisarMaterial.Name = "btnPesquisarMaterial";
            this.btnPesquisarMaterial.Size = new System.Drawing.Size(38, 38);
            this.btnPesquisarMaterial.TabIndex = 61;
            this.btnPesquisarMaterial.UseVisualStyleBackColor = true;
            this.btnPesquisarMaterial.Click += new System.EventHandler(this.btnPesquisarMaterial_Click);
            // 
            // btnDeletarMaterial
            // 
            this.btnDeletarMaterial.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletarMaterial.ForeColor = System.Drawing.Color.Black;
            this.btnDeletarMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarMaterial.Image")));
            this.btnDeletarMaterial.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeletarMaterial.Location = new System.Drawing.Point(643, 159);
            this.btnDeletarMaterial.Name = "btnDeletarMaterial";
            this.btnDeletarMaterial.Size = new System.Drawing.Size(159, 75);
            this.btnDeletarMaterial.TabIndex = 59;
            this.btnDeletarMaterial.Text = "Deletar";
            this.btnDeletarMaterial.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDeletarMaterial.UseVisualStyleBackColor = true;
            this.btnDeletarMaterial.Click += new System.EventHandler(this.btnDeletarMaterial_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(876, 134);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMaterial.Location = new System.Drawing.Point(3, 263);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.RowHeadersWidth = 51;
            this.dgvMaterial.RowTemplate.Height = 29;
            this.dgvMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterial.Size = new System.Drawing.Size(1194, 411);
            this.dgvMaterial.TabIndex = 34;
            this.dgvMaterial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterial_CellDoubleClick);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInserir.ForeColor = System.Drawing.Color.Black;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInserir.Location = new System.Drawing.Point(277, 159);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(159, 75);
            this.btnInserir.TabIndex = 31;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnLimparMaterial
            // 
            this.btnLimparMaterial.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimparMaterial.ForeColor = System.Drawing.Color.Black;
            this.btnLimparMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparMaterial.Image")));
            this.btnLimparMaterial.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimparMaterial.Location = new System.Drawing.Point(463, 159);
            this.btnLimparMaterial.Name = "btnLimparMaterial";
            this.btnLimparMaterial.Size = new System.Drawing.Size(159, 75);
            this.btnLimparMaterial.TabIndex = 32;
            this.btnLimparMaterial.Text = "Limpar";
            this.btnLimparMaterial.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimparMaterial.UseVisualStyleBackColor = true;
            this.btnLimparMaterial.Click += new System.EventHandler(this.btnLimparMaterial_Click);
            // 
            // FrmNotaFiscalFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 721);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNotaFiscalFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar saida de Notas Fiscais";
            this.Load += new System.EventHandler(this.FrmNotaFiscalFinanceiro_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RadioButton rbComercio;
        private RadioButton rbEngenharia;
        private RadioButton rbPisos;
        private Button btnGerarId;
        private TextBox txtGerarId;
        private TextBox txtCliente;
        private Label label9;
        private Label label8;
        private DateTimePicker dtpDataEmissao;
        private Button bntLimparDados;
        private Button btnDeletarDados;
        private Button btnSalvar;
        private RichTextBox rtbObeservacao;
        private Button btnInserir;
        private Button btnLimparMaterial;
        private DataGridView dgvMaterial;
        private PictureBox pictureBox1;
        private Button btnDeletarMaterial;
        private PictureBox pictureBox2;
        private TextBox txtMaterial;
        private TextBox txtCodigoMaterial;
        private Button btnPesquisarMaterial;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtQuantidade;
        private TextBox txtUndMedida;
        private TextBox txtIdMaterial;
        private Button btnPesquisarCliente;
        private TextBox txtCodigoCliente;
        private TextBox txtEndereco;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpDataVencimento;
        private TextBox txtNotaFiscal;
        private TextBox txtProposta;
        private Label label10;
        private Label label7;
    }
}