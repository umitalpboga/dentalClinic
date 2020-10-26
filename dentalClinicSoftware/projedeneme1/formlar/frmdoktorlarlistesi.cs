
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
    public partial class frmdoktorlarlistesi : Form
    {
        
        clsdoktorlar doktorlarcls = new clsdoktorlar();
        public frmdoktorlarlistesi()
        {
            InitializeComponent();
        }
       


        private void frmdoktorlarlistesi_Load(object sender, EventArgs e)
        {
            grddoktorlar.DataSource = doktorlarcls.DoktorlariListele();

        }

        private void btndoktorkayit_Click(object sender, EventArgs e)
        {
          
            frmdoktorekle f = new frmdoktorekle();
               if (f.ShowDialog() == DialogResult.OK)
                grddoktorlar.DataSource = doktorlarcls.DoktorlariListele();
        }

        private void btndoktorsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilisatir = grddoktorlar.CurrentRow;
            int secilininid = (int)secilisatir.Cells["DoktorKodu"].Value;



            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Tabloda ki seçtiğiniz kayıt silinsin mi ?", "Kayıt Sil", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {

                doktorlarcls.baglantiolustur();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "delete from Doktorlar where DoktorKodu=@id";
                cmd.Parameters.AddWithValue("@id", secilininid);
                doktorlarcls.exenonquerycalistir(cmd);

                grddoktorlar.DataSource = doktorlarcls.DoktorlariListele();
            }
            else
            {
                MessageBox.Show("Kayıt Silinmemiştir Bilginize !" , "İşlem İptal",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }

        private void btndoktorguncel_Click(object sender, EventArgs e)
        {
           DataGridViewRow secilisatir = grddoktorlar.CurrentRow;
            int secilininid = (int)secilisatir.Cells["DoktorKodu"].Value;

            //MessageBox.Show(secilininid.ToString());

            frmdoktorguncelle f = new frmdoktorguncelle();
            f.DoktorKodu = secilininid;
            f.ShowDialog();
            grddoktorlar.DataSource = doktorlarcls.DoktorlariListele();




        }

        private void grddoktorlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbarama_TextChanged(object sender, EventArgs e)
        {
            SqlConnection bag = new SqlConnection();
            bag.ConnectionString = @"Server=.;Database=dishekimligioto;Trusted_Connection=true";
            bag.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = bag;
            cmd.CommandText = @"Select * from Doktorlar where Tckimlik  like '%" + tbarama.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable tbl = new DataTable();
            tbl.Load(cmd.ExecuteReader());
            grddoktorlar.DataSource = tbl;
            bag.Close();

        }
    }
}
