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
    public partial class frmGlavniPekarZahtjevnice : Form
    {
        public int idZahtjevnice { get; set; }
        private bool osvjezi = false;
        public frmGlavniPekarZahtjevnice()
        {
            InitializeComponent();
        }

        //Event handler gumba natrag
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Ucitavanje forme te svih njezinih tableadaptera
        private void frmGlavniPekarZahtjevnice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetIzdatnice.zahtjevnica' table. You can move, or remove it, as needed.
            this.zahtjevnicaTableAdapter1.FillIdZahtjevniceIdKorisnik(this.dataSetIzdatnice.zahtjevnica);
            // TODO: This line of code loads data into the 'dataSetZahtjevnice.zahtjevnica' table. You can move, or remove it, as needed.
            this.zahtjevnicaTableAdapter.Fill(this.dataSetZahtjevnice.zahtjevnica);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        //Event handler gumba za kreiranje nove zahtjevnice
        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            frmGlavniPekarKreiranjeZahtjevnice kreiranje = new frmGlavniPekarKreiranjeZahtjevnice();
            kreiranje.Show();
        }
        
        //Kod koji se izvrsava kada se mijenja selekcija u datagridview-u popisa zahtjevnica
        private void dgvPopisZahtjevnica_SelectionChanged(object sender, EventArgs e)
        {
            if (osvjezi == false)
            {
                if (dgvPopisZahtjevnica.RowCount > 0)
                {
                    idZahtjevnice = Int32.Parse(dgvPopisZahtjevnica.SelectedRows[0].Cells[0].Value.ToString());
                    this.zahtjevnica_sirovinaTableAdapter.FillIdZahtjevnicaIdSirovina(dataSetIzdatnice.zahtjevnica_sirovina, idZahtjevnice);
                }  
            }
        }

        //Event handler gumba osvjezi
        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            osvjezi = true;
            this.Validate();
            this.zahtjevnicaBindingSource1.EndEdit();
            this.zahtjevnicaTableAdapter1.Dispose();
            this.zahtjevnicaTableAdapter1.FillIdZahtjevniceIdKorisnik(this.dataSetIzdatnice.zahtjevnica);
            osvjezi = false;
        }

        //Event handler gumba za exportanje pdf-a
        private void btnPdf_Click(object sender, EventArgs e)
        {
            Document noviDokument = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter noviPisac = PdfWriter.GetInstance(noviDokument, new FileStream("Glavni_pekar_zahtjevnice.pdf", FileMode.Create));
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

            MessageBox.Show("Uspjeh! Generirali ste PDF dokument s popisom zahtjevnica glavnog pekara!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Process.Start("Glavni_pekar_zahtjevnice.pdf");
        }

        //Kod koji se izvrsi kada se text unosi u textbox
        private void txtTrazi_TextChanged(object sender, EventArgs e)
        {
            int broj;
            if (txtTrazi.Text != "" && int.TryParse(txtTrazi.Text, out broj))
            {
                this.zahtjevnicaTableAdapter1.FillByLikeZahtjevnica(dataSetIzdatnice.zahtjevnica, Int32.Parse(txtTrazi.Text));
            }
            else
            {
                this.zahtjevnicaTableAdapter1.FillIdZahtjevniceIdKorisnik(this.dataSetIzdatnice.zahtjevnica);
            }

        }
    }
}
