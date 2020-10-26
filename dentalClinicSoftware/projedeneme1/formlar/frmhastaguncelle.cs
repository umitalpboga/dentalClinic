using projedeneme1.sınıflar.siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projedeneme1.formlar
{
    public partial class frmhastaguncelle : Form
    {

        public int HastaKodu;

        clshastalar hastalarcls = new clshastalar();
       
        

        public frmhastaguncelle()
        {
            InitializeComponent();
        }

        public int Varmi(string aranan)
        {
            int sonuc;
            hastalarcls.baglantiolustur();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"select Count(Tckimlik) from hastalar where Tckimlik='" + aranan + "'";
            sonuc = Convert.ToInt32(hastalarcls.executescalarcalistir(cmd));
            hastalarcls.baglantikapat();
            return sonuc;


        }


        private void frmhastaguncelle_Load(object sender, EventArgs e)
        {
            DataRow Hasta = hastalarcls.HastaGetir(HastaKodu);
            tbadi.Text = Hasta["HastaAdi"].ToString();
            tbsoyadi.Text = Hasta["HastaSoyadi"].ToString();
            tbtckimlik.Text = Hasta["TcKimlik"].ToString();
            tbcinsiyet.Text = Hasta["Cinsiyet"].ToString();
            dtpdogum.Value = Convert.ToDateTime(Hasta["DogumTarihi"]);
            tbtelefon.Text = Hasta["TelefonNo"].ToString();
            tbadres.Text = Hasta["Adres"].ToString();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool kaydedilecek = true;

            if (tbadi.TextLength < 2 || tbadi.Text == "")
            {
                kaydedilecek = false;
                errorProvider1.SetError(tbadi, "2 karakterden az bilgi girmeyin ve Alanı boş bırakmayınız!");
            }

            if (tbsoyadi.TextLength < 2 || tbsoyadi.Text == "")
            {
                kaydedilecek = false;
                errorProvider1.SetError(tbsoyadi, "2 karakterden az bilgi girmeyin ve Alanı boş bırakmayınız!");
            }

            if (tbtckimlik.TextLength < 11 || tbtckimlik.TextLength > 11 || tbtckimlik.Text == "")
            {

                kaydedilecek = false;
                errorProvider1.SetError(tbtckimlik, "TC kimlik bilgilerini giriniz ve Alanı boş bırakmayınız!");
            }

            if (Varmi(tbtckimlik.Text) != 0)
            {
                kaydedilecek = false;
                errorProvider1.SetError(tbtckimlik, "Bu TC kimlik ile daha önce kayıt yapılmış!");
            }

            if (tbtelefon.TextLength < 10 || tbtelefon.TextLength > 10 || tbtelefon.Text == "")
            {
                kaydedilecek = false;
                errorProvider1.SetError(tbtelefon, "Başında 0 olmadan yazınız ve Boş bırakmayınız!");
            }

            if (kaydedilecek)
            {
                hastalarcls.HastaGuncelleme(HastaKodu, tbadi.Text, tbsoyadi.Text, tbtckimlik.Text , tbcinsiyet.Text , dtpdogum.Value , tbtelefon.Text , tbadres.Text);
                DialogResult = DialogResult.OK;
            }

            else
            {
                MessageBox.Show("Gerekli Alanları Boş Bırakmayınız!");
            }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
        }

        private void frmhastaguncelle_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Sizden İstenen zorunlu alanları eksiksiz ve doğru bir şekilde giriniz.Hata alıyorsanız alanların yanınıda çıkan ünlem işaretine mouse'unuz ile üstüne gelerek neden hata aldığınızı öğrenebilirsiniz.", " Yardım ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
