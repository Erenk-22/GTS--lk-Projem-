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
    public partial class GebeGiris : Form
    {
        public GebeGiris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-THP3847\\SQLEXPRESS;Initial Catalog=GebeTakipSistemi;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        void griddoldur()
        {
            da = new SqlDataAdapter("Select *From Tbl_Gebe", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "Tbl_Gebe");
            dataGridView1.DataSource = ds.Tables["Tbl_Gebe"];
            conn.Close();
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan çıkılsın mı?", "ÇIKIŞ", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Çıkış yapılmadı");
            }
            panel_menu.Visible = false;
            panel_menı.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(panel_menı.Visible==false)
            panel_menı.Visible = true;
            else
            panel_menı.Visible = false;
            panel_menu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panel_menu.Visible==true)
            panel_menu.Visible = false;
            else
            panel_menu.Visible = true;
            panel_menı.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ilkayGebe ilk = new ilkayGebe();
            ilk.MdiParent = this;
            ilk.Show();
            panel_menı.Visible = false;
            panel_menu.Visible = false;
            
            panel1.Visible = false;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ikinciay iki = new ikinciay();
            iki.MdiParent = this;
            iki.Show();
            panel_menı.Visible = false;
            panel_menu.Visible = false;
           
            panel1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sonay son = new sonay();
            son.MdiParent = this;
            son.Show();
            panel_menı.Visible = false;
            panel_menu.Visible = false;
            
            panel1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sifreGüncelle güncel = new sifreGüncelle();
            güncel.Show();
            panel_menu.Visible = false;
            panel_menı.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
            panel_menı.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            GebeKayıt geb = new GebeKayıt();
            geb.Show();
            panel_menu.Visible = false;
            panel_menı.Visible = false;
        }

        private void GebeGiris_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
            panel_menı.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HemsireMesaj mesaj = new HemsireMesaj();
            mesaj.MdiParent = this;
            mesaj.Show();
            panel_menu.Visible = false;
            panel_menı.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
            panel_menı.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
            panel_menı.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
             
        }
    }
}
