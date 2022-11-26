using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GebeTakipSistemi
{
    internal class sqlbaglanti
    {
        public  SqlConnection baglanti()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-THP3847\\SQLEXPRESS;Initial Catalog=GebeTakipSistemi;Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}
