namespace Projeto.Logistica.Sistema_de_Logistica
{
    partial class FrmTelefone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelefone));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelObra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnDeletarProposta = new System.Windows.Forms.Button();
            this.btnSalvarProposta = new System.Windows.Forms.Button();
            this.txtTelefoneId = new System.Windows.Forms.TextBox();
            this.dgvTelefone = new System.Windows.Forms.DataGridView();
            this.rtbObs = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(722, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(127, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(555, 34);
            this.txtNome.TabIndex = 14;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // labelObra
            // 
            this.labelObra.AutoSize = true;
            this.labelObra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelObra.ForeColor = System.Drawing.Color.White;
            this.labelObra.Location = new System.Drawing.Point(127, 9);
            this.labelObra.Name = "labelObra";
            this.labelObra.Size = new System.Drawing.Size(399, 28);
            this.labelObra.TabIndex = 13;
            this.labelObra.Text = "Informe o nome ou Digite para pesquisa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefone.Location = new System.Drawing.Point(127, 125);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(294, 34);
            this.txtTelefone.TabIndex = 14;
            // 
            // btnDeletarProposta
            // 
            this.btnDeletarProposta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeletarProposta.ForeColor = System.Drawing.Color.Black;
            this.btnDeletarProposta.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarProposta.Image")));
            this.btnDeletarProposta.Location = new System.Drawing.Point(741, 244);
            this.btnDeletarProposta.Name = "btnDeletarProposta";
            this.btnDeletarProposta.Size = new System.Drawing.Size(77, 58);
            this.btnDeletarProposta.TabIndex = 18;
            this.btnDeletarProposta.UseVisualStyleBackColor = true;
            this.btnDeletarProposta.Click += new System.EventHandler(this.btnDeletarProposta_Click);
            // 
            // btnSalvarProposta
            // 
            this.btnSalvarProposta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarProposta.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarProposta.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarProposta.Image")));
            this.btnSalvarProposta.Location = new System.Drawing.Point(641, 244);
            this.btnSalvarProposta.Name = "btnSalvarProposta";
            this.btnSalvarProposta.Size = new System.Drawing.Size(77, 58);
            this.btnSalvarProposta.TabIndex = 17;
            this.btnSalvarProposta.UseVisualStyleBackColor = true;
            this.btnSalvarProposta.Click += new System.EventHandler(this.btnSalvarProposta_Click);
            // 
            // txtTelefoneId
            // 
            this.txtTelefoneId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTelefoneId.Enabled = false;
            this.txtTelefoneId.Location = new System.Drawing.Point(12, 12);
            this.txtTelefoneId.Name = "txtTelefoneId";
            this.txtTelefoneId.Size = new System.Drawing.Size(44, 34);
            this.txtTelefoneId.TabIndex = 16;
            this.txtTelefoneId.Visible = false;
            // 
            // dgvTelefone
            // 
            this.dgvTelefone.AllowUserToAddRows = false;
            this.dgvTelefone.AllowUserToDeleteRows = false;
            this.dgvTelefone.BackgroundColor = System.Drawing.Color.White;
            this.dgvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefone.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTelefone.Location = new System.Drawing.Point(0, 339);
            this.dgvTelefone.Name = "dgvTelefone";
            this.dgvTelefone.ReadOnly = true;
            this.dgvTelefone.RowHeadersWidth = 51;
            this.dgvTelefone.RowTemplate.Height = 29;
            this.dgvTelefone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelefone.Size = new System.Drawing.Size(872, 370);
            this.dgvTelefone.TabIndex = 19;
            this.dgvTelefone.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgTelefone_CellDoubleClick);
            // 
            // rtbObs
            // 
            this.rtbObs.Location = new System.Drawing.Point(127, 201);
            this.rtbObs.Name = "rtbObs";
            this.rtbObs.Size = new System.Drawing.Size(497, 101);
            this.rtbObs.TabIndex = 20;
            this.rtbObs.Text = "";
            this.rtbObs.TextChanged += new System.EventHandler(this.rtbObs_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(127, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Informação extra ou Digite para pesquisar a informação.";
            // 
            // FrmTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(872, 709);
            this.Controls.Add(this.rtbObs);
            this.Controls.Add(this.dgvTelefone);
            this.Controls.Add(this.btnDeletarProposta);
            this.Controls.Add(this.btnSalvarProposta);
            this.Controls.Add(this.txtTelefoneId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelObra);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTelefone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telefones uteis.";
            this.Load += new System.EventHandler(this.FrmTelefone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        public TextBox txtNome;
        private Label labelObra;
        private Label label1;
        public TextBox txtTelefone;
        private Button btnDeletarProposta;
        private Button btnSalvarProposta;
        private TextBox txtTelefoneId;
        private DataGridView dgvTelefone;
        private RichTextBox rtbObs;
        private Label label2;
    }
}