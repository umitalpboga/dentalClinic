using projedeneme1.siniflar;
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
    public partial class frmrandevuekle : Form
    {
        clsrandevular randevularcls = new clsrandevular();
        public frmrandevuekle()
        {
            InitializeComponent();
        }

       


        private void frmrandevuekle_Load(object sender, EventArgs e)
        {
            clshastalar hastalarcls = new clshastalar();
            cbhastalar.DataSource = hastalarcls.ComboBoxMultipleMember();

            clsdoktorlar doktorlarcls = new clsdoktorlar();
            cbdoktorlar.DataSource = doktorlarcls.ComboBoxMultipleMember();

          
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool kaydedilecek = true;


            if (tbpoliklinik.TextLength < 3 || tbpoliklinik.Text == "")
            {

                kaydedilecek = false;
                errorProvider1.SetError(tbpoliklinik, "Poliklinik adını giriniz ve Alanı boş bırakmayınız!");
            }

            if(cbrandevusaati.Text == "")
            {
                kaydedilecek = false;
                errorProvider1.SetError(cbrandevusaati, "Randevu saatini boş bırakmayınız!");
            }

            

            if (kaydedilecek)
            {

            randevularcls.RandevuOlustur(Convert.ToInt16(cbhastalar.SelectedValue), Convert.ToInt16(cbdoktorlar.SelectedValue), dtprandevutarihi.Value , Convert.ToDateTime(cbrandevusaati.SelectedItem) , tbpoliklinik.Text);
            this.DialogResult = DialogResult.OK;
                
            
            }

            else
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz!");
            }


        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Randevu Oluşturulmayacaktır Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
            this.DialogResult = DialogResult.Cancel;

        }

        private void frmrandevuekle_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Sizden İstenen zorunlu alanları eksiksiz ve doğru bir şekilde giriniz.Hata alıyorsanız alanların yanınıda çıkan ünlem işaretine mouse'unuz ile üstüne gelerek neden hata aldığınızı öğrenebilirsiniz.", " Yardım ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
