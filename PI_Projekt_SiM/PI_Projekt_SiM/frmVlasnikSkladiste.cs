using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace PI_Projekt_SiM
{
    public partial class frmVlasnikSkladiste : Form
    {
        public int idSirovina { get; set; }
        public int dostupnaKolicina { get; set; }
        private bool osvjezi = false;
        public string naziv { get; set; }
        public string jedinicnaMjera { get; set; }
        public string napomena { get; set; }
        public frmVlasnikSkladiste()
        {
            InitializeComponent();
        }

        private void frmVlasnikSkladiste_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSirovine.sirovina' table. You can move, or remove it, as needed.
            this.sirovinaTableAdapter.Fill(this.dataSetSirovine.sirovina);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajNOvu_Click(object sender, EventArgs e)
        {
            frmVlasnikSkladisteNovaSirovina novaSirovina = new frmVlasnikSkladisteNovaSirovina();
            novaSirovina.Show();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            osvjezi = true;
            this.Validate();
            this.sirovinaBindingSource.EndEdit();
            this.sirovinaTableAdapter.Dispose();
            this.sirovinaTableAdapter.Fill(this.dataSetSirovine.sirovina);
            osvjezi = false;
        }



        private void btnObrisi_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            if (dostupnaKolicina == 0)
            {
                if (MessageBox.Show("Da li ste sigurni da zelite obrisati ovu sirovinu?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    sirovinaTableAdapter.DeleteQuerySirovina(idSirovina);
                    MessageBox.Show("Sirovina uspjesno obrisana", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Sirovinu s kolicinom vecom od 0 je nemoguce obrisati", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvPopisSirovina_SelectionChanged(object sender, EventArgs e)
        {
            if (osvjezi == false)
            {
                if (dgvPopisSirovina.RowCount > 0)
                {
                    idSirovina = Int32.Parse(dgvPopisSirovina.SelectedRows[0].Cells[0].Value.ToString());
                    dostupnaKolicina = Int32.Parse(dgvPopisSirovina.SelectedRows[0].Cells[3].Value.ToString());
                    naziv = dgvPopisSirovina.SelectedRows[0].Cells[1].Value.ToString();
                    jedinicnaMjera = dgvPopisSirovina.SelectedRows[0].Cells[4].Value.ToString();
                    napomena = dgvPopisSirovina.SelectedRows[0].Cells[5].Value.ToString();
                }
                
            }         
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            frmVlasnikIzmjeniSirovinu novaIzmjena = new frmVlasnikIzmjeniSirovinu();
            novaIzmjena.preuzmiVrijednosti(idSirovina, naziv, napomena, dostupnaKolicina, jedinicnaMjera);
            novaIzmjena.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document noviDokument = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter noviPisac = PdfWriter.GetInstance(noviDokument, new FileStream("Vlasnik_skladiste.pdf", FileMode.Create));
            noviDokument.Open();

            PdfPTable tablica = new PdfPTable(dgvPopisSirovina.Columns.Count);

            for (int i = 0; i < dgvPopisSirovina.Columns.Count; i++)
            {
                tablica.AddCell(new Phrase(dgvPopisSirovina.Columns[i].HeaderText));
            }

            tablica.HeaderRows = 1;

            for (int j = 0; j < dgvPopisSirovina.Rows.Count; j++)
            {
                for (int k = 0; k < dgvPopisSirovina.Columns.Count; k++)
                {
                    if (dgvPopisSirovina[k, j].Value != null)
                    {
                        tablica.AddCell(new Phrase(dgvPopisSirovina[k, j].Value.ToString()));
                    }
                }
            }

            noviDokument.Add(tablica);
            noviDokument.Close();

            MessageBox.Show("Uspjeh! Generirali ste PDF dokument s popisom otpisnica!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start("Vlasnik_skladiste.pdf");
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
