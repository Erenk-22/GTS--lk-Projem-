namespace GebeTakipSistemi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_doktor = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_gebe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(120, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "GEBE TAKİP SİSTEMİ";
            // 
            // btn_doktor
            // 
            this.btn_doktor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_doktor.FlatAppearance.BorderSize = 0;
            this.btn_doktor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doktor.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_doktor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doktor.ImageIndex = 2;
            this.btn_doktor.ImageList = this.ımageList1;
            this.btn_doktor.Location = new System.Drawing.Point(66, 178);
            this.btn_doktor.Name = "btn_doktor";
            this.btn_doktor.Size = new System.Drawing.Size(250, 40);
            this.btn_doktor.TabIndex = 2;
            this.btn_doktor.Text = "Doktor / Ebe Girişi";
            this.btn_doktor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_doktor.UseVisualStyleBackColor = true;
            this.btn_doktor.Click += new System.EventHandler(this.btn_doktor_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "021591068746.jpg");
            this.ımageList1.Images.SetKeyName(1, "anne-tavsan_1_5fcd3d7f527f9d386e7d2eed.jpg");
            this.ımageList1.Images.SetKeyName(2, "l_75486bb8141d77474c9d39cab1302d62.png");
            // 
            // btn_gebe
            // 
            this.btn_gebe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gebe.FlatAppearance.BorderSize = 0;
            this.btn_gebe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gebe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gebe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gebe.ImageIndex = 0;
            this.btn_gebe.ImageList = this.ımageList1;
            this.btn_gebe.Location = new System.Drawing.Point(66, 266);
            this.btn_gebe.Name = "btn_gebe";
            this.btn_gebe.Size = new System.Drawing.Size(250, 40);
            this.btn_gebe.TabIndex = 4;
            this.btn_gebe.Text = "Hemşire Girişi";
            this.btn_gebe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_gebe.UseVisualStyleBackColor = true;
            this.btn_gebe.Click += new System.EventHandler(this.btn_gebe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 434);
            this.Controls.Add(this.btn_gebe);
            this.Controls.Add(this.btn_doktor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GEBE TAKİP SİSTEMİ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_doktor;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_gebe;
    }
}

