namespace PI_Projekt_SiM
{
    partial class frmSkladistarKreirajNovuPrimku
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
            this.grpPopis = new System.Windows.Forms.GroupBox();
            this.dgvPopisSirovina = new System.Windows.Forms.DataGridView();
            this.idsirovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivsirovineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roktrajanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jedinicnamjeraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPrimkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPrimke = new PI_Projekt_SiM.DataSetPrimke();
            this.grpKolicina = new System.Windows.Forms.GroupBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.inputKolicina = new System.Windows.Forms.TextBox();
            this.labelKolicina = new System.Windows.Forms.Label();
            this.sirovinaTableAdapter = new PI_Projekt_SiM.DataSetPrimkeTableAdapters.sirovinaTableAdapter();
            this.primka_sirovinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primka_sirovinaTableAdapter = new PI_Projekt_SiM.DataSetPrimkeTableAdapters.primka_sirovinaTableAdapter();
            this.tableAdapterManager = new PI_Projekt_SiM.DataSetPrimkeTableAdapters.TableAdapterManager();
            this.grpPopis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSirovina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrimkeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrimke)).BeginInit();
            this.grpKolicina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.primka_sirovinaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPopis
            // 
            this.grpPopis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpPopis.Controls.Add(this.dgvPopisSirovina);
            this.grpPopis.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPopis.Location = new System.Drawing.Point(12, 12);
            this.grpPopis.Name = "grpPopis";
            this.grpPopis.Size = new System.Drawing.Size(583, 336);
            this.grpPopis.TabIndex = 0;
            this.grpPopis.TabStop = false;
            this.grpPopis.Text = "Dodavanje sirovina";
            // 
            // dgvPopisSirovina
            // 
            this.dgvPopisSirovina.AllowUserToAddRows = false;
            this.dgvPopisSirovina.AllowUserToDeleteRows = false;
            this.dgvPopisSirovina.AutoGenerateColumns = false;
            this.dgvPopisSirovina.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPopisSirovina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisSirovina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsirovinaDataGridViewTextBoxColumn,
            this.nazivsirovineDataGridViewTextBoxColumn,
            this.roktrajanjaDataGridViewTextBoxColumn,
            this.jedinicnamjeraDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn});
            this.dgvPopisSirovina.DataSource = this.sirovinaBindingSource;
            this.dgvPopisSirovina.Location = new System.Drawing.Point(6, 20);
            this.dgvPopisSirovina.Name = "dgvPopisSirovina";
            this.dgvPopisSirovina.ReadOnly = true;
            this.dgvPopisSirovina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisSirovina.Size = new System.Drawing.Size(561, 307);
            this.dgvPopisSirovina.TabIndex = 0;
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
            // roktrajanjaDataGridViewTextBoxColumn
            // 
            this.roktrajanjaDataGridViewTextBoxColumn.DataPropertyName = "rok_trajanja";
            this.roktrajanjaDataGridViewTextBoxColumn.HeaderText = "Rok trajanja";
            this.roktrajanjaDataGridViewTextBoxColumn.Name = "roktrajanjaDataGridViewTextBoxColumn";
            this.roktrajanjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.roktrajanjaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // jedinicnamjeraDataGridViewTextBoxColumn
            // 
            this.jedinicnamjeraDataGridViewTextBoxColumn.DataPropertyName = "jedinicna_mjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.HeaderText = "Jedinična mjera";
            this.jedinicnamjeraDataGridViewTextBoxColumn.Name = "jedinicnamjeraDataGridViewTextBoxColumn";
            this.jedinicnamjeraDataGridViewTextBoxColumn.ReadOnly = true;
            this.jedinicnamjeraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.napomenaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sirovinaBindingSource
            // 
            this.sirovinaBindingSource.DataMember = "sirovina";
            this.sirovinaBindingSource.DataSource = this.dataSetPrimkeBindingSource;
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
            // grpKolicina
            // 
            this.grpKolicina.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpKolicina.Controls.Add(this.btnOdustani);
            this.grpKolicina.Controls.Add(this.btnDodaj);
            this.grpKolicina.Controls.Add(this.inputKolicina);
            this.grpKolicina.Controls.Add(this.labelKolicina);
            this.grpKolicina.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKolicina.Location = new System.Drawing.Point(12, 354);
            this.grpKolicina.Name = "grpKolicina";
            this.grpKolicina.Size = new System.Drawing.Size(391, 79);
            this.grpKolicina.TabIndex = 1;
            this.grpKolicina.TabStop = false;
            this.grpKolicina.Text = "Dodavanje količine";
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdustani.Location = new System.Drawing.Point(276, 19);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(96, 38);
            this.btnOdustani.TabIndex = 3;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodaj.Location = new System.Drawing.Point(174, 19);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(96, 38);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // inputKolicina
            // 
            this.inputKolicina.Location = new System.Drawing.Point(68, 28);
            this.inputKolicina.Name = "inputKolicina";
            this.inputKolicina.Size = new System.Drawing.Size(100, 21);
            this.inputKolicina.TabIndex = 1;
            // 
            // labelKolicina
            // 
            this.labelKolicina.AutoSize = true;
            this.labelKolicina.Location = new System.Drawing.Point(6, 31);
            this.labelKolicina.Name = "labelKolicina";
            this.labelKolicina.Size = new System.Drawing.Size(56, 15);
            this.labelKolicina.TabIndex = 0;
            this.labelKolicina.Text = "Količina:";
            // 
            // sirovinaTableAdapter
            // 
            this.sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // primka_sirovinaBindingSource
            // 
            this.primka_sirovinaBindingSource.DataMember = "primka_sirovina";
            this.primka_sirovinaBindingSource.DataSource = this.dataSetPrimke;
            // 
            // primka_sirovinaTableAdapter
            // 
            this.primka_sirovinaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dobavljacTableAdapter = null;
            this.tableAdapterManager.primkaTableAdapter = null;
            this.tableAdapterManager.sirovinaTableAdapter = this.sirovinaTableAdapter;
            this.tableAdapterManager.UpdateOrder = PI_Projekt_SiM.DataSetPrimkeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmSkladistarKreirajNovuPrimku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(603, 444);
            this.Controls.Add(this.grpKolicina);
            this.Controls.Add(this.grpPopis);
            this.Name = "frmSkladistarKreirajNovuPrimku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primka dodavanje sirovina";
            this.Load += new System.EventHandler(this.frmSkladistarKreirajNovuPrimku_Load);
            this.grpPopis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisSirovina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sirovinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrimkeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPrimke)).EndInit();
            this.grpKolicina.ResumeLayout(false);
            this.grpKolicina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.primka_sirovinaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPopis;
        private System.Windows.Forms.DataGridView dgvPopisSirovina;
        private System.Windows.Forms.BindingSource dataSetPrimkeBindingSource;
        private DataSetPrimke dataSetPrimke;
        private System.Windows.Forms.BindingSource sirovinaBindingSource;
        private DataSetPrimkeTableAdapters.sirovinaTableAdapter sirovinaTableAdapter;
        private System.Windows.Forms.GroupBox grpKolicina;
        private System.Windows.Forms.Label labelKolicina;
        private System.Windows.Forms.TextBox inputKolicina;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.BindingSource primka_sirovinaBindingSource;
        private DataSetPrimkeTableAdapters.primka_sirovinaTableAdapter primka_sirovinaTableAdapter;
        private DataSetPrimkeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsirovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivsirovineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roktrajanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jedinicnamjeraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
    }
}