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
    public partial class frmSkladistarKreiranjeZahtjevnice : Form
    {
        public int idZahtjevnice;

        public List<int> lista = new List<int>();
        private bool osvjezi = false;
        public int sirovinaId { get; set; }
        public frmSkladistarKreiranjeZahtjevnice()
        {
            InitializeComponent();
        }

        private void frmSkladistarKreiranjeZahtjevnice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSirovine.sirovina' table. You can move, or remove it, as needed.
            this.sirovinaTableAdapter.Fill(this.dataSetSirovine.sirovina);
            // TODO: This line of code loads data into the 'dataSetUloge.uloga' table. You can move, or remove it, as needed.
            this.zahtjevnicaTableAdapter1.Fill(this.dataSetZahtjevnice1.zahtjevnica);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            this.zahtjevnica_sirovinaTableAdapter2.DeleteQueryBrisanjeZahtjevnice(idZahtjevnice);
            this.zahtjevnicaTableAdapter1.DeleteQueryObrisiZahtjevnicu(idZahtjevnice);
            this.Close();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (inputIdZahtjevnice.Text != "" && inputNaslov.Text != "" && inputSvrha.Text != "")
            {
                int id = Int32.Parse(inputIdZahtjevnice.Text.ToString());
                int provjera = Int32.Parse(zahtjevnicaTableAdapter1.FillBySifraZahtjevnice(id).ToString());
                if (provjera == 0)
                {
                    osvjezi = false;
                    idZahtjevnice = int.Parse(inputIdZahtjevnice.Text.ToString());
                    string naslovZahtjevnice = inputNaslov.Text.ToString();
                    string svrhaZahtjevnice = inputSvrha.Text.ToString();
                    string datumZahtjevnice = inputDatum.Text.ToString();
                    int idKorisnika = 2;
                    int tipZahtjevnice = 1;
                    this.zahtjevnicaTableAdapter1.InsertQueryDodajNovuZahtjevnicu(idZahtjevnice, naslovZahtjevnice, svrhaZahtjevnice, datumZahtjevnice, idKorisnika, tipZahtjevnice);
                    MessageBox.Show("Uspjesno ste kreirali novu zahtjevnicu, sada dodajte sirovine na zahtjevnicu!", "Potvrda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDodaj.Enabled = true;
                    btnOsvjezi.Enabled = true;
                    btnPotvrdi.Enabled = true;
                    btnObrisi.Enabled = true;
                }
                else
                {
                    osvjezi = false;
                    MessageBox.Show("Zahtjevnica sa ovom šifrom već postoji!");
                }
            }
            else
            {
                osvjezi = false;
                MessageBox.Show("Svi podaci moraju biti unešeni kako bi mogli kreirati zahtjevnicu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            frmSkladistarKreirajNovuZahtjevnicu dodavanje = new frmSkladistarKreirajNovuZahtjevnicu();
            dodavanje.Show();
            dodavanje.prosljediId(idZahtjevnice);
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            osvjezi = true;
            this.Validate();
            this.zahtjevnicasirovinaBindingSource.EndEdit();
            this.zahtjevnicaTableAdapter1.Dispose();
            this.zahtjevnica_sirovinaTableAdapter1.FillByNovaZahtjevnicaId(dataSetZahtjevnicaSirovinaDodajNovi1.zahtjevnica_sirovina, idZahtjevnice);
            osvjezi = false;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            int brojSirovina = this.zahtjevnica_sirovinaTableAdapter2.FillByRowNums(dataSetZahtjevnicaSirovina2.zahtjevnica_sirovina, idZahtjevnice);
            if(brojSirovina == 0)
            {
                MessageBox.Show("Ne možete kreirati prazan dokument!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }
        }

        private void dgvPopisSirovina_SelectionChanged(object sender, EventArgs e)
        {
            if (osvjezi == false)
            {
                if (dgvPopisSirovina.RowCount == 1 || dgvPopisSirovina.RowCount == 0)
                {
                    sirovinaId = Int32.Parse(dgvPopisSirovina.Rows[0].Cells[0].Value.ToString());
                }
                else
                {
                    sirovinaId = Int32.Parse(dgvPopisSirovina.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            if (dgvPopisSirovina.RowCount == 1)
            {
                this.zahtjevnica_sirovinaTableAdapter2.DeleteQueryBrisanjeZahtjevnice(idZahtjevnice);
            }
            else
            {
                this.zahtjevnica_sirovinaTableAdapter2.DeleteQuerySirovinaSPopisa(idZahtjevnice, sirovinaId);
            }
        }
    }
}
