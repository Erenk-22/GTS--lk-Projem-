namespace GebeTakipSistemi
{
    partial class GebeSifre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GebeSifre));
            this.btn_guncell = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_adsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_eposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_guncell
            // 
            this.btn_guncell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guncell.FlatAppearance.BorderSize = 0;
            this.btn_guncell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncell.Location = new System.Drawing.Point(255, 268);
            this.btn_guncell.Name = "btn_guncell";
            this.btn_guncell.Size = new System.Drawing.Size(82, 29);
            this.btn_guncell.TabIndex = 12;
            this.btn_guncell.Text = "Gönder";
            this.btn_guncell.Click += new System.EventHandler(this.btn_guncell_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(403, 47);
            this.label4.TabIndex = 17;
            this.label4.Text = "ŞİFRE GÜNCELLEME";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tb_adsoyad
            // 
            this.Tb_adsoyad.Location = new System.Drawing.Point(180, 217);
            this.Tb_adsoyad.Name = "Tb_adsoyad";
            this.Tb_adsoyad.Size = new System.Drawing.Size(157, 20);
            this.Tb_adsoyad.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ad Soyad :";
            // 
            // Tb_eposta
            // 
            this.Tb_eposta.Location = new System.Drawing.Point(180, 159);
            this.Tb_eposta.Name = "Tb_eposta";
            this.Tb_eposta.Size = new System.Drawing.Size(157, 20);
            this.Tb_eposta.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(50, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "E-posta : ";
            // 
            // GebeSifre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 339);
            this.Controls.Add(this.btn_guncell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tb_adsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_eposta);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GebeSifre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GebeSifre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guncell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tb_adsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_eposta;
        private System.Windows.Forms.Label label2;
    }
}