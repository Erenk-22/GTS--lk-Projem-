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

namespace GebeTakipSistemi
{
    public partial class DoktorGiris : Form
    {
        public DoktorGiris()
        {
            InitializeComponent();

        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-THP3847\\SQLEXPRESS;Initial Catalog=GebeTakipSistemi;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;     
        void griddoldur()
        {
            da = new SqlDataAdapter("Select *From Tbl_hemsire", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "Tbl_hemsire");
            dataGridView1.DataSource = ds.Tables["Tbl_hemsire"];
            conn.Close();
        }
        void griddoldur1()
        {
            da = new SqlDataAdapter("Select *From Tbl_Gebe", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "Tbl_Gebe");
            dataGridView1.DataSource = ds.Tables["Tbl_Gebe"];
            conn.Close();
        }
        void griddoldur2()
        {
            da = new SqlDataAdapter("Select *From Tbl_Doktor", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "Tbl_Doktor");
            dataGridView1.DataSource = ds.Tables["Tbl_Doktor"];
            conn.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel_menı.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan çıkılsın mı?", "ÇIKIŞ", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Çıkış yapılmadı");
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            if (panel_menı.Visible == false)
                panel_menı.Visible = true;
            else
                panel_menı.Visible = false;

            panel3.Visible = false;
            panel5.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel_menı.Visible = false;
            if (panel2.Visible == false)
                panel2.Visible = true;
            else
                panel2.Visible = false;

            panel3.Visible = false;
            panel5.Visible = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            HemsireKayit hemsire = new HemsireKayit();
            hemsire.Show();
            panel_menı.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
        }
  
        private void DoktorGiris_Load(object sender, EventArgs e)
        {
            
        }
        private void button10_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel_menı.Visible = false;
            panel1.Visible = true;
            griddoldur();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            DoktorListe list = new DoktorListe();
            list.MdiParent = this;
            list.Show();
            panel_menı.Visible = false;
            panel5.Visible = false;
            panel1.Visible = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel_menı.Visible = false;
            panel1.Visible = true;
            griddoldur1();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel_menı.Visible = false;
            panel5.Visible = false;
            panel1.Visible=false;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            doktorSifreGüncel güncel = new doktorSifreGüncel();
            güncel.Show();
            panel2.Visible = false;
            panel_menı.Visible = false;
            panel5.Visible = false;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel_menı.Visible = false;
            panel1.Visible = true;
            griddoldur2();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DoktorMesaj mesaj = new DoktorMesaj();
            mesaj.MdiParent = this;
            mesaj.Show();
            panel_menı.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            Doktorkayıt doc = new Doktorkayıt();
            doc.Show();
            panel_menı.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel_menı.Visible = false;
            panel5.Visible = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel_menı.Visible = false;
            panel5.Visible = false;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == false)
                panel3.Visible = true;
            else
                panel3.Visible = false;

            panel5.Visible = false;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            
            panel3.Visible = false;
            panel_menı.Visible = false;
            if (panel5.Visible == false)
                panel5.Visible = true;
            else
                panel5.Visible = false;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            DoktorBilgi doc = new DoktorBilgi();
            doc.MdiParent = this;
            doc.Show();
            panel5.Visible = false;
            panel2.Visible = false;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            HemsireBilgi hem = new HemsireBilgi();
            hem.MdiParent = this;
            hem.Show();
            panel5.Visible = false;
            panel2.Visible = false;
        }
    }
}
