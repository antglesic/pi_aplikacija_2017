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
    public partial class frmVlasnikIzmjenaPodatakaDobavljac : Form
    {
        public int idDobavljac { get; set; }
        public string naziv { get; set; }
        public string email { get; set; }
        public string brojTelefona { get; set; }
        public string grad { get; set; }
        public frmVlasnikIzmjenaPodatakaDobavljac()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void preuzmiVrijednosti(int id, string name, string mail, string phone, string city)
        {
            idDobavljac = id;
            naziv = name;
            email = mail;
            brojTelefona = phone;
            grad = city;
        }

        private void frmVlasnikIzmjenaPodatakaDobavljac_Load(object sender, EventArgs e)
        {
            txtSifra.Text = idDobavljac.ToString();
            txtNaziv.Text = naziv;
            txtGrad.Text = grad;
            txtEmail.Text = email;
            txtBrojTelefona.Text = brojTelefona;
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text != "" && txtGrad.Text != "" && txtEmail.Text != "" && txtBrojTelefona.Text != "")
            {
                if (MessageBox.Show("Da li ste sigurni da zelite izmjeniti podatke ovog dobavljača?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    DataSetSirovineTableAdapters.dobavljac2TableAdapter noviTblAdapter = new DataSetSirovineTableAdapters.dobavljac2TableAdapter();
                    noviTblAdapter.UpdateQueryDobavljac(Int32.Parse(txtSifra.Text), txtNaziv.Text, txtGrad.Text, txtBrojTelefona.Text, txtEmail.Text);
                    MessageBox.Show("Uspjesno ste izmjenili podatke o dobavljacu!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
