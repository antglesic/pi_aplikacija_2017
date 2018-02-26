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
    public partial class frmVlasnikPopisDobavljaca : Form
    {
        public int idDobavljac { get; set; }
        public string naziv { get; set; }
        public string grad { get; set; }
        public string email { get; set; }
        public string brojTelefona { get; set; }
        private bool osvjezi = false;
        public frmVlasnikPopisDobavljaca()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVlasnikPopisDobavljaca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetSirovine.dobavljac2' table. You can move, or remove it, as needed.
            this.dobavljac2TableAdapter.FillByDobavljac(this.dataSetSirovine.dobavljac2);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void dgvDobavljaci_SelectionChanged(object sender, EventArgs e)
        {
            if (osvjezi == false)
            {
                if (dgvDobavljaci.RowCount > 0)
                {
                    idDobavljac = Int32.Parse(dgvDobavljaci.SelectedRows[0].Cells[0].Value.ToString());
                    naziv = dgvDobavljaci.SelectedRows[0].Cells[1].Value.ToString();
                    grad = dgvDobavljaci.SelectedRows[0].Cells[2].Value.ToString();
                    brojTelefona = dgvDobavljaci.SelectedRows[0].Cells[3].Value.ToString();
                    email = dgvDobavljaci.SelectedRows[0].Cells[4].Value.ToString();
                }
                
            }
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            osvjezi = true;
            this.Validate();
            this.dobavljac2BindingSource.EndEdit();
            this.dobavljac2TableAdapter.Dispose();
            this.dobavljac2TableAdapter.FillByDobavljac(dataSetSirovine.dobavljac2);
            osvjezi = false;
        }

        private void btnDodajNovog_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            frmVlasnikDodajNovogDobavljaca noviDobavljac = new frmVlasnikDodajNovogDobavljaca();
            noviDobavljac.Show();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            if (MessageBox.Show("Da li ste sigurni da zelite obrisati ovog dobavljača?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.dobavljac2TableAdapter.DeleteQueryDobavljac(idDobavljac);
                MessageBox.Show("Uspješno ste obrisali ovog dobavljača!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIzmjena_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            frmVlasnikIzmjenaPodatakaDobavljac novaIzmjena = new frmVlasnikIzmjenaPodatakaDobavljac();
            novaIzmjena.preuzmiVrijednosti(idDobavljac, naziv, email, brojTelefona, grad);
            novaIzmjena.Show();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document noviDokument = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter noviPisac = PdfWriter.GetInstance(noviDokument, new FileStream("Vlasnik_dobavljaci.pdf", FileMode.Create));
            noviDokument.Open();

            PdfPTable tablica = new PdfPTable(dgvDobavljaci.Columns.Count);

            for (int i = 0; i < dgvDobavljaci.Columns.Count; i++)
            {
                tablica.AddCell(new Phrase(dgvDobavljaci.Columns[i].HeaderText));
            }

            tablica.HeaderRows = 1;

            for (int j = 0; j < dgvDobavljaci.Rows.Count; j++)
            {
                for (int k = 0; k < dgvDobavljaci.Columns.Count; k++)
                {
                    if (dgvDobavljaci[k, j].Value != null)
                    {
                        tablica.AddCell(new Phrase(dgvDobavljaci[k, j].Value.ToString()));
                    }
                }
            }

            noviDokument.Add(tablica);
            noviDokument.Close();

            MessageBox.Show("Uspjeh! Generirali ste PDF dokument s popisom dobavljaca!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start("Vlasnik_dobavljaci.pdf");
        }

        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            int broj;
            if (txtTrazi.Text != "" && int.TryParse(txtTrazi.Text, out broj))
            {
                this.dobavljac2TableAdapter.FillByLikeDobavljac(dataSetSirovine.dobavljac2, Int32.Parse(txtTrazi.Text));
            }
            else
            {
                this.dobavljac2TableAdapter.FillByDobavljac(this.dataSetSirovine.dobavljac2);
            }
        }
    }
}
