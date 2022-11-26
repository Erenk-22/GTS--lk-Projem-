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
    public partial class Doktorkayıt : Form
    {
        public Doktorkayıt()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-THP3847\\SQLEXPRESS;Initial Catalog=GebeTakipSistemi;Integrated Security=True");
        string imagess;
        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(tb_sifre.Text);
            double s2 = Convert.ToDouble(tb_sifreTekrar.Text);
            if (s1 != s2)
            {
                MessageBox.Show("Şifreler eşit değil", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(pb_resim.Image == null)
            {
                MessageBox.Show("Resim Boş geçilemez", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            FileStream resim = new FileStream(imagess, FileMode.Open, FileAccess.Read);
            BinaryReader resimm = new BinaryReader(resim);
            byte[] resimmm = resimm.ReadBytes((int)resim.Length);
            resimm.Close();
            resim.Close();
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Tbl_Doktor(AdSoyad,Tckimlik,Telefon,Eposta,Sifre,SifreTekrar,CalistigiHastane,Unvan,Images)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",conn);
            cmd.Parameters.AddWithValue("@p1", tb_adSoyad.Text);
            cmd.Parameters.AddWithValue("@p2", Tb_tc.Text);
            cmd.Parameters.AddWithValue("@p3", tb_tel.Text);
            cmd.Parameters.AddWithValue("@p4", tb_eposta.Text);
            cmd.Parameters.AddWithValue("@p5", tb_sifre.Text);
            cmd.Parameters.AddWithValue("@p6", tb_sifreTekrar.Text);
            cmd.Parameters.AddWithValue("@p7", tb_hastane.Text);
            cmd.Parameters.AddWithValue("@p8", cb_unvan.Text);
            cmd.Parameters.Add("@p9", SqlDbType.Image, resimmm.Length).Value = resimmm;
            cmd.ExecuteNonQuery();
            conn.Close();
            
            MessageBox.Show("Kayıtınız Yapıldı", "Bilgi");
            DoktorGiris doc = new DoktorGiris();
            doc.Show();
            this.Close();
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
    }
}
