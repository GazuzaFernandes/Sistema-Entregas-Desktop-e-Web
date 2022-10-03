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
            this.mtSalvarProposta = new System.Windows.Forms.ToolStripMenuItem();
            this.mtSalvarComentario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalvarProposta = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgvDatas = new System.Windows.Forms.DataGridView();
            this.txtProposta = new System.Windows.Forms.TextBox();
            this.btnGerarId = new System.Windows.Forms.Button();
            this.txtPropostId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cmsSalvarConteudos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatas)).BeginInit();
            this.SuspendLayout();
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
            // 
            // mtSalvarComentario
            // 
            this.mtSalvarComentario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtSalvarComentario.ForeColor = System.Drawing.Color.Red;
            this.mtSalvarComentario.Name = "mtSalvarComentario";
            this.mtSalvarComentario.Size = new System.Drawing.Size(206, 24);
            this.mtSalvarComentario.Text = "Salvar Comentario";
            // 
            // btnSalvarProposta
            // 
            this.btnSalvarProposta.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarProposta.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarProposta.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarProposta.Image")));
            this.btnSalvarProposta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalvarProposta.Location = new System.Drawing.Point(28, 578);
            this.btnSalvarProposta.Name = "btnSalvarProposta";
            this.btnSalvarProposta.Size = new System.Drawing.Size(159, 75);
            this.btnSalvarProposta.TabIndex = 16;
            this.btnSalvarProposta.Text = "Salvar";
            this.btnSalvarProposta.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSalvarProposta.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            // 
            // dgvDatas
            // 
            this.dgvDatas.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatas.Location = new System.Drawing.Point(716, 209);
            this.dgvDatas.Name = "dgvDatas";
            this.dgvDatas.RowHeadersWidth = 51;
            this.dgvDatas.RowTemplate.Height = 29;
            this.dgvDatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatas.Size = new System.Drawing.Size(431, 463);
            this.dgvDatas.TabIndex = 17;
            // 
            // txtProposta
            // 
            this.txtProposta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProposta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProposta.Location = new System.Drawing.Point(30, 118);
            this.txtProposta.Name = "txtProposta";
            this.txtProposta.Size = new System.Drawing.Size(661, 38);
            this.txtProposta.TabIndex = 21;
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
            // 
            // txtPropostId
            // 
            this.txtPropostId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPropostId.Enabled = false;
            this.txtPropostId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPropostId.Location = new System.Drawing.Point(12, 21);
            this.txtPropostId.Name = "txtPropostId";
            this.txtPropostId.Size = new System.Drawing.Size(97, 38);
            this.txtPropostId.TabIndex = 19;
            this.txtPropostId.TextChanged += new System.EventHandler(this.txtPropostId_TextChanged);
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(1105, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 38);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.txtPropostId_TextChanged);
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataEntrega.Location = new System.Drawing.Point(478, 21);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(148, 34);
            this.dtpDataEntrega.TabIndex = 23;
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
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(30, 236);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(661, 38);
            this.textBox2.TabIndex = 21;
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
            // textBox3
            // 
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(30, 361);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 38);
            this.textBox3.TabIndex = 21;
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
            // textBox4
            // 
            this.textBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(30, 500);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(502, 38);
            this.textBox4.TabIndex = 21;
            // 
            // FrmCadastrarValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1171, 713);
            this.Controls.Add(this.dtpDataEntrega);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtProposta);
            this.Controls.Add(this.btnGerarId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPropostId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvDatas);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvarProposta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarValores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar produtos.";
            this.cmsSalvarConteudos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip cmsSalvarConteudos;
        private ToolStripMenuItem mtSalvarProposta;
        private ToolStripMenuItem mtSalvarComentario;
        private Button btnSalvarProposta;
        private Button btnDeletar;
        private Button btnLimpar;
        private DataGridView dgvDatas;
        private TextBox txtProposta;
        private Button btnGerarId;
        private TextBox txtPropostId;
        private Label label10;
        private TextBox textBox1;
        private DateTimePicker dtpDataEntrega;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
    }
}