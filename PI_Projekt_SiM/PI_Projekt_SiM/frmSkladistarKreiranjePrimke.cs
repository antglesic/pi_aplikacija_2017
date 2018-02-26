using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using PI_Projekt_SiM;

namespace PI_Projekt_SiM
{
    public partial class frmSkladistarKreiranjePrimke : Form
    {
        public int idPrimke;
        private bool osvjezi = false;
        public int sirovinaId { get; set; }
        public frmSkladistarKreiranjePrimke()
        {
            InitializeComponent();
        }

        private void frmSkladistarKreiranjePrimke_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPrimke.dobavljac' table. You can move, or remove it, as needed.
            this.dobavljacTableAdapter.Fill(this.dataSetPrimke.dobavljac);
            // TODO: This line of code loads data into the 'dataSetPrimke.primka' table. You can move, or remove it, as needed.
            this.primkaTableAdapter.Fill(this.dataSetPrimke.primka);
            // TODO: This line of code loads data into the 'dataSetPrimke.primka' table. You can move, or remove it, as needed.
            this.primkaTableAdapter.Fill(this.dataSetPrimke.primka);
            // TODO: This line of code loads data into the 'dataSetPrimke.primka_sirovina' table. You can move, or remove it, as needed.
            this.primka_sirovinaTableAdapter.FillByIdPrimke(dataSetPrimke.primka_sirovina, idPrimke);
            // TODO: This line of code loads data into the 'dataSetPrimke.sirovina' table. You can move, or remove it, as needed.
            this.sirovinaTableAdapter.Fill(this.dataSetPrimke.sirovina);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if(inputIdPrimke.Text != "" && inputNaslov.Text != "" && inputOpis.Text != "")
            {
                idPrimke = Int32.Parse(inputIdPrimke.Text.ToString());
                int provjera = Int32.Parse(primkaTableAdapter.FillByIdPrimke(idPrimke).ToString());
                if (provjera != 0)
                {
                    osvjezi = false;
                    MessageBox.Show("Primka sa ovom šifrom već postoji!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    osvjezi = false;
                    string naslovPrimke = inputNaslov.Text.ToString();
                    string datumPrimke = inputDatum.Text.ToString();
                    string opisPrimke = inputOpis.Text.ToString();
                    int idDobavljaca = Int32.Parse(dgvPopisDobavljaca.Rows[dgvPopisDobavljaca.SelectedRows[0].Index].Cells[0].Value.ToString());
                    primkaTableAdapter.InsertQueryDodajNovuPrimku(idPrimke, naslovPrimke, opisPrimke, datumPrimke, 2, idDobavljaca);
                    MessageBox.Show("Uspješno ste kreirali novu primku!", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDodaj.Enabled = true;
                    btnOsvjezi.Enabled = true;
                    btnPotvrdi.Enabled = true;
                    btnObrisi.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Svi podaci moraju biti unešeni kako bi mogli kreirati primku!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            frmSkladistarKreirajNovuPrimku novaPrimka = new frmSkladistarKreirajNovuPrimku();
            novaPrimka.Show();
            novaPrimka.proslijediId(idPrimke);
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            osvjezi = true;
            this.Validate();
            this.primka_sirovinaBindingSource.EndEdit();
            this.primka_sirovinaTableAdapter.Dispose();
            this.primka_sirovinaTableAdapter.FillByIdPrimke(dataSetPrimke.primka_sirovina, idPrimke);
            osvjezi = false;
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            IList<int> listaSirovina = new List<int>();
            SqlConnection myConnection = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=17015_DB;Integrated Security=False;User ID=17015_User;Password=546YQ8yy;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter myDataAdapter = new SqlDataAdapter("SELECT id_sirovina FROM primka_sirovina WHERE id_primke = "+idPrimke,myConnection);
            DataTable dataTable = new System.Data.DataTable();
            myDataAdapter.Fill(dataTable);
            using (IDataReader reader = dataTable.CreateDataReader())
            while(reader.Read())
                {
                    listaSirovina.Add(reader.GetInt32(reader.GetOrdinal("id_sirovina")));
                }
            if(listaSirovina.Count.Equals(0))
            {
                MessageBox.Show("Ne možete kreirati prazan dokument!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (int item in listaSirovina)
                {
                    int trenutnaKolicina = Int32.Parse(sirovinaTableAdapter.DohvatiKolicinu(item).ToString());
                    int zaprimljenaKolicina = Int32.Parse(primka_sirovinaTableAdapter.DohvatiKolicinu(item, idPrimke).ToString());
                    int novaKolicina = PomocneClass.dajPovecanuKolicinu(trenutnaKolicina, zaprimljenaKolicina);
                    sirovinaTableAdapter.UpdateQueryAzurirajKolicinu(novaKolicina, item);
                }
                this.Close();
            }
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.primka_sirovinaTableAdapter.DeleteQueryBrisanjePrimke(idPrimke);
            this.primkaTableAdapter.DeleteQueryBrisanjePrimke(idPrimke);
            this.Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            if (dgvPopisSirovina.RowCount == 1)
            {
                this.primka_sirovinaTableAdapter.DeleteQueryBrisanjePrimke(idPrimke);
            }
            else
            {
                this.primka_sirovinaTableAdapter.DeleteQuerySirovinaPrimka(idPrimke, sirovinaId);
            }
        }

        private void dgvPopisSirovina_SelectionChanged(object sender, EventArgs e)
        {
            if (osvjezi == false)
            {
                if (dgvPopisSirovina.RowCount == 1 || dgvPopisSirovina.RowCount == 0)
                {
                    sirovinaId = Int32.Parse(dgvPopisSirovina.Rows[0].Cells[0].Value.ToString());
                }
                else
                {
                    sirovinaId = Int32.Parse(dgvPopisSirovina.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }
    }
}
