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
    public partial class frmVlasnikIzmjeniSirovinu : Form
    {
        public int idSirovine { get; set; }
        public string naziv { get; set; }
        public string napomena { get; set; }
        public int dostupna { get; set; }
        public string jedinicna { get; set; }

        public frmVlasnikIzmjeniSirovinu()
        {
            InitializeComponent();
        }

        public void preuzmiVrijednosti(int id, string naslov, string napomeni, int dostupno, string jedinica)
        {
            idSirovine = id;
            naziv = naslov;
            napomena = napomeni;
            dostupna = dostupno;
            jedinicna = jedinica;
        }

        private void frmVlasnikIzmjeniSirovinu_Load(object sender, EventArgs e)
        {
            txtSifra.Text = idSirovine.ToString();
            txtNaziv.Text = naziv;
            txtJedinicna.Text = jedinicna;
            txtDostupna.Text = dostupna.ToString();
            txtNapomena.Text = napomena;
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text != "" && txtNapomena.Text != "" && txtJedinicna.Text != "")
            {
                if (MessageBox.Show("Da li ste sigurni da zelite izmjeniti ovu sirovinu?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    DataSetSirovineTableAdapters.sirovinaTableAdapter noviTableAdapterSirovina = new DataSetSirovineTableAdapters.sirovinaTableAdapter();
                    noviTableAdapterSirovina.UpdateQuerySirovina(txtNaziv.Text, dtpDatum.Text, txtJedinicna.Text, txtNapomena.Text, idSirovine);
                    MessageBox.Show("Uspjesno ste napravili izmjene nad sirovinom!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Potrebno je popuniti sve podatke!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
