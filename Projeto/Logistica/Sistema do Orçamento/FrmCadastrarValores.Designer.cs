namespace Projeto.Logistica.Sistema_do_Orçamento
{
    partial class FrmCadastrarValores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarValores));
            this.cmsSalvarConteudos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mtSalvarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.mtSalvarData = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.btnGerarId = new System.Windows.Forms.Button();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDataId = new System.Windows.Forms.TextBox();
            this.dtpDataAtualizada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRendimento = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.msDeletarData = new System.Windows.Forms.ToolStripMenuItem();
            this.msDeletarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbComentario = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmsSalvarConteudos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsSalvarConteudos
            // 
            this.cmsSalvarConteudos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSalvarConteudos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtSalvarProduto,
            this.mtSalvarData});
            this.cmsSalvarConteudos.Name = "contextMenuStrip1";
            this.cmsSalvarConteudos.Size = new System.Drawing.Size(182, 52);
            // 
            // mtSalvarProduto
            // 
            this.mtSalvarProduto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtSalvarProduto.ForeColor = System.Drawing.Color.Red;
            this.mtSalvarProduto.Name = "mtSalvarProduto";
            this.mtSalvarProduto.Size = new System.Drawing.Size(181, 24);
            this.mtSalvarProduto.Text = "Salvar Data";
            this.mtSalvarProduto.Click += new System.EventHandler(this.mtSalvarProduto_Click);
            // 
            // mtSalvarData
            // 
            this.mtSalvarData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtSalvarData.ForeColor = System.Drawing.Color.Red;
            this.mtSalvarData.Name = "mtSalvarData";
            this.mtSalvarData.Size = new System.Drawing.Size(181, 24);
            this.mtSalvarData.Text = "Salvar Produto";
            this.mtSalvarData.Click += new System.EventHandler(this.mtSalvarData_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalvar.Location = new System.Drawing.Point(28, 578);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(159, 75);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletar.ForeColor = System.Drawing.Color.Black;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeletar.Location = new System.Drawing.Point(240, 578);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(159, 75);
            this.btnDeletar.TabIndex = 16;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLimpar.Location = new System.Drawing.Point(450, 578);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(159, 75);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(728, 84);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 29;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(431, 277);
            this.dgvData.TabIndex = 17;
            this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatas_CellDoubleClick);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFornecedor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFornecedor.Location = new System.Drawing.Point(30, 118);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(661, 38);
            this.txtFornecedor.TabIndex = 21;
            // 
            // btnGerarId
            // 
            this.btnGerarId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGerarId.ForeColor = System.Drawing.Color.Red;
            this.btnGerarId.Location = new System.Drawing.Point(115, 21);
            this.btnGerarId.Name = "btnGerarId";
            this.btnGerarId.Size = new System.Drawing.Size(97, 38);
            this.btnGerarId.TabIndex = 20;
            this.btnGerarId.Text = "Gerar ID";
            this.btnGerarId.UseVisualStyleBackColor = true;
            this.btnGerarId.Click += new System.EventHandler(this.btnGerarId_Click);
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIdProduto.Enabled = false;
            this.txtIdProduto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdProduto.Location = new System.Drawing.Point(12, 21);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(97, 38);
            this.txtIdProduto.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(30, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 31);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fornecedor:";
            // 
            // txtDataId
            // 
            this.txtDataId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDataId.Enabled = false;
            this.txtDataId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataId.Location = new System.Drawing.Point(1110, 14);
            this.txtDataId.Name = "txtDataId";
            this.txtDataId.Size = new System.Drawing.Size(49, 38);
            this.txtDataId.TabIndex = 19;
            // 
            // dtpDataAtualizada
            // 
            this.dtpDataAtualizada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpDataAtualizada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataAtualizada.Location = new System.Drawing.Point(478, 21);
            this.dtpDataAtualizada.Name = "dtpDataAtualizada";
            this.dtpDataAtualizada.Size = new System.Drawing.Size(148, 34);
            this.dtpDataAtualizada.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(297, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Atualizado em:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Produto:";
            // 
            // txtProduto
            // 
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProduto.Location = new System.Drawing.Point(30, 236);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(661, 38);
            this.txtProduto.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPreco.Location = new System.Drawing.Point(33, 347);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(154, 38);
            this.txtPreco.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Rendimento:";
            // 
            // txtRendimento
            // 
            this.txtRendimento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRendimento.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRendimento.Location = new System.Drawing.Point(30, 479);
            this.txtRendimento.Name = "txtRendimento";
            this.txtRendimento.Size = new System.Drawing.Size(502, 38);
            this.txtRendimento.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msDeletarData,
            this.msDeletarProduto});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 52);
            // 
            // msDeletarData
            // 
            this.msDeletarData.ForeColor = System.Drawing.Color.Red;
            this.msDeletarData.Name = "msDeletarData";
            this.msDeletarData.Size = new System.Drawing.Size(184, 24);
            this.msDeletarData.Text = "Deletar Data";
            this.msDeletarData.Click += new System.EventHandler(this.msDeletarData_Click);
            // 
            // msDeletarProduto
            // 
            this.msDeletarProduto.ForeColor = System.Drawing.Color.Red;
            this.msDeletarProduto.Name = "msDeletarProduto";
            this.msDeletarProduto.Size = new System.Drawing.Size(184, 24);
            this.msDeletarProduto.Text = "Deletar Produto";
            this.msDeletarProduto.Click += new System.EventHandler(this.msDeletarProduto_Click);
            // 
            // rtbComentario
            // 
            this.rtbComentario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbComentario.Location = new System.Drawing.Point(704, 444);
            this.rtbComentario.Name = "rtbComentario";
            this.rtbComentario.Size = new System.Drawing.Size(455, 209);
            this.rtbComentario.TabIndex = 24;
            this.rtbComentario.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(704, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Comentario:";
            // 
            // FrmCadastrarValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1171, 713);
            this.Controls.Add(this.rtbComentario);
            this.Controls.Add(this.dtpDataAtualizada);
            this.Controls.Add(this.txtRendimento);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.btnGerarId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDataId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarValores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar produtos.";
            this.Load += new System.EventHandler(this.FrmCadastrarValores_Load);
            this.cmsSalvarConteudos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip cmsSalvarConteudos;
        private ToolStripMenuItem mtSalvarProduto;
        private ToolStripMenuItem mtSalvarData;
        private Button btnSalvar;
        private Button btnDeletar;
        private Button btnLimpar;
        private DataGridView dgvData;
        private TextBox txtFornecedor;
        private Button btnGerarId;
        private TextBox txtIdProduto;
        private Label label10;
        private TextBox txtDataId;
        private DateTimePicker dtpDataAtualizada;
        private Label label1;
        private Label label2;
        private TextBox txtProduto;
        private Label label3;
        private TextBox txtPreco;
        private Label label4;
        private TextBox txtRendimento;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem msDeletarData;
        private ToolStripMenuItem msDeletarProduto;
        private RichTextBox rtbComentario;
        private Label label5;
    }
}