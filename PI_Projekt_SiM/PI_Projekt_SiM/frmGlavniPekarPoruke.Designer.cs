namespace PI_Projekt_SiM
{
    partial class frmGlavniPekarPoruke
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
            this.dgvPopisPoruka = new System.Windows.Forms.DataGridView();
            this.idporukaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porukaPrikazBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPoruke = new PI_Projekt_SiM.DataSetPoruke();
            this.outputSadrzajPoruke = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.porukaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.porukaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porukaTableAdapter = new PI_Projekt_SiM.DataSetPorukeTableAdapters.porukaTableAdapter();
            this.tableAdapterManager = new PI_Projekt_SiM.DataSetPorukeTableAdapters.TableAdapterManager();
            this.porukaPrikazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porukaPrikazTableAdapter = new PI_Projekt_SiM.DataSetPorukeTableAdapters.porukaPrikazTableAdapter();
            this.posiljatelj_porukaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.posiljatelj_porukaTableAdapter = new PI_Projekt_SiM.DataSetPorukeTableAdapters.posiljatelj_porukaTableAdapter();
            this.primatelj_porukaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.primatelj_porukaTableAdapter = new PI_Projekt_SiM.DataSetPorukeTableAdapters.primatelj_porukaTableAdapter();
            this.grbPopisPoruka = new System.Windows.Forms.GroupBox();
            this.grbSadrzajPoruke = new System.Windows.Forms.GroupBox();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisPoruka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaPrikazBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPoruke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaPrikazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posiljatelj_porukaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primatelj_porukaBindingSource)).BeginInit();
            this.grbPopisPoruka.SuspendLayout();
            this.grbSadrzajPoruke.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNatrag
            // 
            this.btnNatrag.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNatrag.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(180, 66);
            this.btnNatrag.TabIndex = 0;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = false;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // dgvPopisPoruka
            // 
            this.dgvPopisPoruka.AllowUserToAddRows = false;
            this.dgvPopisPoruka.AllowUserToDeleteRows = false;
            this.dgvPopisPoruka.AutoGenerateColumns = false;
            this.dgvPopisPoruka.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPopisPoruka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisPoruka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idporukaDataGridViewTextBoxColumn,
            this.naslovDataGridViewTextBoxColumn,
            this.datumkreiranjaDataGridViewTextBoxColumn});
            this.dgvPopisPoruka.DataSource = this.porukaPrikazBindingSource1;
            this.dgvPopisPoruka.Location = new System.Drawing.Point(6, 20);
            this.dgvPopisPoruka.Name = "dgvPopisPoruka";
            this.dgvPopisPoruka.ReadOnly = true;
            this.dgvPopisPoruka.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisPoruka.Size = new System.Drawing.Size(400, 173);
            this.dgvPopisPoruka.TabIndex = 1;
            this.dgvPopisPoruka.SelectionChanged += new System.EventHandler(this.dgvPopisPoruka_SelectionChanged);
            // 
            // idporukaDataGridViewTextBoxColumn
            // 
            this.idporukaDataGridViewTextBoxColumn.DataPropertyName = "id_poruka";
            this.idporukaDataGridViewTextBoxColumn.HeaderText = "Šifra poruke";
            this.idporukaDataGridViewTextBoxColumn.Name = "idporukaDataGridViewTextBoxColumn";
            this.idporukaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idporukaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // naslovDataGridViewTextBoxColumn
            // 
            this.naslovDataGridViewTextBoxColumn.DataPropertyName = "naslov";
            this.naslovDataGridViewTextBoxColumn.HeaderText = "Naslov poruke";
            this.naslovDataGridViewTextBoxColumn.Name = "naslovDataGridViewTextBoxColumn";
            this.naslovDataGridViewTextBoxColumn.ReadOnly = true;
            this.naslovDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // datumkreiranjaDataGridViewTextBoxColumn
            // 
            this.datumkreiranjaDataGridViewTextBoxColumn.DataPropertyName = "datum_kreiranja";
            this.datumkreiranjaDataGridViewTextBoxColumn.HeaderText = "Datum kreiranja";
            this.datumkreiranjaDataGridViewTextBoxColumn.Name = "datumkreiranjaDataGridViewTextBoxColumn";
            this.datumkreiranjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumkreiranjaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // porukaPrikazBindingSource1
            // 
            this.porukaPrikazBindingSource1.DataMember = "porukaPrikaz";
            this.porukaPrikazBindingSource1.DataSource = this.dataSetPoruke;
            // 
            // dataSetPoruke
            // 
            this.dataSetPoruke.DataSetName = "DataSetPoruke";
            this.dataSetPoruke.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // outputSadrzajPoruke
            // 
            this.outputSadrzajPoruke.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputSadrzajPoruke.ForeColor = System.Drawing.SystemColors.WindowText;
            this.outputSadrzajPoruke.Location = new System.Drawing.Point(6, 20);
            this.outputSadrzajPoruke.Multiline = true;
            this.outputSadrzajPoruke.Name = "outputSadrzajPoruke";
            this.outputSadrzajPoruke.ReadOnly = true;
            this.outputSadrzajPoruke.Size = new System.Drawing.Size(400, 172);
            this.outputSadrzajPoruke.TabIndex = 2;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObrisi.Location = new System.Drawing.Point(305, 431);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(101, 38);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPosalji.Location = new System.Drawing.Point(198, 431);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(101, 38);
            this.btnPosalji.TabIndex = 4;
            this.btnPosalji.Text = "Nova poruka";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // porukaBindingSource1
            // 
            this.porukaBindingSource1.DataMember = "poruka";
            this.porukaBindingSource1.DataSource = this.dataSetPoruke;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.korisnikTableAdapter = null;
            this.tableAdapterManager.porukaTableAdapter = this.porukaTableAdapter;
            this.tableAdapterManager.posiljatelj_porukaTableAdapter = null;
            this.tableAdapterManager.primatelj_porukaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PI_Projekt_SiM.DataSetPorukeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // grbPopisPoruka
            // 
            this.grbPopisPoruka.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbPopisPoruka.Controls.Add(this.dgvPopisPoruka);
            this.grbPopisPoruka.Location = new System.Drawing.Point(198, 12);
            this.grbPopisPoruka.Name = "grbPopisPoruka";
            this.grbPopisPoruka.Size = new System.Drawing.Size(417, 206);
            this.grbPopisPoruka.TabIndex = 7;
            this.grbPopisPoruka.TabStop = false;
            this.grbPopisPoruka.Text = "Popis poruka";
            // 
            // grbSadrzajPoruke
            // 
            this.grbSadrzajPoruke.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbSadrzajPoruke.Controls.Add(this.outputSadrzajPoruke);
            this.grbSadrzajPoruke.Location = new System.Drawing.Point(198, 224);
            this.grbSadrzajPoruke.Name = "grbSadrzajPoruke";
            this.grbSadrzajPoruke.Size = new System.Drawing.Size(417, 201);
            this.grbSadrzajPoruke.TabIndex = 8;
            this.grbSadrzajPoruke.TabStop = false;
            this.grbSadrzajPoruke.Text = "Sadržaj poruke";
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Location = new System.Drawing.Point(412, 431);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(101, 38);
            this.btnOsvjezi.TabIndex = 9;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // frmGlavniPekarPoruke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 478);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.grbSadrzajPoruke);
            this.Controls.Add(this.grbPopisPoruka);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnNatrag);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGlavniPekarPoruke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poruke";
            this.Load += new System.EventHandler(this.frmGlavniPekarPoruke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisPoruka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaPrikazBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPoruke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaPrikazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posiljatelj_porukaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primatelj_porukaBindingSource)).EndInit();
            this.grbPopisPoruka.ResumeLayout(false);
            this.grbSadrzajPoruke.ResumeLayout(false);
            this.grbSadrzajPoruke.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private DataSetPoruke dataSetPoruke;
        private System.Windows.Forms.BindingSource porukaBindingSource;
        private DataSetPorukeTableAdapters.porukaTableAdapter porukaTableAdapter;
        private DataSetPorukeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource porukaBindingSource1;
        private System.Windows.Forms.BindingSource porukaPrikazBindingSource;
        private DataSetPorukeTableAdapters.porukaPrikazTableAdapter porukaPrikazTableAdapter;
        private System.Windows.Forms.DataGridView dgvPopisPoruka;
        private System.Windows.Forms.BindingSource porukaPrikazBindingSource1;
        private System.Windows.Forms.TextBox outputSadrzajPoruke;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.BindingSource posiljatelj_porukaBindingSource;
        private DataSetPorukeTableAdapters.posiljatelj_porukaTableAdapter posiljatelj_porukaTableAdapter;
        private System.Windows.Forms.BindingSource primatelj_porukaBindingSource;
        private DataSetPorukeTableAdapters.primatelj_porukaTableAdapter primatelj_porukaTableAdapter;
        private System.Windows.Forms.GroupBox grbPopisPoruka;
        private System.Windows.Forms.GroupBox grbSadrzajPoruke;
        private System.Windows.Forms.DataGridViewTextBoxColumn idporukaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOsvjezi;
    }
}