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
    public partial class frmVlasnikSkladisteNovaSirovina : Form
    {
        public frmVlasnikSkladisteNovaSirovina()
        {
            InitializeComponent();
        }

        private void frmVlasnikSkladisteNovaSirovina_Load(object sender, EventArgs e)
        {
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (txtSifra.Text != "" && txtNaziv.Text != "" && textBox2.Text != "" && txtJedinicna.Text != "" && txtDostupna.Text != "")
            {
                int idSirovina = Int32.Parse(txtSifra.Text);
                DataSetSirovineTableAdapters.sirovinaTableAdapter noviTableAdapterSirovina = new DataSetSirovineTableAdapters.sirovinaTableAdapter();
                int broj = noviTableAdapterSirovina.ScalarQueryProvjeriPostojanje(idSirovina).Value;
                if (broj > 0)
                {
                    MessageBox.Show("Sirovina s ovom sifrom vec postoji", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    noviTableAdapterSirovina.InsertQueryNovaSirovina(idSirovina, txtNaziv.Text, dtpDatum.Text, Int32.Parse(txtDostupna.Text), txtJedinicna.Text, textBox2.Text);
                    MessageBox.Show("Uspjesno ste kreirali novu sirovinu", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    frmVlasnikSkladiste novaInstancaSkladista = new frmVlasnikSkladiste();

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Svi podaci o sirovini moraju biti uneseni", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
