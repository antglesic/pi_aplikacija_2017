using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_Projekt_SiM;

namespace PI_Projekt_SiM
{
    public partial class frmSkladistarKreirajNovuOtpisnicu : Form
    {
        public int idOtpisnice { get; set; }
        private bool osvjezi = false;
        public int sirovinaId { get; set; }
        public int sifraOtpisnice;
        public frmSkladistarKreirajNovuOtpisnicu()
        {
            InitializeComponent();
        }

        private void btnOtpis_Click(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (txtSifraOtpisnice.Text != "" && txtNaslov.Text != "" && txtSvrha.Text != "")
            {
                idOtpisnice = Int32.Parse(txtSifraOtpisnice.Text);
                sifraOtpisnice = Int32.Parse(txtSifraOtpisnice.Text.ToString());
                DataSetSirovineTableAdapters.otpisnicaTableAdapter noviTblAdapter = new DataSetSirovineTableAdapters.otpisnicaTableAdapter();
                int postoji = noviTblAdapter.ScalarQueryPostojiOtpisnica(idOtpisnice).Value;
                if (postoji != 0)
                {
                    osvjezi = false;
                    MessageBox.Show("Otpisnica s ovom sifrom vec postoji!", "Upoorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    osvjezi = false;
                    noviTblAdapter.InsertQueryOtpisnica(idOtpisnice, txtNaslov.Text, txtSvrha.Text, inputDatum.Text, 2);
                    MessageBox.Show("Uspjesno ste kreirali otpisnicu!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSifraOtpisnice.ReadOnly = true;
                    btnDodajSirovinu.Enabled = true;
                    btnOsvjezi.Enabled = true;
                    btnPotvrdi.Enabled = true;
                }
            }
            else
            {
                osvjezi = false;
                MessageBox.Show("Potrebno je unjeti sve podatke!", "Upoorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmSkladistarKreirajNovuOtpisnicu_Load(object sender, EventArgs e)
        {
            btnDodajSirovinu.Enabled = false;
            btnOsvjezi.Enabled = false;
            btnPotvrdi.Enabled = false;
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void btnDodajSirovinu_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            frmSkladistarKreiranjeOtpisniceSirovine dodajSirovinu = new frmSkladistarKreiranjeOtpisniceSirovine();
            dodajSirovinu.preuzmiVrijednost(Int32.Parse(txtSifraOtpisnice.Text));
            dodajSirovinu.Show();
        }

        private void btnOdustani_Click_1(object sender, EventArgs e)
        {
            DataSetSirovineTableAdapters.otpisnicaTableAdapter noviTblaOtpisnica = new DataSetSirovineTableAdapters.otpisnicaTableAdapter();
            DataSetSirovineTableAdapters.otpisnica_sirovinaTableAdapter noviTblaOtpisnicaSirovina = new DataSetSirovineTableAdapters.otpisnica_sirovinaTableAdapter();
            noviTblaOtpisnica.DeleteQueryFromOtpisnica(idOtpisnice);
            noviTblaOtpisnicaSirovina.DeleteQueryFromOtpisnicaSirovina(idOtpisnice);
            this.Close();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            DataSetSirovineTableAdapters.otpisnicaTableAdapter noviTblaOtpisnica = new DataSetSirovineTableAdapters.otpisnicaTableAdapter();
            DataSetSirovineTableAdapters.otpisnica_sirovinaTableAdapter noviTblaOtpisnicaSirovina = new DataSetSirovineTableAdapters.otpisnica_sirovinaTableAdapter();
            int? brojSirovina = noviTblaOtpisnicaSirovina.BrojSirovina(sifraOtpisnice);
            if(brojSirovina == 0)
            {
                MessageBox.Show("Ne možete kreirati prazan dokument!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow row in dgvPopisSirovinaNaOtpisnici.Rows)
                {
                    DataSetSirovineTableAdapters.sirovinaTableAdapter noviSirovine = new DataSetSirovineTableAdapters.sirovinaTableAdapter();
                    int staraKolicina = noviSirovine.ScalarQueryDostupnaKolicina(Int32.Parse(row.Cells[1].Value.ToString())).Value;
                    int kolicinaZaOduzeti = Int32.Parse(row.Cells[2].Value.ToString());
                    int novaKolicina = PomocneClass.dajSmanjenuKolicinu(staraKolicina, kolicinaZaOduzeti);
                    noviSirovine.UpdateQueryDostupnaKolicina(novaKolicina, Int32.Parse(row.Cells[1].Value.ToString()));
                }
                MessageBox.Show("Uspjesno ste otpisali sirovine sa skladista i kreirali otpisnicu!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            osvjezi = true;
            this.Validate();
            this.otpisnicasirovinaBindingSource.EndEdit();
            this.otpisnica_sirovinaTableAdapter.Dispose();
            this.otpisnica_sirovinaTableAdapter.Fill(dataSetSirovine.otpisnica_sirovina, idOtpisnice);
            osvjezi = false;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvPopisSirovinaNaOtpisnici.RowCount == 1)
            {
                this.otpisnica_sirovinaTableAdapter.DeleteQueryFromOtpisnicaSirovina(idOtpisnice);
            }
            else
            {
                this.otpisnica_sirovinaTableAdapter.DeleteQueryOtpisnicaSirovina(idOtpisnice, sirovinaId);       
            }
        }

        private void dgvPopisSirovinaNaOtpisnici_SelectionChanged(object sender, EventArgs e)
        {
            if (osvjezi == false)
            {
                if (dgvPopisSirovinaNaOtpisnici.RowCount == 1 || dgvPopisSirovinaNaOtpisnici.RowCount == 0)
                {
                    sirovinaId = Int32.Parse(dgvPopisSirovinaNaOtpisnici.Rows[0].Cells[0].Value.ToString());
                }
                else
                {
                    sirovinaId = Int32.Parse(dgvPopisSirovinaNaOtpisnici.SelectedRows[0].Cells[1].Value.ToString());
                }
            }
            
        }
    }
}
