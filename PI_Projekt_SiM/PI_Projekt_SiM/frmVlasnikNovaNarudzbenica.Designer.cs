namespace PI_Projekt_SiM
{
    partial class frmVlasnikNovaNarudzbenica
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
            this.grbZaglavljeIzdatnice = new System.Windows.Forms.GroupBox();
            this.txtSifraZahtjevnice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnKreirajNaraudzbenicu = new System.Windows.Forms.Button();
            this.txtOpisNarudzbenice = new System.Windows.Forms.TextBox();
            this.inputDatum = new System.Windows.Forms.DateTimePicker();
            this.lblIdIzdatnice = new System.Windows.Forms.Label();
            this.labelSvrha = new System.Windows.Forms.Label();
            this.txtNaslovNarudzbenice = new System.Windows.Forms.TextBox();
            this.labelDatum = new System.Windows.Forms.Label();
            this.txtSifraNarudzbenice = new System.Windows.Forms.TextBox();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.grbSirovina = new System.Windows.Forms.GroupBox();
            this.dgvSirovinaZaNarucivanje = new System.Windows.Forms.DataGridView();
            this.idsirovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivsirovineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roktrajanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostupnakolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirovina2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSirovine = new PI_Projekt_SiM.DataSetSirovine();
            this.grbDobavljac = new System.Windows.Forms.GroupBox();
            this.dgvDobavljac = new System.Windows.Forms.DataGridView();
            this.iddobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivdobavljacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljac2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobavljacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sirovina2TableAdapter = new PI_Projekt_SiM.DataSetSirovineTableAdapters.sirovina2TableAdapter();
            this.dobavljacTableAdapter = new PI_Projekt_SiM.DataSetSirovineTableAdapters.dobavljacTableAdapter();
            this.dobavljac2TableAdapter = new PI_Projekt_SiM.DataSetSirovineTableAdapters.dobavljac2TableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.grbZaglavljeIzdatnice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSirovinaZaNarucivanje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovina2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).BeginInit();
            this.grbDobavljac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbZaglavljeIzdatnice
            // 
            this.grbZaglavljeIzdatnice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbZaglavljeIzdatnice.Controls.Add(this.txtSifraZahtjevnice);
            this.grbZaglavljeIzdatnice.Controls.Add(this.label1);
            this.grbZaglavljeIzdatnice.Controls.Add(this.btnOdustani);
            this.grbZaglavljeIzdatnice.Controls.Add(this.btnKreirajNaraudzbenicu);
            this.grbZaglavljeIzdatnice.Controls.Add(this.txtOpisNarudzbenice);
            this.grbZaglavljeIzdatnice.Controls.Add(this.inputDatum);
            this.grbZaglavljeIzdatnice.Controls.Add(this.lblIdIzdatnice);
            this.grbZaglavljeIzdatnice.Controls.Add(this.labelSvrha);
            this.grbZaglavljeIzdatnice.Controls.Add(this.txtNaslovNarudzbenice);
            this.grbZaglavljeIzdatnice.Controls.Add(this.labelDatum);
            this.grbZaglavljeIzdatnice.Controls.Add(this.txtSifraNarudzbenice);
            this.grbZaglavljeIzdatnice.Controls.Add(this.labelNaslov);
            this.grbZaglavljeIzdatnice.Location = new System.Drawing.Point(12, 10);
            this.grbZaglavljeIzdatnice.Name = "grbZaglavljeIzdatnice";
            this.grbZaglavljeIzdatnice.Size = new System.Drawing.Size(471, 322);
            this.grbZaglavljeIzdatnice.TabIndex = 19;
            this.grbZaglavljeIzdatnice.TabStop = false;
            this.grbZaglavljeIzdatnice.Text = "Zaglavlje";
            // 
            // txtSifraZahtjevnice
            // 
            this.txtSifraZahtjevnice.Location = new System.Drawing.Point(134, 32);
            this.txtSifraZahtjevnice.Name = "txtSifraZahtjevnice";
            this.txtSifraZahtjevnice.ReadOnly = true;
            this.txtSifraZahtjevnice.Size = new System.Drawing.Size(70, 21);
            this.txtSifraZahtjevnice.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Šifra zahtjevnice:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdustani.Location = new System.Drawing.Point(236, 262);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(96, 38);
            this.btnOdustani.TabIndex = 24;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnKreirajNaraudzbenicu
            // 
            this.btnKreirajNaraudzbenicu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKreirajNaraudzbenicu.Location = new System.Drawing.Point(134, 262);
            this.btnKreirajNaraudzbenicu.Name = "btnKreirajNaraudzbenicu";
            this.btnKreirajNaraudzbenicu.Size = new System.Drawing.Size(96, 38);
            this.btnKreirajNaraudzbenicu.TabIndex = 23;
            this.btnKreirajNaraudzbenicu.Text = "Kreiraj";
            this.btnKreirajNaraudzbenicu.UseVisualStyleBackColor = false;
            this.btnKreirajNaraudzbenicu.Click += new System.EventHandler(this.btnKreirajNaraudzbenicu_Click);
            // 
            // txtOpisNarudzbenice
            // 
            this.txtOpisNarudzbenice.Location = new System.Drawing.Point(134, 177);
            this.txtOpisNarudzbenice.Multiline = true;
            this.txtOpisNarudzbenice.Name = "txtOpisNarudzbenice";
            this.txtOpisNarudzbenice.Size = new System.Drawing.Size(324, 79);
            this.txtOpisNarudzbenice.TabIndex = 19;
            // 
            // inputDatum
            // 
            this.inputDatum.Location = new System.Drawing.Point(134, 143);
            this.inputDatum.Name = "inputDatum";
            this.inputDatum.Size = new System.Drawing.Size(233, 21);
            this.inputDatum.TabIndex = 22;
            // 
            // lblIdIzdatnice
            // 
            this.lblIdIzdatnice.AutoSize = true;
            this.lblIdIzdatnice.Location = new System.Drawing.Point(16, 71);
            this.lblIdIzdatnice.Name = "lblIdIzdatnice";
            this.lblIdIzdatnice.Size = new System.Drawing.Size(112, 15);
            this.lblIdIzdatnice.TabIndex = 13;
            this.lblIdIzdatnice.Text = "Šifra narudžbenice:";
            // 
            // labelSvrha
            // 
            this.labelSvrha.AutoSize = true;
            this.labelSvrha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSvrha.Location = new System.Drawing.Point(92, 180);
            this.labelSvrha.Name = "labelSvrha";
            this.labelSvrha.Size = new System.Drawing.Size(36, 15);
            this.labelSvrha.TabIndex = 17;
            this.labelSvrha.Text = "Opis:";
            // 
            // txtNaslovNarudzbenice
            // 
            this.txtNaslovNarudzbenice.Location = new System.Drawing.Point(134, 106);
            this.txtNaslovNarudzbenice.Name = "txtNaslovNarudzbenice";
            this.txtNaslovNarudzbenice.Size = new System.Drawing.Size(233, 21);
            this.txtNaslovNarudzbenice.TabIndex = 21;
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDatum.Location = new System.Drawing.Point(81, 148);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(47, 15);
            this.labelDatum.TabIndex = 16;
            this.labelDatum.Text = "Datum:";
            // 
            // txtSifraNarudzbenice
            // 
            this.txtSifraNarudzbenice.Location = new System.Drawing.Point(134, 68);
            this.txtSifraNarudzbenice.Name = "txtSifraNarudzbenice";
            this.txtSifraNarudzbenice.Size = new System.Drawing.Size(116, 21);
            this.txtSifraNarudzbenice.TabIndex = 20;
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNaslov.Location = new System.Drawing.Point(82, 109);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(46, 15);
            this.labelNaslov.TabIndex = 15;
            this.labelNaslov.Text = "Naslov:";
            // 
            // grbSirovina
            // 
            this.grbSirovina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbSirovina.Location = new System.Drawing.Point(489, 10);
            this.grbSirovina.Name = "grbSirovina";
            this.grbSirovina.Size = new System.Drawing.Size(665, 100);
            this.grbSirovina.TabIndex = 20;
            this.grbSirovina.TabStop = false;
            this.grbSirovina.Text = "Sirovina za naručivanje";
            // 
            // dgvSirovinaZaNarucivanje
            // 
            this.dgvSirovinaZaNarucivanje.AllowUserToAddRows = false;
            this.dgvSirovinaZaNarucivanje.AllowUserToDeleteRows = false;
            this.dgvSirovinaZaNarucivanje.AutoGenerateColumns = false;
            this.dgvSirovinaZaNarucivanje.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSirovinaZaNarucivanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSirovinaZaNarucivanje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsirovinaDataGridViewTextBoxColumn,
            this.nazivsirovineDataGridViewTextBoxColumn,
            this.roktrajanjaDataGridViewTextBoxColumn,
            this.dostupnakolicinaDataGridViewTextBoxColumn,
            this.jedinicnamjeraDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn});
            this.dgvSirovinaZaNarucivanje.DataSource = this.sirovina2BindingSource;
            this.dgvSirovinaZaNarucivanje.Location = new System.Drawing.Point(495, 30);
            this.dgvSirovinaZaNarucivanje.Name = "dgvSirovinaZaNarucivanje";
            this.dgvSirovinaZaNarucivanje.ReadOnly = true;
            this.dgvSirovinaZaNarucivanje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSirovinaZaNarucivanje.Size = new System.Drawing.Size(648, 74);
            this.dgvSirovinaZaNarucivanje.TabIndex = 0;
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
            // roktrajanjaDataGridViewTextBoxColumn
            // 
            this.roktrajanjaDataGridViewTextBoxColumn.DataPropertyName = "rok_trajanja";
            this.roktrajanjaDataGridViewTextBoxColumn.HeaderText = "Rok trajanja";
            this.roktrajanjaDataGridViewTextBoxColumn.Name = "roktrajanjaDataGridViewTextBoxColumn";
            this.roktrajanjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.roktrajanjaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.napomenaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sirovina2BindingSource
            // 
            this.sirovina2BindingSource.DataMember = "sirovina2";
            this.sirovina2BindingSource.DataSource = this.dataSetSirovine;
            // 
            // dataSetSirovine
            // 
            this.dataSetSirovine.DataSetName = "DataSetSirovine";
            this.dataSetSirovine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grbDobavljac
            // 
            this.grbDobavljac.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbDobavljac.Controls.Add(this.dgvDobavljac);
            this.grbDobavljac.Location = new System.Drawing.Point(489, 116);
            this.grbDobavljac.Name = "grbDobavljac";
            this.grbDobavljac.Size = new System.Drawing.Size(626, 216);
            this.grbDobavljac.TabIndex = 21;
            this.grbDobavljac.TabStop = false;
            this.grbDobavljac.Text = "Dobavljači";
            // 
            // dgvDobavljac
            // 
            this.dgvDobavljac.AllowUserToAddRows = false;
            this.dgvDobavljac.AllowUserToDeleteRows = false;
            this.dgvDobavljac.AutoGenerateColumns = false;
            this.dgvDobavljac.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDobavljac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDobavljac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddobavljacDataGridViewTextBoxColumn,
            this.nazivdobavljacaDataGridViewTextBoxColumn,
            this.gradDataGridViewTextBoxColumn,
            this.brojtelefonaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvDobavljac.DataSource = this.dobavljac2BindingSource;
            this.dgvDobavljac.Location = new System.Drawing.Point(6, 20);
            this.dgvDobavljac.Name = "dgvDobavljac";
            this.dgvDobavljac.ReadOnly = true;
            this.dgvDobavljac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDobavljac.Size = new System.Drawing.Size(610, 190);
            this.dgvDobavljac.TabIndex = 0;
            this.dgvDobavljac.SelectionChanged += new System.EventHandler(this.dgvDobavljac_SelectionChanged);
            // 
            // iddobavljacDataGridViewTextBoxColumn
            // 
            this.iddobavljacDataGridViewTextBoxColumn.DataPropertyName = "id_dobavljac";
            this.iddobavljacDataGridViewTextBoxColumn.HeaderText = "Šifra dobavljača";
            this.iddobavljacDataGridViewTextBoxColumn.Name = "iddobavljacDataGridViewTextBoxColumn";
            this.iddobavljacDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddobavljacDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nazivdobavljacaDataGridViewTextBoxColumn
            // 
            this.nazivdobavljacaDataGridViewTextBoxColumn.DataPropertyName = "naziv_dobavljaca";
            this.nazivdobavljacaDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivdobavljacaDataGridViewTextBoxColumn.Name = "nazivdobavljacaDataGridViewTextBoxColumn";
            this.nazivdobavljacaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivdobavljacaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gradDataGridViewTextBoxColumn
            // 
            this.gradDataGridViewTextBoxColumn.DataPropertyName = "grad";
            this.gradDataGridViewTextBoxColumn.HeaderText = "Grad";
            this.gradDataGridViewTextBoxColumn.Name = "gradDataGridViewTextBoxColumn";
            this.gradDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // brojtelefonaDataGridViewTextBoxColumn
            // 
            this.brojtelefonaDataGridViewTextBoxColumn.DataPropertyName = "broj_telefona";
            this.brojtelefonaDataGridViewTextBoxColumn.HeaderText = "Broj telefona";
            this.brojtelefonaDataGridViewTextBoxColumn.Name = "brojtelefonaDataGridViewTextBoxColumn";
            this.brojtelefonaDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojtelefonaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dobavljac2BindingSource
            // 
            this.dobavljac2BindingSource.DataMember = "dobavljac2";
            this.dobavljac2BindingSource.DataSource = this.dataSetSirovine;
            // 
            // dobavljacBindingSource
            // 
            this.dobavljacBindingSource.DataMember = "dobavljac";
            this.dobavljacBindingSource.DataSource = this.dataSetSirovine;
            // 
            // sirovina2TableAdapter
            // 
            this.sirovina2TableAdapter.ClearBeforeFill = true;
            // 
            // dobavljacTableAdapter
            // 
            this.dobavljacTableAdapter.ClearBeforeFill = true;
            // 
            // dobavljac2TableAdapter
            // 
            this.dobavljac2TableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTrazi);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(489, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 66);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trazilica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Šifra:";
            // 
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(151, 23);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(322, 21);
            this.txtTrazi.TabIndex = 0;
            this.txtTrazi.TextChanged += new System.EventHandler(this.txtTrazi_TextChanged);
            // 
            // frmVlasnikNovaNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1159, 413);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbDobavljac);
            this.Controls.Add(this.dgvSirovinaZaNarucivanje);
            this.Controls.Add(this.grbSirovina);
            this.Controls.Add(this.grbZaglavljeIzdatnice);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmVlasnikNovaNarudzbenica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova narudžbenica";
            this.Load += new System.EventHandler(this.frmVlasnikNovaNarudzbenica_Load);
            this.grbZaglavljeIzdatnice.ResumeLayout(false);
            this.grbZaglavljeIzdatnice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSirovinaZaNarucivanje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovina2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).EndInit();
            this.grbDobavljac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbZaglavljeIzdatnice;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnKreirajNaraudzbenicu;
        private System.Windows.Forms.TextBox txtOpisNarudzbenice;
        private System.Windows.Forms.DateTimePicker inputDatum;
        private System.Windows.Forms.Label lblIdIzdatnice;
        private System.Windows.Forms.Label labelSvrha;
        private System.Windows.Forms.TextBox txtNaslovNarudzbenice;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.TextBox txtSifraNarudzbenice;
        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.GroupBox grbSirovina;
        private System.Windows.Forms.DataGridView dgvSirovinaZaNarucivanje;
        private System.Windows.Forms.BindingSource sirovina2BindingSource;
        private DataSetSirovine dataSetSirovine;
        private DataSetSirovineTableAdapters.sirovina2TableAdapter sirovina2TableAdapter;
        private System.Windows.Forms.GroupBox grbDobavljac;
        private System.Windows.Forms.DataGridView dgvDobavljac;
        private System.Windows.Forms.BindingSource dobavljacBindingSource;
        private DataSetSirovineTableAdapters.dobavljacTableAdapter dobavljacTableAdapter;
        private System.Windows.Forms.BindingSource dobavljac2BindingSource;
        private DataSetSirovineTableAdapters.dobavljac2TableAdapter dobavljac2TableAdapter;
        private System.Windows.Forms.TextBox txtSifraZahtjevnice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsirovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivsirovineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roktrajanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostupnakolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnamjeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivdobavljacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrazi;
    }
}