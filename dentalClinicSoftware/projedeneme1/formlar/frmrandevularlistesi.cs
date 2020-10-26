using projedeneme1.siniflar;
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
    public partial class frmrandevularlistesi : Form
    {

        clsrandevular randevularcls = new clsrandevular();

        public frmrandevularlistesi()
        {
            InitializeComponent();
        }

        private void frmrandevularlistesi_Load(object sender, EventArgs e)
        {
            grdrandevular.DataSource = randevularcls.RandevuSade();
        }

        private void btnrandevukayit_Click(object sender, EventArgs e)
        {
            frmrandevuekle f = new frmrandevuekle();
            f.ShowDialog();
            grdrandevular.DataSource = randevularcls.RandevuSade();
        }

        private void btnrandevuiptal_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilisatir = grdrandevular.CurrentRow;
            int secilininid = (int)secilisatir.Cells["RandevuKodu"].Value;

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(" Tabloda ki seçtiğiniz kayıt silinsin mi ?", "Uyarı", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                randevularcls.baglantiolustur();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "delete from Randevular where RandevuKodu=@rid";
                cmd.Parameters.AddWithValue("@rid", secilininid);
                randevularcls.exenonquerycalistir(cmd);

                grdrandevular.DataSource = randevularcls.RandevuSade();

            }
            else
            {
                MessageBox.Show("Randevu silinmemiştir!","İşlem İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnrandevuguncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilisatir = grdrandevular.CurrentRow;
            int secilininid = (int)secilisatir.Cells["RandevuKodu"].Value;

            frmrandevuguncelleme f = new frmrandevuguncelleme();
            f.RandevuKodu = secilininid;
            f.ShowDialog();
            grdrandevular.DataSource = randevularcls.RandevuSade();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataGridViewRow secilisatir = grdrandevular.CurrentRow;
            int secilininid = (int)secilisatir.Cells["RandevuKodu"].Value;

            frmmuayenelistesi f = new frmmuayenelistesi();
            f.RandevuKodu = secilininid;
            f.ShowDialog();

        }

        private void tbarama_TextChanged(object sender, EventArgs e)
        {
            SqlConnection bag = new SqlConnection();
            bag.ConnectionString = @"Server=.;Database=dishekimligioto;Trusted_Connection=true";
            bag.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = bag;
            cmd.CommandText = @"select rb.RandevuKodu,db.DoktorAdi+' '+db.DoktorSoyadi as DoktorBilgisi,hb.HastaAdi+' '+hb.HastaSoyadi as HastaBilgisi,
                               hb.TcKimlik,rb.RandevuTarihi,rb.RandevuSaati,rb.Bolumu 
                               from Randevular rb 
                               join hastalar hb on rb.HastaKodu=hb.HastaKodu 
                               join Doktorlar db on rb.DoktorKodu=db.DoktorKodu 
                                    where hb.Tckimlik  like '%" + tbarama.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable tbl = new DataTable();
            tbl.Load(cmd.ExecuteReader());
            grdrandevular.DataSource = tbl;
            bag.Close();
        }

        private void btnmuayenekayit_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilisatir = grdrandevular.CurrentRow;
            int secilininid = (int)secilisatir.Cells["RandevuKodu"].Value;

            frmsecilikisimuayene f = new frmsecilikisimuayene();
            

            
            f.RandevuKodu = secilininid;

            

            f.ShowDialog();
        }
    }
}
