namespace PI_Projekt_SiM
{
    partial class frmGlavniPekarKreiranjeZahtjevnice
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
            this.labelSifra = new System.Windows.Forms.Label();
            this.inputIdZahtjevnice = new System.Windows.Forms.TextBox();
            this.inputNaslov = new System.Windows.Forms.TextBox();
            this.inputSvrha = new System.Windows.Forms.TextBox();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.labelSvrha = new System.Windows.Forms.Label();
            this.inputDatum = new System.Windows.Forms.DateTimePicker();
            this.labelDatum = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.dgvSirovinePopis = new System.Windows.Forms.DataGridView();
            this.idsirovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivsirovineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zahtjevnicasirovinaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetZahtjevnicaSirovinaDodajNoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetZahtjevnicaSirovinaDodajNovi = new PI_Projekt_SiM.DataSetZahtjevnicaSirovinaDodajNovi();
            this.dataSetSirovine = new PI_Projekt_SiM.DataSetSirovine();
            this.dataSetSirovineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sirovinaTableAdapter = new PI_Projekt_SiM.DataSetSirovineTableAdapters.sirovinaTableAdapter();
            this.grbZaglavlje = new System.Windows.Forms.GroupBox();
            this.grbPopisSirovina = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dataSetZahtjevnicaSirovina = new PI_Projekt_SiM.DataSetZahtjevnicaSirovina();
            this.zahtjevnicasirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zahtjevnica_sirovinaTableAdapter = new PI_Projekt_SiM.DataSetZahtjevnicaSirovinaTableAdapters.zahtjevnica_sirovinaTableAdapter();
            this.zahtjevnica_sirovinaTableAdapter2 = new PI_Projekt_SiM.DataSetZahtjevnicaSirovinaTableAdapters.zahtjevnica_sirovinaTableAdapter();
            this.zahtjevnica_sirovinaTableAdapter1 = new PI_Projekt_SiM.DataSetZahtjevnicaSirovinaDodajNoviTableAdapters.zahtjevnica_sirovinaTableAdapter();
            this.dataSetZahtjevnice1 = new PI_Projekt_SiM.DataSetZahtjevnice();
            this.zahtjevnicaTableAdapter1 = new PI_Projekt_SiM.DataSetZahtjevniceTableAdapters.zahtjevnicaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSirovinePopis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovinaDodajNoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovinaDodajNovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).BeginInit();
            this.grbZaglavlje.SuspendLayout();
            this.grbPopisSirovina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnice1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSifra
            // 
            this.labelSifra.AutoSize = true;
            this.labelSifra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSifra.Location = new System.Drawing.Point(16, 31);
            this.labelSifra.Name = "labelSifra";
            this.labelSifra.Size = new System.Drawing.Size(101, 15);
            this.labelSifra.TabIndex = 0;
            this.labelSifra.Text = "Šifra zahtjevnice:";
            // 
            // inputIdZahtjevnice
            // 
            this.inputIdZahtjevnice.Location = new System.Drawing.Point(123, 28);
            this.inputIdZahtjevnice.Name = "inputIdZahtjevnice";
            this.inputIdZahtjevnice.Size = new System.Drawing.Size(116, 21);
            this.inputIdZahtjevnice.TabIndex = 1;
            // 
            // inputNaslov
            // 
            this.inputNaslov.Location = new System.Drawing.Point(123, 64);
            this.inputNaslov.Name = "inputNaslov";
            this.inputNaslov.Size = new System.Drawing.Size(233, 21);
            this.inputNaslov.TabIndex = 2;
            // 
            // inputSvrha
            // 
            this.inputSvrha.Location = new System.Drawing.Point(123, 138);
            this.inputSvrha.Multiline = true;
            this.inputSvrha.Name = "inputSvrha";
            this.inputSvrha.Size = new System.Drawing.Size(324, 79);
            this.inputSvrha.TabIndex = 3;
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNaslov.Location = new System.Drawing.Point(71, 67);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(46, 15);
            this.labelNaslov.TabIndex = 4;
            this.labelNaslov.Text = "Naslov:";
            // 
            // labelSvrha
            // 
            this.labelSvrha.AutoSize = true;
            this.labelSvrha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSvrha.Location = new System.Drawing.Point(75, 141);
            this.labelSvrha.Name = "labelSvrha";
            this.labelSvrha.Size = new System.Drawing.Size(42, 15);
            this.labelSvrha.TabIndex = 5;
            this.labelSvrha.Text = "Svrha:";
            // 
            // inputDatum
            // 
            this.inputDatum.Location = new System.Drawing.Point(123, 100);
            this.inputDatum.Name = "inputDatum";
            this.inputDatum.Size = new System.Drawing.Size(233, 21);
            this.inputDatum.TabIndex = 6;
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDatum.Location = new System.Drawing.Point(70, 105);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(47, 15);
            this.labelDatum.TabIndex = 7;
            this.labelDatum.Text = "Datum:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdustani.Location = new System.Drawing.Point(225, 223);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(96, 38);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKreiraj.Location = new System.Drawing.Point(123, 223);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(96, 38);
            this.btnKreiraj.TabIndex = 9;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodaj.Enabled = false;
            this.btnDodaj.Location = new System.Drawing.Point(357, 19);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(96, 38);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Enabled = false;
            this.btnOsvjezi.Location = new System.Drawing.Point(357, 107);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(96, 38);
            this.btnOsvjezi.TabIndex = 11;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPotvrdi.Enabled = false;
            this.btnPotvrdi.Location = new System.Drawing.Point(357, 151);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(96, 38);
            this.btnPotvrdi.TabIndex = 12;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // dgvSirovinePopis
            // 
            this.dgvSirovinePopis.AllowUserToAddRows = false;
            this.dgvSirovinePopis.AllowUserToDeleteRows = false;
            this.dgvSirovinePopis.AutoGenerateColumns = false;
            this.dgvSirovinePopis.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSirovinePopis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSirovinePopis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsirovinaDataGridViewTextBoxColumn,
            this.nazivsirovineDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dgvSirovinePopis.DataSource = this.zahtjevnicasirovinaBindingSource1;
            this.dgvSirovinePopis.Location = new System.Drawing.Point(6, 19);
            this.dgvSirovinePopis.Name = "dgvSirovinePopis";
            this.dgvSirovinePopis.ReadOnly = true;
            this.dgvSirovinePopis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSirovinePopis.Size = new System.Drawing.Size(345, 190);
            this.dgvSirovinePopis.TabIndex = 13;
            this.dgvSirovinePopis.SelectionChanged += new System.EventHandler(this.dgvSirovinePopis_SelectionChanged);
            // 
            // idsirovinaDataGridViewTextBoxColumn
            // 
            this.idsirovinaDataGridViewTextBoxColumn.DataPropertyName = "id_sirovina";
            this.idsirovinaDataGridViewTextBoxColumn.HeaderText = "Šifra sirovine";
            this.idsirovinaDataGridViewTextBoxColumn.Name = "idsirovinaDataGridViewTextBoxColumn";
            this.idsirovinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsirovinaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nazivsirovineDataGridViewTextBoxColumn
            // 
            this.nazivsirovineDataGridViewTextBoxColumn.DataPropertyName = "naziv_sirovine";
            this.nazivsirovineDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivsirovineDataGridViewTextBoxColumn.Name = "nazivsirovineDataGridViewTextBoxColumn";
            this.nazivsirovineDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivsirovineDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Zahtjevana količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // zahtjevnicasirovinaBindingSource1
            // 
            this.zahtjevnicasirovinaBindingSource1.DataMember = "zahtjevnica_sirovina";
            this.zahtjevnicasirovinaBindingSource1.DataSource = this.dataSetZahtjevnicaSirovinaDodajNoviBindingSource;
            // 
            // dataSetZahtjevnicaSirovinaDodajNoviBindingSource
            // 
            this.dataSetZahtjevnicaSirovinaDodajNoviBindingSource.DataSource = this.dataSetZahtjevnicaSirovinaDodajNovi;
            this.dataSetZahtjevnicaSirovinaDodajNoviBindingSource.Position = 0;
            // 
            // dataSetZahtjevnicaSirovinaDodajNovi
            // 
            this.dataSetZahtjevnicaSirovinaDodajNovi.DataSetName = "DataSetZahtjevnicaSirovinaDodajNovi";
            this.dataSetZahtjevnicaSirovinaDodajNovi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetSirovine
            // 
            this.dataSetSirovine.DataSetName = "DataSetSirovine";
            this.dataSetSirovine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetSirovineBindingSource
            // 
            this.dataSetSirovineBindingSource.DataSource = this.dataSetSirovine;
            this.dataSetSirovineBindingSource.Position = 0;
            // 
            // sirovinaBindingSource
            // 
            this.sirovinaBindingSource.DataMember = "sirovina";
            this.sirovinaBindingSource.DataSource = this.dataSetSirovineBindingSource;
            // 
            // sirovinaTableAdapter
            // 
            this.sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // grbZaglavlje
            // 
            this.grbZaglavlje.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbZaglavlje.Controls.Add(this.labelSifra);
            this.grbZaglavlje.Controls.Add(this.inputIdZahtjevnice);
            this.grbZaglavlje.Controls.Add(this.labelNaslov);
            this.grbZaglavlje.Controls.Add(this.inputNaslov);
            this.grbZaglavlje.Controls.Add(this.btnOdustani);
            this.grbZaglavlje.Controls.Add(this.btnKreiraj);
            this.grbZaglavlje.Controls.Add(this.inputDatum);
            this.grbZaglavlje.Controls.Add(this.labelDatum);
            this.grbZaglavlje.Controls.Add(this.inputSvrha);
            this.grbZaglavlje.Controls.Add(this.labelSvrha);
            this.grbZaglavlje.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbZaglavlje.Location = new System.Drawing.Point(14, 14);
            this.grbZaglavlje.Name = "grbZaglavlje";
            this.grbZaglavlje.Size = new System.Drawing.Size(471, 271);
            this.grbZaglavlje.TabIndex = 14;
            this.grbZaglavlje.TabStop = false;
            this.grbZaglavlje.Text = "Zaglavlje";
            // 
            // grbPopisSirovina
            // 
            this.grbPopisSirovina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbPopisSirovina.Controls.Add(this.btnObrisi);
            this.grbPopisSirovina.Controls.Add(this.dgvSirovinePopis);
            this.grbPopisSirovina.Controls.Add(this.btnPotvrdi);
            this.grbPopisSirovina.Controls.Add(this.btnDodaj);
            this.grbPopisSirovina.Controls.Add(this.btnOsvjezi);
            this.grbPopisSirovina.Location = new System.Drawing.Point(14, 291);
            this.grbPopisSirovina.Name = "grbPopisSirovina";
            this.grbPopisSirovina.Size = new System.Drawing.Size(471, 215);
            this.grbPopisSirovina.TabIndex = 15;
            this.grbPopisSirovina.TabStop = false;
            this.grbPopisSirovina.Text = "Popis sirovina";
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObrisi.Enabled = false;
            this.btnObrisi.Location = new System.Drawing.Point(357, 63);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(96, 38);
            this.btnObrisi.TabIndex = 14;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // dataSetZahtjevnicaSirovina
            // 
            this.dataSetZahtjevnicaSirovina.DataSetName = "DataSetZahtjevnicaSirovina";
            this.dataSetZahtjevnicaSirovina.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zahtjevnicasirovinaBindingSource
            // 
            this.zahtjevnicasirovinaBindingSource.DataMember = "zahtjevnica_sirovina";
            this.zahtjevnicasirovinaBindingSource.DataSource = this.dataSetZahtjevnicaSirovina;
            // 
            // zahtjevnica_sirovinaTableAdapter
            // 
            this.zahtjevnica_sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // zahtjevnica_sirovinaTableAdapter2
            // 
            this.zahtjevnica_sirovinaTableAdapter2.ClearBeforeFill = true;
            // 
            // zahtjevnica_sirovinaTableAdapter1
            // 
            this.zahtjevnica_sirovinaTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSetZahtjevnice1
            // 
            this.dataSetZahtjevnice1.DataSetName = "DataSetZahtjevnice";
            this.dataSetZahtjevnice1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zahtjevnicaTableAdapter1
            // 
            this.zahtjevnicaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmGlavniPekarKreiranjeZahtjevnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 516);
            this.Controls.Add(this.grbPopisSirovina);
            this.Controls.Add(this.grbZaglavlje);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGlavniPekarKreiranjeZahtjevnice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova zahtjevnica";
            this.Load += new System.EventHandler(this.frmGlavniPekarKreiranjeZahtjevnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSirovinePopis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovinaDodajNoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovinaDodajNovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).EndInit();
            this.grbZaglavlje.ResumeLayout(false);
            this.grbZaglavlje.PerformLayout();
            this.grbPopisSirovina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnice1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSifra;
        private System.Windows.Forms.TextBox inputIdZahtjevnice;
        private System.Windows.Forms.TextBox inputNaslov;
        private System.Windows.Forms.TextBox inputSvrha;
        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Label labelSvrha;
        private System.Windows.Forms.DateTimePicker inputDatum;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnKreiraj;
        private DataSetZahtjevnice dataSetZahtjevnice1;
        private DataSetZahtjevniceTableAdapters.zahtjevnicaTableAdapter zahtjevnicaTableAdapter1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.DataGridView dgvSirovinePopis;
        private System.Windows.Forms.BindingSource dataSetSirovineBindingSource;
        private DataSetSirovine dataSetSirovine;
        private System.Windows.Forms.BindingSource sirovinaBindingSource;
        private DataSetSirovineTableAdapters.sirovinaTableAdapter sirovinaTableAdapter;
        private DataSetZahtjevnicaSirovina dataSetZahtjevnicaSirovina;
        private System.Windows.Forms.BindingSource zahtjevnicasirovinaBindingSource;
        private DataSetZahtjevnicaSirovinaTableAdapters.zahtjevnica_sirovinaTableAdapter zahtjevnica_sirovinaTableAdapter;
        private System.Windows.Forms.BindingSource zahtjevnicasirovinaBindingSource1;
        private System.Windows.Forms.BindingSource dataSetZahtjevnicaSirovinaDodajNoviBindingSource;
        private DataSetZahtjevnicaSirovinaDodajNovi dataSetZahtjevnicaSirovinaDodajNovi;
        private DataSetZahtjevnicaSirovinaDodajNoviTableAdapters.zahtjevnica_sirovinaTableAdapter zahtjevnica_sirovinaTableAdapter1;
        private DataSetZahtjevnicaSirovinaTableAdapters.zahtjevnica_sirovinaTableAdapter zahtjevnica_sirovinaTableAdapter2;
        private System.Windows.Forms.GroupBox grbZaglavlje;
        private System.Windows.Forms.GroupBox grbPopisSirovina;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsirovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivsirovineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnObrisi;
    }
}