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
    public partial class frmGlavniPekarKreiranjeZahtjevnice : Form
    {
        public int idZahtjevnice;
        public int sirovinaId { get; set; }
        public bool osvjezi = false;
        public frmGlavniPekarKreiranjeZahtjevnice()
        {
            InitializeComponent();
        }

        //Ucitavanje forme te svih datasetova i F1 pomoci
        private void frmGlavniPekarKreiranjeZahtjevnice_Load(object sender, EventArgs e)
        {
            osvjezi = false;
            // TODO: This line of code loads data into the 'dataSetZahtjevnicaSirovina.zahtjevnica_sirovina' table. You can move, or remove it, as needed.
            this.zahtjevnica_sirovinaTableAdapter.Fill(this.dataSetZahtjevnicaSirovina.zahtjevnica_sirovina);
            // TODO: This line of code loads data into the 'dataSetSirovine.sirovina' table. You can move, or remove it, as needed.
            this.sirovinaTableAdapter.Fill(this.dataSetSirovine.sirovina);
            this.zahtjevnicaTableAdapter1.Fill(this.dataSetZahtjevnice1.zahtjevnica);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        //Event handler gumba za odustajanje
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.zahtjevnica_sirovinaTableAdapter2.DeleteQueryBrisanjeZahtjevnice(idZahtjevnice);
            this.zahtjevnicaTableAdapter1.DeleteQueryObrisiZahtjevnicu(idZahtjevnice);
            this.Close();
        }

        //Event handler gumba za kreiranje sa svim provjerama
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
                    int idKorisnika = 3;
                    int tipZahtjevnice = 2;
                    this.zahtjevnicaTableAdapter1.InsertQueryDodajNovuZahtjevnicu(idZahtjevnice, naslovZahtjevnice, svrhaZahtjevnice, datumZahtjevnice, idKorisnika, tipZahtjevnice);
                    MessageBox.Show("Uspjesno ste kreirali novu zahtjevnicu, sada dodajte sirovine na zahtjevnicu!", "Potvrda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDodaj.Enabled = true;
                    btnOsvjezi.Enabled = true;
                    btnPotvrdi.Enabled = true;
                    btnObrisi.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Zahtjevnica sa ovom šifrom već postoji!");
                }
            }
            else
            {
                MessageBox.Show("Svi podaci moraju biti unešeni kako bi mogli kreirati zahtjevnicu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Event handler za dodavanje novih sirovina odnosno otvaranje nove forme
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            frmGlavniPekarKreirajNovuZahtjevnicu nova = new frmGlavniPekarKreirajNovuZahtjevnicu();
            nova.Show();
            nova.prosljediId(idZahtjevnice);
        }

        //Event handler gumba za osvjezavanje 
        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            osvjezi = true;
            this.Validate();
            this.zahtjevnicasirovinaBindingSource1.EndEdit();
            this.zahtjevnica_sirovinaTableAdapter1.Dispose();
            this.zahtjevnica_sirovinaTableAdapter1.FillByNovaZahtjevnicaId(dataSetZahtjevnicaSirovinaDodajNovi.zahtjevnica_sirovina, idZahtjevnice);
            osvjezi = false;
        }

        //Event handler gumba za potvrdu
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            int? brojSirovina = this.zahtjevnica_sirovinaTableAdapter.BrojSirovina(idZahtjevnice);
            if(brojSirovina == 0)
            {
                MessageBox.Show("Ne možete kreirati prazan dokument!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }
        }

        //Event handler gumba za brisanje
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            if (dgvSirovinePopis.RowCount == 1)
            {
                this.zahtjevnica_sirovinaTableAdapter1.DeleteQueryZahtjevnicaSirovina(idZahtjevnice);
            }
            else
            {
                this.zahtjevnicaTableAdapter1.DeleteQueryZahtjevnicaISirovina(idZahtjevnice, sirovinaId);
            }
            
        }

        //Kod za promjeni selekcije i dodjelu vrijednosti
        private void dgvSirovinePopis_SelectionChanged(object sender, EventArgs e)
        {
            if (osvjezi == false)
            {
                if (dgvSirovinePopis.RowCount == 1 || dgvSirovinePopis.RowCount == 0)
                {
                    sirovinaId = Int32.Parse(dgvSirovinePopis.Rows[0].Cells[0].Value.ToString());
                }
                else
                {
                        sirovinaId = Int32.Parse(dgvSirovinePopis.SelectedRows[0].Cells[0].Value.ToString());
                }
                
            }
        }
    }
}
