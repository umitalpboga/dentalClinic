using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projedeneme1.sınıflar.siniflar
{
   public  class clsdoktorlar  : komutlar
    {
        public DataTable ComboBoxMultipleMember()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select DoktorKodu , DoktorAdi+' '+DoktorSoyadi as doktor from Doktorlar";
            return executereadercalistir(cmd);
        }

        public DataTable DoktorlariListele()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from Doktorlar";
            return executereadercalistir(cmd);

        }

        public DataRow DoktorGetir(int DoktorKodu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from Doktorlar where DoktorKodu=@doktorkodu";
            cmd.Parameters.AddWithValue("@doktorkodu", DoktorKodu);
            return executereadercalistir(cmd).Rows[0];
        }



        public void DoktorEkle(string adi , string soyadi , DateTime dogumtarihi , string cinsiyet , string tckimlik , string telefonno , string adres , string bolum , DateTime sozlesmebas, DateTime sozlesmebit )
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" insert into Doktorlar 
                                 (DoktorAdi , DoktorSoyadi , DogumTarihi , Cinsiyet , Tckimlik , TelefonNo , Adres , Bolumu , SozlesmeBaslangic , SozlesmeBitis )
                                 Values
                                 (@Adi , @Soyadi , @DogumTarihi , @Cinsiyet , @Tckimlik , @TelefonNo , @Adres , @Bolumu , @SozlesmeBaslangic , @SozlesmeBitis)";
            cmd.Parameters.AddWithValue("@Adi", adi);
            cmd.Parameters.AddWithValue("@Soyadi", soyadi);
            cmd.Parameters.AddWithValue("@DogumTarihi", dogumtarihi);
            cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
            cmd.Parameters.AddWithValue("@Tckimlik", tckimlik);
            cmd.Parameters.AddWithValue("@TelefonNo",telefonno);
            cmd.Parameters.AddWithValue("@Adres", adres );
            cmd.Parameters.AddWithValue("@Bolumu", bolum );
            cmd.Parameters.AddWithValue("@SozlesmeBaslangic", sozlesmebas);
            cmd.Parameters.AddWithValue("@SozlesmeBitis", sozlesmebit);
            exenonquerycalistir(cmd);

            

        }
         
        public void DoktorGuncelleme(int doktorkodu,string adi, string soyadi, DateTime dogumtarihi, string cinsiyet, string tckimlik, string telefonno, string adres, string bolum, DateTime sozlesmebas, DateTime sozlesmebit)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update Doktorlar set
                                DoktorAdi=@Adi,DoktorSoyadi=@Soyadi,DogumTarihi=@DogumTarihi,Cinsiyet=@Cinsiyet,
                                Tckimlik=@Tckimlik,TelefonNo=@TelefonNo,Adres=@Adres,Bolumu=@Bolumu,
                                SozlesmeBaslangic=@SozlesmeBaslangic,SozlesmeBitis=@SozlesmeBitis where DoktorKodu=@doktorkodu";
            cmd.Parameters.AddWithValue("@Adi", adi);
            cmd.Parameters.AddWithValue("@Soyadi", soyadi);
            cmd.Parameters.AddWithValue("@DogumTarihi", dogumtarihi);
            cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
            cmd.Parameters.AddWithValue("@Tckimlik", tckimlik);
            cmd.Parameters.AddWithValue("@TelefonNo", telefonno);
            cmd.Parameters.AddWithValue("@Adres", adres);
            cmd.Parameters.AddWithValue("@Bolumu", bolum);
            cmd.Parameters.AddWithValue("@SozlesmeBaslangic", sozlesmebas);
            cmd.Parameters.AddWithValue("@SozlesmeBitis", sozlesmebit);
            cmd.Parameters.AddWithValue("@doktorkodu", doktorkodu);
            exenonquerycalistir(cmd);

        }

     
     
    }
}
