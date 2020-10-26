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
   public class clsmuayene : komutlar
    {


        public DataTable DuzenliMuayeneListesi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select tb.TedaviKodu,hb.HastaAdi+' '+hb.HastaSoyadi as HastaBilgisi ,db.DoktorAdi+' '+db.DoktorSoyadi as DoktorBilgisi,hb.Tckimlik,
                                  TedaviAciklamasi,DisKodu,MuayeneTarihi,MuayeneUcreti,MuayeneDurumu 
                                from Tedaviler tb 
                                   join hastalar hb on tb.HastaKodu=hb.HastaKodu 
                                   join Doktorlar db on tb.DoktorKodu=db.DoktorKodu 
                           order by TedaviKodu";
            return executereadercalistir(cmd);
        }

        public DataTable MuayeneListesi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from Tedaviler";
            return executereadercalistir(cmd);
        }

        public void MuayeneKayit( int HastaKodu , int DoktorKodu , decimal MuayeneUcreti , string TedaviAciklamasi, string Poliklinik ,int DisKodu , DateTime MuayeneTarihi )
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Tedaviler
                                (HastaKodu,DoktorKodu,MuayeneUcreti,TedaviAciklamasi,Poliklinik,DisKodu,MuayeneTarihi,MuayeneDurumu)
                                   output inserted.HastaKodu
                                    values
                                 (@HastaKodu,@DoktorKodu,@MuayeneUcreti,@TedaviAciklamasi,@Poliklinik,@DisKodu,@MuayeneTarihi,@MuayeneDurumu)";
            cmd.Parameters.AddWithValue("@HastaKodu",HastaKodu);
            cmd.Parameters.AddWithValue("@DoktorKodu",DoktorKodu);
            cmd.Parameters.AddWithValue("@MuayeneUcreti",MuayeneUcreti);
            cmd.Parameters.AddWithValue("@TedaviAciklamasi",TedaviAciklamasi);
            cmd.Parameters.AddWithValue("@Poliklinik", Poliklinik);
            cmd.Parameters.AddWithValue("@DisKodu",DisKodu);
            cmd.Parameters.AddWithValue("@MuayeneTarihi",MuayeneTarihi);
            cmd.Parameters.AddWithValue("@MuayeneDurumu",false);
            //exenonquerycalistir(cmd);

            int eklenenHastaKodu = executescalarcalistir(cmd);

            clskasaislemleri kasaislemlericls = new clskasaislemleri();
            kasaislemlericls.KasaGiris(eklenenHastaKodu,MuayeneUcreti);




        }

        public void MuayeneDurumunuGuncelle(int TedaviKodu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Tedaviler set MuayeneDurumu=@MuayeneDurumu where TedaviKodu=@TedaviKodu ";
            cmd.Parameters.AddWithValue("@MuayeneDurumu", true);
            cmd.Parameters.AddWithValue("@TedaviKodu", TedaviKodu);
            exenonquerycalistir(cmd);
        }
       








    }
}
