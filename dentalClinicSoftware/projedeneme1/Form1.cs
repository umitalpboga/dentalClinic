using projedeneme1.formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projedeneme1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void doktorEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formlar.frmdoktorekle f = new formlar.frmdoktorekle();
            f.ShowDialog();
        }

        private void doktorlarListeisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formlar.frmdoktorlarlistesi f = new formlar.frmdoktorlarlistesi();
            f.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void doktorlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doktorListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdoktorlarlistesi f = new frmdoktorlarlistesi();
            f.ShowDialog();
        }

        private void doktorKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdoktorekle f = new frmdoktorekle();
            f.ShowDialog();
        }

        private void sözlesmeGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdoktorguncelle f = new frmdoktorguncelle();
            f.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmhastalistele f = new frmhastalistele();
            f.ShowDialog();
        }

        private void hastaKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhastaekle f = new frmhastaekle();
            f.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmrandevularlistesi f = new frmrandevularlistesi();
            f.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmrandevuekle f = new frmrandevuekle();
            f.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            

            frmmuayenelistesi f = new frmmuayenelistesi();
            f.ShowDialog();
        }

        private void ödemelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkasaislemleri f = new frmkasaislemleri();
            f.ShowDialog();
        }

        private void muayeneKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmuayenelistesi f = new frmmuayenelistesi();
            f.ShowDialog();
        }
    }
}
