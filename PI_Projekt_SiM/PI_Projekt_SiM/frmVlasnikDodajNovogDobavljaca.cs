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
    public partial class frmVlasnikDodajNovogDobavljaca : Form
    {
        public frmVlasnikDodajNovogDobavljaca()
        {
            InitializeComponent();
        }

        private void frmVlasnikDodajNovogDobavljaca_Load(object sender, EventArgs e)
        {
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
            if (txtSifra.Text != "" && txtNaziv.Text != "" && txtGrad.Text != "" && txtEmail.Text != "" && txtBrojTelefona.Text != "")
            {
                DataSetSirovineTableAdapters.dobavljac2TableAdapter noviTblAdapter = new DataSetSirovineTableAdapters.dobavljac2TableAdapter();
                int postoji = noviTblAdapter.ScalarQueryPostojiDobavljac(Int32.Parse(txtSifra.Text)).Value;
                if (postoji != 0)
                {
                    MessageBox.Show("Dobavljač s ovom sifrom vec postoji!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    noviTblAdapter.InsertQueryDobavljac(Int32.Parse(txtSifra.Text), txtNaziv.Text, txtGrad.Text, txtBrojTelefona.Text, txtEmail.Text);
                    MessageBox.Show("Uspješno ste kreirali novog dobavljača!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Potrebno je unjeti sve podatke!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        } 
    }
}
