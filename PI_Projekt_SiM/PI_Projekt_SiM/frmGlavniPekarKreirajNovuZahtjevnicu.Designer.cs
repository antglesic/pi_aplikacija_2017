namespace PI_Projekt_SiM
{
    partial class frmGlavniPekarKreirajNovuZahtjevnicu
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
            this.labelKolicina = new System.Windows.Forms.Label();
            this.sirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSirovineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSirovine = new PI_Projekt_SiM.DataSetSirovine();
            this.inputKolicina = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPopisSirovina = new System.Windows.Forms.DataGridView();
            this.zahtjevnicasirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetZahtjevnicaSirovinaDodajNovi1 = new PI_Projekt_SiM.DataSetZahtjevnicaSirovinaDodajNovi();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.sirovinaTableAdapter = new PI_Projekt_SiM.DataSetSirovineTableAdapters.sirovinaTableAdapter();
            this.dataSetZahtjevnicaSirovina1 = new PI_Projekt_SiM.DataSetZahtjevnicaSirovina();
            this.zahtjevnica_sirovinaTableAdapter1 = new PI_Projekt_SiM.DataSetZahtjevnicaSirovinaDodajNoviTableAdapters.zahtjevnica_sirovinaTableAdapter();
            this.dataSetZahtjevnice1 = new PI_Projekt_SiM.DataSetZahtjevnice();
            this.zahtjevnicaTableAdapter1 = new PI_Projekt_SiM.DataSetZahtjevniceTableAdapters.zahtjevnicaTableAdapter();
            this.dataSetZahtjevnicaSirovina = new PI_Projekt_SiM.DataSetZahtjevnicaSirovina();
            this.zahtjevnica_sirovinaTableAdapter = new PI_Projekt_SiM.DataSetZahtjevnicaSirovinaTableAdapters.zahtjevnica_sirovinaTableAdapter();
            this.grbPopisSirovina = new System.Windows.Forms.GroupBox();
            this.grbKolicina = new System.Windows.Forms.GroupBox();
            this.idsirovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivsirovineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rok_trajanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostupna_kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicna_mjera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSirovina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovinaDodajNovi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovina1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovina)).BeginInit();
            this.grbPopisSirovina.SuspendLayout();
            this.grbKolicina.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKolicina
            // 
            this.labelKolicina.AutoSize = true;
            this.labelKolicina.Location = new System.Drawing.Point(6, 32);
            this.labelKolicina.Name = "labelKolicina";
            this.labelKolicina.Size = new System.Drawing.Size(56, 15);
            this.labelKolicina.TabIndex = 1;
            this.labelKolicina.Text = "Količina:";
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
            // inputKolicina
            // 
            this.inputKolicina.Location = new System.Drawing.Point(68, 29);
            this.inputKolicina.Name = "inputKolicina";
            this.inputKolicina.Size = new System.Drawing.Size(75, 21);
            this.inputKolicina.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodaj.Location = new System.Drawing.Point(149, 20);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(96, 38);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click_1);
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
            this.rok_trajanja,
            this.dostupna_kolicina,
            this.jedinicna_mjera,
            this.napomena});
            this.dgvPopisSirovina.DataSource = this.sirovinaBindingSource;
            this.dgvPopisSirovina.Location = new System.Drawing.Point(6, 20);
            this.dgvPopisSirovina.Name = "dgvPopisSirovina";
            this.dgvPopisSirovina.ReadOnly = true;
            this.dgvPopisSirovina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisSirovina.Size = new System.Drawing.Size(644, 235);
            this.dgvPopisSirovina.TabIndex = 5;
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
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdustani.Location = new System.Drawing.Point(251, 20);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(96, 38);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // sirovinaTableAdapter
            // 
            this.sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetZahtjevnicaSirovina1
            // 
            this.dataSetZahtjevnicaSirovina1.DataSetName = "DataSetZahtjevnicaSirovina";
            this.dataSetZahtjevnicaSirovina1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataSetZahtjevnicaSirovina
            // 
            this.dataSetZahtjevnicaSirovina.DataSetName = "DataSetZahtjevnicaSirovina";
            this.dataSetZahtjevnicaSirovina.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zahtjevnica_sirovinaTableAdapter
            // 
            this.zahtjevnica_sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // grbPopisSirovina
            // 
            this.grbPopisSirovina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbPopisSirovina.Controls.Add(this.dgvPopisSirovina);
            this.grbPopisSirovina.Location = new System.Drawing.Point(12, 12);
            this.grbPopisSirovina.Name = "grbPopisSirovina";
            this.grbPopisSirovina.Size = new System.Drawing.Size(659, 261);
            this.grbPopisSirovina.TabIndex = 7;
            this.grbPopisSirovina.TabStop = false;
            this.grbPopisSirovina.Text = "Popis sirovina";
            // 
            // grbKolicina
            // 
            this.grbKolicina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbKolicina.Controls.Add(this.btnOdustani);
            this.grbKolicina.Controls.Add(this.labelKolicina);
            this.grbKolicina.Controls.Add(this.inputKolicina);
            this.grbKolicina.Controls.Add(this.btnDodaj);
            this.grbKolicina.Location = new System.Drawing.Point(12, 279);
            this.grbKolicina.Name = "grbKolicina";
            this.grbKolicina.Size = new System.Drawing.Size(357, 68);
            this.grbKolicina.TabIndex = 0;
            this.grbKolicina.TabStop = false;
            this.grbKolicina.Text = "Dodavanje količine";
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
            // rok_trajanja
            // 
            this.rok_trajanja.DataPropertyName = "rok_trajanja";
            this.rok_trajanja.HeaderText = "Rok trajanja";
            this.rok_trajanja.Name = "rok_trajanja";
            this.rok_trajanja.ReadOnly = true;
            this.rok_trajanja.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dostupna_kolicina
            // 
            this.dostupna_kolicina.DataPropertyName = "dostupna_kolicina";
            this.dostupna_kolicina.HeaderText = "Dostupna količina";
            this.dostupna_kolicina.Name = "dostupna_kolicina";
            this.dostupna_kolicina.ReadOnly = true;
            this.dostupna_kolicina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // frmGlavniPekarKreirajNovuZahtjevnicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 355);
            this.Controls.Add(this.grbPopisSirovina);
            this.Controls.Add(this.grbKolicina);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGlavniPekarKreirajNovuZahtjevnicu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis sirovina";
            this.Load += new System.EventHandler(this.frmGlavniPekarKreirajNovuZahtjevnicu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSirovina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovinaDodajNovi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovina1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnicaSirovina)).EndInit();
            this.grbPopisSirovina.ResumeLayout(false);
            this.grbKolicina.ResumeLayout(false);
            this.grbKolicina.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelKolicina;
        private System.Windows.Forms.TextBox inputKolicina;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvPopisSirovina;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.BindingSource dataSetSirovineBindingSource;
        private DataSetSirovine dataSetSirovine;
        private System.Windows.Forms.BindingSource sirovinaBindingSource;
        private DataSetSirovineTableAdapters.sirovinaTableAdapter sirovinaTableAdapter;
        private DataSetZahtjevnicaSirovinaDodajNovi dataSetZahtjevnicaSirovinaDodajNovi1;
        private DataSetZahtjevnicaSirovina dataSetZahtjevnicaSirovina1;
        private DataSetZahtjevnicaSirovinaDodajNoviTableAdapters.zahtjevnica_sirovinaTableAdapter zahtjevnica_sirovinaTableAdapter1;
        private System.Windows.Forms.BindingSource zahtjevnicasirovinaBindingSource;
        private DataSetZahtjevnice dataSetZahtjevnice1;
        private DataSetZahtjevniceTableAdapters.zahtjevnicaTableAdapter zahtjevnicaTableAdapter1;
        private DataSetZahtjevnicaSirovina dataSetZahtjevnicaSirovina;
        private DataSetZahtjevnicaSirovinaTableAdapters.zahtjevnica_sirovinaTableAdapter zahtjevnica_sirovinaTableAdapter;
        private System.Windows.Forms.GroupBox grbPopisSirovina;
        private System.Windows.Forms.GroupBox grbKolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsirovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivsirovineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rok_trajanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostupna_kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicna_mjera;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomena;
    }
}