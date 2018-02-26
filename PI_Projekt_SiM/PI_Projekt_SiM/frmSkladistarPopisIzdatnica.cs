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
    public partial class frmSkladistarPopisIzdatnica : Form
    {
        public int idIzdatnice { get; set; }
        public frmSkladistarPopisIzdatnica()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSkladistarPopisIzdatnica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetIzdatnice.izdatnica' table. You can move, or remove it, as needed.
            this.izdatnicaTableAdapter.Fill(this.dataSetIzdatnice.izdatnica);
            this.izdatnica_sirovinaTableAdapter.Fill(dataSetIzdatnice.izdatnica_sirovina, idIzdatnice);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void dgvPopisIzdatnica_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPopisIzdatnica.RowCount > 0)
            {
                idIzdatnice = Int32.Parse(dgvPopisIzdatnica.SelectedRows[0].Cells[0].Value.ToString());
                this.izdatnica_sirovinaTableAdapter.Fill(dataSetIzdatnice.izdatnica_sirovina, idIzdatnice);
            }
           
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document noviDokument = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter noviPisac = PdfWriter.GetInstance(noviDokument, new FileStream("Skladistar_izdatnice.pdf", FileMode.Create));
            noviDokument.Open();

            PdfPTable tablica = new PdfPTable(dgvPopisIzdatnica.Columns.Count);

            for (int i = 0; i < dgvPopisIzdatnica.Columns.Count; i++)
            {
                tablica.AddCell(new Phrase(dgvPopisIzdatnica.Columns[i].HeaderText));
            }

            tablica.HeaderRows = 1;

            for (int j = 0; j < dgvPopisIzdatnica.Rows.Count; j++)
            {
                for (int k = 0; k < dgvPopisIzdatnica.Columns.Count; k++)
                {
                    if (dgvPopisIzdatnica[k, j].Value != null)
                    {
                        tablica.AddCell(new Phrase(dgvPopisIzdatnica[k, j].Value.ToString()));
                    }
                }
            }

            noviDokument.Add(tablica);
            noviDokument.Close();

            MessageBox.Show("Uspjeh! Generirali ste PDF dokument s popisom izdatnica!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start("Skladistar_izdatnice.pdf");
        }

        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            int broj;
            if (txtTrazi.Text != "" && int.TryParse(txtTrazi.Text, out broj))
            {
                this.izdatnicaTableAdapter.FillByLikeIzdatnica(dataSetIzdatnice.izdatnica, Int32.Parse(txtTrazi.Text));
            }
            else
            {
                this.izdatnicaTableAdapter.Fill(this.dataSetIzdatnice.izdatnica);
            }
        }
    }
}
