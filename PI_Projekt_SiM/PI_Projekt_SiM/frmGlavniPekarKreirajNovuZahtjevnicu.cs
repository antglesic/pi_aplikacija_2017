using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Projekt_SiM
{
    public partial class frmGlavniPekarKreirajNovuZahtjevnicu : Form
    {

        public int idZahtjevnice;

        public frmGlavniPekarKreirajNovuZahtjevnicu()
        {
            InitializeComponent();
        }

        public void prosljediId(int id)
        {
            this.idZahtjevnice = id;
        }

        //Ucitavanje svih dataadaptera te F1 pomoci
        private void frmGlavniPekarKreirajNovuZahtjevnicu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetZahtjevnice.zahtjevnica' table. You can move, or remove it, as needed.
            this.zahtjevnicaTableAdapter1.Fill(this.dataSetZahtjevnice1.zahtjevnica);
            // TODO: This line of code loads data into the 'dataSetSirovine.sirovina' table. You can move, or remove it, as needed.
            this.sirovinaTableAdapter.Fill(this.dataSetSirovine.sirovina);
            // TODO: This line of code loads data into the 'dataSetZahtjevnicaSirovina.zahtjevnica_sirovina' table. You can move, or remove it, as needed.
            this.zahtjevnica_sirovinaTableAdapter.Fill(this.dataSetZahtjevnicaSirovina.zahtjevnica_sirovina);
            this.zahtjevnica_sirovinaTableAdapter1.FillByNovaZahtjevnicaId(dataSetZahtjevnicaSirovinaDodajNovi1.zahtjevnica_sirovina, idZahtjevnice);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        //Event handler za dodavanje novih sirovina
        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            
            
            if (inputKolicina.Text != "")
            {
                int idSirovine = Int32.Parse(dgvPopisSirovina.SelectedRows[0].Cells[0].Value.ToString());
                int dostupna_kolicina = Int32.Parse(dgvPopisSirovina.SelectedRows[0].Cells[3].Value.ToString());
                int kolicina = Int32.Parse(inputKolicina.Text);
                if(kolicina == 0)
                {
                    MessageBox.Show("Količina ne smije biti 0!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (dostupna_kolicina > kolicina)
                    {
                        if (int.Parse(zahtjevnica_sirovinaTableAdapter.FillByIdSirovine(idSirovine, idZahtjevnice).ToString()) != 0)
                        {
                            MessageBox.Show("Tražena sirovina je već dodana na zahtjevnicu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            this.zahtjevnica_sirovinaTableAdapter.InsertQueryNovaSirovinaNaZahtjevnici(idZahtjevnice, idSirovine, kolicina);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ne moguće zahtijevati više od dostupne količine na skladištu", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Niste unijeli količinu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Event handler gumba za odustajanje
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sirovinaTableAdapter.FillBy(this.dataSetSirovine.sirovina);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
