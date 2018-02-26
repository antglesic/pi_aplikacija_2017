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
    public partial class frmVlasnikNovaNarudzbenica : Form
    {
        public int idSirovine { get; set; }
        public int idDobavljaca { get; set; }
        public int idZahtjevnica { get; set; }
        public int kolicina { get; set; }
        public frmVlasnikNovaNarudzbenica()
        {
            InitializeComponent();
        }

        private void frmVlasnikNovaNarudzbenica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSirovine.dobavljac2' table. You can move, or remove it, as needed.
            this.dobavljac2TableAdapter.FillByDobavljac(this.dataSetSirovine.dobavljac2);
            this.sirovina2TableAdapter.FillIdSirovineNarudzbenica(dataSetSirovine.sirovina2,idSirovine);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        public void preuzmi_vrijednosti(int sirovina, int zahtjevnica, int kolicinaZaNaruciti)
        {
            idSirovine = sirovina;
            idZahtjevnica = zahtjevnica;
            kolicina = kolicinaZaNaruciti;
            txtSifraZahtjevnice.Text = zahtjevnica.ToString();
        }

        private void dgvDobavljac_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDobavljac.RowCount > 0)
            {
                idDobavljaca = Int32.Parse(dgvDobavljac.SelectedRows[0].Cells[0].Value.ToString());
            }
           
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKreirajNaraudzbenicu_Click(object sender, EventArgs e)
        {
            if (txtSifraNarudzbenice.Text != "" && txtNaslovNarudzbenice.Text != "" && txtOpisNarudzbenice.Text != "")
            {
                DataSetSirovineTableAdapters.narudzbenicaTableAdapter noviTableAdapterNarudzbenica = new DataSetSirovineTableAdapters.narudzbenicaTableAdapter();
                int narudzbenica = Int32.Parse(txtSifraNarudzbenice.Text);
                noviTableAdapterNarudzbenica.InsertQueryNarudzbenica(narudzbenica, txtNaslovNarudzbenice.Text, txtOpisNarudzbenice.Text, inputDatum.Text, 1, idZahtjevnica, idDobavljaca);
                DataSetSirovineTableAdapters.narudzbenica_sirovinaTableAdapter noviTableAdapterNarudzbenicaSirovina = new DataSetSirovineTableAdapters.narudzbenica_sirovinaTableAdapter();
                noviTableAdapterNarudzbenicaSirovina.InsertQueryNarudzbenicaSirovina(narudzbenica, idSirovine, kolicina);
                MessageBox.Show("Uspjesno ste kreirali narudžbenicu!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sve vrijednosti moraju biti unesene!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            int broj;
            if (txtTrazi.Text != "" && int.TryParse(txtTrazi.Text, out broj) == true)
            {
                this.dobavljac2TableAdapter.FillByLikeDobavljac(dataSetSirovine.dobavljac2, Int32.Parse(txtTrazi.Text));
            }
            else
            {
                this.dobavljac2TableAdapter.FillByDobavljac(this.dataSetSirovine.dobavljac2);
            }
        }
    }
}
