namespace Personel_Kayit
{
    partial class FrmGiris
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
            this.Txt_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_username = new System.Windows.Forms.TextBox();
            this.tbl_personelTableAdapter1 = new Personel_Kayit.SirketCalisanlariVeriTabaniDataSet1TableAdapters.Tbl_personelTableAdapter();
            this.Btn_giris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_sifre
            // 
            this.Txt_sifre.Location = new System.Drawing.Point(210, 125);
            this.Txt_sifre.Name = "Txt_sifre";
            this.Txt_sifre.Size = new System.Drawing.Size(138, 40);
            this.Txt_sifre.TabIndex = 2;
            this.Txt_sifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(474, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şirket Yöneticileri Giriş Paneli\r\n";
            // 
            // Txt_username
            // 
            this.Txt_username.Location = new System.Drawing.Point(210, 79);
            this.Txt_username.Name = "Txt_username";
            this.Txt_username.Size = new System.Drawing.Size(138, 40);
            this.Txt_username.TabIndex = 1;
            // 
            // tbl_personelTableAdapter1
            // 
            this.tbl_personelTableAdapter1.ClearBeforeFill = true;
            // 
            // Btn_giris
            // 
            this.Btn_giris.BackColor = System.Drawing.Color.White;
            this.Btn_giris.ForeColor = System.Drawing.Color.Black;
            this.Btn_giris.Location = new System.Drawing.Point(229, 171);
            this.Btn_giris.Name = "Btn_giris";
            this.Btn_giris.Size = new System.Drawing.Size(97, 41);
            this.Btn_giris.TabIndex = 3;
            this.Btn_giris.Text = "Giriş Yap";
            this.Btn_giris.UseVisualStyleBackColor = false;
            this.Btn_giris.Click += new System.EventHandler(this.Btn_giris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı adı:";
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(513, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_giris);
            this.Controls.Add(this.Txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_sifre);
            this.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_username;
        private SirketCalisanlariVeriTabaniDataSet1TableAdapters.Tbl_personelTableAdapter tbl_personelTableAdapter1;
        private System.Windows.Forms.Button Btn_giris;
        private System.Windows.Forms.Label label1;
    }
}