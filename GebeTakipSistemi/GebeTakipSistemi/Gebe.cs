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
    public partial class Gebe : Form
    {
        public Gebe()
        {
            InitializeComponent();
            
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-THP3847\\SQLEXPRESS;Initial Catalog=GebeTakipSistemi;Integrated Security=True");
        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "Select * from Tbl_hemsire where AdSoyad=@ad AND Sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("ad", Tb_adSoyad.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", Tb_sifre.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    
                    GebeGiris gebe = new GebeGiris();
                    gebe.Show();
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
            GebeSifre sifre = new GebeSifre();
            this.Hide();
        }

        private void hatırla_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Gebe_Load(object sender, EventArgs e)
        {
           
        }
    }
}
