namespace PI_Projekt_SiM
{
    partial class frmGlavniPekarPosaljiPoruku
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
            this.btnPosalji = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.labelSifra = new System.Windows.Forms.Label();
            this.labelPrimatelj = new System.Windows.Forms.Label();
            this.labelNaslov = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelSadrzaj = new System.Windows.Forms.Label();
            this.inputSifraPoruke = new System.Windows.Forms.TextBox();
            this.dgvPopisKorisnika = new System.Windows.Forms.DataGridView();
            this.korisnikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPoruke = new PI_Projekt_SiM.DataSetPoruke();
            this.inputNaslov = new System.Windows.Forms.TextBox();
            this.inputDatum = new System.Windows.Forms.DateTimePicker();
            this.inputSadrzaj = new System.Windows.Forms.TextBox();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new PI_Projekt_SiM.DataSetPorukeTableAdapters.korisnikTableAdapter();
            this.tableAdapterManager = new PI_Projekt_SiM.DataSetPorukeTableAdapters.TableAdapterManager();
            this.posiljatelj_porukaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posiljatelj_porukaTableAdapter = new PI_Projekt_SiM.DataSetPorukeTableAdapters.posiljatelj_porukaTableAdapter();
            this.primatelj_porukaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primatelj_porukaTableAdapter = new PI_Projekt_SiM.DataSetPorukeTableAdapters.primatelj_porukaTableAdapter();
            this.porukaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porukaTableAdapter = new PI_Projekt_SiM.DataSetPorukeTableAdapters.porukaTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idkorisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisKorisnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPoruke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posiljatelj_porukaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primatelj_porukaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPosalji.Location = new System.Drawing.Point(116, 526);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(88, 35);
            this.btnPosalji.TabIndex = 0;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click_1);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdustani.Location = new System.Drawing.Point(210, 526);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(88, 35);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // labelSifra
            // 
            this.labelSifra.AutoSize = true;
            this.labelSifra.Location = new System.Drawing.Point(32, 28);
            this.labelSifra.Name = "labelSifra";
            this.labelSifra.Size = new System.Drawing.Size(78, 15);
            this.labelSifra.TabIndex = 2;
            this.labelSifra.Text = "Šifra poruke:";
            // 
            // labelPrimatelj
            // 
            this.labelPrimatelj.AutoSize = true;
            this.labelPrimatelj.Location = new System.Drawing.Point(49, 63);
            this.labelPrimatelj.Name = "labelPrimatelj";
            this.labelPrimatelj.Size = new System.Drawing.Size(61, 15);
            this.labelPrimatelj.TabIndex = 3;
            this.labelPrimatelj.Text = "Primatelj:";
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Location = new System.Drawing.Point(64, 303);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(46, 15);
            this.labelNaslov.TabIndex = 4;
            this.labelNaslov.Text = "Naslov:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(63, 343);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(47, 15);
            this.labelDatum.TabIndex = 5;
            this.labelDatum.Text = "Datum:";
            // 
            // labelSadrzaj
            // 
            this.labelSadrzaj.AutoSize = true;
            this.labelSadrzaj.Location = new System.Drawing.Point(58, 379);
            this.labelSadrzaj.Name = "labelSadrzaj";
            this.labelSadrzaj.Size = new System.Drawing.Size(52, 15);
            this.labelSadrzaj.TabIndex = 6;
            this.labelSadrzaj.Text = "Sadržaj:";
            // 
            // inputSifraPoruke
            // 
            this.inputSifraPoruke.Location = new System.Drawing.Point(116, 25);
            this.inputSifraPoruke.Name = "inputSifraPoruke";
            this.inputSifraPoruke.Size = new System.Drawing.Size(72, 21);
            this.inputSifraPoruke.TabIndex = 7;
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
            this.dgvPopisKorisnika.Size = new System.Drawing.Size(402, 183);
            this.dgvPopisKorisnika.TabIndex = 8;
            // 
            // korisnikBindingSource1
            // 
            this.korisnikBindingSource1.DataMember = "korisnik";
            this.korisnikBindingSource1.DataSource = this.dataSetPoruke;
            // 
            // dataSetPoruke
            // 
            this.dataSetPoruke.DataSetName = "DataSetPoruke";
            this.dataSetPoruke.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inputNaslov
            // 
            this.inputNaslov.Location = new System.Drawing.Point(116, 300);
            this.inputNaslov.Name = "inputNaslov";
            this.inputNaslov.Size = new System.Drawing.Size(222, 21);
            this.inputNaslov.TabIndex = 9;
            // 
            // inputDatum
            // 
            this.inputDatum.Location = new System.Drawing.Point(116, 338);
            this.inputDatum.Name = "inputDatum";
            this.inputDatum.Size = new System.Drawing.Size(233, 21);
            this.inputDatum.TabIndex = 10;
            // 
            // inputSadrzaj
            // 
            this.inputSadrzaj.Location = new System.Drawing.Point(116, 376);
            this.inputSadrzaj.Multiline = true;
            this.inputSadrzaj.Name = "inputSadrzaj";
            this.inputSadrzaj.Size = new System.Drawing.Size(375, 144);
            this.inputSadrzaj.TabIndex = 11;
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
            this.tableAdapterManager.porukaTableAdapter = null;
            this.tableAdapterManager.posiljatelj_porukaTableAdapter = null;
            this.tableAdapterManager.primatelj_porukaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PI_Projekt_SiM.DataSetPorukeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // posiljatelj_porukaBindingSource
            // 
            this.posiljatelj_porukaBindingSource.DataMember = "posiljatelj_poruka";
            this.posiljatelj_porukaBindingSource.DataSource = this.dataSetPoruke;
            // 
            // posiljatelj_porukaTableAdapter
            // 
            this.posiljatelj_porukaTableAdapter.ClearBeforeFill = true;
            // 
            // primatelj_porukaBindingSource
            // 
            this.primatelj_porukaBindingSource.DataMember = "primatelj_poruka";
            this.primatelj_porukaBindingSource.DataSource = this.dataSetPoruke;
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
            // porukaTableAdapter
            // 
            this.porukaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.dgvPopisKorisnika);
            this.groupBox1.Location = new System.Drawing.Point(116, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 221);
            this.groupBox1.TabIndex = 12;
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
            // frmGlavniPekarPosaljiPoruku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(551, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputSadrzaj);
            this.Controls.Add(this.inputDatum);
            this.Controls.Add(this.inputNaslov);
            this.Controls.Add(this.inputSifraPoruke);
            this.Controls.Add(this.labelSadrzaj);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.labelNaslov);
            this.Controls.Add(this.labelPrimatelj);
            this.Controls.Add(this.labelSifra);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPosalji);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGlavniPekarPosaljiPoruku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova poruka";
            this.Load += new System.EventHandler(this.frmGlavniPekarPosaljiPoruku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisKorisnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPoruke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posiljatelj_porukaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primatelj_porukaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label labelSifra;
        private System.Windows.Forms.Label labelPrimatelj;
        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelSadrzaj;
        private System.Windows.Forms.TextBox inputSifraPoruke;
        private DataSetPoruke dataSetPoruke;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private DataSetPorukeTableAdapters.korisnikTableAdapter korisnikTableAdapter;
        private DataSetPorukeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvPopisKorisnika;
        private System.Windows.Forms.BindingSource korisnikBindingSource1;
        private System.Windows.Forms.TextBox inputNaslov;
        private System.Windows.Forms.DateTimePicker inputDatum;
        private System.Windows.Forms.TextBox inputSadrzaj;
        private System.Windows.Forms.BindingSource posiljatelj_porukaBindingSource;
        private DataSetPorukeTableAdapters.posiljatelj_porukaTableAdapter posiljatelj_porukaTableAdapter;
        private System.Windows.Forms.BindingSource primatelj_porukaBindingSource;
        private DataSetPorukeTableAdapters.primatelj_porukaTableAdapter primatelj_porukaTableAdapter;
        private System.Windows.Forms.BindingSource porukaBindingSource;
        private DataSetPorukeTableAdapters.porukaTableAdapter porukaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkorisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}