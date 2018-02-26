namespace PI_Projekt_SiM
{
    partial class frmSkladistarKreiranjeZahtjevnice
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
            this.inputIdZahtjevnice = new System.Windows.Forms.TextBox();
            this.inputNaslov = new System.Windows.Forms.TextBox();
            this.inputSvrha = new System.Windows.Forms.TextBox();
            this.labelIdZahtjevnice = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelSvrha = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.inputDatum = new System.Windows.Forms.DateTimePicker();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.zahtjevnicaTableAdapter1 = new PI_Projekt_SiM.DataSetZahtjevniceTableAdapters.zahtjevnicaTableAdapter();
            this.dataSetZahtjevnice1 = new PI_Projekt_SiM.DataSetZahtjevnice();
            this.tip_zahtjevniceTableAdapter1 = new PI_Projekt_SiM.DataSetZahtjevniceTableAdapters.tip_zahtjevniceTableAdapter();
            this.dgvPopisSirovina = new System.Windows.Forms.DataGridView();
            this.idsirovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivsirovineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zahtjevnicasirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetZahtjevnicaSirovinaDodajNovi1 = new PI_Projekt_SiM.DataSetZahtjevnicaSirovinaDodajNovi();
            this.sirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSirovineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSirovine = new PI_Projekt_SiM.DataSetSirovine();
            this.sirovinaTableAdapter = new PI_Projekt_SiM.DataSetSirovineTableAdapters.sirovinaTableAdapter();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.zahtjevnica_sirovinaTableAdapter1 = new PI_Projekt_SiM.DataSetZahtjevnicaSirovinaDodajNoviTableAdapters.zahtjevnica_sirovinaTableAdapter();
            this.dataSetZahtjevnicaSirovina1 = new PI_Projekt_SiM.DataSetZahtjevnicaSirovina();
            this.dataSetZahtjevnicaSirovina2 = new PI_Projekt_SiM.DataSetZahtjevnicaSirovina();
            this.zahtjevnica_sirovinaTableAdapter2 = new PI_Projekt_SiM.DataSetZahtjevnicaSirovinaTableAdapters.zahtjevnica_sirovinaTableAdapter();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.grbZaglavlje = new System.Windows.Forms.GroupBox();
            this.grbPopisSirovina = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSirovina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovinaDodajNovi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovina1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovina2)).BeginInit();
            this.grbZaglavlje.SuspendLayout();
            this.grbPopisSirovina.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputIdZahtjevnice
            // 
            this.inputIdZahtjevnice.Location = new System.Drawing.Point(124, 35);
            this.inputIdZahtjevnice.Name = "inputIdZahtjevnice";
            this.inputIdZahtjevnice.Size = new System.Drawing.Size(64, 21);
            this.inputIdZahtjevnice.TabIndex = 0;
            // 
            // inputNaslov
            // 
            this.inputNaslov.Location = new System.Drawing.Point(124, 71);
            this.inputNaslov.Name = "inputNaslov";
            this.inputNaslov.Size = new System.Drawing.Size(200, 21);
            this.inputNaslov.TabIndex = 1;
            // 
            // inputSvrha
            // 
            this.inputSvrha.Location = new System.Drawing.Point(124, 149);
            this.inputSvrha.Multiline = true;
            this.inputSvrha.Name = "inputSvrha";
            this.inputSvrha.Size = new System.Drawing.Size(329, 64);
            this.inputSvrha.TabIndex = 2;
            // 
            // labelIdZahtjevnice
            // 
            this.labelIdZahtjevnice.AutoSize = true;
            this.labelIdZahtjevnice.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdZahtjevnice.Location = new System.Drawing.Point(17, 37);
            this.labelIdZahtjevnice.Name = "labelIdZahtjevnice";
            this.labelIdZahtjevnice.Size = new System.Drawing.Size(101, 15);
            this.labelIdZahtjevnice.TabIndex = 3;
            this.labelIdZahtjevnice.Text = "Šifra zahtjevnice:";
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
            // inputDatum
            // 
            this.inputDatum.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDatum.Location = new System.Drawing.Point(124, 108);
            this.inputDatum.Name = "inputDatum";
            this.inputDatum.Size = new System.Drawing.Size(200, 20);
            this.inputDatum.TabIndex = 7;
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
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // zahtjevnicaTableAdapter1
            // 
            this.zahtjevnicaTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSetZahtjevnice1
            // 
            this.dataSetZahtjevnice1.DataSetName = "DataSetZahtjevnice";
            this.dataSetZahtjevnice1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tip_zahtjevniceTableAdapter1
            // 
            this.tip_zahtjevniceTableAdapter1.ClearBeforeFill = true;
            // 
            // dgvPopisSirovina
            // 
            this.dgvPopisSirovina.AllowUserToAddRows = false;
            this.dgvPopisSirovina.AllowUserToDeleteRows = false;
            this.dgvPopisSirovina.AutoGenerateColumns = false;
            this.dgvPopisSirovina.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPopisSirovina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisSirovina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsirovinaDataGridViewTextBoxColumn,
            this.nazivsirovineDataGridViewTextBoxColumn,
            this.kolicina});
            this.dgvPopisSirovina.DataSource = this.zahtjevnicasirovinaBindingSource;
            this.dgvPopisSirovina.Location = new System.Drawing.Point(6, 19);
            this.dgvPopisSirovina.Name = "dgvPopisSirovina";
            this.dgvPopisSirovina.ReadOnly = true;
            this.dgvPopisSirovina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisSirovina.Size = new System.Drawing.Size(354, 190);
            this.dgvPopisSirovina.TabIndex = 10;
            this.dgvPopisSirovina.SelectionChanged += new System.EventHandler(this.dgvPopisSirovina_SelectionChanged);
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
            // kolicina
            // 
            this.kolicina.DataPropertyName = "kolicina";
            this.kolicina.HeaderText = "Zahtjevana količina";
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
            this.kolicina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // zahtjevnicasirovinaBindingSource
            // 
            this.zahtjevnicasirovinaBindingSource.DataMember = "zahtjevnica_sirovina";
            this.zahtjevnicasirovinaBindingSource.DataSource = this.dataSetZahtjevnicaSirovinaDodajNovi1;
            // 
            // dataSetZahtjevnicaSirovinaDodajNovi1
            // 
            this.dataSetZahtjevnicaSirovinaDodajNovi1.DataSetName = "DataSetZahtjevnicaSirovinaDodajNovi";
            this.dataSetZahtjevnicaSirovinaDodajNovi1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sirovinaBindingSource
            // 
            this.sirovinaBindingSource.DataMember = "sirovina";
            this.sirovinaBindingSource.DataSource = this.dataSetSirovineBindingSource;
            // 
            // dataSetSirovineBindingSource
            // 
            this.dataSetSirovineBindingSource.DataSource = this.dataSetSirovine;
            this.dataSetSirovineBindingSource.Position = 0;
            // 
            // dataSetSirovine
            // 
            this.dataSetSirovine.DataSetName = "DataSetSirovine";
            this.dataSetSirovine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sirovinaTableAdapter
            // 
            this.sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodaj.Enabled = false;
            this.btnDodaj.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(366, 19);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(96, 38);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // zahtjevnica_sirovinaTableAdapter1
            // 
            this.zahtjevnica_sirovinaTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSetZahtjevnicaSirovina1
            // 
            this.dataSetZahtjevnicaSirovina1.DataSetName = "DataSetZahtjevnicaSirovina";
            this.dataSetZahtjevnicaSirovina1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetZahtjevnicaSirovina2
            // 
            this.dataSetZahtjevnicaSirovina2.DataSetName = "DataSetZahtjevnicaSirovina";
            this.dataSetZahtjevnicaSirovina2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zahtjevnica_sirovinaTableAdapter2
            // 
            this.zahtjevnica_sirovinaTableAdapter2.ClearBeforeFill = true;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsvjezi.Location = new System.Drawing.Point(366, 107);
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
            this.btnPotvrdi.Location = new System.Drawing.Point(366, 151);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(96, 38);
            this.btnPotvrdi.TabIndex = 15;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // grbZaglavlje
            // 
            this.grbZaglavlje.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbZaglavlje.Controls.Add(this.inputSvrha);
            this.grbZaglavlje.Controls.Add(this.labelSvrha);
            this.grbZaglavlje.Controls.Add(this.inputNaslov);
            this.grbZaglavlje.Controls.Add(this.labelNaziv);
            this.grbZaglavlje.Controls.Add(this.inputDatum);
            this.grbZaglavlje.Controls.Add(this.btnOdustani);
            this.grbZaglavlje.Controls.Add(this.labelDatum);
            this.grbZaglavlje.Controls.Add(this.inputIdZahtjevnice);
            this.grbZaglavlje.Controls.Add(this.btnKreiraj);
            this.grbZaglavlje.Controls.Add(this.labelIdZahtjevnice);
            this.grbZaglavlje.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbZaglavlje.Location = new System.Drawing.Point(12, 12);
            this.grbZaglavlje.Name = "grbZaglavlje";
            this.grbZaglavlje.Size = new System.Drawing.Size(468, 271);
            this.grbZaglavlje.TabIndex = 16;
            this.grbZaglavlje.TabStop = false;
            this.grbZaglavlje.Text = "Zaglavlje";
            // 
            // grbPopisSirovina
            // 
            this.grbPopisSirovina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbPopisSirovina.Controls.Add(this.btnObrisi);
            this.grbPopisSirovina.Controls.Add(this.btnDodaj);
            this.grbPopisSirovina.Controls.Add(this.btnOsvjezi);
            this.grbPopisSirovina.Controls.Add(this.btnPotvrdi);
            this.grbPopisSirovina.Controls.Add(this.dgvPopisSirovina);
            this.grbPopisSirovina.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPopisSirovina.Location = new System.Drawing.Point(12, 289);
            this.grbPopisSirovina.Name = "grbPopisSirovina";
            this.grbPopisSirovina.Size = new System.Drawing.Size(468, 215);
            this.grbPopisSirovina.TabIndex = 17;
            this.grbPopisSirovina.TabStop = false;
            this.grbPopisSirovina.Text = "Popis sirovina";
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObrisi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(366, 63);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(96, 38);
            this.btnObrisi.TabIndex = 16;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmSkladistarKreiranjeZahtjevnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 516);
            this.Controls.Add(this.grbZaglavlje);
            this.Controls.Add(this.grbPopisSirovina);
            this.Name = "frmSkladistarKreiranjeZahtjevnice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova zahtjevnica";
            this.Load += new System.EventHandler(this.frmSkladistarKreiranjeZahtjevnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSirovina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovinaDodajNovi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovina1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovina2)).EndInit();
            this.grbZaglavlje.ResumeLayout(false);
            this.grbZaglavlje.PerformLayout();
            this.grbPopisSirovina.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox inputIdZahtjevnice;
        private System.Windows.Forms.TextBox inputNaslov;
        private System.Windows.Forms.TextBox inputSvrha;
        private System.Windows.Forms.Label labelIdZahtjevnice;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelSvrha;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.DateTimePicker inputDatum;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Button btnOdustani;
        private DataSetZahtjevniceTableAdapters.zahtjevnicaTableAdapter zahtjevnicaTableAdapter1;
        private DataSetZahtjevnice dataSetZahtjevnice1;
        private DataSetZahtjevniceTableAdapters.tip_zahtjevniceTableAdapter tip_zahtjevniceTableAdapter1;
        private System.Windows.Forms.DataGridView dgvPopisSirovina;
        private System.Windows.Forms.BindingSource dataSetSirovineBindingSource;
        private DataSetSirovine dataSetSirovine;
        private System.Windows.Forms.BindingSource sirovinaBindingSource;
        private DataSetSirovineTableAdapters.sirovinaTableAdapter sirovinaTableAdapter;
        private System.Windows.Forms.Button btnDodaj;
        private DataSetZahtjevnicaSirovina dataSetZahtjevnicaSirovina1;
        private DataSetZahtjevnicaSirovinaDodajNoviTableAdapters.zahtjevnica_sirovinaTableAdapter zahtjevnica_sirovinaTableAdapter1;
        private DataSetZahtjevnicaSirovina dataSetZahtjevnicaSirovina2;
        private DataSetZahtjevnicaSirovinaDodajNovi dataSetZahtjevnicaSirovinaDodajNovi1;
        private DataSetZahtjevnicaSirovinaTableAdapters.zahtjevnica_sirovinaTableAdapter zahtjevnica_sirovinaTableAdapter2;
        private System.Windows.Forms.BindingSource zahtjevnicasirovinaBindingSource;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.GroupBox grbZaglavlje;
        private System.Windows.Forms.GroupBox grbPopisSirovina;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsirovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivsirovineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.Button btnObrisi;
    }
}