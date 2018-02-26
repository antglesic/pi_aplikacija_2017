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
    public partial class frmSkladistarPoruke : Form
    {
        public int idPoruke;
        private bool osvjezi = false;
        public frmSkladistarPoruke()
        {
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSkladistarPoruke_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPoruke.primatelj_poruka' table. You can move, or remove it, as needed.
            this.primatelj_porukaTableAdapter1.Fill(this.dataSetPoruke1.primatelj_poruka);
            // TODO: This line of code loads data into the 'dataSetPoruke.posiljatelj_poruka' table. You can move, or remove it, as needed.
            this.posiljatelj_porukaTableAdapter1.Fill(this.dataSetPoruke1.posiljatelj_poruka);
            // TODO: This line of code loads data into the 'dataSetPoruke.porukaPrikaz' table. You can move, or remove it, as needed.
            this.porukaPrikazTableAdapter1.FillByKorisnik(this.dataSetPoruke1.porukaPrikaz, 2);
            // TODO: This line of code loads data into the 'dataSetPoruke.poruka' table. You can move, or remove it, as needed.
            this.porukaTableAdapter1.Fill(this.dataSetPoruke1.poruka);
            this.porukaTableAdapter1.FillByIdKorisnika(dataSetPoruke1.poruka);
            frmPrijava nova = new frmPrijava();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(nova.Form1_KeyDown);
        }

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

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(dgvPopisPoruka.RowCount != 0)
            {
                osvjezi = false;
                if (MessageBox.Show("Da li ste sigurni da zelite obrisati ovu poruku?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    osvjezi = false;
                    idPoruke = Int32.Parse(dgvPopisPoruka.Rows[dgvPopisPoruka.SelectedRows[0].Index].Cells[0].Value.ToString());
                    primatelj_porukaTableAdapter1.DeleteQuery(idPoruke);
                    posiljatelj_porukaTableAdapter1.DeleteQuery(idPoruke);
                    porukaTableAdapter1.DeleteQuery(idPoruke);
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
            frmSkladistarSaljiPoruku novaPoruka = new frmSkladistarSaljiPoruku();
            novaPoruka.Show();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            osvjezi = true;
            this.Validate();
            this.porukaPrikazBindingSource1.EndEdit();
            this.porukaPrikazTableAdapter1.Dispose();
            this.porukaPrikazTableAdapter1.FillByKorisnik(this.dataSetPoruke1.porukaPrikaz, 2);
            osvjezi = false;
        }
    }
}
