namespace Logistica.Sistema_de_Logistica
{
    partial class FrmPrincipalLogistica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalLogistica));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.msInserir = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msFerramentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msNotaFiscal = new System.Windows.Forms.ToolStripMenuItem();
            this.msArt = new System.Windows.Forms.ToolStripMenuItem();
            this.roteiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msRoteiro = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbCancelado = new System.Windows.Forms.CheckBox();
            this.cbFinalizado = new System.Windows.Forms.CheckBox();
            this.cbPendente = new System.Windows.Forms.CheckBox();
            this.cbImediato = new System.Windows.Forms.CheckBox();
            this.rbEndereco = new System.Windows.Forms.RadioButton();
            this.rbMaterial = new System.Windows.Forms.RadioButton();
            this.rbEng = new System.Windows.Forms.RadioButton();
            this.rbNotaFiscal = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbPedidoVenda = new System.Windows.Forms.RadioButton();
            this.rbProposta = new System.Windows.Forms.RadioButton();
            this.rbPedidoRb = new System.Windows.Forms.RadioButton();
            this.rbFabrica = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvFerramenta = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFerramenta)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ferramentasToolStripMenuItem,
            this.tutorialToolStripMenuItem,
            this.roteiroToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(7, 7);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(157, 156);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msInserir});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 35);
            this.toolStripMenuItem1.Text = "Pedidos";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // msInserir
            // 
            this.msInserir.Name = "msInserir";
            this.msInserir.Size = new System.Drawing.Size(242, 36);
            this.msInserir.Text = "Inserir Pedido";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFerramentas});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(153, 35);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // msFerramentas
            // 
            this.msFerramentas.Name = "msFerramentas";
            this.msFerramentas.Size = new System.Drawing.Size(397, 36);
            this.msFerramentas.Text = "Anotar Saida de Ferramentas";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msNotaFiscal,
            this.msArt});
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(153, 35);
            this.tutorialToolStripMenuItem.Text = "Ajuda";
            this.tutorialToolStripMenuItem.Click += new System.EventHandler(this.tutorialToolStripMenuItem_Click);
            // 
            // msNotaFiscal
            // 
            this.msNotaFiscal.Name = "msNotaFiscal";
            this.msNotaFiscal.Size = new System.Drawing.Size(344, 36);
            this.msNotaFiscal.Text = "Como emitir nota fiscal ";
            // 
            // msArt
            // 
            this.msArt.Name = "msArt";
            this.msArt.Size = new System.Drawing.Size(344, 36);
            this.msArt.Text = "Como emitir ART";
            // 
            // roteiroToolStripMenuItem
            // 
            this.roteiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msRoteiro});
            this.roteiroToolStripMenuItem.Name = "roteiroToolStripMenuItem";
            this.roteiroToolStripMenuItem.Size = new System.Drawing.Size(153, 35);
            this.roteiroToolStripMenuItem.Text = "Roteiro";
            // 
            // msRoteiro
            // 
            this.msRoteiro.Name = "msRoteiro";
            this.msRoteiro.Size = new System.Drawing.Size(375, 36);
            this.msRoteiro.Text = "Saida do Roteiro Motorista";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLimparPesquisa);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.cbCancelado);
            this.panel1.Controls.Add(this.cbFinalizado);
            this.panel1.Controls.Add(this.cbPendente);
            this.panel1.Controls.Add(this.cbImediato);
            this.panel1.Controls.Add(this.rbEndereco);
            this.panel1.Controls.Add(this.rbMaterial);
            this.panel1.Controls.Add(this.rbEng);
            this.panel1.Controls.Add(this.rbNotaFiscal);
            this.panel1.Controls.Add(this.rbCliente);
            this.panel1.Controls.Add(this.rbPedidoVenda);
            this.panel1.Controls.Add(this.rbProposta);
            this.panel1.Controls.Add(this.rbPedidoRb);
            this.panel1.Controls.Add(this.rbFabrica);
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1781, 179);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1548, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1313, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Material Cancelado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(1058, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Material na Fabrica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(1313, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Material na obra";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(1058, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Material em SP";
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.Location = new System.Drawing.Point(893, 12);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(44, 38);
            this.btnLimparPesquisa.TabIndex = 8;
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(843, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(44, 38);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // cbCancelado
            // 
            this.cbCancelado.AutoSize = true;
            this.cbCancelado.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbCancelado.ForeColor = System.Drawing.Color.Red;
            this.cbCancelado.Location = new System.Drawing.Point(1313, 87);
            this.cbCancelado.Name = "cbCancelado";
            this.cbCancelado.Size = new System.Drawing.Size(173, 42);
            this.cbCancelado.TabIndex = 7;
            this.cbCancelado.Text = "Cancelado";
            this.cbCancelado.UseVisualStyleBackColor = true;
            // 
            // cbFinalizado
            // 
            this.cbFinalizado.AutoSize = true;
            this.cbFinalizado.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbFinalizado.ForeColor = System.Drawing.Color.Lime;
            this.cbFinalizado.Location = new System.Drawing.Point(1313, 22);
            this.cbFinalizado.Name = "cbFinalizado";
            this.cbFinalizado.Size = new System.Drawing.Size(172, 42);
            this.cbFinalizado.TabIndex = 7;
            this.cbFinalizado.Text = "Finalizado";
            this.cbFinalizado.UseVisualStyleBackColor = true;
            // 
            // cbPendente
            // 
            this.cbPendente.AutoSize = true;
            this.cbPendente.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbPendente.ForeColor = System.Drawing.Color.Yellow;
            this.cbPendente.Location = new System.Drawing.Point(1058, 87);
            this.cbPendente.Name = "cbPendente";
            this.cbPendente.Size = new System.Drawing.Size(162, 42);
            this.cbPendente.TabIndex = 7;
            this.cbPendente.Text = "Pendente";
            this.cbPendente.UseVisualStyleBackColor = true;
            // 
            // cbImediato
            // 
            this.cbImediato.AutoSize = true;
            this.cbImediato.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbImediato.ForeColor = System.Drawing.Color.Blue;
            this.cbImediato.Location = new System.Drawing.Point(1063, 13);
            this.cbImediato.Name = "cbImediato";
            this.cbImediato.Size = new System.Drawing.Size(157, 42);
            this.cbImediato.TabIndex = 7;
            this.cbImediato.Text = "Imediato";
            this.cbImediato.UseVisualStyleBackColor = true;
            // 
            // rbEndereco
            // 
            this.rbEndereco.AutoSize = true;
            this.rbEndereco.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbEndereco.ForeColor = System.Drawing.Color.White;
            this.rbEndereco.Location = new System.Drawing.Point(654, 113);
            this.rbEndereco.Name = "rbEndereco";
            this.rbEndereco.Size = new System.Drawing.Size(133, 35);
            this.rbEndereco.TabIndex = 6;
            this.rbEndereco.TabStop = true;
            this.rbEndereco.Text = "Endereço";
            this.rbEndereco.UseVisualStyleBackColor = true;
            // 
            // rbMaterial
            // 
            this.rbMaterial.AutoSize = true;
            this.rbMaterial.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbMaterial.ForeColor = System.Drawing.Color.White;
            this.rbMaterial.Location = new System.Drawing.Point(821, 68);
            this.rbMaterial.Name = "rbMaterial";
            this.rbMaterial.Size = new System.Drawing.Size(125, 35);
            this.rbMaterial.TabIndex = 6;
            this.rbMaterial.TabStop = true;
            this.rbMaterial.Text = "Material";
            this.rbMaterial.UseVisualStyleBackColor = true;
            // 
            // rbEng
            // 
            this.rbEng.AutoSize = true;
            this.rbEng.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbEng.ForeColor = System.Drawing.Color.White;
            this.rbEng.Location = new System.Drawing.Point(654, 68);
            this.rbEng.Name = "rbEng";
            this.rbEng.Size = new System.Drawing.Size(143, 35);
            this.rbEng.TabIndex = 6;
            this.rbEng.TabStop = true;
            this.rbEng.Text = "Eng. Resp.";
            this.rbEng.UseVisualStyleBackColor = true;
            // 
            // rbNotaFiscal
            // 
            this.rbNotaFiscal.AutoSize = true;
            this.rbNotaFiscal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbNotaFiscal.ForeColor = System.Drawing.Color.White;
            this.rbNotaFiscal.Location = new System.Drawing.Point(492, 113);
            this.rbNotaFiscal.Name = "rbNotaFiscal";
            this.rbNotaFiscal.Size = new System.Drawing.Size(153, 35);
            this.rbNotaFiscal.TabIndex = 6;
            this.rbNotaFiscal.TabStop = true;
            this.rbNotaFiscal.Text = "Nota Fiscal";
            this.rbNotaFiscal.UseVisualStyleBackColor = true;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCliente.ForeColor = System.Drawing.Color.White;
            this.rbCliente.Location = new System.Drawing.Point(492, 65);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(120, 35);
            this.rbCliente.TabIndex = 6;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Clientes";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // rbPedidoVenda
            // 
            this.rbPedidoVenda.AutoSize = true;
            this.rbPedidoVenda.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbPedidoVenda.ForeColor = System.Drawing.Color.White;
            this.rbPedidoVenda.Location = new System.Drawing.Point(340, 113);
            this.rbPedidoVenda.Name = "rbPedidoVenda";
            this.rbPedidoVenda.Size = new System.Drawing.Size(134, 35);
            this.rbPedidoVenda.TabIndex = 6;
            this.rbPedidoVenda.TabStop = true;
            this.rbPedidoVenda.Text = "Pd Venda";
            this.rbPedidoVenda.UseVisualStyleBackColor = true;
            // 
            // rbProposta
            // 
            this.rbProposta.AutoSize = true;
            this.rbProposta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbProposta.ForeColor = System.Drawing.Color.White;
            this.rbProposta.Location = new System.Drawing.Point(340, 65);
            this.rbProposta.Name = "rbProposta";
            this.rbProposta.Size = new System.Drawing.Size(131, 35);
            this.rbProposta.TabIndex = 6;
            this.rbProposta.TabStop = true;
            this.rbProposta.Text = "Proposta";
            this.rbProposta.UseVisualStyleBackColor = true;
            // 
            // rbPedidoRb
            // 
            this.rbPedidoRb.AutoSize = true;
            this.rbPedidoRb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbPedidoRb.ForeColor = System.Drawing.Color.White;
            this.rbPedidoRb.Location = new System.Drawing.Point(178, 113);
            this.rbPedidoRb.Name = "rbPedidoRb";
            this.rbPedidoRb.Size = new System.Drawing.Size(144, 35);
            this.rbPedidoRb.TabIndex = 6;
            this.rbPedidoRb.TabStop = true;
            this.rbPedidoRb.Text = "Pedido Rb";
            this.rbPedidoRb.UseVisualStyleBackColor = true;
            // 
            // rbFabrica
            // 
            this.rbFabrica.AutoSize = true;
            this.rbFabrica.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbFabrica.ForeColor = System.Drawing.Color.White;
            this.rbFabrica.Location = new System.Drawing.Point(178, 65);
            this.rbFabrica.Name = "rbFabrica";
            this.rbFabrica.Size = new System.Drawing.Size(111, 35);
            this.rbFabrica.TabIndex = 6;
            this.rbFabrica.TabStop = true;
            this.rbFabrica.Text = "Fabrica";
            this.rbFabrica.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisar.Location = new System.Drawing.Point(178, 10);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(659, 38);
            this.txtPesquisar.TabIndex = 5;
            this.txtPesquisar.Text = "Digite para pesquisar:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 179);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1781, 610);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPrincipal);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1773, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrincipal.Location = new System.Drawing.Point(3, 3);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.RowHeadersWidth = 51;
            this.dgvPrincipal.Size = new System.Drawing.Size(1767, 560);
            this.dgvPrincipal.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvFerramenta);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1773, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ferramentas Obra";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvFerramenta
            // 
            this.dgvFerramenta.AllowUserToAddRows = false;
            this.dgvFerramenta.AllowUserToDeleteRows = false;
            this.dgvFerramenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFerramenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFerramenta.Location = new System.Drawing.Point(3, 3);
            this.dgvFerramenta.Name = "dgvFerramenta";
            this.dgvFerramenta.ReadOnly = true;
            this.dgvFerramenta.RowHeadersWidth = 51;
            this.dgvFerramenta.Size = new System.Drawing.Size(1767, 560);
            this.dgvFerramenta.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1773, 566);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tipo de Calculo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1773, 566);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tabela Carretos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipalLogistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1781, 789);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipalLogistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFerramenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem propostaToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private ToolStripMenuItem tutorialToolStripMenuItem;
        private ToolStripMenuItem roteiroToolStripMenuItem;
        private ToolStripMenuItem msInserir;
        private ToolStripMenuItem msFerramentas;
        private ToolStripMenuItem msNotaFiscal;
        private ToolStripMenuItem msArt;
        private ToolStripMenuItem msRoteiro;
        private Panel panel1;
        private CheckBox cbCancelado;
        private CheckBox cbFinalizado;
        private CheckBox cbPendente;
        private CheckBox cbImediato;
        private RadioButton rbEndereco;
        private RadioButton rbMaterial;
        private RadioButton rbEng;
        private RadioButton rbNotaFiscal;
        private RadioButton rbCliente;
        private RadioButton rbPedidoVenda;
        private RadioButton rbProposta;
        private RadioButton rbPedidoRb;
        private RadioButton rbFabrica;
        private TextBox txtPesquisar;
        private Button btnLimparPesquisa;
        private Button btnPesquisar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label1;
        private DataGridView dgvPrincipal;
        private DataGridView dgvFerramenta;
        private PictureBox pictureBox1;
    }
}