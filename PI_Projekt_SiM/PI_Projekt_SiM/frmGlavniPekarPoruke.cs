using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Projekt_SiM
{
    public partial class frmGlavniPekarPoruke : Form
    {
        public int idPoruke;
        private bool osvjezi = false;

        public frmGlavniPekarPoruke()
        {
            InitializeComponent();
        }

        //Event handler gumba natrag
        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Ucitavanje sih table adapter te F1 pomoci
        private void frmGlavniPekarPoruke_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPoruke.primatelj_poruka' table. You can move, or remove it, as needed.
            this.primatelj_porukaTableAdapter.Fill(this.dataSetPoruke.primatelj_poruka);
            // TODO: This line of code loads data into the 'dataSetPoruke.posiljatelj_poruka' table. You can move, or remove it, as needed.
            this.posiljatelj_porukaTableAdapter.Fill(this.dataSetPoruke.posiljatelj_poruka);
            // TODO: This line of code loads data into the 'dataSetPoruke.porukaPrikaz' table. You can move, or remove it, as needed.
            this.porukaPrikazTableAdapter.FillByKorisnik(this.dataSetPoruke.porukaPrikaz, 3);
            // TODO: This line of code loads data into the 'dataSetPoruke.poruka' table. You can move, or remove it, as needed.
            this.porukaTableAdapter.Fill(this.dataSetPoruke.poruka);
            this.porukaTableAdapter.FillByIdKorisnika(dataSetPoruke.poruka);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

        //Kod koji se izvrsi prilikom promjene selekcije datagridview-a
        private void dgvPopisPoruka_SelectionChanged(object sender, EventArgs e)
        {
            if (osvjezi == false)
            {
                idPoruke = Int32.Parse(dgvPopisPoruka.Rows[dgvPopisPoruka.SelectedRows[0].Index].Cells[0].Value.ToString());
                SqlConnection myConnection = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=17015_DB;Integrated Security=False;User ID=17015_User;Password=546YQ8yy;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlDataAdapter myDataAdapter = new SqlDataAdapter("SELECT id_poruka, sadrzaj FROM poruka WHERE id_poruka = " + idPoruke, myConnection);
                DataTable dataTable = new System.Data.DataTable();
                myDataAdapter.Fill(dataTable);
                using (IDataReader reader = dataTable.CreateDataReader())
                    while (reader.Read())
                    {
                        outputSadrzajPoruke.Text = reader.GetString(reader.GetOrdinal("sadrzaj"));
                    }
            }
            
        }

        //Event handler gumba obrisi i njegov kod
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            if (dgvPopisPoruka.RowCount != 0)
            {
                if (MessageBox.Show("Da li ste sigurni da zelite obrisati ovu poruku?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    idPoruke = Int32.Parse(dgvPopisPoruka.Rows[dgvPopisPoruka.SelectedRows[0].Index].Cells[0].Value.ToString());
                    primatelj_porukaTableAdapter.DeleteQuery(idPoruke);
                    posiljatelj_porukaTableAdapter.DeleteQuery(idPoruke);
                    porukaTableAdapter.DeleteQuery(idPoruke);
                    MessageBox.Show("Uspješno izbrisana poruka!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nemate što obrisati!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Event handler gumba za slanje podataka
        private void btnPosalji_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            frmGlavniPekarPosaljiPoruku novaPoruka = new frmGlavniPekarPosaljiPoruku();
            novaPoruka.Show();
        }

        //Event handler gumba za osvjezavanje datagridview-a
        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            osvjezi = true;
            this.Validate();
            this.porukaPrikazBindingSource1.EndEdit();
            this.porukaPrikazTableAdapter.Dispose();
            this.porukaPrikazTableAdapter.FillByKorisnik(this.dataSetPoruke.porukaPrikaz, 3);
            osvjezi = false;
        }
    }
}
