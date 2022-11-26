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
    public partial class ikinciay : Form
    {
        public ikinciay()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-THP3847\\SQLEXPRESS;Initial Catalog=GebeTakipSistemi;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;
        void griddoldur2()
        {
            da = new SqlDataAdapter("Select *From Tbl_ikinciay", conn);
            ds = new DataSet();
            conn.Open();
            da.Fill(ds, "Tbl_ikinciay");
            dataGridView1.DataSource = ds.Tables["Tbl_ikinciay"];
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_ikinciay(Tc,soru1,soru2,soru3,soru4,soru5,ekstra)values(@s1,@s2,@s3,@s4,@s5,@s6,@s7)", conn);
            cmd.Parameters.AddWithValue("@s1", txt_tc.Text);
            cmd.Parameters.AddWithValue("@s2", soru1.Text);
            cmd.Parameters.AddWithValue("@s3", soru2.Text);
            cmd.Parameters.AddWithValue("@s4", soru3.Text);
            cmd.Parameters.AddWithValue("@s5", soru4.Text);
            cmd.Parameters.AddWithValue("@s6", soru5.Text);
            cmd.Parameters.AddWithValue("@s7", soru6.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Formunuz Dolduruldu Teşekkür ederiz", "Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            griddoldur2();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_tc.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soru1.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            soru2.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            soru3.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            soru4.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            soru5.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            soru6.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void ikinciay_Load(object sender, EventArgs e)
        {
            griddoldur2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string kayit = "update Tbl_ilkay set soru1=@s1,soru2=@s2,soru3=@s3,soru4=@s4,soru5=@s5,ekstra=@s6 where Tc='" + txt_tc.Text + "'";
            SqlCommand guncelle = new SqlCommand(kayit, conn);
            guncelle.Parameters.AddWithValue("@s1", soru1.Text);
            guncelle.Parameters.AddWithValue("@s2", soru2.Text);
            guncelle.Parameters.AddWithValue("@s3", soru3.Text);
            guncelle.Parameters.AddWithValue("@s4", soru4.Text);
            guncelle.Parameters.AddWithValue("@s5", soru5.Text);
            guncelle.Parameters.AddWithValue("@s6", soru6.Text);
            guncelle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Formunuz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            griddoldur2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Tbl_ikinciay where Tc=@t1", conn);
            cmd.Parameters.AddWithValue("@t1", txt_tc.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("kayıt silindi");
            griddoldur2();
        }
    }
}
