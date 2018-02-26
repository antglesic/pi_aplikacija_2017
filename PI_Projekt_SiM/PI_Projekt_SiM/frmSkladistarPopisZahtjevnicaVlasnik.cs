using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace PI_Projekt_SiM
{
    public partial class frmSkladistarPopisZahtjevnicaVlasnik : Form
    {
        public int idZahtjevnice { get; set; }
        private bool osvjezi = false;
        public frmSkladistarPopisZahtjevnicaVlasnik()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSkladistar_zahtjevnica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetZahtjevnice.zahtjevnica' table. You can move, or remove it, as needed.
            this.zahtjevnicaTableAdapter.Fill(this.dataSetZahtjevnice.zahtjevnica);
            this.tip_zahtjevniceTableAdapter.FillIdZahtjevnicaIdSirovinaDetaljno(dataSetZahtjevnice.tip_zahtjevnice, idZahtjevnice);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            this.Close();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            frmSkladistarKreiranjeZahtjevnice formaNovaZahtjevnica = new frmSkladistarKreiranjeZahtjevnice();
            formaNovaZahtjevnica.Show();
        }

        private void dgvPopisZahtjevnica_SelectionChanged(object sender, EventArgs e)
        {
            if (osvjezi == false)
            {
                if (dgvPopisZahtjevnica.RowCount > 0)
                {
                    idZahtjevnice = Int32.Parse(dgvPopisZahtjevnica.SelectedRows[0].Cells[0].Value.ToString());
                    this.tip_zahtjevniceTableAdapter.FillIdZahtjevnicaIdSirovinaDetaljno(dataSetZahtjevnice.tip_zahtjevnice, idZahtjevnice);
                }
                
            }
            
        }

        private void zahtjevnicaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            osvjezi = true;
            this.Validate();
            this.zahtjevnicaBindingSource.EndEdit();
            this.zahtjevnicaTableAdapter.Dispose();
            this.zahtjevnicaTableAdapter.Fill(this.dataSetZahtjevnice.zahtjevnica);
            osvjezi = false;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document noviDokument = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter noviPisac = PdfWriter.GetInstance(noviDokument, new FileStream("Skladistar_zahtjevnice_vlasnik.pdf", FileMode.Create));
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

            MessageBox.Show("Uspjeh! Generirali ste PDF dokument s popisom zahtjevnica upucenih vlasniku!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start("Skladistar_zahtjevnice_vlasnik.pdf");
        }

        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            int broj;
            if (txtTrazi.Text != "" && int.TryParse(txtTrazi.Text, out broj))
            {
                this.zahtjevnicaTableAdapter.FillByLike(dataSetZahtjevnice.zahtjevnica, Int32.Parse(txtTrazi.Text));
            }
            else
            {
                this.zahtjevnicaTableAdapter.Fill(this.dataSetZahtjevnice.zahtjevnica);
            }
        }
    }
}
