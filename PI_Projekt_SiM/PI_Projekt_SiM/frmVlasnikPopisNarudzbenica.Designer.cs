namespace PI_Projekt_SiM
{
    partial class frmVlasnikPopisNarudzbenica
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
            this.grbNarudzbenice = new System.Windows.Forms.GroupBox();
            this.dgvPopisNarudzbenica = new System.Windows.Forms.DataGridView();
            this.idnarudzbenicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idzahtjevnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv_dobavljaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbenicaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSirovine = new PI_Projekt_SiM.DataSetSirovine();
            this.grbDetaljiNarudzbenice = new System.Windows.Forms.GroupBox();
            this.dgvDetaljiNarudzbenice = new System.Windows.Forms.DataGridView();
            this.idnarudzbenicaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsirovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivsirovineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbenicasirovina2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNatrag = new System.Windows.Forms.Button();
            this.narudzbenicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudzbenicaTableAdapter = new PI_Projekt_SiM.DataSetSirovineTableAdapters.narudzbenicaTableAdapter();
            this.narudzbenica_sirovina2TableAdapter = new PI_Projekt_SiM.DataSetSirovineTableAdapters.narudzbenica_sirovina2TableAdapter();
            this.btnPdf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.grbNarudzbenice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisNarudzbenica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).BeginInit();
            this.grbDetaljiNarudzbenice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiNarudzbenice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicasirovina2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNarudzbenice
            // 
            this.grbNarudzbenice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbNarudzbenice.Controls.Add(this.dgvPopisNarudzbenica);
            this.grbNarudzbenice.Location = new System.Drawing.Point(196, 12);
            this.grbNarudzbenice.Name = "grbNarudzbenice";
            this.grbNarudzbenice.Size = new System.Drawing.Size(878, 276);
            this.grbNarudzbenice.TabIndex = 0;
            this.grbNarudzbenice.TabStop = false;
            this.grbNarudzbenice.Text = "Narudžbenice";
            // 
            // dgvPopisNarudzbenica
            // 
            this.dgvPopisNarudzbenica.AllowUserToAddRows = false;
            this.dgvPopisNarudzbenica.AllowUserToDeleteRows = false;
            this.dgvPopisNarudzbenica.AutoGenerateColumns = false;
            this.dgvPopisNarudzbenica.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPopisNarudzbenica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisNarudzbenica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnarudzbenicaDataGridViewTextBoxColumn,
            this.naslovDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.datumkreiranjaDataGridViewTextBoxColumn,
            this.idzahtjevnicaDataGridViewTextBoxColumn,
            this.ime,
            this.prezime,
            this.naziv_dobavljaca});
            this.dgvPopisNarudzbenica.DataSource = this.narudzbenicaBindingSource1;
            this.dgvPopisNarudzbenica.Location = new System.Drawing.Point(6, 20);
            this.dgvPopisNarudzbenica.Name = "dgvPopisNarudzbenica";
            this.dgvPopisNarudzbenica.ReadOnly = true;
            this.dgvPopisNarudzbenica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisNarudzbenica.Size = new System.Drawing.Size(861, 250);
            this.dgvPopisNarudzbenica.TabIndex = 1;
            this.dgvPopisNarudzbenica.SelectionChanged += new System.EventHandler(this.dgvPopisNarudzbenica_SelectionChanged);
            // 
            // idnarudzbenicaDataGridViewTextBoxColumn
            // 
            this.idnarudzbenicaDataGridViewTextBoxColumn.DataPropertyName = "id_narudzbenica";
            this.idnarudzbenicaDataGridViewTextBoxColumn.HeaderText = "Šifra narudžbenice";
            this.idnarudzbenicaDataGridViewTextBoxColumn.Name = "idnarudzbenicaDataGridViewTextBoxColumn";
            this.idnarudzbenicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idnarudzbenicaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // idzahtjevnicaDataGridViewTextBoxColumn
            // 
            this.idzahtjevnicaDataGridViewTextBoxColumn.DataPropertyName = "id_zahtjevnica";
            this.idzahtjevnicaDataGridViewTextBoxColumn.HeaderText = "Šifra zahtjevnice";
            this.idzahtjevnicaDataGridViewTextBoxColumn.Name = "idzahtjevnicaDataGridViewTextBoxColumn";
            this.idzahtjevnicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idzahtjevnicaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // naziv_dobavljaca
            // 
            this.naziv_dobavljaca.DataPropertyName = "naziv_dobavljaca";
            this.naziv_dobavljaca.HeaderText = "Dobavljač";
            this.naziv_dobavljaca.Name = "naziv_dobavljaca";
            this.naziv_dobavljaca.ReadOnly = true;
            this.naziv_dobavljaca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // narudzbenicaBindingSource1
            // 
            this.narudzbenicaBindingSource1.DataMember = "narudzbenica";
            this.narudzbenicaBindingSource1.DataSource = this.dataSetSirovine;
            // 
            // dataSetSirovine
            // 
            this.dataSetSirovine.DataSetName = "DataSetSirovine";
            this.dataSetSirovine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grbDetaljiNarudzbenice
            // 
            this.grbDetaljiNarudzbenice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbDetaljiNarudzbenice.Controls.Add(this.dgvDetaljiNarudzbenice);
            this.grbDetaljiNarudzbenice.Location = new System.Drawing.Point(198, 294);
            this.grbDetaljiNarudzbenice.Name = "grbDetaljiNarudzbenice";
            this.grbDetaljiNarudzbenice.Size = new System.Drawing.Size(575, 252);
            this.grbDetaljiNarudzbenice.TabIndex = 0;
            this.grbDetaljiNarudzbenice.TabStop = false;
            this.grbDetaljiNarudzbenice.Text = "Detalji narudžbenice";
            // 
            // dgvDetaljiNarudzbenice
            // 
            this.dgvDetaljiNarudzbenice.AllowUserToAddRows = false;
            this.dgvDetaljiNarudzbenice.AllowUserToDeleteRows = false;
            this.dgvDetaljiNarudzbenice.AutoGenerateColumns = false;
            this.dgvDetaljiNarudzbenice.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetaljiNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetaljiNarudzbenice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnarudzbenicaDataGridViewTextBoxColumn1,
            this.idsirovinaDataGridViewTextBoxColumn,
            this.nazivsirovineDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.jedinicnamjeraDataGridViewTextBoxColumn});
            this.dgvDetaljiNarudzbenice.DataSource = this.narudzbenicasirovina2BindingSource;
            this.dgvDetaljiNarudzbenice.Location = new System.Drawing.Point(6, 20);
            this.dgvDetaljiNarudzbenice.Name = "dgvDetaljiNarudzbenice";
            this.dgvDetaljiNarudzbenice.ReadOnly = true;
            this.dgvDetaljiNarudzbenice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetaljiNarudzbenice.Size = new System.Drawing.Size(558, 226);
            this.dgvDetaljiNarudzbenice.TabIndex = 0;
            // 
            // idnarudzbenicaDataGridViewTextBoxColumn1
            // 
            this.idnarudzbenicaDataGridViewTextBoxColumn1.DataPropertyName = "id_narudzbenica";
            this.idnarudzbenicaDataGridViewTextBoxColumn1.HeaderText = "Šifra narudžbenice";
            this.idnarudzbenicaDataGridViewTextBoxColumn1.Name = "idnarudzbenicaDataGridViewTextBoxColumn1";
            this.idnarudzbenicaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idnarudzbenicaDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Naručena količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // jedinicnamjeraDataGridViewTextBoxColumn
            // 
            this.jedinicnamjeraDataGridViewTextBoxColumn.DataPropertyName = "jedinicna_mjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.HeaderText = "Jedinična mjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.Name = "jedinicnamjeraDataGridViewTextBoxColumn";
            this.jedinicnamjeraDataGridViewTextBoxColumn.ReadOnly = true;
            this.jedinicnamjeraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // narudzbenicasirovina2BindingSource
            // 
            this.narudzbenicasirovina2BindingSource.DataMember = "narudzbenica_sirovina2";
            this.narudzbenicasirovina2BindingSource.DataSource = this.dataSetSirovine;
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNatrag.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(180, 66);
            this.btnNatrag.TabIndex = 9;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // narudzbenicaBindingSource
            // 
            this.narudzbenicaBindingSource.DataMember = "narudzbenica";
            this.narudzbenicaBindingSource.DataSource = this.dataSetSirovine;
            // 
            // narudzbenicaTableAdapter
            // 
            this.narudzbenicaTableAdapter.ClearBeforeFill = true;
            // 
            // narudzbenica_sirovina2TableAdapter
            // 
            this.narudzbenica_sirovina2TableAdapter.ClearBeforeFill = true;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPdf.Location = new System.Drawing.Point(196, 624);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(81, 38);
            this.btnPdf.TabIndex = 15;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTrazi);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(196, 552);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 66);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tražilica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Šifra:";
            // 
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(151, 23);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(322, 21);
            this.txtTrazi.TabIndex = 0;
            this.txtTrazi.TextChanged += new System.EventHandler(this.txtTrazi_TextChanged);
            // 
            // frmVlasnikPopisNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1086, 704);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.grbDetaljiNarudzbenice);
            this.Controls.Add(this.grbNarudzbenice);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmVlasnikPopisNarudzbenica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis narudžbenica";
            this.Load += new System.EventHandler(this.frmVlasnikPopisNarudzbenica_Load);
            this.grbNarudzbenice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisNarudzbenica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).EndInit();
            this.grbDetaljiNarudzbenice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiNarudzbenice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicasirovina2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbenicaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNarudzbenice;
        private System.Windows.Forms.GroupBox grbDetaljiNarudzbenice;
        private System.Windows.Forms.DataGridView dgvDetaljiNarudzbenice;
        private System.Windows.Forms.DataGridView dgvPopisNarudzbenica;
        private System.Windows.Forms.Button btnNatrag;
        private DataSetSirovine dataSetSirovine;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource;
        private DataSetSirovineTableAdapters.narudzbenicaTableAdapter narudzbenicaTableAdapter;
        private System.Windows.Forms.BindingSource narudzbenicaBindingSource1;
        private System.Windows.Forms.BindingSource narudzbenicasirovina2BindingSource;
        private DataSetSirovineTableAdapters.narudzbenica_sirovina2TableAdapter narudzbenica_sirovina2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnarudzbenicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzahtjevnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_dobavljaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnarudzbenicaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsirovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivsirovineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnamjeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrazi;
    }
}