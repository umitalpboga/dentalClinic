using projedeneme1.siniflar;
using projedeneme1.sınıflar.siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projedeneme1.formlar
{
    public partial class frmrandevuguncelleme : Form
    {
        public int RandevuKodu;

        clsrandevular randevularcls = new clsrandevular();
        clshastalar hastalarcls = new clshastalar();
        clsdoktorlar doktorlarcls = new clsdoktorlar();


        public frmrandevuguncelleme()
        {
            InitializeComponent();
        }

        private void frmrandevuguncelleme_Load(object sender, EventArgs e)
        {

            cbhastalar.DataSource = hastalarcls.ComboBoxMultipleMember();
            cbdoktorlar.DataSource = doktorlarcls.ComboBoxMultipleMember();
           

            DataRow randevu = randevularcls.RandevuGetir(RandevuKodu);
            cbhastalar.SelectedValue = randevu["HastaKodu"].ToString();
            cbdoktorlar.SelectedValue = randevu["DoktorKodu"].ToString();
            dtprandevutarihi.Value = Convert.ToDateTime(randevu["RandevuTarihi"]);
            cbrandevusaati.SelectedValue =Convert.ToString(randevu["RandevuSaati"]);
            tbpoliklinik.Text = randevu["Bolumu"].ToString();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool kaydedilecek = true;

          

            if (string.IsNullOrWhiteSpace(tbpoliklinik.Text))
            {
                kaydedilecek = false;
                errorProvider1.SetError(tbpoliklinik, "Poliklinik adını yazınız!");
            }

            if (string.IsNullOrWhiteSpace(cbrandevusaati.Text))
            {
                kaydedilecek = false;
                errorProvider1.SetError(cbrandevusaati, "Randevu saatini giriniz!");
            }


            if (kaydedilecek)
            {

                randevularcls.RandevuGuncelleme(RandevuKodu, Convert.ToInt16(cbhastalar.SelectedValue), Convert.ToInt16(cbdoktorlar.SelectedValue), dtprandevutarihi.Value, Convert.ToDateTime(cbrandevusaati.SelectedItem),tbpoliklinik.Text);
                this.DialogResult = DialogResult.OK;

            }

            else
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz!");
            }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmrandevuguncelleme_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Sizden İstenen zorunlu alanları eksiksiz ve doğru bir şekilde giriniz.Hata alıyorsanız alanların yanınıda çıkan ünlem işaretine mouse'unuz ile üstüne gelerek neden hata aldığınızı öğrenebilirsiniz.", " Yardım ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
