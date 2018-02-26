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
    public partial class frmSkladistarKreirajNovuZahtjevnicu : Form
    {

        public int idZahtjevnice;

        public frmSkladistarKreirajNovuZahtjevnicu()
        {
            InitializeComponent();
        }

        public void prosljediId(int id)
        {
            this.idZahtjevnice = id;
        }

        private void frmSkladistarKreirajNovuZahtjevnicu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetZahtjevnice.zahtjevnica' table. You can move, or remove it, as needed.
            this.zahtjevnicaTableAdapter1.Fill(this.dataSetZahtjevnice1.zahtjevnica);
            // TODO: This line of code loads data into the 'dataSetSirovine.sirovina' table. You can move, or remove it, as needed.
            this.sirovinaTableAdapter.Fill(this.dataSetSirovine.sirovina);
            // TODO: This line of code loads data into the 'dataSetZahtjevnicaSirovina.zahtjevnica_sirovina' table. You can move, or remove it, as needed.
            this.zahtjevnica_sirovinaTableAdapter.Fill(this.dataSetZahtjevnicaSirovina.zahtjevnica_sirovina);
            this.zahtjevnica_sirovinaTableAdapter1.FillByNovaZahtjevnicaId(dataSetZahtjevnicaSirovinaDodajNovi.zahtjevnica_sirovina, idZahtjevnice);
            this.zahtjevnica_sirovinaTableAdapter1.FillByNovaZahtjevnicaId(dataSetZahtjevnicaSirovinaDodajNovi.zahtjevnica_sirovina, idZahtjevnice);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void dgvZahtjevnicaPopis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            if(inputKolicina.Text != "")
            {
                int idSirovine = int.Parse(dgvSirovinaPopis.Rows[dgvSirovinaPopis.SelectedRows[0].Index].Cells[0].Value.ToString());
                int kolicina = int.Parse(inputKolicina.Text.ToString());
                if(kolicina == 0)
                {
                    MessageBox.Show("Unesena količina ne smije biti 0!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (int.Parse(zahtjevnica_sirovinaTableAdapter.FillByIdSirovine(idSirovine, idZahtjevnice).ToString()) != 0)
                    {
                        MessageBox.Show("Tražena sirovina je već dodana na zahtjevnici!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        this.zahtjevnica_sirovinaTableAdapter.InsertQueryNovaSirovinaNaZahtjevnici(idZahtjevnice, idSirovine, kolicina);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Niste unijeli količinu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void inputKolicina_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
