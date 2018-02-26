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
    public partial class frmSkladistarNovaIzdatnica : Form
    {
        public int idZahtjevnica { get; set; }

        public frmSkladistarNovaIzdatnica()
        {
            InitializeComponent();
        }

        private void frmSkladistarNovaIzdatnica_Load(object sender, EventArgs e)
        {
            this.zahtjevnica_sirovinaTableAdapter.FillIdZahtjevnicaIdSirovina(dataSetIzdatnice.zahtjevnica_sirovina, idZahtjevnica);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        public void preuzmi_vrijednost(int id_zahtjevnica)
        {
            this.idZahtjevnica = id_zahtjevnica;
        }

        private void labelNaslov_Click(object sender, EventArgs e)
        {

        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (txtSifra.Text != "" && txtNaslov.Text != "" && txtOpis.Text != "")
            {
                int idIzdatnica = Int32.Parse(txtSifra.Text);
                string naslov = txtNaslov.Text;
                string opis = txtOpis.Text;
                string datum = inputDatum.Text;
                int idKorisnik = 2;
                int brojIzdatnica = Int32.Parse(zahtjevnica_sirovinaTableAdapter.FillByIdIzdatniceBrojRedova(idIzdatnica).ToString());
                if (brojIzdatnica != 0)
                {
                    MessageBox.Show("Izdatnica s ovom šifrom već postoji!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    zahtjevnica_sirovinaTableAdapter.InsertQueryIntoIzdatnica(idIzdatnica, naslov, opis, datum, idKorisnik, idZahtjevnica);
                    for (int i = 0; i < dgvPopisSirovinaIzdatnica.RowCount; i++)
                    {
                        int id_sirovina = Int32.Parse(dgvPopisSirovinaIzdatnica.Rows[i].Cells[0].Value.ToString());
                        int kolicina = Int32.Parse(dgvPopisSirovinaIzdatnica.Rows[i].Cells[2].Value.ToString());
                        int staraKolicina = Int32.Parse(dgvPopisSirovinaIzdatnica.Rows[i].Cells[3].Value.ToString());
                        int novaKolicina = PomocneClass.dajSmanjenuKolicinu(staraKolicina, kolicina);
                        DataSetSirovineTableAdapters.sirovinaTableAdapter noviTableAdapterSirovina = new DataSetSirovineTableAdapters.sirovinaTableAdapter();
                        noviTableAdapterSirovina.UpdateQueryDostupnaKolicina(novaKolicina, id_sirovina);
                        zahtjevnica_sirovinaTableAdapter.InsertQueryIzdatnicaSirovina(idIzdatnica, id_sirovina, kolicina);
                    }
                    MessageBox.Show("Uspjesno ste kreirali novu izdatnicu", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Niste unjeli sve podatke!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
