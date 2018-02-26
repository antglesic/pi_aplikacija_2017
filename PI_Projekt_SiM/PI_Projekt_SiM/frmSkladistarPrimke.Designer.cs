namespace PI_Projekt_SiM
{
    partial class frmSkladistarPrimke
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
            this.btnNatrag = new System.Windows.Forms.Button();
            this.primkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPrimkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPrimke = new PI_Projekt_SiM.DataSetPrimke();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.dgvDetaljiPrimke = new System.Windows.Forms.DataGridView();
            this.id_sirovina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv_sirovine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicna_mjera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primkasirovina2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primkasirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grbPospiPrimki = new System.Windows.Forms.GroupBox();
            this.dgvPopisPrimki = new System.Windows.Forms.DataGridView();
            this.idprimkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivdobavljacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primka2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grbDetaljiPrimke = new System.Windows.Forms.GroupBox();
            this.primka2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primkaTableAdapter = new PI_Projekt_SiM.DataSetPrimkeTableAdapters.primkaTableAdapter();
            this.primka_sirovinaTableAdapter = new PI_Projekt_SiM.DataSetPrimkeTableAdapters.primka_sirovinaTableAdapter();
            this.primka2TableAdapter = new PI_Projekt_SiM.DataSetPrimkeTableAdapters.primka2TableAdapter();
            this.primka_sirovina2TableAdapter = new PI_Projekt_SiM.DataSetPrimkeTableAdapters.primka_sirovina2TableAdapter();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.primkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrimkeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrimke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiPrimke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkasirovina2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkasirovinaBindingSource)).BeginInit();
            this.grbPospiPrimki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisPrimki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primka2BindingSource1)).BeginInit();
            this.grbDetaljiPrimke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.primka2BindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(180, 66);
            this.btnNatrag.TabIndex = 0;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // primkaBindingSource
            // 
            this.primkaBindingSource.DataMember = "primka";
            this.primkaBindingSource.DataSource = this.dataSetPrimkeBindingSource;
            // 
            // dataSetPrimkeBindingSource
            // 
            this.dataSetPrimkeBindingSource.DataSource = this.dataSetPrimke;
            this.dataSetPrimkeBindingSource.Position = 0;
            // 
            // dataSetPrimke
            // 
            this.dataSetPrimke.DataSetName = "DataSetPrimke";
            this.dataSetPrimke.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKreiraj.Location = new System.Drawing.Point(198, 595);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(119, 38);
            this.btnKreiraj.TabIndex = 2;
            this.btnKreiraj.Text = "Nova primka";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // dgvDetaljiPrimke
            // 
            this.dgvDetaljiPrimke.AllowUserToAddRows = false;
            this.dgvDetaljiPrimke.AllowUserToDeleteRows = false;
            this.dgvDetaljiPrimke.AutoGenerateColumns = false;
            this.dgvDetaljiPrimke.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetaljiPrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetaljiPrimke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_sirovina,
            this.naziv_sirovine,
            this.kolicinaDataGridViewTextBoxColumn,
            this.jedinicna_mjera});
            this.dgvDetaljiPrimke.DataSource = this.primkasirovina2BindingSource;
            this.dgvDetaljiPrimke.Location = new System.Drawing.Point(6, 20);
            this.dgvDetaljiPrimke.Name = "dgvDetaljiPrimke";
            this.dgvDetaljiPrimke.ReadOnly = true;
            this.dgvDetaljiPrimke.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetaljiPrimke.Size = new System.Drawing.Size(467, 173);
            this.dgvDetaljiPrimke.TabIndex = 3;
            // 
            // id_sirovina
            // 
            this.id_sirovina.DataPropertyName = "id_sirovina";
            this.id_sirovina.HeaderText = "Šifra sirovine";
            this.id_sirovina.Name = "id_sirovina";
            this.id_sirovina.ReadOnly = true;
            this.id_sirovina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // naziv_sirovine
            // 
            this.naziv_sirovine.DataPropertyName = "naziv_sirovine";
            this.naziv_sirovine.HeaderText = "Naziv";
            this.naziv_sirovine.Name = "naziv_sirovine";
            this.naziv_sirovine.ReadOnly = true;
            this.naziv_sirovine.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Zaprimljena količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // jedinicna_mjera
            // 
            this.jedinicna_mjera.DataPropertyName = "jedinicna_mjera";
            this.jedinicna_mjera.HeaderText = "Jedinična mjera";
            this.jedinicna_mjera.Name = "jedinicna_mjera";
            this.jedinicna_mjera.ReadOnly = true;
            this.jedinicna_mjera.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // primkasirovina2BindingSource
            // 
            this.primkasirovina2BindingSource.DataMember = "primka_sirovina2";
            this.primkasirovina2BindingSource.DataSource = this.dataSetPrimke;
            // 
            // primkasirovinaBindingSource
            // 
            this.primkasirovinaBindingSource.DataMember = "primka_sirovina";
            this.primkasirovinaBindingSource.DataSource = this.dataSetPrimkeBindingSource;
            // 
            // grbPospiPrimki
            // 
            this.grbPospiPrimki.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbPospiPrimki.Controls.Add(this.dgvPopisPrimki);
            this.grbPospiPrimki.Location = new System.Drawing.Point(198, 12);
            this.grbPospiPrimki.Name = "grbPospiPrimki";
            this.grbPospiPrimki.Size = new System.Drawing.Size(776, 293);
            this.grbPospiPrimki.TabIndex = 4;
            this.grbPospiPrimki.TabStop = false;
            this.grbPospiPrimki.Text = "Popis primki";
            // 
            // dgvPopisPrimki
            // 
            this.dgvPopisPrimki.AllowUserToAddRows = false;
            this.dgvPopisPrimki.AllowUserToDeleteRows = false;
            this.dgvPopisPrimki.AutoGenerateColumns = false;
            this.dgvPopisPrimki.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPopisPrimki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisPrimki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprimkeDataGridViewTextBoxColumn,
            this.naslovDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.datumkreiranjaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.nazivdobavljacaDataGridViewTextBoxColumn});
            this.dgvPopisPrimki.DataSource = this.primka2BindingSource1;
            this.dgvPopisPrimki.Location = new System.Drawing.Point(7, 21);
            this.dgvPopisPrimki.Name = "dgvPopisPrimki";
            this.dgvPopisPrimki.ReadOnly = true;
            this.dgvPopisPrimki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisPrimki.Size = new System.Drawing.Size(763, 266);
            this.dgvPopisPrimki.TabIndex = 0;
            this.dgvPopisPrimki.SelectionChanged += new System.EventHandler(this.dgvPopisPrimki_SelectionChanged);
            // 
            // idprimkeDataGridViewTextBoxColumn
            // 
            this.idprimkeDataGridViewTextBoxColumn.DataPropertyName = "id_primke";
            this.idprimkeDataGridViewTextBoxColumn.HeaderText = "Šifra primke";
            this.idprimkeDataGridViewTextBoxColumn.Name = "idprimkeDataGridViewTextBoxColumn";
            this.idprimkeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idprimkeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // naslovDataGridViewTextBoxColumn
            // 
            this.naslovDataGridViewTextBoxColumn.DataPropertyName = "naslov";
            this.naslovDataGridViewTextBoxColumn.HeaderText = "Naslov";
            this.naslovDataGridViewTextBoxColumn.Name = "naslovDataGridViewTextBoxColumn";
            this.naslovDataGridViewTextBoxColumn.ReadOnly = true;
            this.naslovDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            this.opisDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // nazivdobavljacaDataGridViewTextBoxColumn
            // 
            this.nazivdobavljacaDataGridViewTextBoxColumn.DataPropertyName = "naziv_dobavljaca";
            this.nazivdobavljacaDataGridViewTextBoxColumn.HeaderText = "Dobavljač";
            this.nazivdobavljacaDataGridViewTextBoxColumn.Name = "nazivdobavljacaDataGridViewTextBoxColumn";
            this.nazivdobavljacaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivdobavljacaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // primka2BindingSource1
            // 
            this.primka2BindingSource1.DataMember = "primka2";
            this.primka2BindingSource1.DataSource = this.dataSetPrimke;
            // 
            // grbDetaljiPrimke
            // 
            this.grbDetaljiPrimke.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbDetaljiPrimke.Controls.Add(this.dgvDetaljiPrimke);
            this.grbDetaljiPrimke.Location = new System.Drawing.Point(198, 311);
            this.grbDetaljiPrimke.Name = "grbDetaljiPrimke";
            this.grbDetaljiPrimke.Size = new System.Drawing.Size(486, 206);
            this.grbDetaljiPrimke.TabIndex = 0;
            this.grbDetaljiPrimke.TabStop = false;
            this.grbDetaljiPrimke.Text = "Detalji primke";
            // 
            // primka2BindingSource
            // 
            this.primka2BindingSource.DataMember = "primka2";
            this.primka2BindingSource.DataSource = this.dataSetPrimke;
            // 
            // primkaTableAdapter
            // 
            this.primkaTableAdapter.ClearBeforeFill = true;
            // 
            // primka_sirovinaTableAdapter
            // 
            this.primka_sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // primka2TableAdapter
            // 
            this.primka2TableAdapter.ClearBeforeFill = true;
            // 
            // primka_sirovina2TableAdapter
            // 
            this.primka_sirovina2TableAdapter.ClearBeforeFill = true;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Location = new System.Drawing.Point(323, 595);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(119, 38);
            this.btnOsvjezi.TabIndex = 5;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPdf.Location = new System.Drawing.Point(448, 595);
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
            this.groupBox2.Location = new System.Drawing.Point(198, 523);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 66);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trazilica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Šifra:";
            // 
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(65, 25);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(322, 21);
            this.txtTrazi.TabIndex = 0;
            this.txtTrazi.TextChanged += new System.EventHandler(this.txtTrazi_TextChanged);
            // 
            // frmSkladistarPrimke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(986, 639);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.grbDetaljiPrimke);
            this.Controls.Add(this.grbPospiPrimki);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.btnNatrag);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSkladistarPrimke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis primki";
            this.Load += new System.EventHandler(this.frmSkladistarPrimke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.primkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrimkeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrimke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiPrimke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkasirovina2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primkasirovinaBindingSource)).EndInit();
            this.grbPospiPrimki.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisPrimki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primka2BindingSource1)).EndInit();
            this.grbDetaljiPrimke.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.primka2BindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.BindingSource dataSetPrimkeBindingSource;
        private DataSetPrimke dataSetPrimke;
        private System.Windows.Forms.BindingSource primkaBindingSource;
        private DataSetPrimkeTableAdapters.primkaTableAdapter primkaTableAdapter;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.DataGridView dgvDetaljiPrimke;
        private System.Windows.Forms.BindingSource primkasirovinaBindingSource;
        private DataSetPrimkeTableAdapters.primka_sirovinaTableAdapter primka_sirovinaTableAdapter;
        private System.Windows.Forms.BindingSource primka2BindingSource;
        private DataSetPrimkeTableAdapters.primka2TableAdapter primka2TableAdapter;
        private System.Windows.Forms.BindingSource primkasirovina2BindingSource;
        private DataSetPrimkeTableAdapters.primka_sirovina2TableAdapter primka_sirovina2TableAdapter;
        private System.Windows.Forms.GroupBox grbPospiPrimki;
        private System.Windows.Forms.GroupBox grbDetaljiPrimke;
        private System.Windows.Forms.DataGridView dgvPopisPrimki;
        private System.Windows.Forms.BindingSource primka2BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sirovina;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_sirovine;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicna_mjera;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprimkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivdobavljacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrazi;
    }
}