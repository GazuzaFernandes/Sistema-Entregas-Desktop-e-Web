namespace Projeto.Logistica.Sistema_de_Logistica
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.Location = new System.Drawing.Point(123, 30);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(187, 43);
            this.txtSenha.TabIndex = 0;
            this.txtSenha.Text = "0000000000";
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Click += new System.EventHandler(this.txtSenha_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 38);
            this.label11.TabIndex = 17;
            this.label11.Text = "Senha:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnValidar
            // 
            this.btnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnValidar.ForeColor = System.Drawing.Color.Black;
            this.btnValidar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidar.Location = new System.Drawing.Point(123, 79);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(92, 51);
            this.btnValidar.TabIndex = 22;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFechar.ForeColor = System.Drawing.Color.Black;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(221, 79);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(92, 51);
            this.btnFechar.TabIndex = 22;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(470, 173);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe a senha.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label11;
        private PictureBox pictureBox1;
        private Button btnValidar;
        private Button btnFechar;
        public TextBox txtSenha;
    }
}