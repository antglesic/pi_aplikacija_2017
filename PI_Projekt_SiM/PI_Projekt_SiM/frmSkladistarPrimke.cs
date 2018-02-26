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
    public partial class frmSkladistarPrimke : Form
    {
        public int idPrimke { get; set; }
        private bool osvjezi = false;
        public frmSkladistarPrimke()
        {
            InitializeComponent();
        }

        private void frmSkladistarPrimke_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPrimke.primka2' table. You can move, or remove it, as needed.
            this.primka2TableAdapter.Fill(this.dataSetPrimke.primka2);
            // TODO: This line of code loads data into the 'dataSetPrimke.primka_sirovina' table. You can move, or remove it, as needed.
            this.primka_sirovina2TableAdapter.Fill(dataSetPrimke.primka_sirovina2, idPrimke);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            frmSkladistarKreiranjePrimke novaPrimka = new frmSkladistarKreiranjePrimke();
            novaPrimka.Show();
        }

        private void dgvPopisPrimki_SelectionChanged(object sender, EventArgs e)
        {
            if (osvjezi == false)
            {
                if (dgvPopisPrimki.RowCount > 0)
                {
                    idPrimke = Int32.Parse(dgvPopisPrimki.SelectedRows[0].Cells[0].Value.ToString());
                    this.primka_sirovina2TableAdapter.Fill(dataSetPrimke.primka_sirovina2, idPrimke);
                }
                
            }
            
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            osvjezi = true;
            this.Validate();
            this.primka2BindingSource1.EndEdit();
            this.primka2TableAdapter.Dispose();
            this.primka2TableAdapter.Fill(this.dataSetPrimke.primka2);
            osvjezi = false;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document noviDokument = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter noviPisac = PdfWriter.GetInstance(noviDokument, new FileStream("Skladistar_primke.pdf", FileMode.Create));
            noviDokument.Open();

            PdfPTable tablica = new PdfPTable(dgvPopisPrimki.Columns.Count);

            for (int i = 0; i < dgvPopisPrimki.Columns.Count; i++)
            {
                tablica.AddCell(new Phrase(dgvPopisPrimki.Columns[i].HeaderText));
            }

            tablica.HeaderRows = 1;

            for (int j = 0; j < dgvPopisPrimki.Rows.Count; j++)
            {
                for (int k = 0; k < dgvPopisPrimki.Columns.Count; k++)
                {
                    if (dgvPopisPrimki[k, j].Value != null)
                    {
                        tablica.AddCell(new Phrase(dgvPopisPrimki[k, j].Value.ToString()));
                    }
                }
            }

            noviDokument.Add(tablica);
            noviDokument.Close();

            MessageBox.Show("Uspjeh! Generirali ste PDF dokument s popisom primki!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start("Skladistar_primke.pdf");
        }

        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            int broj;
            if (txtTrazi.Text != "" && int.TryParse(txtTrazi.Text, out broj))
            {
                this.primka2TableAdapter.FillByLikeIdPrimke(dataSetPrimke.primka2, Int32.Parse(txtTrazi.Text));
            }
            else
            {
                this.primka2TableAdapter.Fill(this.dataSetPrimke.primka2);
            }
        }
    }
}
