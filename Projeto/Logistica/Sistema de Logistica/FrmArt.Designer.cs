namespace Projeto.Logistica.Sistema_de_Logistica
{
    partial class FrmArt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArt));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbMaterialSp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1204, 1021);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lbMaterialSp
            // 
            this.lbMaterialSp.AutoSize = true;
            this.lbMaterialSp.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMaterialSp.ForeColor = System.Drawing.Color.Red;
            this.lbMaterialSp.Location = new System.Drawing.Point(157, 26);
            this.lbMaterialSp.Name = "lbMaterialSp";
            this.lbMaterialSp.Size = new System.Drawing.Size(1084, 114);
            this.lbMaterialSp.TabIndex = 12;
            this.lbMaterialSp.Text = "COMO EMITIR ART -\r\nhttps://creanet1.creasp.org.br/Seguranca/Login.aspx?Acesso=UHJ" +
    "vZmlzc2lvbmFs\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 1025);
            this.label1.TabIndex = 13;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(750, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 950);
            this.label2.TabIndex = 13;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // FrmArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1422, 735);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMaterialSp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmArt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Como montar Art.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbMaterialSp;
        private Label label1;
        private Label label2;
    }
}