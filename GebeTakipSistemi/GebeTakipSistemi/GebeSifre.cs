using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace GebeTakipSistemi
{
    public partial class GebeSifre : Form
    {
        public GebeSifre()
        {
            InitializeComponent();
        }

        private void btn_guncell_Click(object sender, EventArgs e)
        {
            sqlbaglanti bgln = new sqlbaglanti();
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Gebe Where Eposta='" + Tb_eposta.Text.ToString() + "' and AdSoyad='" + Tb_adsoyad.Text.ToString() + "'", bgln.baglanti());


            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                try
                {
                    if (bgln.baglanti().State == ConnectionState.Closed)
                    {
                        bgln.baglanti().Open();
                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    string tarih = DateTime.Now.ToLongDateString();
                    string mailadresi = ("ekose0619@gmail.com");
                    string sifre = ("erenkose1a2e3e");
                    string smtpsrvr = "smtp.gmail.com";
                    string kime = (oku["Eposta"].ToString());
                    string konu = ("Şifre Hatırlatma Maili");
                    string yaz = ("Sayın," + oku["AdSoyad"].ToString() + "\n" + "Bizden" + tarih + "Tarihinde Şifre Hatırlatma Talebinde bulundunuz" + "\n" + "Parolanız:" +
                        oku["Sifre"].ToString() + "\n" + "İyi Günler");
                    smtpserver.Credentials = new NetworkCredential(mailadresi, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smtpsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresi);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yaz;
                    smtpserver.Send(mail);
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Girmiş olduğunuz bilgiler uyuştu şifreniz mailinize gönderildi.");
                    this.Hide();
                    Gebe geb = new Gebe();
                    geb.Show();
                }
                catch (Exception Hata)
                {
                    MessageBox.Show("Mail Gönderme Hatası!", Hata.Message);
                }
            }
        }
    }
}
