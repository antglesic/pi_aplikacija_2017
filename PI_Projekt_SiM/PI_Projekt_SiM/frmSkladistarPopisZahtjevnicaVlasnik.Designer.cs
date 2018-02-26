namespace PI_Projekt_SiM
{
    partial class frmSkladistarPopisZahtjevnicaVlasnik
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
            this.sirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSirovineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSirovine = new PI_Projekt_SiM.DataSetSirovine();
            this.dgvPopisZahtjevnica = new System.Windows.Forms.DataGridView();
            this.idzahtjevnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svrhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zahtjevnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetZahtjevniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetZahtjevnice = new PI_Projekt_SiM.DataSetZahtjevnice();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.dgvDetaljiZahtjevnice = new System.Windows.Forms.DataGridView();
            this.idsirovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivsirovineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostupnakolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipzahtjevniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zahtjevnicaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.grbPopisZahtjevnica = new System.Windows.Forms.GroupBox();
            this.grbDetaljiZahtjevnice = new System.Windows.Forms.GroupBox();
            this.dataSetIzdatnice = new PI_Projekt_SiM.DataSetIzdatnice();
            this.zahtjevnicasirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zahtjevnica_sirovinaTableAdapter = new PI_Projekt_SiM.DataSetIzdatniceTableAdapters.zahtjevnica_sirovinaTableAdapter();
            this.zahtjevnicaTableAdapter = new PI_Projekt_SiM.DataSetZahtjevniceTableAdapters.zahtjevnicaTableAdapter();
            this.tip_zahtjevniceTableAdapter = new PI_Projekt_SiM.DataSetZahtjevniceTableAdapters.tip_zahtjevniceTableAdapter();
            this.tableAdapterManager = new PI_Projekt_SiM.DataSetZahtjevniceTableAdapters.TableAdapterManager();
            this.zahtjevnicaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZahtjevnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiZahtjevnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipzahtjevniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicaBindingSource2)).BeginInit();
            this.grbPopisZahtjevnica.SuspendLayout();
            this.grbDetaljiZahtjevnice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIzdatnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicaBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.ime,
            this.prezime});
            this.dgvPopisZahtjevnica.DataSource = this.zahtjevnicaBindingSource;
            this.dgvPopisZahtjevnica.Location = new System.Drawing.Point(7, 22);
            this.dgvPopisZahtjevnica.Name = "dgvPopisZahtjevnica";
            this.dgvPopisZahtjevnica.ReadOnly = true;
            this.dgvPopisZahtjevnica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisZahtjevnica.Size = new System.Drawing.Size(667, 359);
            this.dgvPopisZahtjevnica.TabIndex = 1;
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
            // ime
            // 
            this.ime.DataPropertyName = "ime";
            this.ime.HeaderText = "Ime";
            this.ime.Name = "ime";
            this.ime.ReadOnly = true;
            this.ime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // prezime
            // 
            this.prezime.DataPropertyName = "prezime";
            this.prezime.HeaderText = "Prezime";
            this.prezime.Name = "prezime";
            this.prezime.ReadOnly = true;
            this.prezime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // zahtjevnicaBindingSource
            // 
            this.zahtjevnicaBindingSource.DataMember = "zahtjevnica";
            this.zahtjevnicaBindingSource.DataSource = this.dataSetZahtjevniceBindingSource;
            this.zahtjevnicaBindingSource.CurrentChanged += new System.EventHandler(this.zahtjevnicaBindingSource_CurrentChanged);
            // 
            // dataSetZahtjevniceBindingSource
            // 
            this.dataSetZahtjevniceBindingSource.DataSource = this.dataSetZahtjevnice;
            this.dataSetZahtjevniceBindingSource.Position = 0;
            // 
            // dataSetZahtjevnice
            // 
            this.dataSetZahtjevnice.DataSetName = "DataSetZahtjevnice";
            this.dataSetZahtjevnice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKreiraj.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreiraj.Location = new System.Drawing.Point(201, 725);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(119, 38);
            this.btnKreiraj.TabIndex = 7;
            this.btnKreiraj.Text = "Nova zahtjevnica";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNatrag.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.Location = new System.Drawing.Point(12, 14);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(180, 66);
            this.btnNatrag.TabIndex = 12;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnOdustani_Click);
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
            this.nazivsirovineDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.dostupnakolicinaDataGridViewTextBoxColumn,
            this.jedinicnamjeraDataGridViewTextBoxColumn});
            this.dgvDetaljiZahtjevnice.DataSource = this.tipzahtjevniceBindingSource;
            this.dgvDetaljiZahtjevnice.Location = new System.Drawing.Point(7, 20);
            this.dgvDetaljiZahtjevnice.Name = "dgvDetaljiZahtjevnice";
            this.dgvDetaljiZahtjevnice.ReadOnly = true;
            this.dgvDetaljiZahtjevnice.Size = new System.Drawing.Size(544, 188);
            this.dgvDetaljiZahtjevnice.TabIndex = 13;
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
            // tipzahtjevniceBindingSource
            // 
            this.tipzahtjevniceBindingSource.DataMember = "tip_zahtjevnice";
            this.tipzahtjevniceBindingSource.DataSource = this.dataSetZahtjevnice;
            // 
            // zahtjevnicaBindingSource2
            // 
            this.zahtjevnicaBindingSource2.DataMember = "zahtjevnica";
            this.zahtjevnicaBindingSource2.DataSource = this.dataSetZahtjevnice;
            // 
            // grbPopisZahtjevnica
            // 
            this.grbPopisZahtjevnica.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbPopisZahtjevnica.Controls.Add(this.dgvPopisZahtjevnica);
            this.grbPopisZahtjevnica.Location = new System.Drawing.Point(201, 14);
            this.grbPopisZahtjevnica.Name = "grbPopisZahtjevnica";
            this.grbPopisZahtjevnica.Size = new System.Drawing.Size(680, 397);
            this.grbPopisZahtjevnica.TabIndex = 14;
            this.grbPopisZahtjevnica.TabStop = false;
            this.grbPopisZahtjevnica.Text = "Popis zahtjevnica";
            // 
            // grbDetaljiZahtjevnice
            // 
            this.grbDetaljiZahtjevnice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbDetaljiZahtjevnice.Controls.Add(this.dgvDetaljiZahtjevnice);
            this.grbDetaljiZahtjevnice.Location = new System.Drawing.Point(201, 417);
            this.grbDetaljiZahtjevnice.Name = "grbDetaljiZahtjevnice";
            this.grbDetaljiZahtjevnice.Size = new System.Drawing.Size(563, 230);
            this.grbDetaljiZahtjevnice.TabIndex = 2;
            this.grbDetaljiZahtjevnice.TabStop = false;
            this.grbDetaljiZahtjevnice.Text = "Detalji zahtjevnice";
            // 
            // dataSetIzdatnice
            // 
            this.dataSetIzdatnice.DataSetName = "DataSetIzdatnice";
            this.dataSetIzdatnice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zahtjevnicasirovinaBindingSource
            // 
            this.zahtjevnicasirovinaBindingSource.DataMember = "zahtjevnica_sirovina";
            this.zahtjevnicasirovinaBindingSource.DataSource = this.dataSetIzdatnice;
            // 
            // zahtjevnica_sirovinaTableAdapter
            // 
            this.zahtjevnica_sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // zahtjevnicaTableAdapter
            // 
            this.zahtjevnicaTableAdapter.ClearBeforeFill = true;
            // 
            // tip_zahtjevniceTableAdapter
            // 
            this.tip_zahtjevniceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = PI_Projekt_SiM.DataSetZahtjevniceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // zahtjevnicaBindingSource1
            // 
            this.zahtjevnicaBindingSource1.DataMember = "zahtjevnica";
            this.zahtjevnicaBindingSource1.DataSource = this.dataSetZahtjevnice;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsvjezi.Location = new System.Drawing.Point(326, 725);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(119, 38);
            this.btnOsvjezi.TabIndex = 15;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPdf.Location = new System.Drawing.Point(451, 725);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(81, 38);
            this.btnPdf.TabIndex = 16;
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
            this.groupBox2.Location = new System.Drawing.Point(201, 653);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 66);
            this.groupBox2.TabIndex = 35;
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
            // frmSkladistarPopisZahtjevnicaVlasnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(893, 741);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.grbPopisZahtjevnica);
            this.Controls.Add(this.grbDetaljiZahtjevnice);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSkladistarPopisZahtjevnicaVlasnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis zahtjevnica";
            this.Load += new System.EventHandler(this.frmSkladistar_zahtjevnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZahtjevnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiZahtjevnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipzahtjevniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicaBindingSource2)).EndInit();
            this.grbPopisZahtjevnica.ResumeLayout(false);
            this.grbDetaljiZahtjevnice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIzdatnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicaBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dataSetSirovineBindingSource;
        private DataSetSirovine dataSetSirovine;
        private System.Windows.Forms.BindingSource sirovinaBindingSource;
        private System.Windows.Forms.DataGridView dgvPopisZahtjevnica;
        private System.Windows.Forms.BindingSource dataSetZahtjevniceBindingSource;
        private DataSetZahtjevnice dataSetZahtjevnice;
        private System.Windows.Forms.BindingSource zahtjevnicaBindingSource;
        private DataSetZahtjevniceTableAdapters.zahtjevnicaTableAdapter zahtjevnicaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipzahtjevniceDataGridViewTextBoxColumn;
        private DataSetZahtjevniceTableAdapters.tip_zahtjevniceTableAdapter tip_zahtjevniceTableAdapter;
        private DataSetZahtjevniceTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.DataGridView dgvDetaljiZahtjevnice;
        private System.Windows.Forms.GroupBox grbPopisZahtjevnica;
        private System.Windows.Forms.GroupBox grbDetaljiZahtjevnice;
        private System.Windows.Forms.BindingSource zahtjevnicasirovinaBindingSource;
        private DataSetIzdatnice dataSetIzdatnice;
        private DataSetIzdatniceTableAdapters.zahtjevnica_sirovinaTableAdapter zahtjevnica_sirovinaTableAdapter;
        private System.Windows.Forms.BindingSource zahtjevnicaBindingSource1;
        private System.Windows.Forms.BindingSource zahtjevnicaBindingSource2;
        private System.Windows.Forms.BindingSource tipzahtjevniceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzahtjevnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svrhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsirovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivsirovineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostupnakolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnamjeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrazi;
    }
}