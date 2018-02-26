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
    public partial class frmVlasnikPopisNarudzbenica : Form
    {
        public frmVlasnikPopisNarudzbenica()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVlasnikPopisNarudzbenica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSirovine.narudzbenica' table. You can move, or remove it, as needed.
            this.narudzbenicaTableAdapter.FillByIdNarudzbenica(this.dataSetSirovine.narudzbenica);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void dgvPopisNarudzbenica_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPopisNarudzbenica.RowCount > 0)
            {
                int idNarudzbenica = Int32.Parse(dgvPopisNarudzbenica.SelectedRows[0].Cells[0].Value.ToString());
                narudzbenica_sirovina2TableAdapter.FillByDetalljiNarudzbenice(dataSetSirovine.narudzbenica_sirovina2, idNarudzbenica);
            }
           
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document noviDokument = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter noviPisac = PdfWriter.GetInstance(noviDokument, new FileStream("Vlasnik_narudzbenice.pdf", FileMode.Create));
            noviDokument.Open();

            PdfPTable tablica = new PdfPTable(dgvPopisNarudzbenica.Columns.Count);

            for (int i = 0; i < dgvPopisNarudzbenica.Columns.Count; i++)
            {
                tablica.AddCell(new Phrase(dgvPopisNarudzbenica.Columns[i].HeaderText));
            }

            tablica.HeaderRows = 1;

            for (int j = 0; j < dgvPopisNarudzbenica.Rows.Count; j++)
            {
                for (int k = 0; k < dgvPopisNarudzbenica.Columns.Count; k++)
                {
                    if (dgvPopisNarudzbenica[k, j].Value != null)
                    {
                        tablica.AddCell(new Phrase(dgvPopisNarudzbenica[k, j].Value.ToString()));
                    }
                }
            }

            noviDokument.Add(tablica);
            noviDokument.Close();

            MessageBox.Show("Uspjeh! Generirali ste PDF dokument s popisom narudzbenica!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start("Vlasnik_narudzbenice.pdf");
        }

        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            int broj;
            if (txtTrazi.Text != "" && int.TryParse(txtTrazi.Text, out broj) == true) {

                this.narudzbenicaTableAdapter.FillByLikeNarudzbenica(dataSetSirovine.narudzbenica, Int32.Parse(txtTrazi.Text));
            }
            else
            {
                this.narudzbenicaTableAdapter.FillByIdNarudzbenica(this.dataSetSirovine.narudzbenica);
            }
        }
    }
}
