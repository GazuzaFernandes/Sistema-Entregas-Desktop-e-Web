namespace Logistica.Sistema_dos_Engenheiros
{
    partial class FrmPrincipalEng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalEng));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbProposta = new System.Windows.Forms.RadioButton();
            this.rbEndereço = new System.Windows.Forms.RadioButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cbEmpresas = new System.Windows.Forms.ComboBox();
            this.btnProposta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPrincipal);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1356, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            this.dgvPrincipal.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrincipal.Location = new System.Drawing.Point(3, 2);
            this.dgvPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.RowHeadersWidth = 51;
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.Size = new System.Drawing.Size(1350, 508);
            this.dgvPrincipal.TabIndex = 0;
            this.dgvPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrincipal_CellDoubleClick);
            this.dgvPrincipal.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPrincipal_DataBindingComplete);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 173);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1364, 556);
            this.tabControl1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparPesquisa.Image")));
            this.btnLimparPesquisa.Location = new System.Drawing.Point(718, 27);
            this.btnLimparPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(38, 38);
            this.btnLimparPesquisa.TabIndex = 8;
            this.btnLimparPesquisa.UseVisualStyleBackColor = true;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnLimparPesquisa_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(673, 26);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(38, 38);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCliente.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCliente.ForeColor = System.Drawing.Color.White;
            this.rbCliente.Location = new System.Drawing.Point(379, 91);
            this.rbCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(120, 35);
            this.rbCliente.TabIndex = 6;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Clientes";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // rbProposta
            // 
            this.rbProposta.AutoSize = true;
            this.rbProposta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbProposta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbProposta.ForeColor = System.Drawing.Color.White;
            this.rbProposta.Location = new System.Drawing.Point(526, 91);
            this.rbProposta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbProposta.Name = "rbProposta";
            this.rbProposta.Size = new System.Drawing.Size(131, 35);
            this.rbProposta.TabIndex = 6;
            this.rbProposta.TabStop = true;
            this.rbProposta.Text = "Proposta";
            this.rbProposta.UseVisualStyleBackColor = true;
            // 
            // rbEndereço
            // 
            this.rbEndereço.AutoSize = true;
            this.rbEndereço.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEndereço.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbEndereço.ForeColor = System.Drawing.Color.White;
            this.rbEndereço.Location = new System.Drawing.Point(226, 91);
            this.rbEndereço.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbEndereço.Name = "rbEndereço";
            this.rbEndereço.Size = new System.Drawing.Size(133, 35);
            this.rbEndereço.TabIndex = 6;
            this.rbEndereço.TabStop = true;
            this.rbEndereço.Text = "Endereço";
            this.rbEndereço.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisar.Location = new System.Drawing.Point(226, 26);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(431, 38);
            this.txtPesquisar.TabIndex = 5;
            this.txtPesquisar.Text = "Digite para pesquisar:";
            this.txtPesquisar.Click += new System.EventHandler(this.txtPesquisar_Click);
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbEmpresas);
            this.panel1.Controls.Add(this.btnProposta);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLimparPesquisa);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.rbCliente);
            this.panel1.Controls.Add(this.rbProposta);
            this.panel1.Controls.Add(this.rbEndereço);
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 173);
            this.panel1.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(829, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 31);
            this.label11.TabIndex = 31;
            this.label11.Text = "Status da obra:";
            // 
            // cbEmpresas
            // 
            this.cbEmpresas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbEmpresas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresas.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEmpresas.ForeColor = System.Drawing.Color.Red;
            this.cbEmpresas.FormattingEnabled = true;
            this.cbEmpresas.Items.AddRange(new object[] {
            "Em Obra.",
            "Finalizado.",
            "Cancelado."});
            this.cbEmpresas.Location = new System.Drawing.Point(803, 74);
            this.cbEmpresas.Name = "cbEmpresas";
            this.cbEmpresas.Size = new System.Drawing.Size(224, 39);
            this.cbEmpresas.TabIndex = 30;
            // 
            // btnProposta
            // 
            this.btnProposta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProposta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProposta.Location = new System.Drawing.Point(1094, 91);
            this.btnProposta.Name = "btnProposta";
            this.btnProposta.Size = new System.Drawing.Size(256, 61);
            this.btnProposta.TabIndex = 14;
            this.btnProposta.Text = "Nova Proposta";
            this.btnProposta.UseVisualStyleBackColor = true;
            this.btnProposta.Click += new System.EventHandler(this.btnProposta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 28);
            this.label1.TabIndex = 48;
            this.label1.Text = "Clique na imagem para trocar de sistema.";
            // 
            // FrmPrincipalEng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1364, 729);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipalEng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de obra da Engenharia";
            this.Load += new System.EventHandler(this.FrmPrincipalEng_Load);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage1;
        private DataGridView dgvPrincipal;
        private TabControl tabControl1;
        private PictureBox pictureBox1;
        private Button btnLimparPesquisa;
        private Button btnPesquisar;
        private RadioButton rbCliente;
        private RadioButton rbProposta;
        private RadioButton rbEndereço;
        private TextBox txtPesquisar;
        private Panel panel1;
        private Button btnProposta;
        private Label label11;
        private ComboBox cbEmpresas;
        private Label label1;
    }
}