namespace PI_Projekt_SiM
{
    partial class frmSkladistarKreirajNovuOtpisnicu
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
            this.grbZaglavlje = new System.Windows.Forms.GroupBox();
            this.txtSvrha = new System.Windows.Forms.TextBox();
            this.labelSvrha = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.inputDatum = new System.Windows.Forms.DateTimePicker();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.labelDatum = new System.Windows.Forms.Label();
            this.txtSifraOtpisnice = new System.Windows.Forms.TextBox();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.labelIdZahtjevnice = new System.Windows.Forms.Label();
            this.grbPopisSirovina = new System.Windows.Forms.GroupBox();
            this.dgvPopisSirovinaNaOtpisnici = new System.Windows.Forms.DataGridView();
            this.idotpisnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsirovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivsirovineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otpisnicasirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSirovine = new PI_Projekt_SiM.DataSetSirovine();
            this.btnDodajSirovinu = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.otpisnica_sirovinaTableAdapter = new PI_Projekt_SiM.DataSetSirovineTableAdapters.otpisnica_sirovinaTableAdapter();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.grbZaglavlje.SuspendLayout();
            this.grbPopisSirovina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSirovinaNaOtpisnici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpisnicasirovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).BeginInit();
            this.SuspendLayout();
            // 
            // grbZaglavlje
            // 
            this.grbZaglavlje.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbZaglavlje.Controls.Add(this.txtSvrha);
            this.grbZaglavlje.Controls.Add(this.labelSvrha);
            this.grbZaglavlje.Controls.Add(this.txtNaslov);
            this.grbZaglavlje.Controls.Add(this.labelNaziv);
            this.grbZaglavlje.Controls.Add(this.inputDatum);
            this.grbZaglavlje.Controls.Add(this.btnOdustani);
            this.grbZaglavlje.Controls.Add(this.labelDatum);
            this.grbZaglavlje.Controls.Add(this.txtSifraOtpisnice);
            this.grbZaglavlje.Controls.Add(this.btnKreiraj);
            this.grbZaglavlje.Controls.Add(this.labelIdZahtjevnice);
            this.grbZaglavlje.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbZaglavlje.Location = new System.Drawing.Point(12, 12);
            this.grbZaglavlje.Name = "grbZaglavlje";
            this.grbZaglavlje.Size = new System.Drawing.Size(468, 271);
            this.grbZaglavlje.TabIndex = 18;
            this.grbZaglavlje.TabStop = false;
            this.grbZaglavlje.Text = "Zaglavlje";
            // 
            // txtSvrha
            // 
            this.txtSvrha.Location = new System.Drawing.Point(124, 149);
            this.txtSvrha.Multiline = true;
            this.txtSvrha.Name = "txtSvrha";
            this.txtSvrha.Size = new System.Drawing.Size(329, 64);
            this.txtSvrha.TabIndex = 2;
            // 
            // labelSvrha
            // 
            this.labelSvrha.AutoSize = true;
            this.labelSvrha.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSvrha.Location = new System.Drawing.Point(76, 151);
            this.labelSvrha.Name = "labelSvrha";
            this.labelSvrha.Size = new System.Drawing.Size(42, 15);
            this.labelSvrha.TabIndex = 5;
            this.labelSvrha.Text = "Svrha:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(124, 71);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(200, 21);
            this.txtNaslov.TabIndex = 1;
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaziv.Location = new System.Drawing.Point(72, 73);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(46, 15);
            this.labelNaziv.TabIndex = 4;
            this.labelNaziv.Text = "Naslov:";
            // 
            // inputDatum
            // 
            this.inputDatum.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDatum.Location = new System.Drawing.Point(124, 108);
            this.inputDatum.Name = "inputDatum";
            this.inputDatum.Size = new System.Drawing.Size(200, 20);
            this.inputDatum.TabIndex = 7;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdustani.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOdustani.Location = new System.Drawing.Point(226, 219);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(96, 38);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click_1);
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatum.Location = new System.Drawing.Point(71, 111);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(47, 15);
            this.labelDatum.TabIndex = 6;
            this.labelDatum.Text = "Datum:";
            // 
            // txtSifraOtpisnice
            // 
            this.txtSifraOtpisnice.Location = new System.Drawing.Point(124, 35);
            this.txtSifraOtpisnice.Name = "txtSifraOtpisnice";
            this.txtSifraOtpisnice.Size = new System.Drawing.Size(64, 21);
            this.txtSifraOtpisnice.TabIndex = 0;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKreiraj.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.Location = new System.Drawing.Point(124, 219);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(96, 38);
            this.btnKreiraj.TabIndex = 8;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // labelIdZahtjevnice
            // 
            this.labelIdZahtjevnice.AutoSize = true;
            this.labelIdZahtjevnice.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdZahtjevnice.Location = new System.Drawing.Point(17, 37);
            this.labelIdZahtjevnice.Name = "labelIdZahtjevnice";
            this.labelIdZahtjevnice.Size = new System.Drawing.Size(88, 15);
            this.labelIdZahtjevnice.TabIndex = 3;
            this.labelIdZahtjevnice.Text = "Šifra otpisnice:";
            // 
            // grbPopisSirovina
            // 
            this.grbPopisSirovina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbPopisSirovina.Controls.Add(this.btnObrisi);
            this.grbPopisSirovina.Controls.Add(this.dgvPopisSirovinaNaOtpisnici);
            this.grbPopisSirovina.Controls.Add(this.btnDodajSirovinu);
            this.grbPopisSirovina.Controls.Add(this.btnOsvjezi);
            this.grbPopisSirovina.Controls.Add(this.btnPotvrdi);
            this.grbPopisSirovina.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPopisSirovina.Location = new System.Drawing.Point(12, 289);
            this.grbPopisSirovina.Name = "grbPopisSirovina";
            this.grbPopisSirovina.Size = new System.Drawing.Size(685, 215);
            this.grbPopisSirovina.TabIndex = 19;
            this.grbPopisSirovina.TabStop = false;
            this.grbPopisSirovina.Text = "Popis sirovina";
            // 
            // dgvPopisSirovinaNaOtpisnici
            // 
            this.dgvPopisSirovinaNaOtpisnici.AllowUserToAddRows = false;
            this.dgvPopisSirovinaNaOtpisnici.AllowUserToDeleteRows = false;
            this.dgvPopisSirovinaNaOtpisnici.AutoGenerateColumns = false;
            this.dgvPopisSirovinaNaOtpisnici.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPopisSirovinaNaOtpisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisSirovinaNaOtpisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idotpisnicaDataGridViewTextBoxColumn,
            this.idsirovinaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.nazivsirovineDataGridViewTextBoxColumn,
            this.jedinicnamjeraDataGridViewTextBoxColumn});
            this.dgvPopisSirovinaNaOtpisnici.DataSource = this.otpisnicasirovinaBindingSource;
            this.dgvPopisSirovinaNaOtpisnici.Location = new System.Drawing.Point(6, 19);
            this.dgvPopisSirovinaNaOtpisnici.Name = "dgvPopisSirovinaNaOtpisnici";
            this.dgvPopisSirovinaNaOtpisnici.ReadOnly = true;
            this.dgvPopisSirovinaNaOtpisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisSirovinaNaOtpisnici.Size = new System.Drawing.Size(560, 190);
            this.dgvPopisSirovinaNaOtpisnici.TabIndex = 16;
            this.dgvPopisSirovinaNaOtpisnici.SelectionChanged += new System.EventHandler(this.dgvPopisSirovinaNaOtpisnici_SelectionChanged);
            // 
            // idotpisnicaDataGridViewTextBoxColumn
            // 
            this.idotpisnicaDataGridViewTextBoxColumn.DataPropertyName = "id_otpisnica";
            this.idotpisnicaDataGridViewTextBoxColumn.HeaderText = "Šifra otpisnice";
            this.idotpisnicaDataGridViewTextBoxColumn.Name = "idotpisnicaDataGridViewTextBoxColumn";
            this.idotpisnicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idotpisnicaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idsirovinaDataGridViewTextBoxColumn
            // 
            this.idsirovinaDataGridViewTextBoxColumn.DataPropertyName = "id_sirovina";
            this.idsirovinaDataGridViewTextBoxColumn.HeaderText = "Šifra sirovine";
            this.idsirovinaDataGridViewTextBoxColumn.Name = "idsirovinaDataGridViewTextBoxColumn";
            this.idsirovinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsirovinaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Otpisana količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nazivsirovineDataGridViewTextBoxColumn
            // 
            this.nazivsirovineDataGridViewTextBoxColumn.DataPropertyName = "naziv_sirovine";
            this.nazivsirovineDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivsirovineDataGridViewTextBoxColumn.Name = "nazivsirovineDataGridViewTextBoxColumn";
            this.nazivsirovineDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivsirovineDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // jedinicnamjeraDataGridViewTextBoxColumn
            // 
            this.jedinicnamjeraDataGridViewTextBoxColumn.DataPropertyName = "jedinicna_mjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.HeaderText = "Jedinična mjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.Name = "jedinicnamjeraDataGridViewTextBoxColumn";
            this.jedinicnamjeraDataGridViewTextBoxColumn.ReadOnly = true;
            this.jedinicnamjeraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // otpisnicasirovinaBindingSource
            // 
            this.otpisnicasirovinaBindingSource.DataMember = "otpisnica_sirovina";
            this.otpisnicasirovinaBindingSource.DataSource = this.dataSetSirovine;
            // 
            // dataSetSirovine
            // 
            this.dataSetSirovine.DataSetName = "DataSetSirovine";
            this.dataSetSirovine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDodajSirovinu
            // 
            this.btnDodajSirovinu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodajSirovinu.Enabled = false;
            this.btnDodajSirovinu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSirovinu.Location = new System.Drawing.Point(572, 20);
            this.btnDodajSirovinu.Name = "btnDodajSirovinu";
            this.btnDodajSirovinu.Size = new System.Drawing.Size(96, 38);
            this.btnDodajSirovinu.TabIndex = 11;
            this.btnDodajSirovinu.Text = "Dodaj";
            this.btnDodajSirovinu.UseVisualStyleBackColor = false;
            this.btnDodajSirovinu.Click += new System.EventHandler(this.btnDodajSirovinu_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsvjezi.Location = new System.Drawing.Point(572, 108);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(96, 38);
            this.btnOsvjezi.TabIndex = 14;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPotvrdi.Enabled = false;
            this.btnPotvrdi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotvrdi.Location = new System.Drawing.Point(572, 152);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(96, 38);
            this.btnPotvrdi.TabIndex = 15;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // otpisnica_sirovinaTableAdapter
            // 
            this.otpisnica_sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObrisi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(572, 64);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(96, 38);
            this.btnObrisi.TabIndex = 17;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmSkladistarKreirajNovuOtpisnicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(705, 518);
            this.Controls.Add(this.grbZaglavlje);
            this.Controls.Add(this.grbPopisSirovina);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSkladistarKreirajNovuOtpisnicu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova otpisnica";
            this.Load += new System.EventHandler(this.frmSkladistarKreirajNovuOtpisnicu_Load);
            this.grbZaglavlje.ResumeLayout(false);
            this.grbZaglavlje.PerformLayout();
            this.grbPopisSirovina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSirovinaNaOtpisnici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpisnicasirovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbZaglavlje;
        private System.Windows.Forms.TextBox txtSvrha;
        private System.Windows.Forms.Label labelSvrha;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.DateTimePicker inputDatum;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.TextBox txtSifraOtpisnice;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Label labelIdZahtjevnice;
        private System.Windows.Forms.GroupBox grbPopisSirovina;
        private System.Windows.Forms.Button btnDodajSirovinu;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.DataGridView dgvPopisSirovinaNaOtpisnici;
        private System.Windows.Forms.BindingSource otpisnicasirovinaBindingSource;
        private DataSetSirovine dataSetSirovine;
        private DataSetSirovineTableAdapters.otpisnica_sirovinaTableAdapter otpisnica_sirovinaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idotpisnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsirovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivsirovineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnamjeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnObrisi;
    }
}