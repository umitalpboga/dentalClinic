using projedeneme1.siniflar;
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
    public partial class frmkasaislemleri : Form
    {
        clskasaislemleri kasaislemlericls = new clskasaislemleri();

        public frmkasaislemleri()
        {
            InitializeComponent();
        }

       public void KasaIslemOzeti()
        {
            DataTable tblkasaozet = new DataTable();
            tblkasaozet = kasaislemlericls.KasaİslemOzet();

            if(tblkasaozet.Rows.Count==0)
            {
                lblkasatoplam.Text = "0";
                lblodenentoplam.Text = "0";
                lblodenmeyentoplam.Text = "0";
            }

            else
            {
                DataRow kasaozet = tblkasaozet.Rows[0];
                lblkasatoplam.Text = kasaozet["GenelToplam"].ToString();
                lblodenentoplam.Text = kasaozet["OdenenToplam"].ToString();
                lblodenmeyentoplam.Text = kasaozet["OdenmeyenToplam"].ToString();
            }
        }

        private void frmkasaislemleri_Load(object sender, EventArgs e)
        {
            grdkasa.DataSource = kasaislemlericls.KasaBilgileri();
            KasaIslemOzeti();
        }

        private void btnodemeal_Click(object sender, EventArgs e)
        {
            DataGridViewRow seciliodeme = grdkasa.CurrentRow;
            int OdemeKodu = Convert.ToInt16(seciliodeme.Cells["OdemeKodu"].Value);
            
            bool OdenmeDurumu = Convert.ToBoolean(seciliodeme.Cells["OdenmeDurumu"].Value);


            if (OdenmeDurumu)
            {
                MessageBox.Show("Bu Ücret Daha Önce Ödenmiştir.","Ödendi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            else
            {
                kasaislemlericls.TedaviUcretiAl(OdemeKodu);
                grdkasa.DataSource = kasaislemlericls.KasaBilgileri(false);
                KasaIslemOzeti();

            }

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            grdkasa.DataSource = kasaislemlericls.KasaBilgileri();
        }

        private void btnodenenler_Click(object sender, EventArgs e)
        {
            grdkasa.DataSource = kasaislemlericls.KasaBilgileri(true);

        }

        private void btnodenmeyenler_Click(object sender, EventArgs e)
        {
            grdkasa.DataSource = kasaislemlericls.KasaBilgileri(false);
        }

     
    }
}
