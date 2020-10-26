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
    public partial class frmhastaekle : Form
    {
        clshastalar hastalarcls = new clshastalar();

        public frmhastaekle()
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
                          
            if(tbtelefon.TextLength < 10 || tbtelefon.TextLength > 10 || tbtelefon.Text == "")
            {
                kaydedilecek = false;
                errorProvider1.SetError(tbtelefon, "Başında 0 olmadan yazınız ve Boş bırakmayınız!");
            }

            if (tbkimlik.TextLength < 11 || tbkimlik.TextLength > 11 || tbkimlik.Text == "")
            {

                kaydedilecek = false;
                errorProvider1.SetError(tbkimlik, "TC kimlik bilgilerini giriniz ve Alanı boş bırakmayınız!");
            }


            if (Varmi(tbkimlik.Text) != 0)
            {
                kaydedilecek = false;
                errorProvider1.SetError(tbkimlik, "Bu TC kimlik ile daha önce kayıt yapılmış!");
            }

          
            if (kaydedilecek)
            {
                clshastalar hastalarcls = new clshastalar();
                hastalarcls.HastaEkle(tbadi.Text, tbsoyadi.Text, tbkimlik.Text , tbcinsiyet.Text, dtpdogumtarihi.Value, tbtelefon.Text, tbadres.Text);
                this.DialogResult = DialogResult.OK;
            }

            else
            {
                MessageBox.Show("Doldurduğunuz kısımları tekrardan göz gezdiriniz!");
            }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmhastaekle_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Sizden İstenen zorunlu alanları eksiksiz ve doğru bir şekilde giriniz.Hata alıyorsanız alanların yanınıda çıkan ünlem işaretine mouse'unuz ile üstüne gelerek neden hata aldığınızı öğrenebilirsiniz.", " Yardım ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmhastaekle_Load(object sender, EventArgs e)
        {

        }
    }
}
