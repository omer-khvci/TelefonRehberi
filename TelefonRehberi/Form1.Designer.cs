namespace TelefonRehberi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kullanici_sifre = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.txt_kullanici_adi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_kullanici_sifre
            // 
            this.txt_kullanici_sifre.Location = new System.Drawing.Point(340, 120);
            this.txt_kullanici_sifre.Name = "txt_kullanici_sifre";
            this.txt_kullanici_sifre.PasswordChar = '*';
            this.txt_kullanici_sifre.Size = new System.Drawing.Size(252, 23);
            this.txt_kullanici_sifre.TabIndex = 3;
            // 
            // Sifre
            // 
            this.Sifre.AutoSize = true;
            this.Sifre.Location = new System.Drawing.Point(245, 123);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(30, 15);
            this.Sifre.TabIndex = 2;
            this.Sifre.Text = "Sifre";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(245, 166);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(347, 23);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "Sistem Giris";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // txt_kullanici_adi
            // 
            this.txt_kullanici_adi.Location = new System.Drawing.Point(340, 70);
            this.txt_kullanici_adi.Name = "txt_kullanici_adi";
            this.txt_kullanici_adi.Size = new System.Drawing.Size(252, 23);
            this.txt_kullanici_adi.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 318);
            this.Controls.Add(this.txt_kullanici_adi);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_kullanici_sifre);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_kullanici_sifre;
        private Label Sifre;
        private Button btn_giris;
        private TextBox txt_kullanici_adi;
    }
}