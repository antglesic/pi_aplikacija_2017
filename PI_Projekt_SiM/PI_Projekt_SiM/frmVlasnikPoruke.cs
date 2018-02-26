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
    public partial class frmVlasnikPoruke : Form
    {
        public int idPoruke;
        private bool osvjezi = false;

        public frmVlasnikPoruke()
        {
            InitializeComponent();
        }

        private void frmVlasnikPoruke_Load(object sender, EventArgs e)
        {
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
            // TODO: This line of code loads data into the 'dataSetPoruke.primatelj_poruka' table. You can move, or remove it, as needed.
            this.primatelj_porukaTableAdapter.Fill(this.dataSetPoruke.primatelj_poruka);
            // TODO: This line of code loads data into the 'dataSetPoruke.posiljatelj_poruka' table. You can move, or remove it, as needed.
            this.posiljatelj_porukaTableAdapter.Fill(this.dataSetPoruke.posiljatelj_poruka);
            // TODO: This line of code loads data into the 'dataSetPoruke.korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this.dataSetPoruke.korisnik);
            // TODO: This line of code loads data into the 'dataSetPoruke.poruka' table. You can move, or remove it, as needed.
            this.porukaTableAdapter.Fill(this.dataSetPoruke.poruka);
            this.porukaPrikazTableAdapter.FillByKorisnik(dataSetPoruke.porukaPrikaz, 1);
            
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            this.Close();
        }

        private void dgvPopisPoruka_SelectionChanged(object sender, EventArgs e)
        {
            if (osvjezi == false)
            {
                idPoruke = Int32.Parse(dgvPopisPoruka.SelectedRows[0].Cells[0].Value.ToString());
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

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(dgvPopisPoruka.RowCount != 0)
            {
                osvjezi = false;
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
                osvjezi = false;
                MessageBox.Show("Nemate što obrisati!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            osvjezi = false;
            frmVlasnikPosaljiPoruku novaPoruka = new frmVlasnikPosaljiPoruku();
            novaPoruka.Show();
        }

        private void grbPopisPoruka_Enter(object sender, EventArgs e)
        {

        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            osvjezi = true;
            this.Validate();
            this.porukaPrikazBindingSource.EndEdit();
            this.porukaPrikazTableAdapter.Dispose();
            this.porukaPrikazTableAdapter.FillByKorisnik(dataSetPoruke.porukaPrikaz, 1);
            osvjezi = false;
        }
    }
}
