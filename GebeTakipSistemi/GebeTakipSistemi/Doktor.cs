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
    public partial class Doktor : Form
    {
        public Doktor()
        {
            InitializeComponent();
            Init_Data();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-THP3847\\SQLEXPRESS;Initial Catalog=GebeTakipSistemi;Integrated Security=True");
        private void Init_Data()
        {
            if (Properties.Settings.Default.UserName != String.Empty)
            {
                if (Properties.Settings.Default.Remember == true)
                {
                    Tb_adSoyad.Text = Properties.Settings.Default.UserName;
                    Tb_sifre.Text = Properties.Settings.Default.Password;
                    hatırla.Checked = true;
                }
                else
                {
                    Tb_adSoyad.Text = Properties.Settings.Default.UserName;
                }
            }
        }
        private void Save_Data()
        {
            if (hatırla.Checked)
            {
                Properties.Settings.Default.UserName = Tb_adSoyad.Text;
                Properties.Settings.Default.Password = Tb_sifre.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }
        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "Select * from Tbl_Doktor where AdSoyad=@Adi AND Sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("Adi", Tb_adSoyad.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", Tb_sifre.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Save_Data();
                    DoktorGiris doc =new DoktorGiris();
                    doc.Show();
                    this.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void btn_sifreUnuttum_Click(object sender, EventArgs e)
        {
            DoktorSifre dock = new DoktorSifre();
            dock.Show();
            this.Close();
        }

        private void hatırla_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Doktor_Load(object sender, EventArgs e)
        {
           
        }
    }
}
