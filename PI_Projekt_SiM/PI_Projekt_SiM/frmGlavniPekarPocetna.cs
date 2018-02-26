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
    public partial class frmGlavniPekarPocetna : Form
    {
        public frmGlavniPekarPocetna()
        {
            InitializeComponent();
        }

        //Event handler gumba za odjavu
        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrijava odjavaPrijava = new frmPrijava();
            odjavaPrijava.Show();
        }

        //Event handler gumba za zahtjevnice 
        private void btnZahtjevnica_Click(object sender, EventArgs e)
        {
            frmGlavniPekarZahtjevnice zahtjevnice = new frmGlavniPekarZahtjevnice();
            zahtjevnice.Show();
        }

        //Event handler gumba za skladiste
        private void btnSkladiste_Click(object sender, EventArgs e)
        {
            frmGlavniPekarSkladiste novaSkladiste = new frmGlavniPekarSkladiste();
            novaSkladiste.Show();
        }

        //Event handler gumba za poruke
        private void btnPoruke_Click(object sender, EventArgs e)
        {
            frmGlavniPekarPoruke poruke = new frmGlavniPekarPoruke();
            poruke.Show();
        }

        //Ucitavanje forme te F1 pomoci
        private void frmGlavniPekarPocetna_Load(object sender, EventArgs e)
        {
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }
    }
}
