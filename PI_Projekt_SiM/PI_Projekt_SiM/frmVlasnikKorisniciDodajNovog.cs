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
    public partial class frmVlasnikKorisniciDodajNovog : Form
    {
        public frmVlasnikKorisniciDodajNovog()
        {
            InitializeComponent();
        }

        private void frmVlasnikKorisniciDodajNovog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUloge.uloga' table. You can move, or remove it, as needed.
            this.ulogaTableAdapter.Fill(this.dataSetUloge.uloga);
            // TODO: This line of code loads data into the 'dataSetKorisnici.korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.dataSetKorisnici.korisnik);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            
            int idKorisnik;
            Int32.TryParse(txtId.Text, out idKorisnik);
            int postoji = ulogaTableAdapter.ScalarQueryProvjeriPostojanje(idKorisnik).Value;
            if (txtId.Text != "" && txtIme.Text != "" && txtPrezime.Text != "" && txtEmail.Text != "" && txtBrTelefona.Text != "" && txtLozinka.Text != "")
            {
                if (postoji != 0)
                {
                    MessageBox.Show("Korisnik s ovom sifrom vec postoji!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    this.korisnikTableAdapter.InsertQueryDodajNovogKorisnika(idKorisnik, txtIme.Text, txtPrezime.Text, txtKorIme.Text, txtEmail.Text, txtBrTelefona.Text, txtLozinka.Text, Int32.Parse(cmbUloga.SelectedValue.ToString()));
                    MessageBox.Show("Uspjesno ste kreirali novog korisnika!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
