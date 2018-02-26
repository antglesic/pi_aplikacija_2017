namespace PI_Projekt_SiM
{
    partial class frmVlasnikKorisniciDodajNovog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtBrTelefona = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblKorisnicko = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.ulogaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetUloge = new PI_Projekt_SiM.DataSetUloge();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetKorisnici = new PI_Projekt_SiM.DataSetKorisnici();
            this.ulogaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblUloga = new System.Windows.Forms.Label();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.korisnikTableAdapter = new PI_Projekt_SiM.DataSetKorisniciTableAdapters.korisnikTableAdapter();
            this.ulogaTableAdapter = new PI_Projekt_SiM.DataSetUlogeTableAdapters.ulogaTableAdapter();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUloge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetKorisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(134, 69);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(172, 20);
            this.txtIme.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(134, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(138, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(134, 142);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(172, 20);
            this.txtKorIme.TabIndex = 2;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(134, 107);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(172, 20);
            this.txtPrezime.TabIndex = 4;
            // 
            // txtBrTelefona
            // 
            this.txtBrTelefona.Location = new System.Drawing.Point(134, 214);
            this.txtBrTelefona.Name = "txtBrTelefona";
            this.txtBrTelefona.Size = new System.Drawing.Size(138, 20);
            this.txtBrTelefona.TabIndex = 5;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(134, 250);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(172, 20);
            this.txtLozinka.TabIndex = 6;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(97, 71);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(31, 15);
            this.lblIme.TabIndex = 7;
            this.lblIme.Text = "Ime:";
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojTelefona.Location = new System.Drawing.Point(48, 216);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(80, 15);
            this.lblBrojTelefona.TabIndex = 8;
            this.lblBrojTelefona.Text = "Broj telefona:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(86, 179);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email:";
            // 
            // lblKorisnicko
            // 
            this.lblKorisnicko.AutoSize = true;
            this.lblKorisnicko.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorisnicko.Location = new System.Drawing.Point(36, 144);
            this.lblKorisnicko.Name = "lblKorisnicko";
            this.lblKorisnicko.Size = new System.Drawing.Size(92, 15);
            this.lblKorisnicko.TabIndex = 10;
            this.lblKorisnicko.Text = "Korisničko ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(73, 109);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(55, 15);
            this.lblPrezime.TabIndex = 11;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLozinka.Location = new System.Drawing.Point(74, 252);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(54, 15);
            this.lblLozinka.TabIndex = 12;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // cmbUloga
            // 
            this.cmbUloga.DataSource = this.ulogaBindingSource1;
            this.cmbUloga.DisplayMember = "naziv_uloge";
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Location = new System.Drawing.Point(134, 285);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(172, 21);
            this.cmbUloga.TabIndex = 13;
            this.cmbUloga.ValueMember = "id_uloga";
            // 
            // ulogaBindingSource1
            // 
            this.ulogaBindingSource1.DataMember = "uloga";
            this.ulogaBindingSource1.DataSource = this.dataSetUloge;
            // 
            // dataSetUloge
            // 
            this.dataSetUloge.DataSetName = "DataSetUloge";
            this.dataSetUloge.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "korisnik";
            this.korisnikBindingSource.DataSource = this.dataSetKorisnici;
            // 
            // dataSetKorisnici
            // 
            this.dataSetKorisnici.DataSetName = "DataSetKorisnici";
            this.dataSetKorisnici.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ulogaBindingSource
            // 
            this.ulogaBindingSource.DataMember = "uloga";
            this.ulogaBindingSource.DataSource = this.dataSetUloge;
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUloga.Location = new System.Drawing.Point(87, 287);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(41, 15);
            this.lblUloga.TabIndex = 14;
            this.lblUloga.Text = "Uloga:";
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPotvrdi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.Location = new System.Drawing.Point(108, 325);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(96, 38);
            this.btnPotvrdi.TabIndex = 15;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdustani.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(210, 325);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(96, 38);
            this.btnOdustani.TabIndex = 16;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // ulogaTableAdapter
            // 
            this.ulogaTableAdapter.ClearBeforeFill = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(134, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 17;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(36, 34);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(92, 15);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "Šifra korisnika:";
            // 
            // frmVlasnikKorisniciDodajNovog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(349, 391);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.lblUloga);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblKorisnicko);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblBrojTelefona);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtBrTelefona);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtIme);
            this.Name = "frmVlasnikKorisniciDodajNovog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi korisnik";
            this.Load += new System.EventHandler(this.frmVlasnikKorisniciDodajNovog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUloge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetKorisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtBrTelefona;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblKorisnicko;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnOdustani;
        private DataSetKorisnici dataSetKorisnici;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private DataSetKorisniciTableAdapters.korisnikTableAdapter korisnikTableAdapter;
        private DataSetUloge dataSetUloge;
        private System.Windows.Forms.BindingSource ulogaBindingSource;
        private DataSetUlogeTableAdapters.ulogaTableAdapter ulogaTableAdapter;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.BindingSource ulogaBindingSource1;
    }
}