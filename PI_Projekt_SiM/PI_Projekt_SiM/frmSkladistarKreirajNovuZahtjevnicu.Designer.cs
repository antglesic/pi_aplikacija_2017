namespace PI_Projekt_SiM
{
    partial class frmSkladistarKreirajNovuZahtjevnicu
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
            this.dgvSirovinaPopis = new System.Windows.Forms.DataGridView();
            this.idsirovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv_sirovine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rok_trajanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicna_mjera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSirovineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSirovine = new PI_Projekt_SiM.DataSetSirovine();
            this.zahtjevnicasirovinaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetZahtjevnicaSirovinaDodajNoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetZahtjevnicaSirovinaDodajNovi = new PI_Projekt_SiM.DataSetZahtjevnicaSirovinaDodajNovi();
            this.sirovinaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sirovinaTableAdapter = new PI_Projekt_SiM.DataSetSirovineTableAdapters.sirovinaTableAdapter();
            this.dataSetZahtjevnice1 = new PI_Projekt_SiM.DataSetZahtjevnice();
            this.zahtjevnicaTableAdapter1 = new PI_Projekt_SiM.DataSetZahtjevniceTableAdapters.zahtjevnicaTableAdapter();
            this.zahtjevnica_sirovinaTableAdapter1 = new PI_Projekt_SiM.DataSetZahtjevnicaSirovinaDodajNoviTableAdapters.zahtjevnica_sirovinaTableAdapter();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.labelKolicina = new System.Windows.Forms.Label();
            this.inputKolicina = new System.Windows.Forms.TextBox();
            this.zahtjevnicasirovinaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetZahtjevnicaSirovina = new PI_Projekt_SiM.DataSetZahtjevnicaSirovina();
            this.zahtjevnicasirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zahtjevnica_sirovinaTableAdapter = new PI_Projekt_SiM.DataSetZahtjevnicaSirovinaTableAdapters.zahtjevnica_sirovinaTableAdapter();
            this.brbPopisSirovina = new System.Windows.Forms.GroupBox();
            this.grbKolicina = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSirovinaPopis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovinaDodajNoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovinaDodajNovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource)).BeginInit();
            this.brbPopisSirovina.SuspendLayout();
            this.grbKolicina.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSirovinaPopis
            // 
            this.dgvSirovinaPopis.AllowUserToAddRows = false;
            this.dgvSirovinaPopis.AllowUserToDeleteRows = false;
            this.dgvSirovinaPopis.AutoGenerateColumns = false;
            this.dgvSirovinaPopis.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSirovinaPopis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSirovinaPopis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsirovinaDataGridViewTextBoxColumn,
            this.naziv_sirovine,
            this.rok_trajanja,
            this.jedinicna_mjera,
            this.napomena});
            this.dgvSirovinaPopis.DataSource = this.sirovinaBindingSource;
            this.dgvSirovinaPopis.Location = new System.Drawing.Point(6, 20);
            this.dgvSirovinaPopis.Name = "dgvSirovinaPopis";
            this.dgvSirovinaPopis.ReadOnly = true;
            this.dgvSirovinaPopis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSirovinaPopis.Size = new System.Drawing.Size(544, 235);
            this.dgvSirovinaPopis.TabIndex = 0;
            this.dgvSirovinaPopis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZahtjevnicaPopis_CellContentClick);
            // 
            // idsirovinaDataGridViewTextBoxColumn
            // 
            this.idsirovinaDataGridViewTextBoxColumn.DataPropertyName = "id_sirovina";
            this.idsirovinaDataGridViewTextBoxColumn.HeaderText = "Šifra sirovine";
            this.idsirovinaDataGridViewTextBoxColumn.Name = "idsirovinaDataGridViewTextBoxColumn";
            this.idsirovinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsirovinaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // naziv_sirovine
            // 
            this.naziv_sirovine.DataPropertyName = "naziv_sirovine";
            this.naziv_sirovine.HeaderText = "Naziv";
            this.naziv_sirovine.Name = "naziv_sirovine";
            this.naziv_sirovine.ReadOnly = true;
            this.naziv_sirovine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rok_trajanja
            // 
            this.rok_trajanja.DataPropertyName = "rok_trajanja";
            this.rok_trajanja.HeaderText = "Rok trajanja";
            this.rok_trajanja.Name = "rok_trajanja";
            this.rok_trajanja.ReadOnly = true;
            this.rok_trajanja.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // jedinicna_mjera
            // 
            this.jedinicna_mjera.DataPropertyName = "jedinicna_mjera";
            this.jedinicna_mjera.HeaderText = "Jedinična mjera";
            this.jedinicna_mjera.Name = "jedinicna_mjera";
            this.jedinicna_mjera.ReadOnly = true;
            this.jedinicna_mjera.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // napomena
            // 
            this.napomena.DataPropertyName = "napomena";
            this.napomena.HeaderText = "Napomena";
            this.napomena.Name = "napomena";
            this.napomena.ReadOnly = true;
            this.napomena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sirovinaBindingSource
            // 
            this.sirovinaBindingSource.DataMember = "Sirovina";
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
            // zahtjevnicasirovinaBindingSource2
            // 
            this.zahtjevnicasirovinaBindingSource2.DataMember = "zahtjevnica_sirovina";
            this.zahtjevnicasirovinaBindingSource2.DataSource = this.dataSetZahtjevnicaSirovinaDodajNoviBindingSource;
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
            // sirovinaBindingSource1
            // 
            this.sirovinaBindingSource1.DataMember = "sirovina";
            this.sirovinaBindingSource1.DataSource = this.dataSetSirovine;
            // 
            // sirovinaTableAdapter
            // 
            this.sirovinaTableAdapter.ClearBeforeFill = true;
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
            // zahtjevnica_sirovinaTableAdapter1
            // 
            this.zahtjevnica_sirovinaTableAdapter1.ClearBeforeFill = true;
            // 
            // btnNazad
            // 
            this.btnNazad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNazad.Location = new System.Drawing.Point(253, 20);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(96, 38);
            this.btnNazad.TabIndex = 1;
            this.btnNazad.Text = "Odustani";
            this.btnNazad.UseVisualStyleBackColor = false;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodaj.Location = new System.Drawing.Point(151, 20);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(96, 38);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // labelKolicina
            // 
            this.labelKolicina.AutoSize = true;
            this.labelKolicina.Location = new System.Drawing.Point(8, 32);
            this.labelKolicina.Name = "labelKolicina";
            this.labelKolicina.Size = new System.Drawing.Size(56, 15);
            this.labelKolicina.TabIndex = 3;
            this.labelKolicina.Text = "Količina:";
            // 
            // inputKolicina
            // 
            this.inputKolicina.Location = new System.Drawing.Point(70, 29);
            this.inputKolicina.Name = "inputKolicina";
            this.inputKolicina.Size = new System.Drawing.Size(75, 21);
            this.inputKolicina.TabIndex = 4;
            this.inputKolicina.TextChanged += new System.EventHandler(this.inputKolicina_TextChanged);
            // 
            // zahtjevnicasirovinaBindingSource1
            // 
            this.zahtjevnicasirovinaBindingSource1.DataMember = "zahtjevnica_sirovina";
            this.zahtjevnicasirovinaBindingSource1.DataSource = this.dataSetZahtjevnicaSirovina;
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
            // brbPopisSirovina
            // 
            this.brbPopisSirovina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brbPopisSirovina.Controls.Add(this.dgvSirovinaPopis);
            this.brbPopisSirovina.Location = new System.Drawing.Point(12, 14);
            this.brbPopisSirovina.Name = "brbPopisSirovina";
            this.brbPopisSirovina.Size = new System.Drawing.Size(558, 261);
            this.brbPopisSirovina.TabIndex = 5;
            this.brbPopisSirovina.TabStop = false;
            this.brbPopisSirovina.Text = "Popis sirovina";
            // 
            // grbKolicina
            // 
            this.grbKolicina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbKolicina.Controls.Add(this.btnNazad);
            this.grbKolicina.Controls.Add(this.btnDodaj);
            this.grbKolicina.Controls.Add(this.inputKolicina);
            this.grbKolicina.Controls.Add(this.labelKolicina);
            this.grbKolicina.Location = new System.Drawing.Point(12, 279);
            this.grbKolicina.Name = "grbKolicina";
            this.grbKolicina.Size = new System.Drawing.Size(357, 68);
            this.grbKolicina.TabIndex = 6;
            this.grbKolicina.TabStop = false;
            this.grbKolicina.Text = "Dodavanje količine";
            // 
            // frmSkladistarKreirajNovuZahtjevnicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 355);
            this.Controls.Add(this.brbPopisSirovina);
            this.Controls.Add(this.grbKolicina);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSkladistarKreirajNovuZahtjevnicu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje sirovina ";
            this.Load += new System.EventHandler(this.frmSkladistarKreirajNovuZahtjevnicu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSirovinaPopis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovinaDodajNoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovinaDodajNovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource)).EndInit();
            this.brbPopisSirovina.ResumeLayout(false);
            this.grbKolicina.ResumeLayout(false);
            this.grbKolicina.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSirovinaPopis;
        private System.Windows.Forms.BindingSource dataSetSirovineBindingSource;
        private DataSetSirovine dataSetSirovine;
        private System.Windows.Forms.BindingSource sirovinaBindingSource;
        private DataSetZahtjevnicaSirovina dataSetZahtjevnicaSirovina;
        private System.Windows.Forms.BindingSource zahtjevnicasirovinaBindingSource;
        private DataSetZahtjevnicaSirovinaTableAdapters.zahtjevnica_sirovinaTableAdapter zahtjevnica_sirovinaTableAdapter;
        private System.Windows.Forms.BindingSource sirovinaBindingSource1;
        private DataSetSirovineTableAdapters.sirovinaTableAdapter sirovinaTableAdapter;
        private DataSetZahtjevnice dataSetZahtjevnice1;
        private DataSetZahtjevniceTableAdapters.zahtjevnicaTableAdapter zahtjevnicaTableAdapter1;
        private System.Windows.Forms.BindingSource zahtjevnicasirovinaBindingSource1;
        private System.Windows.Forms.BindingSource zahtjevnicasirovinaBindingSource2;
        private System.Windows.Forms.BindingSource dataSetZahtjevnicaSirovinaDodajNoviBindingSource;
        private DataSetZahtjevnicaSirovinaDodajNovi dataSetZahtjevnicaSirovinaDodajNovi;
        private DataSetZahtjevnicaSirovinaDodajNoviTableAdapters.zahtjevnica_sirovinaTableAdapter zahtjevnica_sirovinaTableAdapter1;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label labelKolicina;
        private System.Windows.Forms.TextBox inputKolicina;
        private System.Windows.Forms.GroupBox brbPopisSirovina;
        private System.Windows.Forms.GroupBox grbKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsirovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_sirovine;
        private System.Windows.Forms.DataGridViewTextBoxColumn rok_trajanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicna_mjera;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomena;
    }
}