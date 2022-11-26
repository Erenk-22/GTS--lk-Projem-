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
using System.IO;

namespace GebeTakipSistemi
{
    public partial class HemsireKayit : Form
    {
        public HemsireKayit()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-THP3847\\SQLEXPRESS;Initial Catalog=GebeTakipSistemi;Integrated Security=True");
        string imagess;
        private void HemsireKayit_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            
            int s1 = Convert.ToInt32(tb_sifre.Text.ToString());
            int s2 = Convert.ToInt32(tb_sifreTekrar.Text.ToString());
            if (s1 != s2)
            {
                MessageBox.Show("Şifreler aynı değil", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (pb_resim.Image == null)
            {
                MessageBox.Show("Reim KoymaLısınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FileStream resim = new FileStream(imagess, FileMode.Open, FileAccess.Read);
                BinaryReader resimm = new BinaryReader(resim);
                byte[] resimmm = resimm.ReadBytes((int)resim.Length);
                resimm.Close();
                resim.Close();
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Tbl_hemsire(AdSoyad,Tckimlik,Telefon,Eposta,Sifre,SifreTekrarı,CalistigiHastane,Images)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", conn);
                cmd.Parameters.AddWithValue("@p1", tb_adSoyad.Text);
                cmd.Parameters.AddWithValue("@p2", Tb_tc.Text);
                cmd.Parameters.AddWithValue("@p3", tb_tel.Text);
                cmd.Parameters.AddWithValue("@p4", tb_eposta.Text);
                cmd.Parameters.AddWithValue("@p5", tb_sifre.Text);
                cmd.Parameters.AddWithValue("@p6", tb_sifreTekrar.Text);
                cmd.Parameters.AddWithValue("@p7", tb_hastane.Text);
                cmd.Parameters.Add("@p8", SqlDbType.Image, resimmm.Length).Value = resimmm;
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kayıtınız Yapıldı", "Bilgi"); 
            }
            
           
        }

        private void btn_resimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "GEBE TAKİP SİSTEM";
            openFileDialog1.Filter = "JPEG(*.jpg; *jpeg; *jpe)| *.jpg; *jpeg; *jpe | All files(*.*) | *.* ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_resim.Image = Image.FromFile(openFileDialog1.FileName);
                imagess = openFileDialog1.FileName;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                tb_sifre.UseSystemPasswordChar = false;
                tb_sifreTekrar.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                tb_sifre.UseSystemPasswordChar = true;
                tb_sifreTekrar.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
        }
        private void tb_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void HemsireKayit_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Tb_tc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
