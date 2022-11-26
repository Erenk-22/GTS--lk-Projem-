namespace GebeTakipSistemi
{
    partial class Doktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_adSoyad = new System.Windows.Forms.TextBox();
            this.Tb_sifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_sifreUnuttum = new System.Windows.Forms.Button();
            this.hatırla = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 129);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor / Ebe Girişine Hoşgeldiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(58, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad :";
            // 
            // Tb_adSoyad
            // 
            this.Tb_adSoyad.Location = new System.Drawing.Point(188, 156);
            this.Tb_adSoyad.Name = "Tb_adSoyad";
            this.Tb_adSoyad.Size = new System.Drawing.Size(157, 20);
            this.Tb_adSoyad.TabIndex = 2;
            // 
            // Tb_sifre
            // 
            this.Tb_sifre.Location = new System.Drawing.Point(188, 214);
            this.Tb_sifre.Name = "Tb_sifre";
            this.Tb_sifre.Size = new System.Drawing.Size(157, 20);
            this.Tb_sifre.TabIndex = 4;
            this.Tb_sifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(58, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şifre :";
            // 
            // btn_giris
            // 
            this.btn_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_giris.FlatAppearance.BorderSize = 0;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(245, 312);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(100, 31);
            this.btn_giris.TabIndex = 5;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_sifreUnuttum
            // 
            this.btn_sifreUnuttum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sifreUnuttum.FlatAppearance.BorderSize = 0;
            this.btn_sifreUnuttum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sifreUnuttum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sifreUnuttum.Location = new System.Drawing.Point(44, 312);
            this.btn_sifreUnuttum.Name = "btn_sifreUnuttum";
            this.btn_sifreUnuttum.Size = new System.Drawing.Size(137, 26);
            this.btn_sifreUnuttum.TabIndex = 6;
            this.btn_sifreUnuttum.Text = "Şifremi Unuttum";
            this.btn_sifreUnuttum.UseVisualStyleBackColor = true;
            this.btn_sifreUnuttum.Click += new System.EventHandler(this.btn_sifreUnuttum_Click);
            // 
            // hatırla
            // 
            this.hatırla.AutoSize = true;
            this.hatırla.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hatırla.Location = new System.Drawing.Point(62, 263);
            this.hatırla.Name = "hatırla";
            this.hatırla.Size = new System.Drawing.Size(110, 23);
            this.hatırla.TabIndex = 8;
            this.hatırla.Text = "Beni Hatırla";
            this.hatırla.UseVisualStyleBackColor = true;
            this.hatırla.CheckedChanged += new System.EventHandler(this.hatırla_CheckedChanged);
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 468);
            this.Controls.Add(this.hatırla);
            this.Controls.Add(this.btn_sifreUnuttum);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.Tb_sifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_adSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor";
            this.Load += new System.EventHandler(this.Doktor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_adSoyad;
        private System.Windows.Forms.TextBox Tb_sifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_sifreUnuttum;
        private System.Windows.Forms.CheckBox hatırla;
    }
}