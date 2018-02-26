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
    public partial class frmGlavniPekarSkladiste : Form
    {
        public frmGlavniPekarSkladiste()
        {
            InitializeComponent();
        }

        //Event handler gumba natrag
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Event handler za ucitavanje forme i tableadaptera
        private void frmGlavniPekarSkladiste_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSirovine.sirovina' table. You can move, or remove it, as needed.
            this.sirovinaTableAdapter.Fill(this.dataSetSirovine.sirovina);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        //Event handler gumba za exportanje pdf-a
        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document noviDokument = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter noviPisac = PdfWriter.GetInstance(noviDokument, new FileStream("Glavni_pekar_skladiste.pdf", FileMode.Create));
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

            MessageBox.Show("Uspjeh! Generirali ste PDF dokument s popisom sirovina na skladistu!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start("Glavni_pekar_skladiste.pdf");
        }

        //Event handler textboxa te kod koji se izvrsi kada se tekst unosi u textbox
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
