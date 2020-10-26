using projedeneme1.sınıflar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projedeneme1.siniflar
{
   public class clsrandevular : komutlar
    {
   


        public DataTable RandevuSade()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select rb.RandevuKodu,db.DoktorAdi+' '+db.DoktorSoyadi as DoktorBilgisi,hb.HastaAdi+' '+hb.HastaSoyadi as HastaBilgisi,
                               hb.TcKimlik,rb.RandevuTarihi,rb.RandevuSaati,rb.Bolumu 
                               from Randevular rb 
                               join hastalar hb on rb.HastaKodu=hb.HastaKodu 
                               join Doktorlar db on rb.DoktorKodu=db.DoktorKodu 
                            order by RandevuKodu ";

            return executereadercalistir(cmd);

        }
      


        public DataTable RandevulariListele()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Randevular";
            return executereadercalistir(cmd);
        }

        public DataRow RandevuGetir(int RandevuKodu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from Randevular where RandevuKodu=@RandevuKodu";
            cmd.Parameters.AddWithValue("@RandevuKodu", RandevuKodu);
            return executereadercalistir(cmd).Rows[0];
        }

        public void RandevuOlustur(int HastaKodu, int DoktorKodu, DateTime RandevuTarihi, DateTime RandevuSaati, string Bolumu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" insert into Randevular 
                                 (HastaKodu,DoktorKodu,RandevuTarihi,RandevuSaati,Bolumu)
                                 
                                  values
                                  (@HastaKodu,@DoktorKodu,@RandevuTarihi,@RandevuSaati,@Bolumu)";
            cmd.Parameters.AddWithValue("@HastaKodu", HastaKodu);
            cmd.Parameters.AddWithValue("@DoktorKodu", DoktorKodu);
            cmd.Parameters.AddWithValue("@RandevuTarihi", RandevuTarihi);
            cmd.Parameters.AddWithValue("@RandevuSaati", RandevuSaati);
            cmd.Parameters.AddWithValue("@Bolumu", Bolumu);
            exenonquerycalistir(cmd);


        }


        public void RandevuGuncelleme(int RandevuKodu, int HastaKodu, int DoktorKodu, DateTime RandevuTarihi, DateTime RandevuSaati, string Bolumu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Update Randevular set
                                 HastaKodu=@HastaKodu,DoktorKodu=@DoktorKodu,
                                 RandevuTarihi=@RandevuTarihi,RandevuSaati=@RandevuSaati,Bolumu=@Bolumu where RandevuKodu=@RandevuKodu";
            cmd.Parameters.AddWithValue("@HastaKodu",HastaKodu);
            cmd.Parameters.AddWithValue("@DoktorKodu",DoktorKodu);
            cmd.Parameters.AddWithValue("@RandevuTarihi",RandevuTarihi);
            cmd.Parameters.AddWithValue("@RandevuSaati",RandevuSaati);
            cmd.Parameters.AddWithValue("@Bolumu",Bolumu);
            cmd.Parameters.AddWithValue("@RandevuKodu",RandevuKodu);
            exenonquerycalistir(cmd);

        }

    }
}
