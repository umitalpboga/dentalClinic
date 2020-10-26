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
   public class clskasaislemleri:komutlar
    {
        

        public DataTable KasaBilgileri()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select kb.OdemeKodu,hb.HastaAdi+' '+hb.HastaSoyadi as KişiBilgileri , kb.OdenecekTutar,kb.OdenmeTarihi,kb.OdenmeDurumu 
                                  from Kasaİslemleri kb join hastalar hb on kb.HastaKodu=hb.HastaKodu order by OdemeKodu";
            return executereadercalistir(cmd);
        }

        public DataTable KasaBilgileri(bool durum)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select kb.OdemeKodu,hb.HastaAdi+' '+hb.HastaSoyadi as KişiBilgileri , kb.OdenecekTutar,kb.OdenmeTarihi,kb.OdenmeDurumu 
                                  from Kasaİslemleri kb join hastalar hb on kb.HastaKodu=hb.HastaKodu where OdenmeDurumu=@OdenmeDurumu order by OdemeKodu";
            cmd.Parameters.AddWithValue("@OdenmeDurumu",durum);
            
            return executereadercalistir(cmd);
        }

        public void KasaGiris(int HastaKodu, decimal OdenecekTutar)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"insert into Kasaİslemleri
                                  (HastaKodu,OdenecekTutar,OdenmeDurumu)
                                   values
                                   (@HastaKodu,@OdenecekTutar,@OdenmeDurumu)";
            cmd.Parameters.AddWithValue("@HastaKodu",HastaKodu);
            cmd.Parameters.AddWithValue("@OdenecekTutar", OdenecekTutar);
            cmd.Parameters.AddWithValue("@OdenmeDurumu", false);
            exenonquerycalistir(cmd);
        }

        public DataTable KasaİslemOzet()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"select
                               (
                                select isnull(sum(OdenecekTutar),0) from Kasaİslemleri
                                where OdenmeDurumu = 0) as OdenmeyenToplam,
                               (
                                select isnull(sum(OdenecekTutar),0) from Kasaİslemleri
                                where OdenmeDurumu = 1) as OdenenToplam,
                               (
                                select isnull(sum(OdenecekTutar),0) from Kasaİslemleri ) as GenelToplam";
            return executereadercalistir(cmd);
        }

        public void TedaviUcretiAl(int OdemeKodu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"Update Kasaİslemleri set OdenmeDurumu=@OdenmeDurumu,OdenmeTarihi=@OdenmeTarihi where OdemeKodu=@OdemeKodu";
            cmd.Parameters.AddWithValue("@OdenmeDurumu",true);
            cmd.Parameters.AddWithValue("OdenmeTarihi", DateTime.Now);
            cmd.Parameters.AddWithValue("@OdemeKodu", OdemeKodu);
            exenonquerycalistir(cmd);

        }
    }
}
