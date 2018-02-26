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
    public partial class frmVlasnikKorisniciIzmjenaPodataka : Form
    {
        public int sifra { get; set; }
        public string uloga { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string korisnickoIme { get; set; }
        public string email { get; set; }
        public string lozinka { get; set; }
        public string brojTelefona { get; set; }
        public int idUloge { get; set; }
        public frmVlasnikKorisniciIzmjenaPodataka()
        {
            InitializeComponent();
        }

        public void preuzmiVrijednosti(int id, string name, string surename, string userName, string mail, string pass, string phone, string role)
        {
            sifra = id;
            ime = name;
            prezime = surename;
            korisnickoIme = userName;
            email = mail;
            lozinka = pass;
            brojTelefona = phone;
            uloga = role;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            if (txtIme.Text != "" && txtPrezime.Text != "" && txtKorisnickoIme.Text != "" && txtEmail.Text != "" && txtLozinka.Text != "" && txtBrojTelefona.Text != "")
            {
                DataSetKorisniciTableAdapters.korisnik2TableAdapter noviTableAdapter = new DataSetKorisniciTableAdapters.korisnik2TableAdapter();
                if (uloga.Equals("Administrator"))
                {
                    idUloge = 1;
                }

                if (uloga.Equals("Glavni pekar"))
                {
                    idUloge = 3;
                }

                if (uloga.Equals("Skladistar"))
                {
                    idUloge = 2;
                }

                if (MessageBox.Show("Da li ste sigurni da zelite izmjeniti podatke ovog korisnika?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    noviTableAdapter.UpdateQueryKorisnik(sifra, txtIme.Text, txtPrezime.Text, txtKorisnickoIme.Text, txtEmail.Text, txtBrojTelefona.Text, txtLozinka.Text, idUloge);
                    MessageBox.Show("Uspjesno ste izmijenili podatke o korisniku!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Potrebno je unjeti sve podatke!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmVlasnikKorisniciIzmjenaPodataka_Load(object sender, EventArgs e)
        {
            txtSifra.Text = sifra.ToString();
            txtIme.Text = ime;
            txtPrezime.Text = prezime;
            txtKorisnickoIme.Text = korisnickoIme;
            txtEmail.Text = email;
            txtLozinka.Text = lozinka;
            txtBrojTelefona.Text = brojTelefona;
            txtUloga.Text = uloga;
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }
    }
}
