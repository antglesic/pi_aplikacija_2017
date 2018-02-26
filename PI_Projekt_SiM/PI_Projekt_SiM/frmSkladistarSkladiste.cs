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
    public partial class frmSkladistarSkladiste : Form
    {
        public frmSkladistarSkladiste()
        {
            InitializeComponent();
        }

        private void frmStanjeSkladista_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSirovine.sirovina' table. You can move, or remove it, as needed.
            this.sirovinaTableAdapter1.Fill(this.dataSetSirovine.sirovina);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOtpisnica_Click(object sender, EventArgs e)
        {

        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document noviDokument = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter noviPisac = PdfWriter.GetInstance(noviDokument, new FileStream("Skladistar_sirovine.pdf", FileMode.Create));
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

            MessageBox.Show("Uspjeh! Generirali ste PDF dokument s popisom sirovina!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start("Skladistar_sirovine.pdf");
        }

        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            if (txtTrazi.Text != "")
            {
                this.sirovinaTableAdapter1.FillByLikeNazivSirovine(dataSetSirovine.sirovina, txtTrazi.Text);
            }
            else
            {
                this.sirovinaTableAdapter1.Fill(this.dataSetSirovine.sirovina);
            }
        }
    }
}
