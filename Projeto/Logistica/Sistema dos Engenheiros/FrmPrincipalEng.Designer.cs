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
            this.cbCancelado = new System.Windows.Forms.CheckBox();
            this.cbFinalizado = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbPendente = new System.Windows.Forms.CheckBox();
            this.btnProposta = new System.Windows.Forms.Button();
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
            this.tabPage1.Size = new System.Drawing.Size(1356, 484);
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
            this.dgvPrincipal.Size = new System.Drawing.Size(1350, 480);
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
            this.tabControl1.Location = new System.Drawing.Point(0, 201);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1364, 528);
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
            // 
            // btnLimparPesquisa
            // 
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
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnProposta);
            this.panel1.Controls.Add(this.cbCancelado);
            this.panel1.Controls.Add(this.cbFinalizado);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.cbPendente);
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
            this.panel1.Size = new System.Drawing.Size(1364, 201);
            this.panel1.TabIndex = 7;
            // 
            // cbCancelado
            // 
            this.cbCancelado.AutoSize = true;
            this.cbCancelado.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbCancelado.ForeColor = System.Drawing.Color.Red;
            this.cbCancelado.Location = new System.Drawing.Point(1158, 84);
            this.cbCancelado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCancelado.Name = "cbCancelado";
            this.cbCancelado.Size = new System.Drawing.Size(173, 42);
            this.cbCancelado.TabIndex = 11;
            this.cbCancelado.Text = "Cancelado";
            this.cbCancelado.UseVisualStyleBackColor = true;
            // 
            // cbFinalizado
            // 
            this.cbFinalizado.AutoSize = true;
            this.cbFinalizado.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbFinalizado.ForeColor = System.Drawing.Color.Lime;
            this.cbFinalizado.Location = new System.Drawing.Point(1158, 27);
            this.cbFinalizado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFinalizado.Name = "cbFinalizado";
            this.cbFinalizado.Size = new System.Drawing.Size(172, 42);
            this.cbFinalizado.TabIndex = 12;
            this.cbFinalizado.Text = "Finalizado";
            this.cbFinalizado.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.Blue;
            this.checkBox1.Location = new System.Drawing.Point(793, 26);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(311, 42);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Pendente de entrega";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbPendente
            // 
            this.cbPendente.AutoSize = true;
            this.cbPendente.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbPendente.ForeColor = System.Drawing.Color.Yellow;
            this.cbPendente.Location = new System.Drawing.Point(793, 84);
            this.cbPendente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPendente.Name = "cbPendente";
            this.cbPendente.Size = new System.Drawing.Size(148, 42);
            this.cbPendente.TabIndex = 13;
            this.cbPendente.Text = "Em obra";
            this.cbPendente.UseVisualStyleBackColor = true;
            // 
            // btnProposta
            // 
            this.btnProposta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProposta.Location = new System.Drawing.Point(604, 131);
            this.btnProposta.Name = "btnProposta";
            this.btnProposta.Size = new System.Drawing.Size(256, 63);
            this.btnProposta.TabIndex = 14;
            this.btnProposta.Text = "Nova Proposta";
            this.btnProposta.UseVisualStyleBackColor = true;
            this.btnProposta.Click += new System.EventHandler(this.btnProposta_Click);
            // 
            // FrmPrincipalEng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private CheckBox cbCancelado;
        private CheckBox cbFinalizado;
        private CheckBox cbPendente;
        private CheckBox checkBox1;
        private Button btnProposta;
    }
}