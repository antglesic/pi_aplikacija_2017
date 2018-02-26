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
    public partial class frmSkladistarKreirajNovuPrimku : Form
    {
        public int idPrimke;

        public frmSkladistarKreirajNovuPrimku()
        {
            InitializeComponent();
        }

        public void proslijediId(int id)
        {
            this.idPrimke = id;
        }

        private void frmSkladistarKreirajNovuPrimku_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPrimke.primka_sirovina' table. You can move, or remove it, as needed.
            this.primka_sirovinaTableAdapter.Fill(this.dataSetPrimke.primka_sirovina);
            // TODO: This line of code loads data into the 'dataSetPrimke.sirovina' table. You can move, or remove it, as needed.
            this.sirovinaTableAdapter.Fill(this.dataSetPrimke.sirovina);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int idSirovine = Int32.Parse(dgvPopisSirovina.Rows[dgvPopisSirovina.SelectedRows[0].Index].Cells[0].Value.ToString());
            
            if(inputKolicina.Text != "")
            {
                int kolicina = Int32.Parse(inputKolicina.Text.ToString());
                if(kolicina == 0)
                {
                    MessageBox.Show("Unesena količina ne smije biti 0!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int provjera = Int32.Parse(primka_sirovinaTableAdapter.FillByIdSirovine(idSirovine, idPrimke).ToString());
                    if (provjera != 0)
                    {
                        MessageBox.Show("Tražena sirovina se već nalazi na primci!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        primka_sirovinaTableAdapter.InsertQueryDodajNovuSirovinu(idPrimke, idSirovine, kolicina);
                        MessageBox.Show("Uspješno dodana sirovina na primku!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Niste unijeli količinu!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
