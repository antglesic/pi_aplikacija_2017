namespace PI_Projekt_SiM
{
    partial class frmSkladistarPopisZahtjevnicaGlavniPekar
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
            this.dgvPopisZahtjevnica = new System.Windows.Forms.DataGridView();
            this.idzahtjevnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svrhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zahtjevnicaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetIzdatniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetIzdatnice = new PI_Projekt_SiM.DataSetIzdatnice();
            this.grbDetaljiZahtjevnice = new System.Windows.Forms.GroupBox();
            this.dgvDetaljiZahtjevnice = new System.Windows.Forms.DataGridView();
            this.idsirovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivsirovineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostupnakolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zahtjevnicasirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zahtjevnicaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetZahtjevnice = new PI_Projekt_SiM.DataSetZahtjevnice();
            this.zahtjevnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zahtjevnicaTableAdapter = new PI_Projekt_SiM.DataSetZahtjevniceTableAdapters.zahtjevnicaTableAdapter();
            this.tipzahtjevniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_zahtjevniceTableAdapter = new PI_Projekt_SiM.DataSetZahtjevniceTableAdapters.tip_zahtjevniceTableAdapter();
            this.grbPopisZahtjevnica = new System.Windows.Forms.GroupBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnNovaIzdatnica = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.korisnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zahtjevnicaTableAdapter1 = new PI_Projekt_SiM.DataSetIzdatniceTableAdapters.zahtjevnicaTableAdapter();
            this.zahtjevnica_sirovinaTableAdapter = new PI_Projekt_SiM.DataSetIzdatniceTableAdapters.zahtjevnica_sirovinaTableAdapter();
            this.korisnikTableAdapter = new PI_Projekt_SiM.DataSetIzdatniceTableAdapters.korisnikTableAdapter();
            this.sirovinaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetIzdatnice1 = new PI_Projekt_SiM.DataSetIzdatnice();
            this.sirovinaTableAdapter = new PI_Projekt_SiM.DataSetIzdatniceTableAdapters.sirovinaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZahtjevnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIzdatniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIzdatnice)).BeginInit();
            this.grbDetaljiZahtjevnice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiZahtjevnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipzahtjevniceBindingSource)).BeginInit();
            this.grbPopisZahtjevnica.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIzdatnice1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisZahtjevnica
            // 
            this.dgvPopisZahtjevnica.AllowUserToAddRows = false;
            this.dgvPopisZahtjevnica.AllowUserToDeleteRows = false;
            this.dgvPopisZahtjevnica.AutoGenerateColumns = false;
            this.dgvPopisZahtjevnica.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPopisZahtjevnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisZahtjevnica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzahtjevnicaDataGridViewTextBoxColumn,
            this.naslovDataGridViewTextBoxColumn,
            this.svrhaDataGridViewTextBoxColumn,
            this.datumkreiranjaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn});
            this.dgvPopisZahtjevnica.DataSource = this.zahtjevnicaBindingSource2;
            this.dgvPopisZahtjevnica.Location = new System.Drawing.Point(7, 20);
            this.dgvPopisZahtjevnica.Name = "dgvPopisZahtjevnica";
            this.dgvPopisZahtjevnica.ReadOnly = true;
            this.dgvPopisZahtjevnica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisZahtjevnica.Size = new System.Drawing.Size(662, 208);
            this.dgvPopisZahtjevnica.TabIndex = 0;
            this.dgvPopisZahtjevnica.SelectionChanged += new System.EventHandler(this.dgvPopisZahtjevnica_SelectionChanged);
            // 
            // idzahtjevnicaDataGridViewTextBoxColumn
            // 
            this.idzahtjevnicaDataGridViewTextBoxColumn.DataPropertyName = "id_zahtjevnica";
            this.idzahtjevnicaDataGridViewTextBoxColumn.HeaderText = "Šifra zahtjevnice";
            this.idzahtjevnicaDataGridViewTextBoxColumn.Name = "idzahtjevnicaDataGridViewTextBoxColumn";
            this.idzahtjevnicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idzahtjevnicaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // naslovDataGridViewTextBoxColumn
            // 
            this.naslovDataGridViewTextBoxColumn.DataPropertyName = "naslov";
            this.naslovDataGridViewTextBoxColumn.HeaderText = "Naslov";
            this.naslovDataGridViewTextBoxColumn.Name = "naslovDataGridViewTextBoxColumn";
            this.naslovDataGridViewTextBoxColumn.ReadOnly = true;
            this.naslovDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // svrhaDataGridViewTextBoxColumn
            // 
            this.svrhaDataGridViewTextBoxColumn.DataPropertyName = "svrha";
            this.svrhaDataGridViewTextBoxColumn.HeaderText = "Svrha";
            this.svrhaDataGridViewTextBoxColumn.Name = "svrhaDataGridViewTextBoxColumn";
            this.svrhaDataGridViewTextBoxColumn.ReadOnly = true;
            this.svrhaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // datumkreiranjaDataGridViewTextBoxColumn
            // 
            this.datumkreiranjaDataGridViewTextBoxColumn.DataPropertyName = "datum_kreiranja";
            this.datumkreiranjaDataGridViewTextBoxColumn.HeaderText = "Datum kreiranja";
            this.datumkreiranjaDataGridViewTextBoxColumn.Name = "datumkreiranjaDataGridViewTextBoxColumn";
            this.datumkreiranjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumkreiranjaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prezimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // zahtjevnicaBindingSource2
            // 
            this.zahtjevnicaBindingSource2.DataMember = "zahtjevnica";
            this.zahtjevnicaBindingSource2.DataSource = this.dataSetIzdatniceBindingSource;
            // 
            // dataSetIzdatniceBindingSource
            // 
            this.dataSetIzdatniceBindingSource.DataSource = this.dataSetIzdatnice;
            this.dataSetIzdatniceBindingSource.Position = 0;
            // 
            // dataSetIzdatnice
            // 
            this.dataSetIzdatnice.DataSetName = "DataSetIzdatnice";
            this.dataSetIzdatnice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grbDetaljiZahtjevnice
            // 
            this.grbDetaljiZahtjevnice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbDetaljiZahtjevnice.Controls.Add(this.dgvDetaljiZahtjevnice);
            this.grbDetaljiZahtjevnice.Location = new System.Drawing.Point(198, 252);
            this.grbDetaljiZahtjevnice.Name = "grbDetaljiZahtjevnice";
            this.grbDetaljiZahtjevnice.Size = new System.Drawing.Size(560, 188);
            this.grbDetaljiZahtjevnice.TabIndex = 1;
            this.grbDetaljiZahtjevnice.TabStop = false;
            this.grbDetaljiZahtjevnice.Text = "Detalji zahtjevnice";
            // 
            // dgvDetaljiZahtjevnice
            // 
            this.dgvDetaljiZahtjevnice.AllowUserToAddRows = false;
            this.dgvDetaljiZahtjevnice.AllowUserToDeleteRows = false;
            this.dgvDetaljiZahtjevnice.AutoGenerateColumns = false;
            this.dgvDetaljiZahtjevnice.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetaljiZahtjevnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetaljiZahtjevnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsirovinaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.nazivsirovineDataGridViewTextBoxColumn,
            this.dostupnakolicinaDataGridViewTextBoxColumn,
            this.jedinicnamjeraDataGridViewTextBoxColumn});
            this.dgvDetaljiZahtjevnice.DataSource = this.zahtjevnicasirovinaBindingSource;
            this.dgvDetaljiZahtjevnice.Location = new System.Drawing.Point(6, 20);
            this.dgvDetaljiZahtjevnice.Name = "dgvDetaljiZahtjevnice";
            this.dgvDetaljiZahtjevnice.ReadOnly = true;
            this.dgvDetaljiZahtjevnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetaljiZahtjevnice.Size = new System.Drawing.Size(544, 162);
            this.dgvDetaljiZahtjevnice.TabIndex = 1;
            this.dgvDetaljiZahtjevnice.SelectionChanged += new System.EventHandler(this.dgvDetaljiZahtjevnice_SelectionChanged);
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
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nazivsirovineDataGridViewTextBoxColumn
            // 
            this.nazivsirovineDataGridViewTextBoxColumn.DataPropertyName = "naziv_sirovine";
            this.nazivsirovineDataGridViewTextBoxColumn.HeaderText = "Naziv sirovine";
            this.nazivsirovineDataGridViewTextBoxColumn.Name = "nazivsirovineDataGridViewTextBoxColumn";
            this.nazivsirovineDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivsirovineDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dostupnakolicinaDataGridViewTextBoxColumn
            // 
            this.dostupnakolicinaDataGridViewTextBoxColumn.DataPropertyName = "dostupna_kolicina";
            this.dostupnakolicinaDataGridViewTextBoxColumn.HeaderText = "Dostupna količina";
            this.dostupnakolicinaDataGridViewTextBoxColumn.Name = "dostupnakolicinaDataGridViewTextBoxColumn";
            this.dostupnakolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dostupnakolicinaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // jedinicnamjeraDataGridViewTextBoxColumn
            // 
            this.jedinicnamjeraDataGridViewTextBoxColumn.DataPropertyName = "jedinicna_mjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.HeaderText = "Jedinična mjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.Name = "jedinicnamjeraDataGridViewTextBoxColumn";
            this.jedinicnamjeraDataGridViewTextBoxColumn.ReadOnly = true;
            this.jedinicnamjeraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // zahtjevnicasirovinaBindingSource
            // 
            this.zahtjevnicasirovinaBindingSource.DataMember = "zahtjevnica_sirovina";
            this.zahtjevnicasirovinaBindingSource.DataSource = this.dataSetIzdatniceBindingSource;
            // 
            // zahtjevnicaBindingSource1
            // 
            this.zahtjevnicaBindingSource1.DataMember = "zahtjevnica";
            this.zahtjevnicaBindingSource1.DataSource = this.dataSetZahtjevnice;
            // 
            // dataSetZahtjevnice
            // 
            this.dataSetZahtjevnice.DataSetName = "DataSetZahtjevnice";
            this.dataSetZahtjevnice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zahtjevnicaBindingSource
            // 
            this.zahtjevnicaBindingSource.DataMember = "zahtjevnica";
            this.zahtjevnicaBindingSource.DataSource = this.dataSetZahtjevnice;
            // 
            // zahtjevnicaTableAdapter
            // 
            this.zahtjevnicaTableAdapter.ClearBeforeFill = true;
            // 
            // tipzahtjevniceBindingSource
            // 
            this.tipzahtjevniceBindingSource.DataMember = "tip_zahtjevnice";
            this.tipzahtjevniceBindingSource.DataSource = this.dataSetZahtjevnice;
            // 
            // tip_zahtjevniceTableAdapter
            // 
            this.tip_zahtjevniceTableAdapter.ClearBeforeFill = true;
            // 
            // grbPopisZahtjevnica
            // 
            this.grbPopisZahtjevnica.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbPopisZahtjevnica.Controls.Add(this.dgvPopisZahtjevnica);
            this.grbPopisZahtjevnica.Location = new System.Drawing.Point(198, 12);
            this.grbPopisZahtjevnica.Name = "grbPopisZahtjevnica";
            this.grbPopisZahtjevnica.Size = new System.Drawing.Size(675, 234);
            this.grbPopisZahtjevnica.TabIndex = 2;
            this.grbPopisZahtjevnica.TabStop = false;
            this.grbPopisZahtjevnica.Text = "Popis zahtjevnica";
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNatrag.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(180, 66);
            this.btnNatrag.TabIndex = 8;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnNovaIzdatnica
            // 
            this.btnNovaIzdatnica.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNovaIzdatnica.Location = new System.Drawing.Point(198, 518);
            this.btnNovaIzdatnica.Name = "btnNovaIzdatnica";
            this.btnNovaIzdatnica.Size = new System.Drawing.Size(119, 38);
            this.btnNovaIzdatnica.TabIndex = 9;
            this.btnNovaIzdatnica.Text = "Nova izdatnica";
            this.btnNovaIzdatnica.UseVisualStyleBackColor = false;
            this.btnNovaIzdatnica.Click += new System.EventHandler(this.btnNovaIzdatnica_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Location = new System.Drawing.Point(323, 518);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(119, 38);
            this.btnOsvjezi.TabIndex = 10;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPdf.Location = new System.Drawing.Point(448, 518);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(81, 38);
            this.btnPdf.TabIndex = 15;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTrazi);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(198, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 66);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tražilica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Šifra:";
            // 
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(133, 26);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(322, 21);
            this.txtTrazi.TabIndex = 0;
            this.txtTrazi.TextChanged += new System.EventHandler(this.txtTrazi_TextChanged);
            // 
            // korisnikBindingSource1
            // 
            this.korisnikBindingSource1.DataMember = "korisnik";
            this.korisnikBindingSource1.DataSource = this.dataSetIzdatnice;
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "korisnik";
            this.korisnikBindingSource.DataSource = this.dataSetIzdatnice;
            // 
            // zahtjevnicaTableAdapter1
            // 
            this.zahtjevnicaTableAdapter1.ClearBeforeFill = true;
            // 
            // zahtjevnica_sirovinaTableAdapter
            // 
            this.zahtjevnica_sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // sirovinaBindingSource1
            // 
            this.sirovinaBindingSource1.DataMember = "sirovina";
            this.sirovinaBindingSource1.DataSource = this.dataSetIzdatnice;
            // 
            // sirovinaBindingSource
            // 
            this.sirovinaBindingSource.DataMember = "sirovina";
            this.sirovinaBindingSource.DataSource = this.dataSetIzdatnice1;
            // 
            // dataSetIzdatnice1
            // 
            this.dataSetIzdatnice1.DataSetName = "DataSetIzdatnice";
            this.dataSetIzdatnice1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sirovinaTableAdapter
            // 
            this.sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // frmSkladistarPopisZahtjevnicaGlavniPekar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(878, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnNovaIzdatnica);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.grbPopisZahtjevnica);
            this.Controls.Add(this.grbDetaljiZahtjevnice);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSkladistarPopisZahtjevnicaGlavniPekar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis izdatnica";
            this.Load += new System.EventHandler(this.frmSkaldistarPopisIzdatnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZahtjevnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIzdatniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIzdatnice)).EndInit();
            this.grbDetaljiZahtjevnice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiZahtjevnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipzahtjevniceBindingSource)).EndInit();
            this.grbPopisZahtjevnica.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIzdatnice1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisZahtjevnica;
        private System.Windows.Forms.GroupBox grbDetaljiZahtjevnice;
        private DataSetZahtjevnice dataSetZahtjevnice;
        private System.Windows.Forms.BindingSource zahtjevnicaBindingSource;
        private DataSetZahtjevniceTableAdapters.zahtjevnicaTableAdapter zahtjevnicaTableAdapter;
        private System.Windows.Forms.BindingSource tipzahtjevniceBindingSource;
        private DataSetZahtjevniceTableAdapters.tip_zahtjevniceTableAdapter tip_zahtjevniceTableAdapter;
        private System.Windows.Forms.BindingSource zahtjevnicaBindingSource1;
        private System.Windows.Forms.BindingSource dataSetIzdatniceBindingSource;
        private DataSetIzdatnice dataSetIzdatnice;
        private System.Windows.Forms.BindingSource zahtjevnicaBindingSource2;
        private DataSetIzdatniceTableAdapters.zahtjevnicaTableAdapter zahtjevnicaTableAdapter1;
        private System.Windows.Forms.GroupBox grbPopisZahtjevnica;
        private System.Windows.Forms.DataGridView dgvDetaljiZahtjevnice;
        private System.Windows.Forms.BindingSource zahtjevnicasirovinaBindingSource;
        private DataSetIzdatniceTableAdapters.zahtjevnica_sirovinaTableAdapter zahtjevnica_sirovinaTableAdapter;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Button btnNovaIzdatnica;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private DataSetIzdatniceTableAdapters.korisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkorisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnickoimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idulogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource korisnikBindingSource1;
        private System.Windows.Forms.BindingSource sirovinaBindingSource;
        private DataSetIzdatnice dataSetIzdatnice1;
        private DataSetIzdatniceTableAdapters.sirovinaTableAdapter sirovinaTableAdapter;
        private System.Windows.Forms.BindingSource sirovinaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzahtjevnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svrhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsirovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivsirovineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostupnakolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnamjeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrazi;
    }
}