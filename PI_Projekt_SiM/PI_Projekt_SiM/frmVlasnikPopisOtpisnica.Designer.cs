namespace PI_Projekt_SiM
{
    partial class frmVlasnikPopisOtpisnica
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
            this.grbDetaljiOtpisnice = new System.Windows.Forms.GroupBox();
            this.dgvDetaljiOtpisnice = new System.Windows.Forms.DataGridView();
            this.idsirovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivsirovineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otpisnicasirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSirovine = new PI_Projekt_SiM.DataSetSirovine();
            this.grbOtpisnice = new System.Windows.Forms.GroupBox();
            this.dgvPopisOtpisnica = new System.Windows.Forms.DataGridView();
            this.idotpisnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otpisnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otpisnicaTableAdapter = new PI_Projekt_SiM.DataSetSirovineTableAdapters.otpisnicaTableAdapter();
            this.otpisnica_sirovinaTableAdapter = new PI_Projekt_SiM.DataSetSirovineTableAdapters.otpisnica_sirovinaTableAdapter();
            this.btnPdf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.grbDetaljiOtpisnice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiOtpisnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpisnicasirovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).BeginInit();
            this.grbOtpisnice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisOtpisnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpisnicaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNatrag.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(180, 66);
            this.btnNatrag.TabIndex = 11;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // grbDetaljiOtpisnice
            // 
            this.grbDetaljiOtpisnice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbDetaljiOtpisnice.Controls.Add(this.dgvDetaljiOtpisnice);
            this.grbDetaljiOtpisnice.Location = new System.Drawing.Point(198, 300);
            this.grbDetaljiOtpisnice.Name = "grbDetaljiOtpisnice";
            this.grbDetaljiOtpisnice.Size = new System.Drawing.Size(488, 183);
            this.grbDetaljiOtpisnice.TabIndex = 12;
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
            this.dgvDetaljiOtpisnice.Size = new System.Drawing.Size(470, 150);
            this.dgvDetaljiOtpisnice.TabIndex = 1;
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
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Otpisana količina";
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
            // dataSetSirovine
            // 
            this.dataSetSirovine.DataSetName = "DataSetSirovine";
            this.dataSetSirovine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grbOtpisnice
            // 
            this.grbOtpisnice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbOtpisnice.Controls.Add(this.dgvPopisOtpisnica);
            this.grbOtpisnice.Location = new System.Drawing.Point(198, 12);
            this.grbOtpisnice.Name = "grbOtpisnice";
            this.grbOtpisnice.Size = new System.Drawing.Size(707, 282);
            this.grbOtpisnice.TabIndex = 13;
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
            // otpisnicaTableAdapter
            // 
            this.otpisnicaTableAdapter.ClearBeforeFill = true;
            // 
            // otpisnica_sirovinaTableAdapter
            // 
            this.otpisnica_sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPdf.Location = new System.Drawing.Point(198, 561);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(81, 38);
            this.btnPdf.TabIndex = 14;
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
            this.groupBox1.Location = new System.Drawing.Point(198, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 66);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tražilica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Šifra:";
            // 
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(109, 25);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(322, 21);
            this.txtTrazi.TabIndex = 0;
            this.txtTrazi.TextChanged += new System.EventHandler(this.txtTrazi_TextChanged);
            // 
            // frmVlasnikPopisOtpisnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(917, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.grbDetaljiOtpisnice);
            this.Controls.Add(this.grbOtpisnice);
            this.Controls.Add(this.btnNatrag);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmVlasnikPopisOtpisnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis otpisnica";
            this.Load += new System.EventHandler(this.frmVlasnikPopisOtpisnica_Load);
            this.grbDetaljiOtpisnice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiOtpisnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpisnicasirovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).EndInit();
            this.grbOtpisnice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisOtpisnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otpisnicaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.GroupBox grbDetaljiOtpisnice;
        private System.Windows.Forms.DataGridView dgvDetaljiOtpisnice;
        private System.Windows.Forms.GroupBox grbOtpisnice;
        private System.Windows.Forms.DataGridView dgvPopisOtpisnica;
        private DataSetSirovine dataSetSirovine;
        private System.Windows.Forms.BindingSource otpisnicaBindingSource;
        private DataSetSirovineTableAdapters.otpisnicaTableAdapter otpisnicaTableAdapter;
        private System.Windows.Forms.BindingSource otpisnicasirovinaBindingSource;
        private DataSetSirovineTableAdapters.otpisnica_sirovinaTableAdapter otpisnica_sirovinaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsirovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivsirovineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnamjeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idotpisnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrazi;
    }
}