namespace Projeto.Logistica.Sistema_de_Logistica
{
    partial class FrmFerramentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFerramentas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvFerramentas = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtFerramentaId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rtbEquipamento = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpRetirada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDevolucao = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSelecionar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFerramentas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(797, 253);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // dgvFerramentas
            // 
            this.dgvFerramentas.AllowUserToAddRows = false;
            this.dgvFerramentas.AllowUserToDeleteRows = false;
            this.dgvFerramentas.BackgroundColor = System.Drawing.Color.White;
            this.dgvFerramentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFerramentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFerramentas.Location = new System.Drawing.Point(0, 404);
            this.dgvFerramentas.Name = "dgvFerramentas";
            this.dgvFerramentas.ReadOnly = true;
            this.dgvFerramentas.RowHeadersWidth = 51;
            this.dgvFerramentas.RowTemplate.Height = 29;
            this.dgvFerramentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFerramentas.Size = new System.Drawing.Size(957, 309);
            this.dgvFerramentas.TabIndex = 36;
            this.dgvFerramentas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFerramentas_CellDoubleClick);
            this.dgvFerramentas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvFerramentas_DataBindingComplete);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(543, 235);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(122, 62);
            this.btnLimpar.TabIndex = 33;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeletar.ForeColor = System.Drawing.Color.Black;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(543, 324);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(122, 62);
            this.btnDeletar.TabIndex = 34;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(543, 141);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(122, 62);
            this.btnSalvar.TabIndex = 35;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtFerramentaId
            // 
            this.txtFerramentaId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFerramentaId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFerramentaId.Enabled = false;
            this.txtFerramentaId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFerramentaId.Location = new System.Drawing.Point(12, 12);
            this.txtFerramentaId.Name = "txtFerramentaId";
            this.txtFerramentaId.Size = new System.Drawing.Size(62, 38);
            this.txtFerramentaId.TabIndex = 31;
            this.txtFerramentaId.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(32, 165);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(498, 38);
            this.txtNome.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(32, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(355, 31);
            this.label11.TabIndex = 30;
            this.label11.Text = "Nome: colocador, Raspador, Etc.";
            // 
            // rtbEquipamento
            // 
            this.rtbEquipamento.Location = new System.Drawing.Point(32, 253);
            this.rtbEquipamento.Name = "rtbEquipamento";
            this.rtbEquipamento.Size = new System.Drawing.Size(498, 120);
            this.rtbEquipamento.TabIndex = 38;
            this.rtbEquipamento.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Equipamento:";
            // 
            // dtpRetirada
            // 
            this.dtpRetirada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpRetirada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRetirada.Location = new System.Drawing.Point(797, 24);
            this.dtpRetirada.Name = "dtpRetirada";
            this.dtpRetirada.Size = new System.Drawing.Size(148, 34);
            this.dtpRetirada.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(671, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 30;
            this.label2.Text = "Retirada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(647, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 31);
            this.label3.TabIndex = 30;
            this.label3.Text = "Devolução:";
            // 
            // dtpDevolucao
            // 
            this.dtpDevolucao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDevolucao.Location = new System.Drawing.Point(797, 93);
            this.dtpDevolucao.Name = "dtpDevolucao";
            this.dtpDevolucao.Size = new System.Drawing.Size(148, 34);
            this.dtpDevolucao.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(309, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 30;
            this.label4.Text = "Status:";
            // 
            // cbSelecionar
            // 
            this.cbSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSelecionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelecionar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbSelecionar.ForeColor = System.Drawing.Color.Red;
            this.cbSelecionar.FormattingEnabled = true;
            this.cbSelecionar.Items.AddRange(new object[] {
            "Pendente",
            "Devolvido"});
            this.cbSelecionar.Location = new System.Drawing.Point(238, 48);
            this.cbSelecionar.Name = "cbSelecionar";
            this.cbSelecionar.Size = new System.Drawing.Size(246, 39);
            this.cbSelecionar.TabIndex = 41;
            // 
            // FrmFerramentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(957, 713);
            this.Controls.Add(this.cbSelecionar);
            this.Controls.Add(this.dtpDevolucao);
            this.Controls.Add(this.dtpRetirada);
            this.Controls.Add(this.rtbEquipamento);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvFerramentas);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtFerramentaId);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFerramentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferramentas com funcionario";
            this.Load += new System.EventHandler(this.FrmFerramentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFerramentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dgvFerramentas;
        private Button btnLimpar;
        private Button btnDeletar;
        private Button btnSalvar;
        private TextBox txtFerramentaId;
        private TextBox txtNome;
        private Label label11;
        private RichTextBox rtbEquipamento;
        private Label label1;
        private DateTimePicker dtpRetirada;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDevolucao;
        private Label label4;
        private ComboBox cbSelecionar;
    }
}