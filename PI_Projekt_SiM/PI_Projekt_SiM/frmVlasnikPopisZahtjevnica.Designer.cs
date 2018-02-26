namespace PI_Projekt_SiM
{
    partial class frmVlasnikPopisZahtjevnica
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
            this.grbPopisZahtjevnica = new System.Windows.Forms.GroupBox();
            this.dgvPopisZahtjevnica = new System.Windows.Forms.DataGridView();
            this.idzahtjevnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svrhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zahtjevnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetZahtjevnice = new PI_Projekt_SiM.DataSetZahtjevnice();
            this.zahtjevnicaTableAdapter = new PI_Projekt_SiM.DataSetZahtjevniceTableAdapters.zahtjevnicaTableAdapter();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.grbDetaljiZahtjevnice = new System.Windows.Forms.GroupBox();
            this.dgvDetaljiZahtjevnice = new System.Windows.Forms.DataGridView();
            this.idsirovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivsirovineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostupnakolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipzahtjevniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tip_zahtjevniceTableAdapter = new PI_Projekt_SiM.DataSetZahtjevniceTableAdapters.tip_zahtjevniceTableAdapter();
            this.btnKreirajNarudzbenicu = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.grbPopisZahtjevnica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZahtjevnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnice)).BeginInit();
            this.grbDetaljiZahtjevnice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiZahtjevnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipzahtjevniceBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPopisZahtjevnica
            // 
            this.grbPopisZahtjevnica.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbPopisZahtjevnica.Controls.Add(this.dgvPopisZahtjevnica);
            this.grbPopisZahtjevnica.Location = new System.Drawing.Point(195, 12);
            this.grbPopisZahtjevnica.Name = "grbPopisZahtjevnica";
            this.grbPopisZahtjevnica.Size = new System.Drawing.Size(669, 234);
            this.grbPopisZahtjevnica.TabIndex = 0;
            this.grbPopisZahtjevnica.TabStop = false;
            this.grbPopisZahtjevnica.Text = "Popis zahtjevnica";
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
            this.dgvPopisZahtjevnica.DataSource = this.zahtjevnicaBindingSource;
            this.dgvPopisZahtjevnica.Location = new System.Drawing.Point(6, 20);
            this.dgvPopisZahtjevnica.Name = "dgvPopisZahtjevnica";
            this.dgvPopisZahtjevnica.ReadOnly = true;
            this.dgvPopisZahtjevnica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisZahtjevnica.Size = new System.Drawing.Size(657, 208);
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
            // zahtjevnicaBindingSource
            // 
            this.zahtjevnicaBindingSource.DataMember = "zahtjevnica";
            this.zahtjevnicaBindingSource.DataSource = this.dataSetZahtjevnice;
            // 
            // dataSetZahtjevnice
            // 
            this.dataSetZahtjevnice.DataSetName = "DataSetZahtjevnice";
            this.dataSetZahtjevnice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zahtjevnicaTableAdapter
            // 
            this.zahtjevnicaTableAdapter.ClearBeforeFill = true;
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNatrag.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.Location = new System.Drawing.Point(9, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(180, 66);
            this.btnNatrag.TabIndex = 9;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // grbDetaljiZahtjevnice
            // 
            this.grbDetaljiZahtjevnice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbDetaljiZahtjevnice.Controls.Add(this.dgvDetaljiZahtjevnice);
            this.grbDetaljiZahtjevnice.Location = new System.Drawing.Point(195, 252);
            this.grbDetaljiZahtjevnice.Name = "grbDetaljiZahtjevnice";
            this.grbDetaljiZahtjevnice.Size = new System.Drawing.Size(568, 234);
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
            this.nazivsirovineDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.dostupnakolicinaDataGridViewTextBoxColumn,
            this.jedinicnamjeraDataGridViewTextBoxColumn});
            this.dgvDetaljiZahtjevnice.DataSource = this.tipzahtjevniceBindingSource;
            this.dgvDetaljiZahtjevnice.Location = new System.Drawing.Point(6, 20);
            this.dgvDetaljiZahtjevnice.Name = "dgvDetaljiZahtjevnice";
            this.dgvDetaljiZahtjevnice.ReadOnly = true;
            this.dgvDetaljiZahtjevnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetaljiZahtjevnice.Size = new System.Drawing.Size(556, 208);
            this.dgvDetaljiZahtjevnice.TabIndex = 0;
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
            // tip_zahtjevniceTableAdapter
            // 
            this.tip_zahtjevniceTableAdapter.ClearBeforeFill = true;
            // 
            // btnKreirajNarudzbenicu
            // 
            this.btnKreirajNarudzbenicu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKreirajNarudzbenicu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKreirajNarudzbenicu.Location = new System.Drawing.Point(195, 564);
            this.btnKreirajNarudzbenicu.Name = "btnKreirajNarudzbenicu";
            this.btnKreirajNarudzbenicu.Size = new System.Drawing.Size(119, 38);
            this.btnKreirajNarudzbenicu.TabIndex = 10;
            this.btnKreirajNarudzbenicu.Text = "Nova narudžbenica";
            this.btnKreirajNarudzbenicu.UseVisualStyleBackColor = false;
            this.btnKreirajNarudzbenicu.Click += new System.EventHandler(this.btnKreirajNarudzbenicu_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPdf.Location = new System.Drawing.Point(320, 564);
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
            this.groupBox1.Location = new System.Drawing.Point(195, 492);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 66);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tražilica";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // frmVlasnikPopisZahtjevnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(876, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnKreirajNarudzbenicu);
            this.Controls.Add(this.grbDetaljiZahtjevnice);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.grbPopisZahtjevnica);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmVlasnikPopisZahtjevnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis narudžbenica";
            this.Load += new System.EventHandler(this.frmSkladistarPopisNarudzbenica_Load);
            this.grbPopisZahtjevnica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisZahtjevnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetZahtjevnice)).EndInit();
            this.grbDetaljiZahtjevnice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetaljiZahtjevnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipzahtjevniceBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPopisZahtjevnica;
        private System.Windows.Forms.DataGridView dgvPopisZahtjevnica;
        private DataSetZahtjevnice dataSetZahtjevnice;
        private System.Windows.Forms.BindingSource zahtjevnicaBindingSource;
        private DataSetZahtjevniceTableAdapters.zahtjevnicaTableAdapter zahtjevnicaTableAdapter;
        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.GroupBox grbDetaljiZahtjevnice;
        private System.Windows.Forms.DataGridView dgvDetaljiZahtjevnice;
        private System.Windows.Forms.BindingSource tipzahtjevniceBindingSource;
        private DataSetZahtjevniceTableAdapters.tip_zahtjevniceTableAdapter tip_zahtjevniceTableAdapter;
        private System.Windows.Forms.Button btnKreirajNarudzbenicu;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzahtjevnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svrhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsirovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivsirovineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostupnakolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnamjeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrazi;
    }
}