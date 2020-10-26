using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projedeneme1.sınıflar.siniflar
{
    public class clshastalar : komutlar
    {


        public DataTable ComboBoxMultipleMember()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select HastaKodu , HastaAdi+' '+HastaSoyadi as hasta from hastalar";
            return executereadercalistir(cmd);


        }
        
        public DataTable HastalariListele()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from Hastalar";
            return executereadercalistir(cmd);
        }

        public DataRow HastaGetir(int HastaKodu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from hastalar where HastaKodu=@hastakodu";
            cmd.Parameters.AddWithValue("@hastakodu", HastaKodu);
            return executereadercalistir(cmd).Rows[0];
        }

        public void HastaEkle(string Adi , string Soyadi, string TcKimlik, string Cinsiyet , DateTime DogumTarihi, string TelefonNo, string Adres)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @" INSERT INTO hastalar 
                                 (HastaAdi,HastaSoyadi,TcKimlik,Cinsiyet,DogumTarihi,TelefonNo,Adres)
		                         VALUES
                                 (@Adi,@Soyadi,@TcKimlik,@Cinsiyet,@DogumTarihi,@TelefonNo,@Adres)";
            cmd.Parameters.AddWithValue("@Adi",Adi);
            cmd.Parameters.AddWithValue("@Soyadi",Soyadi);
            cmd.Parameters.AddWithValue("@TcKimlik",TcKimlik);
            cmd.Parameters.AddWithValue("@Cinsiyet",Cinsiyet);
            cmd.Parameters.AddWithValue("@DogumTarihi",DogumTarihi);
            cmd.Parameters.AddWithValue("@TelefonNo",TelefonNo);
            cmd.Parameters.AddWithValue("@Adres",Adres);
            exenonquerycalistir(cmd);
        }

        public void HastaGuncelleme(int hastakodu,string adi,string soyadi, string tckimlik , string cinsiyet , DateTime dogumtarihi,string telefon ,string adres)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"update hastalar set
                                HastaAdi=@Adi,HastaSoyadi=@Soyadi,TcKimlik=@TcKimlik,Cinsiyet=@Cinsiyet,
                                DogumTarihi=@DogumTarihi,TelefonNo=@TelefonNo,Adres=@Adres where HastaKodu=@HastaKodu";
            cmd.Parameters.AddWithValue("@Adi",adi);
            cmd.Parameters.AddWithValue("@Soyadi",soyadi);
            cmd.Parameters.AddWithValue("@TcKimlik",tckimlik);
            cmd.Parameters.AddWithValue("@Cinsiyet",cinsiyet);
            cmd.Parameters.AddWithValue("@DogumTarihi",dogumtarihi);
            cmd.Parameters.AddWithValue("@TelefonNo",telefon);
            cmd.Parameters.AddWithValue("@Adres",adres);
            cmd.Parameters.AddWithValue("@HastaKodu",hastakodu);
            exenonquerycalistir(cmd);

        }


    }
}
