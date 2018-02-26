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
    public partial class frmVlasnikPocetna : Form
    {
        public frmVlasnikPocetna()
        {
            InitializeComponent();
        }

        private void frmVlasnikPocetna_Load(object sender, EventArgs e)
        {
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            frmVlasnikKorisniciPopis vlasnikKorisnici = new frmVlasnikKorisniciPopis();
            vlasnikKorisnici.Show();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrijava odjavaPrijava = new frmPrijava();
            odjavaPrijava.Show();
        }

        private void btnNarudzbenice_Click(object sender, EventArgs e)
        {
            frmVlasnikPopisZahtjevnica popisZahtjevnica = new frmVlasnikPopisZahtjevnica();
            popisZahtjevnica.Show();
        }

        private void btnNarudžbenice_Click(object sender, EventArgs e)
        {
            frmVlasnikPopisNarudzbenica noviPopis = new frmVlasnikPopisNarudzbenica();
            noviPopis.Show();
        }

        private void btnSkladiste_Click(object sender, EventArgs e)
        {
            frmVlasnikSkladiste novoSkladiste = new frmVlasnikSkladiste();
            novoSkladiste.Show();
        }

        private void btnPoruke_Click(object sender, EventArgs e)
        {
            frmVlasnikPoruke poruke = new frmVlasnikPoruke();
            poruke.Show();
        }

        private void btnDobavljaci_Click(object sender, EventArgs e)
        {
            frmVlasnikPopisDobavljaca noviPopis = new frmVlasnikPopisDobavljaca();
            noviPopis.Show();
        }

        private void btnOtpisnice_Click(object sender, EventArgs e)
        {
            frmVlasnikPopisOtpisnica noviPopis = new frmVlasnikPopisOtpisnica();
            noviPopis.Show();
        }
    }
}
