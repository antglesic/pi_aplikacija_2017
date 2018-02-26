namespace PI_Projekt_SiM
{
    partial class frmSkladistarPopisIzdatnica
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
            this.grbIzdatnice = new System.Windows.Forms.GroupBox();
            this.dgvPopisIzdatnica = new System.Windows.Forms.DataGridView();
            this.idizdatnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idzahtjevnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdatnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetIzdatnice = new PI_Projekt_SiM.DataSetIzdatnice();
            this.primka2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPrimke = new PI_Projekt_SiM.DataSetPrimke();
            this.primka2TableAdapter = new PI_Projekt_SiM.DataSetPrimkeTableAdapters.primka2TableAdapter();
            this.izdatnicaTableAdapter = new PI_Projekt_SiM.DataSetIzdatniceTableAdapters.izdatnicaTableAdapter();
            this.grbDetaljiIzdatnica = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idsirovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivsirovineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izdatnicasirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.izdatnica_sirovinaTableAdapter = new PI_Projekt_SiM.DataSetIzdatniceTableAdapters.izdatnica_sirovinaTableAdapter();
            this.btnPdf = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.grbIzdatnice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisIzdatnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdatnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIzdatnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primka2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrimke)).BeginInit();
            this.grbDetaljiIzdatnica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdatnicasirovinaBindingSource)).BeginInit();
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
            this.btnNatrag.TabIndex = 9;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // grbIzdatnice
            // 
            this.grbIzdatnice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbIzdatnice.Controls.Add(this.dgvPopisIzdatnica);
            this.grbIzdatnice.Location = new System.Drawing.Point(198, 12);
            this.grbIzdatnice.Name = "grbIzdatnice";
            this.grbIzdatnice.Size = new System.Drawing.Size(772, 237);
            this.grbIzdatnice.TabIndex = 10;
            this.grbIzdatnice.TabStop = false;
            this.grbIzdatnice.Text = "Izdatnice";
            // 
            // dgvPopisIzdatnica
            // 
            this.dgvPopisIzdatnica.AllowUserToAddRows = false;
            this.dgvPopisIzdatnica.AllowUserToDeleteRows = false;
            this.dgvPopisIzdatnica.AutoGenerateColumns = false;
            this.dgvPopisIzdatnica.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPopisIzdatnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisIzdatnica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idizdatnicaDataGridViewTextBoxColumn,
            this.naslovDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.datumkreiranjaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.idzahtjevnicaDataGridViewTextBoxColumn});
            this.dgvPopisIzdatnica.DataSource = this.izdatnicaBindingSource;
            this.dgvPopisIzdatnica.Location = new System.Drawing.Point(6, 20);
            this.dgvPopisIzdatnica.Name = "dgvPopisIzdatnica";
            this.dgvPopisIzdatnica.ReadOnly = true;
            this.dgvPopisIzdatnica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisIzdatnica.Size = new System.Drawing.Size(755, 211);
            this.dgvPopisIzdatnica.TabIndex = 0;
            this.dgvPopisIzdatnica.SelectionChanged += new System.EventHandler(this.dgvPopisIzdatnica_SelectionChanged);
            // 
            // idizdatnicaDataGridViewTextBoxColumn
            // 
            this.idizdatnicaDataGridViewTextBoxColumn.DataPropertyName = "id_izdatnica";
            this.idizdatnicaDataGridViewTextBoxColumn.HeaderText = "Šifra izdatnice";
            this.idizdatnicaDataGridViewTextBoxColumn.Name = "idizdatnicaDataGridViewTextBoxColumn";
            this.idizdatnicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idizdatnicaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // idzahtjevnicaDataGridViewTextBoxColumn
            // 
            this.idzahtjevnicaDataGridViewTextBoxColumn.DataPropertyName = "id_zahtjevnica";
            this.idzahtjevnicaDataGridViewTextBoxColumn.HeaderText = "Šifra zahtjevnice";
            this.idzahtjevnicaDataGridViewTextBoxColumn.Name = "idzahtjevnicaDataGridViewTextBoxColumn";
            this.idzahtjevnicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idzahtjevnicaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // izdatnicaBindingSource
            // 
            this.izdatnicaBindingSource.DataMember = "izdatnica";
            this.izdatnicaBindingSource.DataSource = this.dataSetIzdatnice;
            // 
            // dataSetIzdatnice
            // 
            this.dataSetIzdatnice.DataSetName = "DataSetIzdatnice";
            this.dataSetIzdatnice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // primka2BindingSource
            // 
            this.primka2BindingSource.DataMember = "primka2";
            this.primka2BindingSource.DataSource = this.dataSetPrimke;
            // 
            // dataSetPrimke
            // 
            this.dataSetPrimke.DataSetName = "DataSetPrimke";
            this.dataSetPrimke.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // primka2TableAdapter
            // 
            this.primka2TableAdapter.ClearBeforeFill = true;
            // 
            // izdatnicaTableAdapter
            // 
            this.izdatnicaTableAdapter.ClearBeforeFill = true;
            // 
            // grbDetaljiIzdatnica
            // 
            this.grbDetaljiIzdatnica.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbDetaljiIzdatnica.Controls.Add(this.dataGridView1);
            this.grbDetaljiIzdatnica.Location = new System.Drawing.Point(198, 255);
            this.grbDetaljiIzdatnica.Name = "grbDetaljiIzdatnica";
            this.grbDetaljiIzdatnica.Size = new System.Drawing.Size(473, 237);
            this.grbDetaljiIzdatnica.TabIndex = 11;
            this.grbDetaljiIzdatnica.TabStop = false;
            this.grbDetaljiIzdatnica.Text = "Detalji izdatnice";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsirovinaDataGridViewTextBoxColumn,
            this.nazivsirovineDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.jedinicnamjeraDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.izdatnicasirovinaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(457, 211);
            this.dataGridView1.TabIndex = 0;
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
            this.nazivsirovineDataGridViewTextBoxColumn.HeaderText = "Naziv sirovine";
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
            // izdatnicasirovinaBindingSource
            // 
            this.izdatnicasirovinaBindingSource.DataMember = "izdatnica_sirovina";
            this.izdatnicasirovinaBindingSource.DataSource = this.dataSetIzdatnice;
            // 
            // izdatnica_sirovinaTableAdapter
            // 
            this.izdatnica_sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPdf.Location = new System.Drawing.Point(198, 570);
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
            this.groupBox2.Location = new System.Drawing.Point(198, 498);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 66);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tražilica";
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
            // txtTrazi
            // 
            this.txtTrazi.Location = new System.Drawing.Point(113, 26);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(322, 21);
            this.txtTrazi.TabIndex = 0;
            this.txtTrazi.TextChanged += new System.EventHandler(this.txtTrazi_TextChanged);
            // 
            // frmSkladistarPopisIzdatnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 618);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.grbDetaljiIzdatnica);
            this.Controls.Add(this.grbIzdatnice);
            this.Controls.Add(this.btnNatrag);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSkladistarPopisIzdatnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis izdatnica";
            this.Load += new System.EventHandler(this.frmSkladistarPopisIzdatnica_Load);
            this.grbIzdatnice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisIzdatnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdatnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIzdatnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primka2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrimke)).EndInit();
            this.grbDetaljiIzdatnica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izdatnicasirovinaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.GroupBox grbIzdatnice;
        private System.Windows.Forms.DataGridView dgvPopisIzdatnica;
        private DataSetPrimke dataSetPrimke;
        private System.Windows.Forms.BindingSource primka2BindingSource;
        private DataSetPrimkeTableAdapters.primka2TableAdapter primka2TableAdapter;
        private DataSetIzdatnice dataSetIzdatnice;
        private System.Windows.Forms.BindingSource izdatnicaBindingSource;
        private DataSetIzdatniceTableAdapters.izdatnicaTableAdapter izdatnicaTableAdapter;
        private System.Windows.Forms.GroupBox grbDetaljiIzdatnica;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource izdatnicasirovinaBindingSource;
        private DataSetIzdatniceTableAdapters.izdatnica_sirovinaTableAdapter izdatnica_sirovinaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idizdatnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzahtjevnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsirovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivsirovineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnamjeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTrazi;
    }
}