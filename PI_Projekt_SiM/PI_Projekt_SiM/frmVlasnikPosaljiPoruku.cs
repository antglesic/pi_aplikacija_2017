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
    public partial class frmVlasnikPosaljiPoruku : Form
    {
        public frmVlasnikPosaljiPoruku()
        {
            InitializeComponent();
        }

        private void korisnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.korisnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetPoruke);

        }

        private void frmVlasnikPosaljiPoruku_Load(object sender, EventArgs e)
        {
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
            // TODO: This line of code loads data into the 'dataSetPoruke.primatelj_poruka' table. You can move, or remove it, as needed.
            this.primatelj_porukaTableAdapter.Fill(this.dataSetPoruke.primatelj_poruka);
            // TODO: This line of code loads data into the 'dataSetPoruke.posiljatelj_poruka' table. You can move, or remove it, as needed.
            this.posiljatelj_porukaTableAdapter.Fill(this.dataSetPoruke.posiljatelj_poruka);
            // TODO: This line of code loads data into the 'dataSetPoruke.poruka' table. You can move, or remove it, as needed.
            this.porukaTableAdapter.Fill(this.dataSetPoruke.poruka);
            // TODO: This line of code loads data into the 'dataSetPoruke.korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.dataSetPoruke.korisnik);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            if (inputSifraPoruke.Text != "" && inputNaslov.Text != "" && inputSadrzajPoruke.Text != "")
            {
                int idPoruke = Int32.Parse(inputSifraPoruke.Text.ToString());
                int provjera = Int32.Parse(this.porukaTableAdapter.BrojPoruka(idPoruke).ToString());
                if (provjera == 0)
                {
                    int idPrimatelja = Int32.Parse(dgvPopisKorisnika.Rows[dgvPopisKorisnika.SelectedRows[0].Index].Cells[0].Value.ToString());
                    string naslovPoruke = inputNaslov.Text.ToString();
                    string datumPoruke = inputDatum.Text.ToString();
                    string tijeloPoruke = inputSadrzajPoruke.Text.ToString();
                    porukaTableAdapter.InsertQueryNovaPoruka(idPoruke, naslovPoruke, tijeloPoruke, datumPoruke);
                    posiljatelj_porukaTableAdapter.InsertQueryNovaPoruka(2, idPoruke);
                    primatelj_porukaTableAdapter.InsertQueryNovaPoruka(idPrimatelja, idPoruke);
                    MessageBox.Show("Uspješno poslana poruka!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Poruka sa ovom šifrom već postoji!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Niste unijeli potrebne podatke!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
