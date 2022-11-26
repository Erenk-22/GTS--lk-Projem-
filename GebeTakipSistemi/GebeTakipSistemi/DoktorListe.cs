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
    public partial class DoktorListe : Form
    {
        public DoktorListe()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-THP3847\\SQLEXPRESS;Initial Catalog=GebeTakipSistemi;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
                MessageBox.Show("Tc Kimlik numarası giriniz", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from tbl_ilkay where TC like'" + textBox4.Text + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close(); 
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
                MessageBox.Show("Tc Kimlik numarası giriniz", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from tbl_ikinciay where Tc like'" + textBox4.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
                MessageBox.Show("Tc Kimlik numarası giriniz", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from tbl_sonay where Tc like'" + textBox4.Text + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                conn.Close();
            }
        }
    }
}
