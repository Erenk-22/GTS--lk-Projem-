using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GebeTakipSistemi
{
    public partial class sifreGüncelle : Form
    {
        public sifreGüncelle()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-THP3847\\SQLEXPRESS;Initial Catalog=GebeTakipSistemi;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text.ToString());
            int s2 = Convert.ToInt32(textBox2.Text.ToString());
            if (textBox3.Text == "")
            {
                MessageBox.Show("Tc Kimlik numarası giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (s1 != s2)
                {
                    MessageBox.Show("şifreler eşit değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                { 
                conn.Open();
                string kayit = "update Tbl_hemsire set Sifre=@s1,SifreTekrarı=@s2 where TcKimlik='" + textBox3.Text + "'";
                SqlCommand guncelle = new SqlCommand(kayit, conn);
                guncelle.Parameters.AddWithValue("@s1", textBox1.Text);
                guncelle.Parameters.AddWithValue("@s2", textBox2.Text);
                guncelle.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Şifre Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textBox1.UseSystemPasswordChar = false;
                textBox2.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox1.UseSystemPasswordChar = true;
                textBox2.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
        }
    }
}
