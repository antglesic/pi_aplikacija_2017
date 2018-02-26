using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace PI_Projekt_SiM
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                var runningPath = System.AppDomain.CurrentDomain.BaseDirectory;
                string fileName = string.Format("{0}Resources\\README.pdf", System.IO.Path.GetFullPath(System.IO.Path.Combine(runningPath, @"..\..\")));
                System.Diagnostics.Process.Start(fileName);
                // korisnik je pritisnuo F1 tipku na tipkovnici te se u pregledniku otvara poveznica navedena iznad
            }
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"\README.pdf");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prijavaBtn_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection(@"Data Source=31.147.204.119\PISERVER,1433;Initial Catalog=17015_DB;Integrated Security=False;User ID=17015_User;Password=546YQ8yy;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter myDataAdapter = new SqlDataAdapter("SELECT ime FROM korisnik WHERE korisnicko_ime='" + txtUserName.Text + "' AND lozinka='" + txtPassword.Text + "' AND id_uloga=1", myConnection);
            DataTable myDataTable = new System.Data.DataTable();
            myDataAdapter.Fill(myDataTable);
            if (myDataTable.Rows.Count == 1)
            {
                this.Hide();
                frmVlasnikPocetna vlasnikPocetna = new frmVlasnikPocetna();
                vlasnikPocetna.Show();
            }
            else
            {
                SqlDataAdapter myDataAdapterTwo = new SqlDataAdapter("SELECT ime FROM korisnik WHERE korisnicko_ime='" + txtUserName.Text + "' AND lozinka='" + txtPassword.Text + "' AND id_uloga=2", myConnection);
                myDataTable.Clear();
                myDataAdapterTwo.Fill(myDataTable);
                if (myDataTable.Rows.Count == 1) {
                    this.Hide();
                    frmSkladistarPocetna skladistarPocetna = new frmSkladistarPocetna();
                    skladistarPocetna.Show();
                }
                else
                {
                    SqlDataAdapter myDataAdapterThree = new SqlDataAdapter("SELECT ime FROM korisnik WHERE korisnicko_ime='" + txtUserName.Text + "' AND lozinka='" + txtPassword.Text + "' AND id_uloga=3", myConnection);
                    myDataTable.Clear();
                    myDataAdapterThree.Fill(myDataTable);
                    if (myDataTable.Rows.Count == 1)
                    {
                        this.Hide();
                        frmGlavniPekarPocetna glavniPekarPocetna = new frmGlavniPekarPocetna();
                        glavniPekarPocetna.Show();
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
