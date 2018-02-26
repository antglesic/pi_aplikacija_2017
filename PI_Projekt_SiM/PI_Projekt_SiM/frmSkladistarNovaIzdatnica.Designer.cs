namespace PI_Projekt_SiM
{
    partial class frmSkladistarNovaIzdatnica
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
            this.grbPopisSirovina = new System.Windows.Forms.GroupBox();
            this.dgvPopisSirovinaIzdatnica = new System.Windows.Forms.DataGridView();
            this.idsirovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivsirovineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dostupnakolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zahtjevnicasirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetIzdatnice = new PI_Projekt_SiM.DataSetIzdatnice();
            this.zahtjevnicasirovinaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetIzdatnice1 = new PI_Projekt_SiM.DataSetIzdatnice();
            this.zahtjevnica_sirovinaTableAdapter = new PI_Projekt_SiM.DataSetIzdatniceTableAdapters.zahtjevnica_sirovinaTableAdapter();
            this.lblIdIzdatnica = new System.Windows.Forms.Label();
            this.lblIdIzdatnice = new System.Windows.Forms.Label();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelSvrha = new System.Windows.Forms.Label();
            this.grbZaglavljeIzdatnice = new System.Windows.Forms.GroupBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.inputDatum = new System.Windows.Forms.DateTimePicker();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.sirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sirovinaTableAdapter = new PI_Projekt_SiM.DataSetIzdatniceTableAdapters.sirovinaTableAdapter();
            this.grbPopisSirovina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSirovinaIzdatnica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIzdatnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIzdatnice1)).BeginInit();
            this.grbZaglavljeIzdatnice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPopisSirovina
            // 
            this.grbPopisSirovina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbPopisSirovina.Controls.Add(this.dgvPopisSirovinaIzdatnica);
            this.grbPopisSirovina.Location = new System.Drawing.Point(489, 12);
            this.grbPopisSirovina.Name = "grbPopisSirovina";
            this.grbPopisSirovina.Size = new System.Drawing.Size(568, 199);
            this.grbPopisSirovina.TabIndex = 0;
            this.grbPopisSirovina.TabStop = false;
            this.grbPopisSirovina.Text = "Popis sirovina";
            // 
            // dgvPopisSirovinaIzdatnica
            // 
            this.dgvPopisSirovinaIzdatnica.AllowUserToAddRows = false;
            this.dgvPopisSirovinaIzdatnica.AllowUserToDeleteRows = false;
            this.dgvPopisSirovinaIzdatnica.AutoGenerateColumns = false;
            this.dgvPopisSirovinaIzdatnica.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPopisSirovinaIzdatnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisSirovinaIzdatnica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsirovinaDataGridViewTextBoxColumn,
            this.nazivsirovineDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.dostupnakolicinaDataGridViewTextBoxColumn,
            this.jedinicnamjeraDataGridViewTextBoxColumn});
            this.dgvPopisSirovinaIzdatnica.DataSource = this.zahtjevnicasirovinaBindingSource;
            this.dgvPopisSirovinaIzdatnica.Location = new System.Drawing.Point(6, 20);
            this.dgvPopisSirovinaIzdatnica.Name = "dgvPopisSirovinaIzdatnica";
            this.dgvPopisSirovinaIzdatnica.ReadOnly = true;
            this.dgvPopisSirovinaIzdatnica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisSirovinaIzdatnica.Size = new System.Drawing.Size(556, 173);
            this.dgvPopisSirovinaIzdatnica.TabIndex = 0;
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
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Izdana količina";
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
            this.jedinicnamjeraDataGridViewTextBoxColumn.HeaderText = "Jedinicna mjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.Name = "jedinicnamjeraDataGridViewTextBoxColumn";
            this.jedinicnamjeraDataGridViewTextBoxColumn.ReadOnly = true;
            this.jedinicnamjeraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // zahtjevnicasirovinaBindingSource
            // 
            this.zahtjevnicasirovinaBindingSource.DataMember = "zahtjevnica_sirovina";
            this.zahtjevnicasirovinaBindingSource.DataSource = this.dataSetIzdatnice;
            // 
            // dataSetIzdatnice
            // 
            this.dataSetIzdatnice.DataSetName = "DataSetIzdatnice";
            this.dataSetIzdatnice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zahtjevnicasirovinaBindingSource1
            // 
            this.zahtjevnicasirovinaBindingSource1.DataMember = "zahtjevnica_sirovina";
            this.zahtjevnicasirovinaBindingSource1.DataSource = this.dataSetIzdatnice1;
            // 
            // dataSetIzdatnice1
            // 
            this.dataSetIzdatnice1.DataSetName = "DataSetIzdatnice";
            this.dataSetIzdatnice1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zahtjevnica_sirovinaTableAdapter
            // 
            this.zahtjevnica_sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // lblIdIzdatnica
            // 
            this.lblIdIzdatnica.AutoSize = true;
            this.lblIdIzdatnica.Location = new System.Drawing.Point(66, 37);
            this.lblIdIzdatnica.Name = "lblIdIzdatnica";
            this.lblIdIzdatnica.Size = new System.Drawing.Size(0, 15);
            this.lblIdIzdatnica.TabIndex = 11;
            // 
            // lblIdIzdatnice
            // 
            this.lblIdIzdatnice.AutoSize = true;
            this.lblIdIzdatnice.Location = new System.Drawing.Point(30, 33);
            this.lblIdIzdatnice.Name = "lblIdIzdatnice";
            this.lblIdIzdatnice.Size = new System.Drawing.Size(89, 15);
            this.lblIdIzdatnice.TabIndex = 13;
            this.lblIdIzdatnice.Text = "Šifra izdatnice:";
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNaslov.Location = new System.Drawing.Point(73, 71);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(46, 15);
            this.labelNaslov.TabIndex = 15;
            this.labelNaslov.Text = "Naslov:";
            this.labelNaslov.Click += new System.EventHandler(this.labelNaslov_Click);
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDatum.Location = new System.Drawing.Point(72, 110);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(47, 15);
            this.labelDatum.TabIndex = 16;
            this.labelDatum.Text = "Datum:";
            // 
            // labelSvrha
            // 
            this.labelSvrha.AutoSize = true;
            this.labelSvrha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSvrha.Location = new System.Drawing.Point(83, 142);
            this.labelSvrha.Name = "labelSvrha";
            this.labelSvrha.Size = new System.Drawing.Size(36, 15);
            this.labelSvrha.TabIndex = 17;
            this.labelSvrha.Text = "Opis:";
            // 
            // grbZaglavljeIzdatnice
            // 
            this.grbZaglavljeIzdatnice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbZaglavljeIzdatnice.Controls.Add(this.btnOdustani);
            this.grbZaglavljeIzdatnice.Controls.Add(this.btnKreiraj);
            this.grbZaglavljeIzdatnice.Controls.Add(this.txtOpis);
            this.grbZaglavljeIzdatnice.Controls.Add(this.inputDatum);
            this.grbZaglavljeIzdatnice.Controls.Add(this.lblIdIzdatnice);
            this.grbZaglavljeIzdatnice.Controls.Add(this.labelSvrha);
            this.grbZaglavljeIzdatnice.Controls.Add(this.txtNaslov);
            this.grbZaglavljeIzdatnice.Controls.Add(this.labelDatum);
            this.grbZaglavljeIzdatnice.Controls.Add(this.txtSifra);
            this.grbZaglavljeIzdatnice.Controls.Add(this.labelNaslov);
            this.grbZaglavljeIzdatnice.Location = new System.Drawing.Point(12, 12);
            this.grbZaglavljeIzdatnice.Name = "grbZaglavljeIzdatnice";
            this.grbZaglavljeIzdatnice.Size = new System.Drawing.Size(471, 271);
            this.grbZaglavljeIzdatnice.TabIndex = 18;
            this.grbZaglavljeIzdatnice.TabStop = false;
            this.grbZaglavljeIzdatnice.Text = "Zaglavlje";
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdustani.Location = new System.Drawing.Point(227, 227);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(96, 38);
            this.btnOdustani.TabIndex = 24;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKreiraj.Location = new System.Drawing.Point(125, 227);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(96, 38);
            this.btnKreiraj.TabIndex = 23;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(125, 139);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(324, 79);
            this.txtOpis.TabIndex = 19;
            // 
            // inputDatum
            // 
            this.inputDatum.Location = new System.Drawing.Point(125, 105);
            this.inputDatum.Name = "inputDatum";
            this.inputDatum.Size = new System.Drawing.Size(233, 21);
            this.inputDatum.TabIndex = 22;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(125, 68);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(233, 21);
            this.txtNaslov.TabIndex = 21;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(125, 30);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(116, 21);
            this.txtSifra.TabIndex = 20;
            // 
            // sirovinaBindingSource
            // 
            this.sirovinaBindingSource.DataMember = "sirovina";
            this.sirovinaBindingSource.DataSource = this.dataSetIzdatnice1;
            // 
            // sirovinaTableAdapter
            // 
            this.sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // frmSkladistarNovaIzdatnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1069, 293);
            this.Controls.Add(this.grbZaglavljeIzdatnice);
            this.Controls.Add(this.lblIdIzdatnica);
            this.Controls.Add(this.grbPopisSirovina);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSkladistarNovaIzdatnica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova izdatnica";
            this.Load += new System.EventHandler(this.frmSkladistarNovaIzdatnica_Load);
            this.grbPopisSirovina.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSirovinaIzdatnica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIzdatnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zahtjevnicasirovinaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetIzdatnice1)).EndInit();
            this.grbZaglavljeIzdatnice.ResumeLayout(false);
            this.grbZaglavljeIzdatnice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPopisSirovina;
        private System.Windows.Forms.DataGridView dgvPopisSirovinaIzdatnica;
        private System.Windows.Forms.BindingSource zahtjevnicasirovinaBindingSource;
        private DataSetIzdatnice dataSetIzdatnice;
        private DataSetIzdatniceTableAdapters.zahtjevnica_sirovinaTableAdapter zahtjevnica_sirovinaTableAdapter;
        private System.Windows.Forms.Label lblIdIzdatnica;
        private System.Windows.Forms.Label lblIdIzdatnice;
        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelSvrha;
        private System.Windows.Forms.GroupBox grbZaglavljeIzdatnice;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.DateTimePicker inputDatum;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.BindingSource zahtjevnicasirovinaBindingSource1;
        private DataSetIzdatnice dataSetIzdatnice1;
        private System.Windows.Forms.BindingSource sirovinaBindingSource;
        private DataSetIzdatniceTableAdapters.sirovinaTableAdapter sirovinaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsirovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivsirovineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dostupnakolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnamjeraDataGridViewTextBoxColumn;
    }
}