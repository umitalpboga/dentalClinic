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
    public partial class frmdoktorguncelle : Form
    {
        public int DoktorKodu;

        clsdoktorlar doktorlarcls = new clsdoktorlar();

        public frmdoktorguncelle()
        {
            InitializeComponent();
        }

        public int Varmi(string aranan)
        {
            int sonuc;
            doktorlarcls.baglantiolustur();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = @"select Count(Tckimlik) from Doktorlar where Tckimlik='" + aranan + "'";
            sonuc = Convert.ToInt32(doktorlarcls.executescalarcalistir(cmd));
            doktorlarcls.baglantikapat();
            return sonuc;


        }


        private void frmdoktorguncelle_Load(object sender, EventArgs e)
        {
            DataRow Doktor = doktorlarcls.DoktorGetir(DoktorKodu);
            tbadi.Text = Doktor["DoktorAdi"].ToString();
            tbsoyadi.Text = Doktor["DoktorSoyadi"].ToString();
            dtpdogum.Value = Convert.ToDateTime(Doktor["DogumTarihi"]);
            tbcinsiyet.Text = Doktor["Cinsiyet"].ToString();
            tbtckimlik.Text = Doktor["TcKimlik"].ToString();
            tbtelefon.Text = Doktor["TelefonNo"].ToString();
            tbadres.Text = Doktor["Adres"].ToString();
            tbbolumu.Text = Doktor["Bolumu"].ToString();
            dtpsozbas.Value = Convert.ToDateTime(Doktor["SozlesmeBaslangic"]);
            dtpsozbit.Value = Convert.ToDateTime(Doktor["SozlesmeBitis"]);
        }

       

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
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
                doktorlarcls.DoktorGuncelleme(DoktorKodu, tbadi.Text, tbsoyadi.Text, dtpdogum.Value, tbcinsiyet.Text, tbtckimlik.Text, tbtelefon.Text, tbadres.Text, tbbolumu.Text, dtpsozbas.Value, dtpsozbit.Value);
                DialogResult = DialogResult.OK;
            }

            else
            {
                MessageBox.Show("Doldurduğunuz kısımları tekrardan göz gezdiriniz!");
            }
        }

        private void frmdoktorguncelle_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Sizden İstenen zorunlu alanları eksiksiz ve doğru bir şekilde giriniz.Hata alıyorsanız alanların yanınıda çıkan ünlem işaretine mouse'unuz ile üstüne gelerek neden hata aldığınızı öğrenebilirsiniz.", " Yardım ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
