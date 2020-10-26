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
    public partial class frmsecilikisimuayene : Form

    {


        public int RandevuKodu;

        clsmuayene muayenecls = new clsmuayene();
        clsdoktorlar doktorlarcls = new clsdoktorlar();
        clshastalar hastalarcls = new clshastalar();
        clsrandevular randevularcls = new clsrandevular();

        public frmsecilikisimuayene()
        {
            InitializeComponent();
        }

        private void frmsecilikisimuayene_Load(object sender, EventArgs e)
        {


            grdmuayeneler.DataSource = muayenecls.DuzenliMuayeneListesi();
            cbhasta.DataSource = hastalarcls.ComboBoxMultipleMember();
            cbdoktor.DataSource = doktorlarcls.ComboBoxMultipleMember();

            Boolean gsr;
            gsr = Convert.ToBoolean(RandevuKodu);

            if (gsr == true)
            {
                DataRow randevu = randevularcls.RandevuGetir(RandevuKodu);
                cbhasta.SelectedValue = randevu["HastaKodu"].ToString();
                cbdoktor.SelectedValue = randevu["DoktorKodu"].ToString();
                tbpoliklinik.Text = randevu["Bolumu"].ToString();
            }

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
     
            bool kaydedilecek = true;

            if (string.IsNullOrWhiteSpace(tbnumara.Text))
            {
                kaydedilecek = false;
                errorProvider1.SetError(tbnumara, "Diş Numarasını Yazınız!");
            }

            if (kaydedilecek)
            {

                muayenecls.MuayeneKayit(Convert.ToInt16(cbhasta.SelectedValue), Convert.ToInt16(cbdoktor.SelectedValue), Convert.ToDecimal(tbucret.Text), tbaciklama.Text, tbpoliklinik.Text, Convert.ToInt16(tbnumara.Text), dtpmuayenetarihi.Value);

                grdmuayeneler.DataSource = muayenecls.DuzenliMuayeneListesi();

                tbnumara.Clear();
                tbaciklama.Clear();
                tbucret.Clear();
                tbpoliklinik.Clear();

            }
            else
            {
                MessageBox.Show("Gerekli Alanları Doldurunuz!");
            }
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Muayene Oluşturulmayacaktır Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.DialogResult = DialogResult.None;
        }

        private void btnsonlandir_Click(object sender, EventArgs e)
        {

            DataGridViewRow secilimuayene = grdmuayeneler.CurrentRow;
            int tedavikodu = Convert.ToInt16(secilimuayene.Cells["TedaviKodu"].Value);
            bool muayenedurumu = Convert.ToBoolean(secilimuayene.Cells["MuayeneDurumu"].Value);

            if (muayenedurumu)
            {
                MessageBox.Show("Tedavi Zaten Sonlandırılmıştır.");
            }

            else
            {
                muayenecls.MuayeneDurumunuGuncelle(tedavikodu);
                grdmuayeneler.DataSource = muayenecls.DuzenliMuayeneListesi();

            }
        }

        private void tbarama_TextChanged(object sender, EventArgs e)
        {
            SqlConnection bag = new SqlConnection();
            bag.ConnectionString = @"Server=.;Database=dishekimligioto;Trusted_Connection=true";
            bag.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = bag;
            cmd.CommandText = @"select tb.TedaviKodu,hb.HastaAdi+' '+hb.HastaSoyadi as HastaBilgisi ,db.DoktorAdi+' '+db.DoktorSoyadi as DoktorBilgisi,hb.Tckimlik,
                                  TedaviAciklamasi,DisKodu,MuayeneTarihi,MuayeneUcreti,MuayeneDurumu 
                                from Tedaviler tb 
                                   join hastalar hb on tb.HastaKodu=hb.HastaKodu 
                                   join Doktorlar db on tb.DoktorKodu=db.DoktorKodu  
                                        where hb.Tckimlik like '%" + tbarama.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable tbl = new DataTable();
            tbl.Load(cmd.ExecuteReader());
            grdmuayeneler.DataSource = tbl;
            bag.Close();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilisatir = grdmuayeneler.CurrentRow;
            int secilininid = (int)secilisatir.Cells["TedaviKodu"].Value;

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kayıt silinsin mi ?", "Evet", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                hastalarcls.baglantiolustur();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "delete from Tedaviler where TedaviKodu=@id";
                cmd.Parameters.AddWithValue("@id", secilininid);
                hastalarcls.exenonquerycalistir(cmd);

                grdmuayeneler.DataSource = muayenecls.DuzenliMuayeneListesi();
            }
            else
            {
                MessageBox.Show("Kayıt Silinmemiştir Bilginize !");
            }
        }
    }
}
