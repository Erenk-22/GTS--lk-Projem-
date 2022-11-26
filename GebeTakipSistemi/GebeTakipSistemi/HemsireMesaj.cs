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
using System.Net.Mail;

namespace GebeTakipSistemi
{
    public partial class HemsireMesaj : Form
    {
        public HemsireMesaj()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-THP3847\\SQLEXPRESS;Initial Catalog=GebeTakipSistemi;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        void griddoldur()
        {
            da = new SqlDataAdapter("Select AdSoyad,Eposta From Tbl_Doktor", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "Tbl_Doktor");
            dataGridView1.DataSource = ds.Tables["Tbl_Doktor"];
            conn.Close();
        }
        private void HemsireMesaj_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="" || textBox2.Text==""||textBox3.Text=="")
            {
                MessageBox.Show("Boş Geçilemez.", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("ekose0619@gmail.com", "erenkose1a2e3e");
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com";
            istemci.EnableSsl = true;
            mesajım.To.Add(textBox1.Text);
            mesajım.From = new MailAddress("ekose0619@gmail.com");
            mesajım.Subject = textBox2.Text;
            mesajım.Body = textBox3.Text;
            istemci.Send(mesajım);
            MessageBox.Show("Mesaj Gönderilmiştir.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
