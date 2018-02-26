namespace PI_Projekt_SiM
{
    partial class frmSkladistarKreiranjePrimke
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
            this.grpZaglavlje = new System.Windows.Forms.GroupBox();
            this.labelDobavljac = new System.Windows.Forms.Label();
            this.dgvPopisDobavljaca = new System.Windows.Forms.DataGridView();
            this.iddobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivdobavljacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPrimke = new PI_Projekt_SiM.DataSetPrimke();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.inputDatum = new System.Windows.Forms.DateTimePicker();
            this.inputOpis = new System.Windows.Forms.TextBox();
            this.inputNaslov = new System.Windows.Forms.TextBox();
            this.inputIdPrimke = new System.Windows.Forms.TextBox();
            this.labelOpis = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.labelSifra = new System.Windows.Forms.Label();
            this.grpPopis = new System.Windows.Forms.GroupBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPopisSirovina = new System.Windows.Forms.DataGridView();
            this.id_primke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsirovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primkasirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPrimkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new PI_Projekt_SiM.DataSetIzdatniceTableAdapters.TableAdapterManager();
            this.sirovinaTableAdapter = new PI_Projekt_SiM.DataSetPrimkeTableAdapters.sirovinaTableAdapter();
            this.primka_sirovinaTableAdapter = new PI_Projekt_SiM.DataSetPrimkeTableAdapters.primka_sirovinaTableAdapter();
            this.primkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primkaTableAdapter = new PI_Projekt_SiM.DataSetPrimkeTableAdapters.primkaTableAdapter();
            this.tableAdapterManager = new PI_Projekt_SiM.DataSetPrimkeTableAdapters.TableAdapterManager();
            this.primka_sirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primka_sirovinaTableAdapter1 = new PI_Projekt_SiM.DataSetPrimkeTableAdapters.primka_sirovinaTableAdapter();
            this.dobavljacTableAdapter = new PI_Projekt_SiM.DataSetPrimkeTableAdapters.dobavljacTableAdapter();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.grpZaglavlje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisDobavljaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrimke)).BeginInit();
            this.grpPopis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSirovina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkasirovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrimkeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primka_sirovinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpZaglavlje
            // 
            this.grpZaglavlje.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpZaglavlje.Controls.Add(this.labelDobavljac);
            this.grpZaglavlje.Controls.Add(this.dgvPopisDobavljaca);
            this.grpZaglavlje.Controls.Add(this.btnOdustani);
            this.grpZaglavlje.Controls.Add(this.btnKreiraj);
            this.grpZaglavlje.Controls.Add(this.inputDatum);
            this.grpZaglavlje.Controls.Add(this.inputOpis);
            this.grpZaglavlje.Controls.Add(this.inputNaslov);
            this.grpZaglavlje.Controls.Add(this.inputIdPrimke);
            this.grpZaglavlje.Controls.Add(this.labelOpis);
            this.grpZaglavlje.Controls.Add(this.labelDatum);
            this.grpZaglavlje.Controls.Add(this.labelNaslov);
            this.grpZaglavlje.Controls.Add(this.labelSifra);
            this.grpZaglavlje.Location = new System.Drawing.Point(12, 12);
            this.grpZaglavlje.Name = "grpZaglavlje";
            this.grpZaglavlje.Size = new System.Drawing.Size(574, 439);
            this.grpZaglavlje.TabIndex = 0;
            this.grpZaglavlje.TabStop = false;
            this.grpZaglavlje.Text = "Zaglavlje";
            // 
            // labelDobavljac
            // 
            this.labelDobavljac.AutoSize = true;
            this.labelDobavljac.Location = new System.Drawing.Point(38, 154);
            this.labelDobavljac.Name = "labelDobavljac";
            this.labelDobavljac.Size = new System.Drawing.Size(62, 15);
            this.labelDobavljac.TabIndex = 11;
            this.labelDobavljac.Text = "Dobavljač:";
            // 
            // dgvPopisDobavljaca
            // 
            this.dgvPopisDobavljaca.AllowUserToAddRows = false;
            this.dgvPopisDobavljaca.AllowUserToDeleteRows = false;
            this.dgvPopisDobavljaca.AutoGenerateColumns = false;
            this.dgvPopisDobavljaca.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPopisDobavljaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisDobavljaca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddobavljacDataGridViewTextBoxColumn,
            this.nazivdobavljacaDataGridViewTextBoxColumn,
            this.gradDataGridViewTextBoxColumn,
            this.brojtelefonaDataGridViewTextBoxColumn});
            this.dgvPopisDobavljaca.DataSource = this.dobavljacBindingSource;
            this.dgvPopisDobavljaca.Location = new System.Drawing.Point(106, 154);
            this.dgvPopisDobavljaca.Name = "dgvPopisDobavljaca";
            this.dgvPopisDobavljaca.ReadOnly = true;
            this.dgvPopisDobavljaca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisDobavljaca.Size = new System.Drawing.Size(458, 130);
            this.dgvPopisDobavljaca.TabIndex = 10;
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
            this.nazivdobavljacaDataGridViewTextBoxColumn.HeaderText = "Dobavljač";
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
            // dobavljacBindingSource
            // 
            this.dobavljacBindingSource.DataMember = "dobavljac";
            this.dobavljacBindingSource.DataSource = this.dataSetPrimke;
            // 
            // dataSetPrimke
            // 
            this.dataSetPrimke.DataSetName = "DataSetPrimke";
            this.dataSetPrimke.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdustani.Location = new System.Drawing.Point(208, 381);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(96, 38);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKreiraj.Location = new System.Drawing.Point(106, 381);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(96, 38);
            this.btnKreiraj.TabIndex = 8;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // inputDatum
            // 
            this.inputDatum.Location = new System.Drawing.Point(106, 113);
            this.inputDatum.Name = "inputDatum";
            this.inputDatum.Size = new System.Drawing.Size(233, 21);
            this.inputDatum.TabIndex = 7;
            // 
            // inputOpis
            // 
            this.inputOpis.Location = new System.Drawing.Point(106, 302);
            this.inputOpis.Multiline = true;
            this.inputOpis.Name = "inputOpis";
            this.inputOpis.Size = new System.Drawing.Size(343, 73);
            this.inputOpis.TabIndex = 6;
            // 
            // inputNaslov
            // 
            this.inputNaslov.Location = new System.Drawing.Point(106, 73);
            this.inputNaslov.Name = "inputNaslov";
            this.inputNaslov.Size = new System.Drawing.Size(233, 21);
            this.inputNaslov.TabIndex = 5;
            // 
            // inputIdPrimke
            // 
            this.inputIdPrimke.Location = new System.Drawing.Point(106, 35);
            this.inputIdPrimke.Name = "inputIdPrimke";
            this.inputIdPrimke.Size = new System.Drawing.Size(116, 21);
            this.inputIdPrimke.TabIndex = 4;
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(64, 305);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(36, 15);
            this.labelOpis.TabIndex = 3;
            this.labelOpis.Text = "Opis:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(53, 118);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(47, 15);
            this.labelDatum.TabIndex = 2;
            this.labelDatum.Text = "Datum:";
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Location = new System.Drawing.Point(54, 76);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(46, 15);
            this.labelNaslov.TabIndex = 1;
            this.labelNaslov.Text = "Naslov:";
            // 
            // labelSifra
            // 
            this.labelSifra.AutoSize = true;
            this.labelSifra.Location = new System.Drawing.Point(21, 38);
            this.labelSifra.Name = "labelSifra";
            this.labelSifra.Size = new System.Drawing.Size(79, 15);
            this.labelSifra.TabIndex = 0;
            this.labelSifra.Text = "Šifra primke:";
            // 
            // grpPopis
            // 
            this.grpPopis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpPopis.Controls.Add(this.btnObrisi);
            this.grpPopis.Controls.Add(this.btnPotvrdi);
            this.grpPopis.Controls.Add(this.btnOsvjezi);
            this.grpPopis.Controls.Add(this.btnDodaj);
            this.grpPopis.Controls.Add(this.dgvPopisSirovina);
            this.grpPopis.Location = new System.Drawing.Point(12, 457);
            this.grpPopis.Name = "grpPopis";
            this.grpPopis.Size = new System.Drawing.Size(476, 303);
            this.grpPopis.TabIndex = 1;
            this.grpPopis.TabStop = false;
            this.grpPopis.Text = "Popis Sirovina";
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPotvrdi.Enabled = false;
            this.btnPotvrdi.Location = new System.Drawing.Point(374, 152);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(96, 38);
            this.btnPotvrdi.TabIndex = 3;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Enabled = false;
            this.btnOsvjezi.Location = new System.Drawing.Point(374, 108);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(96, 38);
            this.btnOsvjezi.TabIndex = 2;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodaj.Enabled = false;
            this.btnDodaj.Location = new System.Drawing.Point(374, 20);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(96, 38);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPopisSirovina
            // 
            this.dgvPopisSirovina.AllowUserToAddRows = false;
            this.dgvPopisSirovina.AllowUserToDeleteRows = false;
            this.dgvPopisSirovina.AutoGenerateColumns = false;
            this.dgvPopisSirovina.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPopisSirovina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisSirovina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_primke,
            this.idsirovinaDataGridViewTextBoxColumn,
            this.kolicina});
            this.dgvPopisSirovina.DataSource = this.primkasirovinaBindingSource;
            this.dgvPopisSirovina.Location = new System.Drawing.Point(6, 20);
            this.dgvPopisSirovina.Name = "dgvPopisSirovina";
            this.dgvPopisSirovina.ReadOnly = true;
            this.dgvPopisSirovina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisSirovina.Size = new System.Drawing.Size(362, 262);
            this.dgvPopisSirovina.TabIndex = 0;
            this.dgvPopisSirovina.SelectionChanged += new System.EventHandler(this.dgvPopisSirovina_SelectionChanged);
            // 
            // id_primke
            // 
            this.id_primke.DataPropertyName = "id_primke";
            this.id_primke.HeaderText = "Šifra primke";
            this.id_primke.Name = "id_primke";
            this.id_primke.ReadOnly = true;
            this.id_primke.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idsirovinaDataGridViewTextBoxColumn
            // 
            this.idsirovinaDataGridViewTextBoxColumn.DataPropertyName = "id_sirovina";
            this.idsirovinaDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.idsirovinaDataGridViewTextBoxColumn.Name = "idsirovinaDataGridViewTextBoxColumn";
            this.idsirovinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsirovinaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kolicina
            // 
            this.kolicina.DataPropertyName = "kolicina";
            this.kolicina.HeaderText = "Zaprimljena količina";
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
            this.kolicina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // primkasirovinaBindingSource
            // 
            this.primkasirovinaBindingSource.DataMember = "primka_sirovina";
            this.primkasirovinaBindingSource.DataSource = this.dataSetPrimkeBindingSource;
            // 
            // dataSetPrimkeBindingSource
            // 
            this.dataSetPrimkeBindingSource.DataSource = this.dataSetPrimke;
            this.dataSetPrimkeBindingSource.Position = 0;
            // 
            // sirovinaBindingSource
            // 
            this.sirovinaBindingSource.DataMember = "sirovina";
            this.sirovinaBindingSource.DataSource = this.dataSetPrimkeBindingSource;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = PI_Projekt_SiM.DataSetIzdatniceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sirovinaTableAdapter
            // 
            this.sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // primka_sirovinaTableAdapter
            // 
            this.primka_sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // primkaBindingSource
            // 
            this.primkaBindingSource.DataMember = "primka";
            this.primkaBindingSource.DataSource = this.dataSetPrimke;
            // 
            // primkaTableAdapter
            // 
            this.primkaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dobavljacTableAdapter = null;
            this.tableAdapterManager.primkaTableAdapter = this.primkaTableAdapter;
            this.tableAdapterManager.sirovinaTableAdapter = this.sirovinaTableAdapter;
            this.tableAdapterManager.UpdateOrder = PI_Projekt_SiM.DataSetPrimkeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // primka_sirovinaBindingSource
            // 
            this.primka_sirovinaBindingSource.DataMember = "primka_sirovina";
            this.primka_sirovinaBindingSource.DataSource = this.dataSetPrimke;
            // 
            // primka_sirovinaTableAdapter1
            // 
            this.primka_sirovinaTableAdapter1.ClearBeforeFill = true;
            // 
            // dobavljacTableAdapter
            // 
            this.dobavljacTableAdapter.ClearBeforeFill = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObrisi.Enabled = false;
            this.btnObrisi.Location = new System.Drawing.Point(374, 64);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(96, 38);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmSkladistarKreiranjePrimke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 741);
            this.Controls.Add(this.grpPopis);
            this.Controls.Add(this.grpZaglavlje);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSkladistarKreiranjePrimke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova primka";
            this.Load += new System.EventHandler(this.frmSkladistarKreiranjePrimke_Load);
            this.grpZaglavlje.ResumeLayout(false);
            this.grpZaglavlje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisDobavljaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrimke)).EndInit();
            this.grpPopis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSirovina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkasirovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrimkeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primka_sirovinaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpZaglavlje;
        private System.Windows.Forms.Label labelSifra;
        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.TextBox inputOpis;
        private System.Windows.Forms.TextBox inputNaslov;
        private System.Windows.Forms.TextBox inputIdPrimke;
        private System.Windows.Forms.DateTimePicker inputDatum;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.GroupBox grpPopis;
        private System.Windows.Forms.DataGridView dgvPopisSirovina;
        private System.Windows.Forms.BindingSource dataSetPrimkeBindingSource;
        private DataSetPrimke dataSetPrimke;
        private System.Windows.Forms.BindingSource sirovinaBindingSource;
        private DataSetPrimkeTableAdapters.sirovinaTableAdapter sirovinaTableAdapter;
        private System.Windows.Forms.BindingSource primkasirovinaBindingSource;
        private DataSetPrimkeTableAdapters.primka_sirovinaTableAdapter primka_sirovinaTableAdapter;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnPotvrdi;
        private DataSetIzdatniceTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource primkaBindingSource;
        private DataSetPrimkeTableAdapters.primkaTableAdapter primkaTableAdapter;
        private DataSetPrimkeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource primka_sirovinaBindingSource;
        private DataSetPrimkeTableAdapters.primka_sirovinaTableAdapter primka_sirovinaTableAdapter1;
        private System.Windows.Forms.DataGridView dgvPopisDobavljaca;
        private System.Windows.Forms.BindingSource dobavljacBindingSource;
        private DataSetPrimkeTableAdapters.dobavljacTableAdapter dobavljacTableAdapter;
        private System.Windows.Forms.Label labelDobavljac;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivdobavljacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_primke;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsirovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.Button btnObrisi;
    }
}