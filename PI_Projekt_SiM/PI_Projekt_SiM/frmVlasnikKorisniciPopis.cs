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
    public partial class frmVlasnikKorisniciPopis : Form
    {
        private int korisnikId { get; set; }
        private string uloga { get; set; }
        private string ime { get; set; }
        private string prezime { get; set; }
        private string korisnickoIme { get; set; }
        private string email { get; set; }
        private string lozinka { get; set; }
        private string brojTelefona { get; set; }
        private bool osvjezi = false;

        public frmVlasnikKorisniciPopis()
        {
            InitializeComponent();
        }

        private void frmVlasnik_korisnici_popis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetKorisnici.korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.dataSetKorisnici.korisnik);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodajNovog_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            frmVlasnikKorisniciDodajNovog vlasnikDodajNovog = new frmVlasnikKorisniciDodajNovog();
            vlasnikDodajNovog.Show();
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            if (MessageBox.Show("Da li ste sigurni da zelite obrisati ovog korisnika?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.korisnikTableAdapter.DeleteQueryObrisiKorisnikaIzBaze(korisnikId);
                this.korisnikTableAdapter.Fill(this.dataSetKorisnici.korisnik);
            }
        }

        private void dgvPopisKorisnika_SelectionChanged(object sender, EventArgs e)
        {
            if (osvjezi == false)
            {
                foreach (DataGridViewRow row in dgvPopisKorisnika.SelectedRows)
                {
                    korisnikId = Int32.Parse(row.Cells[0].Value.ToString());
                    ime = row.Cells[1].Value.ToString();
                    prezime = row.Cells[2].Value.ToString();
                    korisnickoIme = row.Cells[3].Value.ToString();
                    lozinka = row.Cells[7].Value.ToString();
                    brojTelefona = row.Cells[6].Value.ToString();
                    uloga = row.Cells[4].Value.ToString();
                    email = row.Cells[5].Value.ToString();

                }
            }
            
        }

        private void btnIzmjena_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            frmVlasnikKorisniciIzmjenaPodataka novaIzmjena = new frmVlasnikKorisniciIzmjenaPodataka();
            novaIzmjena.preuzmiVrijednosti(korisnikId, ime, prezime, korisnickoIme, email, lozinka, brojTelefona, uloga);
            novaIzmjena.Show();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            osvjezi = true;
            this.Validate();
            this.korisnikBindingSource1.EndEdit();
            this.korisnikTableAdapter.Dispose();
            this.korisnikTableAdapter.Fill(this.dataSetKorisnici.korisnik);
            osvjezi = false;
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document noviDokument = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter noviPisac = PdfWriter.GetInstance(noviDokument, new FileStream("Vlasnik_korisnici.pdf", FileMode.Create));
            noviDokument.Open();

            PdfPTable tablica = new PdfPTable(dgvPopisKorisnika.Columns.Count);

            for (int i = 0; i < dgvPopisKorisnika.Columns.Count; i++)
            {
                tablica.AddCell(new Phrase(dgvPopisKorisnika.Columns[i].HeaderText));
            }

            tablica.HeaderRows = 1;

            for (int j = 0; j < dgvPopisKorisnika.Rows.Count; j++)
            {
                for (int k = 0; k < dgvPopisKorisnika.Columns.Count; k++)
                {
                    if (dgvPopisKorisnika[k, j].Value != null)
                    {
                        tablica.AddCell(new Phrase(dgvPopisKorisnika[k, j].Value.ToString()));
                    }
                }
            }

            noviDokument.Add(tablica);
            noviDokument.Close();

            MessageBox.Show("Uspjeh! Generirali ste PDF dokument s popisom korisnika!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start("Vlasnik_korisnici.pdf");
        }
    }
}
