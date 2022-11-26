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
    public partial class HemsireBilgi : Form
    {
        public HemsireBilgi()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-THP3847\\SQLEXPRESS;Initial Catalog=GebeTakipSistemi;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        void temizle()
        {
            tb_adSoyad.Text = "";
            Tb_tc.Text = "";
            tb_tel.Text = "";
            tb_eposta.Text = "";
            tb_hastane.Text = "";
        }
        void griddoldur()
        {
            da = new SqlDataAdapter("Select *From Tbl_hemsire", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "Tbl_hemsire");
            dataGridView1.DataSource = ds.Tables["Tbl_hemsire"];
            conn.Close();
        }
        void kayitSil()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Tbl_hemsire where Tc=@t1", conn);
            cmd.Parameters.AddWithValue("@t1", Tb_tc.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("kayıt silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            griddoldur();
            temizle();
        }
        void güncelle()
        {
            conn.Open();
            string kayit = "update Tbl_hemsire set AdSoyad=@s1,TcKimlik=@s2,Telefon=@s3,Eposta=@s4,CalistigiHastane=@s5 where TcKimlik='" + Tb_tc.Text + "'";
            SqlCommand guncelle = new SqlCommand(kayit, conn);
            guncelle.Parameters.AddWithValue("@s1", tb_adSoyad.Text);
            guncelle.Parameters.AddWithValue("@s2", Tb_tc.Text);
            guncelle.Parameters.AddWithValue("@s3", tb_tel.Text);
            guncelle.Parameters.AddWithValue("@s4", tb_eposta.Text);
            guncelle.Parameters.AddWithValue("@s5", tb_hastane.Text);
            guncelle.ExecuteNonQuery();
            conn.Close();
            griddoldur();
            MessageBox.Show("Formunuz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            güncelle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayitSil();
        }

        private void HemsireBilgi_Load(object sender, EventArgs e)
        {
            griddoldur();
        }
    }
}
