using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Projekt_SiM
{
    public partial class frmSkladistarPocetna : Form
    {
        public frmSkladistarPocetna()
        {
            InitializeComponent();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrijava odjavaPrijava = new frmPrijava();
            odjavaPrijava.Show();
        }

        private void btnSkladiste_Click(object sender, EventArgs e)
        {
            frmSkladistarSkladiste skladiste = new frmSkladistarSkladiste();
            skladiste.Show();
        }

        private void btnZahtjevnice_Click(object sender, EventArgs e)
        {
            frmSkladistarPopisZahtjevnicaVlasnik zahtjevnica = new frmSkladistarPopisZahtjevnicaVlasnik();
            zahtjevnica.Show();
        }

        private void frmSkladistarPocetna_Load(object sender, EventArgs e)
        {
            frmPrijava nova = new frmPrijava();        
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void btnIzdatnice_Click(object sender, EventArgs e)
        {
            frmSkladistarPopisZahtjevnicaGlavniPekar novaFormaIzdatnice = new frmSkladistarPopisZahtjevnicaGlavniPekar();
            novaFormaIzdatnice.Show();
        }

        private void btnPrimke_Click(object sender, EventArgs e)
        {
            frmSkladistarPrimke primke = new frmSkladistarPrimke();
            primke.Show();
        }

        private void btnPopisIzdatnice_Click(object sender, EventArgs e)
        {
            frmSkladistarPopisIzdatnica noviPopis = new frmSkladistarPopisIzdatnica();
            noviPopis.Show();
        }

        private void btnPoruke_Click(object sender, EventArgs e)
        {
            frmSkladistarPoruke poruke = new frmSkladistarPoruke();
            poruke.Show();
        }

        private void btnOtpisnice_Click(object sender, EventArgs e)
        {
            frmSkladistarPopisOtpisnica noviPopis = new frmSkladistarPopisOtpisnica();
            noviPopis.Show();
        }
    }
}
