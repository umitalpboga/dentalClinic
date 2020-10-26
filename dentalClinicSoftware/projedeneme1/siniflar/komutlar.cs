using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projedeneme1.sınıflar
{
   public class komutlar
    {
        SqlConnection baglanti;

        string connectionString = "Server=.;Database=dishekimligioto;Trusted_Connection=true";

        public void baglantiolustur()
        {
            baglanti = new SqlConnection();
            baglanti.ConnectionString = connectionString;
            baglanti.Open();

        }

        public void baglantikapat()
        {
            baglanti.Close();

        }

        public void exenonquerycalistir(SqlCommand cmd)
        {
            baglantiolustur();
            cmd.Connection = baglanti;
            cmd.ExecuteNonQuery();
            baglantikapat();

        }

        public int executescalarcalistir(SqlCommand cmd)
        {
            baglantiolustur();
            cmd.Connection = baglanti;
            return (int)cmd.ExecuteScalar();

        }

        public DataTable executereadercalistir(SqlCommand cmd)
        {
            baglantiolustur();
            cmd.Connection = baglanti;
            DataTable tbl = new DataTable();
            tbl.Load(cmd.ExecuteReader());
            baglantikapat();
            return tbl;
        }

        
        

    }
}
