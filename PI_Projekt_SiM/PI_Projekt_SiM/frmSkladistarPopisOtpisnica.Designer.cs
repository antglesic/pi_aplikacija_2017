namespace PI_Projekt_SiM
{
    partial class frmSkladistarPopisOtpisnica
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
            this.grbOtpisnice = new System.Windows.Forms.GroupBox();
            this.dgvPopisOtpisnica = new System.Windows.Forms.DataGridView();
            this.idotpisnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otpisnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSirovine = new PI_Projekt_SiM.DataSetSirovine();
            this.grbDetaljiOtpisnice = new System.Windows.Forms.GroupBox();
            this.dgvDetaljiOtpisnice = new System.Windows.Forms.DataGridView();
            this.idsirovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivsirovineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otpisnicasirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otpisnicaTableAdapter = new PI_Projekt_SiM.DataSetSirovineTableAdapters.otpisnicaTableAdapter();
            this.otpisnica_sirovinaTableAdapter = new PI_Projekt_SiM.DataSetSirovineTableAdapters.otpisnica_sirovinaTableAdapter();
            this.btnKreirajOtpisnicu = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grbOtpisnice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisOtpisnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpisnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).BeginInit();
            this.grbDetaljiOtpisnice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiOtpisnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpisnicasirovinaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNatrag.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(180, 66);
            this.btnNatrag.TabIndex = 10;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // grbOtpisnice
            // 
            this.grbOtpisnice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbOtpisnice.Controls.Add(this.dgvPopisOtpisnica);
            this.grbOtpisnice.Location = new System.Drawing.Point(198, 12);
            this.grbOtpisnice.Name = "grbOtpisnice";
            this.grbOtpisnice.Size = new System.Drawing.Size(695, 282);
            this.grbOtpisnice.TabIndex = 11;
            this.grbOtpisnice.TabStop = false;
            this.grbOtpisnice.Text = "Otpisnice";
            // 
            // dgvPopisOtpisnica
            // 
            this.dgvPopisOtpisnica.AllowUserToAddRows = false;
            this.dgvPopisOtpisnica.AllowUserToDeleteRows = false;
            this.dgvPopisOtpisnica.AutoGenerateColumns = false;
            this.dgvPopisOtpisnica.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPopisOtpisnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisOtpisnica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idotpisnicaDataGridViewTextBoxColumn,
            this.naslovDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.datumkreiranjaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn});
            this.dgvPopisOtpisnica.DataSource = this.otpisnicaBindingSource;
            this.dgvPopisOtpisnica.Location = new System.Drawing.Point(6, 20);
            this.dgvPopisOtpisnica.Name = "dgvPopisOtpisnica";
            this.dgvPopisOtpisnica.ReadOnly = true;
            this.dgvPopisOtpisnica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisOtpisnica.Size = new System.Drawing.Size(683, 245);
            this.dgvPopisOtpisnica.TabIndex = 0;
            this.dgvPopisOtpisnica.SelectionChanged += new System.EventHandler(this.dgvPopisOtpisnica_SelectionChanged);
            // 
            // idotpisnicaDataGridViewTextBoxColumn
            // 
            this.idotpisnicaDataGridViewTextBoxColumn.DataPropertyName = "id_otpisnica";
            this.idotpisnicaDataGridViewTextBoxColumn.HeaderText = "Šifra otpisnice";
            this.idotpisnicaDataGridViewTextBoxColumn.Name = "idotpisnicaDataGridViewTextBoxColumn";
            this.idotpisnicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idotpisnicaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // otpisnicaBindingSource
            // 
            this.otpisnicaBindingSource.DataMember = "otpisnica";
            this.otpisnicaBindingSource.DataSource = this.dataSetSirovine;
            // 
            // dataSetSirovine
            // 
            this.dataSetSirovine.DataSetName = "DataSetSirovine";
            this.dataSetSirovine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grbDetaljiOtpisnice
            // 
            this.grbDetaljiOtpisnice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbDetaljiOtpisnice.Controls.Add(this.dgvDetaljiOtpisnice);
            this.grbDetaljiOtpisnice.Location = new System.Drawing.Point(198, 300);
            this.grbDetaljiOtpisnice.Name = "grbDetaljiOtpisnice";
            this.grbDetaljiOtpisnice.Size = new System.Drawing.Size(488, 183);
            this.grbDetaljiOtpisnice.TabIndex = 0;
            this.grbDetaljiOtpisnice.TabStop = false;
            this.grbDetaljiOtpisnice.Text = "DetaljiOtpisnice";
            // 
            // dgvDetaljiOtpisnice
            // 
            this.dgvDetaljiOtpisnice.AllowUserToAddRows = false;
            this.dgvDetaljiOtpisnice.AllowUserToDeleteRows = false;
            this.dgvDetaljiOtpisnice.AutoGenerateColumns = false;
            this.dgvDetaljiOtpisnice.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetaljiOtpisnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetaljiOtpisnice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsirovinaDataGridViewTextBoxColumn,
            this.nazivsirovineDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.jedinicnamjeraDataGridViewTextBoxColumn});
            this.dgvDetaljiOtpisnice.DataSource = this.otpisnicasirovinaBindingSource;
            this.dgvDetaljiOtpisnice.Location = new System.Drawing.Point(6, 20);
            this.dgvDetaljiOtpisnice.Name = "dgvDetaljiOtpisnice";
            this.dgvDetaljiOtpisnice.ReadOnly = true;
            this.dgvDetaljiOtpisnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetaljiOtpisnice.Size = new System.Drawing.Size(476, 150);
            this.dgvDetaljiOtpisnice.TabIndex = 1;
            this.dgvDetaljiOtpisnice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetaljiOtpisnice_CellContentClick);
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
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
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
            // otpisnicasirovinaBindingSource
            // 
            this.otpisnicasirovinaBindingSource.DataMember = "otpisnica_sirovina";
            this.otpisnicasirovinaBindingSource.DataSource = this.dataSetSirovine;
            // 
            // otpisnicaTableAdapter
            // 
            this.otpisnicaTableAdapter.ClearBeforeFill = true;
            // 
            // otpisnica_sirovinaTableAdapter
            // 
            this.otpisnica_sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // btnKreirajOtpisnicu
            // 
            this.btnKreirajOtpisnicu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKreirajOtpisnicu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajOtpisnicu.Location = new System.Drawing.Point(198, 561);
            this.btnKreirajOtpisnicu.Name = "btnKreirajOtpisnicu";
            this.btnKreirajOtpisnicu.Size = new System.Drawing.Size(119, 38);
            this.btnKreirajOtpisnicu.TabIndex = 12;
            this.btnKreirajOtpisnicu.Text = "Nova otpisnica";
            this.btnKreirajOtpisnicu.UseVisualStyleBackColor = false;
            this.btnKreirajOtpisnicu.Click += new System.EventHandler(this.btnKreirajOtpisnicu_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsvjezi.Location = new System.Drawing.Point(323, 561);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(119, 38);
            this.btnOsvjezi.TabIndex = 13;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPdf.Location = new System.Drawing.Point(448, 561);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(81, 38);
            this.btnPdf.TabIndex = 15;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(113, 26);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(322, 21);
            this.txtTrazi.TabIndex = 0;
            this.txtTrazi.TextChanged += new System.EventHandler(this.txtTrazi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Šifra:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTrazi);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(198, 489);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 66);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tražilica";
            // 
            // frmSkladistarPopisOtpisnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(905, 623);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnKreirajOtpisnicu);
            this.Controls.Add(this.grbDetaljiOtpisnice);
            this.Controls.Add(this.grbOtpisnice);
            this.Controls.Add(this.btnNatrag);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSkladistarPopisOtpisnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis otpisnica";
            this.Load += new System.EventHandler(this.frmSkladistarPopisOtpisnica_Load);
            this.grbOtpisnice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisOtpisnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpisnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).EndInit();
            this.grbDetaljiOtpisnice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiOtpisnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpisnicasirovinaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.GroupBox grbOtpisnice;
        private System.Windows.Forms.DataGridView dgvPopisOtpisnica;
        private System.Windows.Forms.GroupBox grbDetaljiOtpisnice;
        private System.Windows.Forms.DataGridView dgvDetaljiOtpisnice;
        private DataSetSirovine dataSetSirovine;
        private System.Windows.Forms.BindingSource otpisnicaBindingSource;
        private DataSetSirovineTableAdapters.otpisnicaTableAdapter otpisnicaTableAdapter;
        private System.Windows.Forms.BindingSource otpisnicasirovinaBindingSource;
        private DataSetSirovineTableAdapters.otpisnica_sirovinaTableAdapter otpisnica_sirovinaTableAdapter;
        private System.Windows.Forms.Button btnKreirajOtpisnicu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idotpisnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsirovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivsirovineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnamjeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.TextBox txtTrazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}