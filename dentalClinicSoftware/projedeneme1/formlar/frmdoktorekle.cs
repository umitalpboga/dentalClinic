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
    public partial class frmdoktorekle : Form
    {
        clsdoktorlar doktorlarcls = new clsdoktorlar();

        public int DoktorTc;

     

        public frmdoktorekle()
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

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool kaydedilecek = true;


            if(tbadi.TextLength < 2 || tbadi.Text == "" )
            {
                kaydedilecek = false;
                errorProvider1.SetError(tbadi, "2 karakterden az bilgi girmeyin ve Alanı boş bırakmayınız!");
            }

            if(tbsoyadi.TextLength < 2 || tbsoyadi.Text == "")
            {
                kaydedilecek = false;
                errorProvider1.SetError(tbsoyadi, "2 karakterden az bilgi girmeyin ve Alanı boş bırakmayınız!");
            }

           
            if(tbtckimlik.TextLength < 11 || tbtckimlik.TextLength > 11 || tbtckimlik.Text == "")
            {

                kaydedilecek = false;
                errorProvider1.SetError(tbtckimlik, "TC kimlik bilgilerini giriniz ve Alanı boş bırakmayınız!");
            }

            if (Varmi(tbtckimlik.Text) != 0)
            {
                kaydedilecek = false;
                errorProvider1.SetError(tbtckimlik, "Bu TC kimlik ile daha önce kayıt yapılmış!");
            }

            if(tbtelefon.TextLength < 10 || tbtelefon.TextLength > 10 || tbtelefon.Text == "")
            {
                kaydedilecek = false;
                errorProvider1.SetError(tbtelefon, "Başında 0 olmadan yazınız ve Boş bırakmayınız!");
            }
            




            if (kaydedilecek)
            {
                clsdoktorlar doktorlarcls = new clsdoktorlar();
                doktorlarcls.DoktorEkle(tbadi.Text, tbsoyadi.Text, dtpdogum.Value, tbcinsiyet.Text , tbtckimlik.Text, tbtelefon.Text , tbadres.Text, tbbolumu.Text, dtpsozbas.Value, dtpsozbit.Value);
                this.DialogResult = DialogResult.OK;
            }

            else
            {
                MessageBox.Show("Doldurduğunuz kısımları tekrardan göz gezdiriniz!");


            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        

   
        private void frmdoktorekle_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Sizden İstenen zorunlu alanları eksiksiz ve doğru bir şekilde giriniz.Hata alıyorsanız alanların yanınıda çıkan ünlem işaretine mouse'unuz ile üstüne gelerek neden hata aldığınızı öğrenebilirsiniz." , " Yardım " , MessageBoxButtons.OK , MessageBoxIcon.Information);
           
        }

        private void frmdoktorekle_Load(object sender, EventArgs e)
        {

        }
    }
}
