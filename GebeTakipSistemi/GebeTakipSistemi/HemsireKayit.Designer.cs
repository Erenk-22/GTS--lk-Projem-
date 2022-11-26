namespace GebeTakipSistemi
{
    partial class HemsireKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HemsireKayit));
            this.btn_kayıt = new System.Windows.Forms.Button();
            this.tb_sifreTekrar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_eposta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_tc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_adSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_resimSec = new System.Windows.Forms.Button();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_hastane = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kayıt
            // 
            this.btn_kayıt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kayıt.FlatAppearance.BorderSize = 0;
            this.btn_kayıt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kayıt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayıt.Location = new System.Drawing.Point(555, 434);
            this.btn_kayıt.Name = "btn_kayıt";
            this.btn_kayıt.Size = new System.Drawing.Size(75, 37);
            this.btn_kayıt.TabIndex = 55;
            this.btn_kayıt.Text = "Kayıt Ol";
            this.btn_kayıt.UseVisualStyleBackColor = true;
            this.btn_kayıt.Click += new System.EventHandler(this.btn_kayıt_Click);
            // 
            // tb_sifreTekrar
            // 
            this.tb_sifreTekrar.Location = new System.Drawing.Point(493, 341);
            this.tb_sifreTekrar.Name = "tb_sifreTekrar";
            this.tb_sifreTekrar.Size = new System.Drawing.Size(137, 20);
            this.tb_sifreTekrar.TabIndex = 54;
            this.tb_sifreTekrar.UseSystemPasswordChar = true;
            this.tb_sifreTekrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HemsireKayit_KeyPress);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(340, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 53;
            this.label7.Text = "Şifre Tekrar :";
            // 
            // tb_sifre
            // 
            this.tb_sifre.Location = new System.Drawing.Point(493, 292);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.Size = new System.Drawing.Size(137, 20);
            this.tb_sifre.TabIndex = 52;
            this.tb_sifre.UseSystemPasswordChar = true;
            this.tb_sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HemsireKayit_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(340, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 51;
            this.label6.Text = "Şifre :";
            // 
            // tb_eposta
            // 
            this.tb_eposta.Location = new System.Drawing.Point(493, 238);
            this.tb_eposta.Name = "tb_eposta";
            this.tb_eposta.Size = new System.Drawing.Size(137, 20);
            this.tb_eposta.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(340, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 49;
            this.label5.Text = "E-Posta :";
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(493, 189);
            this.tb_tel.MaxLength = 11;
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(137, 20);
            this.tb_tel.TabIndex = 11;
            this.tb_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_tc_KeyPress_1);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(340, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 47;
            this.label4.Text = "Telefon :";
            // 
            // Tb_tc
            // 
            this.Tb_tc.Location = new System.Drawing.Point(493, 138);
            this.Tb_tc.MaxLength = 11;
            this.Tb_tc.Name = "Tb_tc";
            this.Tb_tc.Size = new System.Drawing.Size(137, 20);
            this.Tb_tc.TabIndex = 11;
            this.Tb_tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_tc_KeyPress_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(340, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "TcKimlik :";
            // 
            // tb_adSoyad
            // 
            this.tb_adSoyad.Location = new System.Drawing.Point(493, 90);
            this.tb_adSoyad.Name = "tb_adSoyad";
            this.tb_adSoyad.Size = new System.Drawing.Size(137, 20);
            this.tb_adSoyad.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(340, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Ad Soyad :";
            // 
            // btn_resimSec
            // 
            this.btn_resimSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_resimSec.FlatAppearance.BorderSize = 0;
            this.btn_resimSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_resimSec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_resimSec.Location = new System.Drawing.Point(174, 264);
            this.btn_resimSec.Name = "btn_resimSec";
            this.btn_resimSec.Size = new System.Drawing.Size(93, 29);
            this.btn_resimSec.TabIndex = 42;
            this.btn_resimSec.Text = "Resim Seç";
            this.btn_resimSec.UseVisualStyleBackColor = true;
            this.btn_resimSec.Click += new System.EventHandler(this.btn_resimSec_Click);
            // 
            // pb_resim
            // 
            this.pb_resim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_resim.Location = new System.Drawing.Point(117, 90);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(150, 150);
            this.pb_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_resim.TabIndex = 41;
            this.pb_resim.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(820, 42);
            this.label1.TabIndex = 40;
            this.label1.Text = "HEMŞİRE KAYIT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_hastane
            // 
            this.tb_hastane.Location = new System.Drawing.Point(493, 389);
            this.tb_hastane.Name = "tb_hastane";
            this.tb_hastane.Size = new System.Drawing.Size(137, 20);
            this.tb_hastane.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(340, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 23);
            this.label8.TabIndex = 56;
            this.label8.Text = "Çalıştığı Hastane :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(652, 291);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 23);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // HemsireKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 530);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tb_hastane);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_kayıt);
            this.Controls.Add(this.tb_sifreTekrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_sifre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_eposta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tb_tc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_adSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_resimSec);
            this.Controls.Add(this.pb_resim);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HemsireKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HemsireKayit";
            this.Load += new System.EventHandler(this.HemsireKayit_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HemsireKayit_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kayıt;
        private System.Windows.Forms.TextBox tb_sifreTekrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_eposta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tb_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_adSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_resimSec;
        private System.Windows.Forms.PictureBox pb_resim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_hastane;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}