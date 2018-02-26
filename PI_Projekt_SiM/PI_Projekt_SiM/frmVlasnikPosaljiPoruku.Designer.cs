namespace PI_Projekt_SiM
{
    partial class frmVlasnikPosaljiPoruku
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
            this.labelSifra = new System.Windows.Forms.Label();
            this.labelPrimatelj = new System.Windows.Forms.Label();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelSadrzaj = new System.Windows.Forms.Label();
            this.dataSetPoruke = new PI_Projekt_SiM.DataSetPoruke();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new PI_Projekt_SiM.DataSetPorukeTableAdapters.korisnikTableAdapter();
            this.tableAdapterManager = new PI_Projekt_SiM.DataSetPorukeTableAdapters.TableAdapterManager();
            this.porukaTableAdapter = new PI_Projekt_SiM.DataSetPorukeTableAdapters.porukaTableAdapter();
            this.posiljatelj_porukaTableAdapter = new PI_Projekt_SiM.DataSetPorukeTableAdapters.posiljatelj_porukaTableAdapter();
            this.primatelj_porukaTableAdapter = new PI_Projekt_SiM.DataSetPorukeTableAdapters.primatelj_porukaTableAdapter();
            this.porukaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porukaPrikazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porukaPrikazTableAdapter = new PI_Projekt_SiM.DataSetPorukeTableAdapters.porukaPrikazTableAdapter();
            this.posiljatelj_porukaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primatelj_porukaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputSifraPoruke = new System.Windows.Forms.TextBox();
            this.inputNaslov = new System.Windows.Forms.TextBox();
            this.inputSadrzajPoruke = new System.Windows.Forms.TextBox();
            this.inputDatum = new System.Windows.Forms.DateTimePicker();
            this.dgvPopisKorisnika = new System.Windows.Forms.DataGridView();
            this.korisnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnPosalji = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idkorisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPoruke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaPrikazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posiljatelj_porukaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primatelj_porukaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisKorisnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSifra
            // 
            this.labelSifra.AutoSize = true;
            this.labelSifra.Location = new System.Drawing.Point(34, 36);
            this.labelSifra.Name = "labelSifra";
            this.labelSifra.Size = new System.Drawing.Size(78, 15);
            this.labelSifra.TabIndex = 0;
            this.labelSifra.Text = "Šifra poruke:";
            // 
            // labelPrimatelj
            // 
            this.labelPrimatelj.AutoSize = true;
            this.labelPrimatelj.Location = new System.Drawing.Point(51, 69);
            this.labelPrimatelj.Name = "labelPrimatelj";
            this.labelPrimatelj.Size = new System.Drawing.Size(61, 15);
            this.labelPrimatelj.TabIndex = 1;
            this.labelPrimatelj.Text = "Primatelj:";
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Location = new System.Drawing.Point(66, 314);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(46, 15);
            this.labelNaslov.TabIndex = 2;
            this.labelNaslov.Text = "Naslov:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(65, 352);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(47, 15);
            this.labelDatum.TabIndex = 3;
            this.labelDatum.Text = "Datum:";
            // 
            // labelSadrzaj
            // 
            this.labelSadrzaj.AutoSize = true;
            this.labelSadrzaj.Location = new System.Drawing.Point(60, 389);
            this.labelSadrzaj.Name = "labelSadrzaj";
            this.labelSadrzaj.Size = new System.Drawing.Size(52, 15);
            this.labelSadrzaj.TabIndex = 4;
            this.labelSadrzaj.Text = "Sadržaj:";
            // 
            // dataSetPoruke
            // 
            this.dataSetPoruke.DataSetName = "DataSetPoruke";
            this.dataSetPoruke.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "korisnik";
            this.korisnikBindingSource.DataSource = this.dataSetPoruke;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.korisnikTableAdapter = this.korisnikTableAdapter;
            this.tableAdapterManager.porukaTableAdapter = this.porukaTableAdapter;
            this.tableAdapterManager.posiljatelj_porukaTableAdapter = this.posiljatelj_porukaTableAdapter;
            this.tableAdapterManager.primatelj_porukaTableAdapter = this.primatelj_porukaTableAdapter;
            this.tableAdapterManager.UpdateOrder = PI_Projekt_SiM.DataSetPorukeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // porukaTableAdapter
            // 
            this.porukaTableAdapter.ClearBeforeFill = true;
            // 
            // posiljatelj_porukaTableAdapter
            // 
            this.posiljatelj_porukaTableAdapter.ClearBeforeFill = true;
            // 
            // primatelj_porukaTableAdapter
            // 
            this.primatelj_porukaTableAdapter.ClearBeforeFill = true;
            // 
            // porukaBindingSource
            // 
            this.porukaBindingSource.DataMember = "poruka";
            this.porukaBindingSource.DataSource = this.dataSetPoruke;
            // 
            // porukaPrikazBindingSource
            // 
            this.porukaPrikazBindingSource.DataMember = "porukaPrikaz";
            this.porukaPrikazBindingSource.DataSource = this.dataSetPoruke;
            // 
            // porukaPrikazTableAdapter
            // 
            this.porukaPrikazTableAdapter.ClearBeforeFill = true;
            // 
            // posiljatelj_porukaBindingSource
            // 
            this.posiljatelj_porukaBindingSource.DataMember = "posiljatelj_poruka";
            this.posiljatelj_porukaBindingSource.DataSource = this.dataSetPoruke;
            // 
            // primatelj_porukaBindingSource
            // 
            this.primatelj_porukaBindingSource.DataMember = "primatelj_poruka";
            this.primatelj_porukaBindingSource.DataSource = this.dataSetPoruke;
            // 
            // inputSifraPoruke
            // 
            this.inputSifraPoruke.Location = new System.Drawing.Point(118, 33);
            this.inputSifraPoruke.Name = "inputSifraPoruke";
            this.inputSifraPoruke.Size = new System.Drawing.Size(72, 21);
            this.inputSifraPoruke.TabIndex = 5;
            // 
            // inputNaslov
            // 
            this.inputNaslov.Location = new System.Drawing.Point(118, 311);
            this.inputNaslov.Name = "inputNaslov";
            this.inputNaslov.Size = new System.Drawing.Size(116, 21);
            this.inputNaslov.TabIndex = 6;
            // 
            // inputSadrzajPoruke
            // 
            this.inputSadrzajPoruke.Location = new System.Drawing.Point(118, 389);
            this.inputSadrzajPoruke.Multiline = true;
            this.inputSadrzajPoruke.Name = "inputSadrzajPoruke";
            this.inputSadrzajPoruke.Size = new System.Drawing.Size(399, 146);
            this.inputSadrzajPoruke.TabIndex = 7;
            // 
            // inputDatum
            // 
            this.inputDatum.Location = new System.Drawing.Point(118, 347);
            this.inputDatum.Name = "inputDatum";
            this.inputDatum.Size = new System.Drawing.Size(233, 21);
            this.inputDatum.TabIndex = 8;
            // 
            // dgvPopisKorisnika
            // 
            this.dgvPopisKorisnika.AllowUserToAddRows = false;
            this.dgvPopisKorisnika.AllowUserToDeleteRows = false;
            this.dgvPopisKorisnika.AutoGenerateColumns = false;
            this.dgvPopisKorisnika.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPopisKorisnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisKorisnika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idkorisnikDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn});
            this.dgvPopisKorisnika.DataSource = this.korisnikBindingSource1;
            this.dgvPopisKorisnika.Location = new System.Drawing.Point(6, 20);
            this.dgvPopisKorisnika.Name = "dgvPopisKorisnika";
            this.dgvPopisKorisnika.ReadOnly = true;
            this.dgvPopisKorisnika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisKorisnika.Size = new System.Drawing.Size(406, 190);
            this.dgvPopisKorisnika.TabIndex = 9;
            // 
            // korisnikBindingSource1
            // 
            this.korisnikBindingSource1.DataMember = "korisnik";
            this.korisnikBindingSource1.DataSource = this.dataSetPoruke;
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPosalji.Location = new System.Drawing.Point(118, 541);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(88, 35);
            this.btnPosalji.TabIndex = 10;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdustani.Location = new System.Drawing.Point(212, 541);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(88, 35);
            this.btnOdustani.TabIndex = 11;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.dgvPopisKorisnika);
            this.groupBox1.Location = new System.Drawing.Point(118, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 225);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Korisnici";
            // 
            // idkorisnikDataGridViewTextBoxColumn
            // 
            this.idkorisnikDataGridViewTextBoxColumn.DataPropertyName = "id_korisnik";
            this.idkorisnikDataGridViewTextBoxColumn.HeaderText = "Šifra korisnika";
            this.idkorisnikDataGridViewTextBoxColumn.Name = "idkorisnikDataGridViewTextBoxColumn";
            this.idkorisnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.idkorisnikDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // frmVlasnikPosaljiPoruku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 591);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.inputDatum);
            this.Controls.Add(this.inputSadrzajPoruke);
            this.Controls.Add(this.inputNaslov);
            this.Controls.Add(this.inputSifraPoruke);
            this.Controls.Add(this.labelSadrzaj);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.labelPrimatelj);
            this.Controls.Add(this.labelSifra);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmVlasnikPosaljiPoruku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova poruka";
            this.Load += new System.EventHandler(this.frmVlasnikPosaljiPoruku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPoruke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaPrikazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posiljatelj_porukaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primatelj_porukaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisKorisnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSifra;
        private System.Windows.Forms.Label labelPrimatelj;
        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelSadrzaj;
        private DataSetPoruke dataSetPoruke;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private DataSetPorukeTableAdapters.korisnikTableAdapter korisnikTableAdapter;
        private DataSetPorukeTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetPorukeTableAdapters.porukaTableAdapter porukaTableAdapter;
        private System.Windows.Forms.BindingSource porukaBindingSource;
        private System.Windows.Forms.BindingSource porukaPrikazBindingSource;
        private DataSetPorukeTableAdapters.porukaPrikazTableAdapter porukaPrikazTableAdapter;
        private DataSetPorukeTableAdapters.posiljatelj_porukaTableAdapter posiljatelj_porukaTableAdapter;
        private System.Windows.Forms.BindingSource posiljatelj_porukaBindingSource;
        private DataSetPorukeTableAdapters.primatelj_porukaTableAdapter primatelj_porukaTableAdapter;
        private System.Windows.Forms.BindingSource primatelj_porukaBindingSource;
        private System.Windows.Forms.TextBox inputSifraPoruke;
        private System.Windows.Forms.TextBox inputNaslov;
        private System.Windows.Forms.TextBox inputSadrzajPoruke;
        private System.Windows.Forms.DateTimePicker inputDatum;
        private System.Windows.Forms.DataGridView dgvPopisKorisnika;
        private System.Windows.Forms.BindingSource korisnikBindingSource1;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkorisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}