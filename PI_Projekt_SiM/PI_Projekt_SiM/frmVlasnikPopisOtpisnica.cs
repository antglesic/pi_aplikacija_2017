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
    public partial class frmVlasnikPopisOtpisnica : Form
    {
        public frmVlasnikPopisOtpisnica()
        {
            InitializeComponent();
        }

        private void frmVlasnikPopisOtpisnica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSirovine.otpisnica' table. You can move, or remove it, as needed.
            this.otpisnicaTableAdapter.Fill(this.dataSetSirovine.otpisnica);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void dgvPopisOtpisnica_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPopisOtpisnica.RowCount > 0)
            {
                int idOtpisnice = Int32.Parse(dgvPopisOtpisnica.SelectedRows[0].Cells[0].Value.ToString());
                this.otpisnica_sirovinaTableAdapter.Fill(dataSetSirovine.otpisnica_sirovina, idOtpisnice);
            }
            
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document noviDokument = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter noviPisac = PdfWriter.GetInstance(noviDokument, new FileStream("Vlasnik_otpisnice.pdf", FileMode.Create));
            noviDokument.Open();

            PdfPTable tablica = new PdfPTable(dgvPopisOtpisnica.Columns.Count);

            for (int i = 0; i < dgvPopisOtpisnica.Columns.Count; i++)
            {
                tablica.AddCell(new Phrase(dgvPopisOtpisnica.Columns[i].HeaderText));
            }

            tablica.HeaderRows = 1;

            for (int j = 0; j < dgvPopisOtpisnica.Rows.Count; j++)
            {
                for (int k = 0; k < dgvPopisOtpisnica.Columns.Count; k++)
                {
                    if (dgvPopisOtpisnica[k, j].Value != null)
                    {
                        tablica.AddCell(new Phrase(dgvPopisOtpisnica[k, j].Value.ToString()));
                    }
                }
            }

            noviDokument.Add(tablica);
            noviDokument.Close();

            MessageBox.Show("Uspjeh! Generirali ste PDF dokument s popisom otpisnica!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start("Vlasnik_otpisnice.pdf");
        }

        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            int broj;
            if (txtTrazi.Text != "" && int.TryParse(txtTrazi.Text, out broj) == true)
            {
                this.otpisnicaTableAdapter.FillByLikeOtpisnica(dataSetSirovine.otpisnica, Int32.Parse(txtTrazi.Text));
            }
            else
            {
                this.otpisnicaTableAdapter.Fill(this.dataSetSirovine.otpisnica);
            }
        }
    }
}
