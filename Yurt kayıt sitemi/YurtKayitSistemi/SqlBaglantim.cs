using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YurtKayitSistemi
{
     public class SqlBaglantim
     {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-3P10V0AA;Initial Catalog=YurtOtomasyon;Integrated Security=True"); //SQL Bağlantım için
            baglan.Open();
            return baglan;
        }

    }
}
