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
    public partial class frmVlasnikPopisZahtjevnica : Form
    {
        public int idZahtjevnica { get; set; }
        public int idSirovine { get; set; }
        public int kolicina { get; set; }
        public frmVlasnikPopisZahtjevnica()
        {
            InitializeComponent();
        }

        private void frmSkladistarPopisNarudzbenica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetZahtjevnice.zahtjevnica' table. You can move, or remove it, as needed.
            this.zahtjevnicaTableAdapter.Fill(this.dataSetZahtjevnice.zahtjevnica);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void dgvPopisZahtjevnica_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPopisZahtjevnica.RowCount > 0)
            {
                idZahtjevnica = Int32.Parse(dgvPopisZahtjevnica.SelectedRows[0].Cells[0].Value.ToString());
                tip_zahtjevniceTableAdapter.FillIdZahtjevnicaIdSirovinaDetaljno(dataSetZahtjevnice.tip_zahtjevnice, idZahtjevnica);
            }

        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDetaljiZahtjevnice_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetaljiZahtjevnice.RowCount > 0)
            {
                idSirovine = Int32.Parse(dgvDetaljiZahtjevnice.SelectedRows[0].Cells[0].Value.ToString());
                kolicina = Int32.Parse(dgvDetaljiZahtjevnice.SelectedRows[0].Cells[2].Value.ToString());
            }

        }

        private void btnKreirajNarudzbenicu_Click(object sender, EventArgs e)
        {
            frmVlasnikNovaNarudzbenica posaljiVrijednosti = new frmVlasnikNovaNarudzbenica();
            posaljiVrijednosti.preuzmi_vrijednosti(idSirovine, idZahtjevnica, kolicina);
            posaljiVrijednosti.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document noviDokument = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter noviPisac = PdfWriter.GetInstance(noviDokument, new FileStream("Vlasnik_zahtjevnice.pdf", FileMode.Create));
            noviDokument.Open();

            PdfPTable tablica = new PdfPTable(dgvPopisZahtjevnica.Columns.Count);

            for (int i = 0; i < dgvPopisZahtjevnica.Columns.Count; i++)
            {
                tablica.AddCell(new Phrase(dgvPopisZahtjevnica.Columns[i].HeaderText));
            }

            tablica.HeaderRows = 1;

            for (int j = 0; j < dgvPopisZahtjevnica.Rows.Count; j++)
            {
                for (int k = 0; k < dgvPopisZahtjevnica.Columns.Count; k++)
                {
                    if (dgvPopisZahtjevnica[k, j].Value != null)
                    {
                        tablica.AddCell(new Phrase(dgvPopisZahtjevnica[k, j].Value.ToString()));
                    }
                }
            }

            noviDokument.Add(tablica);
            noviDokument.Close();

            MessageBox.Show("Uspjeh! Generirali ste PDF dokument s popisom zahtjevnica!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start("Vlasnik_zahtjevnice.pdf");
        }

        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            int broj;
            if (txtTrazi.Text != "" && int.TryParse(txtTrazi.Text, out broj) == true)
            {
                this.zahtjevnicaTableAdapter.FillByLike(dataSetZahtjevnice.zahtjevnica, Int32.Parse(txtTrazi.Text));
            }
            else
            {
                this.zahtjevnicaTableAdapter.Fill(this.dataSetZahtjevnice.zahtjevnica);
                tip_zahtjevniceTableAdapter.FillIdZahtjevnicaIdSirovinaDetaljno(dataSetZahtjevnice.tip_zahtjevnice, 112);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
