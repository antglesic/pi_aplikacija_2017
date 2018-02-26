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
    public partial class frmSkladistarKreiranjeOtpisniceSirovine : Form
    {
        public int otpisnica { get; set; }
        public int sirovina { get; set; }
        public frmSkladistarKreiranjeOtpisniceSirovine()
        {
            InitializeComponent();
        }

        private void frmSkladistarKreiranjeOtpisniceSirovine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSirovine.sirovina' table. You can move, or remove it, as needed.
            this.sirovinaTableAdapter.Fill(this.dataSetSirovine.sirovina);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        public void preuzmiVrijednost(int idOtpisnice)
        {
            otpisnica = idOtpisnice;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPopisSirovina_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPopisSirovina.RowCount > 0)
            {
                sirovina = Int32.Parse(dgvPopisSirovina.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            if (txtKolicina.Text != "")
            {
                int kolicina = Int32.Parse(txtKolicina.Text);
                if (kolicina != 0)
                {
                    DataSetSirovineTableAdapters.otpisnica_sirovinaTableAdapter noviAdapter = new DataSetSirovineTableAdapters.otpisnica_sirovinaTableAdapter();
                    int postojiNaOtpisnici = noviAdapter.ScalarQueryPostojiNaOtpisnici(otpisnica, sirovina).Value;
                    if (postojiNaOtpisnici != 0)
                    {
                        MessageBox.Show("Ova sirovina je vec dodana na otpisnicu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        noviAdapter.InsertQueryOtpisnicaSirovina(otpisnica, sirovina, kolicina);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Kolicina sirovine za otpis ne smije biti 0!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Potrebno je unjeti kolicinu kako biste dodali sirovinu na otpisnicu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            if (txtTrazi.Text != "")
            {
                this.sirovinaTableAdapter.FillByLikeNazivSirovine(dataSetSirovine.sirovina, txtTrazi.Text);
            }
            else
            {
                this.sirovinaTableAdapter.Fill(this.dataSetSirovine.sirovina);
            }
        }
    }
}
