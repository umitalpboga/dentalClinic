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
    public partial class frmhastalistele : Form
    {

        clshastalar hastalarcls = new clshastalar();
        public frmhastalistele()
        {
            InitializeComponent();
        }

        private void frmhastalistele_Load(object sender, EventArgs e)
        {
            grdhastalar.DataSource = hastalarcls.HastalariListele();
        }

        private void btnhastakayit_Click(object sender, EventArgs e)
        {
            frmhastaekle f = new frmhastaekle();
            if (f.ShowDialog() == DialogResult.OK)
                grdhastalar.DataSource = hastalarcls.HastalariListele();
        }

        private void btnhastasil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilisatir = grdhastalar.CurrentRow;
            int secilininid = (int)secilisatir.Cells["HastaKodu"].Value;

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Tabloda ki seçtiğiniz kayıt silinsin mi ?", "Kayıt Sil", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {

                hastalarcls.baglantiolustur();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "delete from Hastalar where HastaKodu=@id";
                cmd.Parameters.AddWithValue("@id", secilininid);
                hastalarcls.exenonquerycalistir(cmd);

                grdhastalar.DataSource = hastalarcls.HastalariListele();
            }
            else
            {
                MessageBox.Show("Kayıt Silinmemiştir Bilginize !" ," İşlem İptal", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void btnhastaguncel_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilisatir = grdhastalar.CurrentRow;
            int secilininid = (int)secilisatir.Cells["HastaKodu"].Value;

            frmhastaguncelle f = new frmhastaguncelle();
            f.HastaKodu = secilininid;
            f.ShowDialog();
            grdhastalar.DataSource = hastalarcls.HastalariListele();

            
        }

        private void tbarama_TextChanged(object sender, EventArgs e)
        {
            SqlConnection bag = new SqlConnection();
            bag.ConnectionString = @"Server=.;Database=dishekimligioto;Trusted_Connection=true";
            bag.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = bag;
            cmd.CommandText = @"Select * from Hastalar where Tckimlik  like '%" + tbarama.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable tbl = new DataTable();
            tbl.Load(cmd.ExecuteReader());
            grdhastalar.DataSource = tbl;
            bag.Close();
        }
    }
}
