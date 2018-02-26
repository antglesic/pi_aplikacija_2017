namespace PI_Projekt_SiM
{
    partial class frmSkladistarPoruke
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
            this.porukaTableAdapter1 = new PI_Projekt_SiM.DataSetPorukeTableAdapters.porukaTableAdapter();
            this.porukaPrikazTableAdapter1 = new PI_Projekt_SiM.DataSetPorukeTableAdapters.porukaPrikazTableAdapter();
            this.dataSetPoruke1 = new PI_Projekt_SiM.DataSetPoruke();
            this.posiljatelj_porukaTableAdapter1 = new PI_Projekt_SiM.DataSetPorukeTableAdapters.posiljatelj_porukaTableAdapter();
            this.primatelj_porukaTableAdapter1 = new PI_Projekt_SiM.DataSetPorukeTableAdapters.primatelj_porukaTableAdapter();
            this.porukaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new PI_Projekt_SiM.DataSetPorukeTableAdapters.TableAdapterManager();
            this.porukaPrikazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvPopisPoruka = new System.Windows.Forms.DataGridView();
            this.idporukaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porukaPrikazBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.outputSadrzajPoruke = new System.Windows.Forms.TextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.grbPopisPoruka = new System.Windows.Forms.GroupBox();
            this.grbSadrzajPoruke = new System.Windows.Forms.GroupBox();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPoruke1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaPrikazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisPoruka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaPrikazBindingSource1)).BeginInit();
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
            // porukaTableAdapter1
            // 
            this.porukaTableAdapter1.ClearBeforeFill = true;
            // 
            // porukaPrikazTableAdapter1
            // 
            this.porukaPrikazTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSetPoruke1
            // 
            this.dataSetPoruke1.DataSetName = "DataSetPoruke";
            this.dataSetPoruke1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // posiljatelj_porukaTableAdapter1
            // 
            this.posiljatelj_porukaTableAdapter1.ClearBeforeFill = true;
            // 
            // primatelj_porukaTableAdapter1
            // 
            this.primatelj_porukaTableAdapter1.ClearBeforeFill = true;
            // 
            // porukaBindingSource
            // 
            this.porukaBindingSource.DataMember = "poruka";
            this.porukaBindingSource.DataSource = this.dataSetPoruke1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.korisnikTableAdapter = null;
            this.tableAdapterManager.porukaTableAdapter = this.porukaTableAdapter1;
            this.tableAdapterManager.posiljatelj_porukaTableAdapter = this.posiljatelj_porukaTableAdapter1;
            this.tableAdapterManager.primatelj_porukaTableAdapter = this.primatelj_porukaTableAdapter1;
            this.tableAdapterManager.UpdateOrder = PI_Projekt_SiM.DataSetPorukeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // porukaPrikazBindingSource
            // 
            this.porukaPrikazBindingSource.DataMember = "porukaPrikaz";
            this.porukaPrikazBindingSource.DataSource = this.dataSetPoruke1;
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
            this.porukaPrikazBindingSource1.DataSource = this.dataSetPoruke1;
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
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPosalji.Location = new System.Drawing.Point(198, 431);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(101, 38);
            this.btnPosalji.TabIndex = 3;
            this.btnPosalji.Text = "Nova poruka";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObrisi.Location = new System.Drawing.Point(305, 431);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(101, 38);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // grbPopisPoruka
            // 
            this.grbPopisPoruka.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbPopisPoruka.Controls.Add(this.dgvPopisPoruka);
            this.grbPopisPoruka.Location = new System.Drawing.Point(198, 12);
            this.grbPopisPoruka.Name = "grbPopisPoruka";
            this.grbPopisPoruka.Size = new System.Drawing.Size(417, 206);
            this.grbPopisPoruka.TabIndex = 6;
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
            this.grbSadrzajPoruke.TabIndex = 7;
            this.grbSadrzajPoruke.TabStop = false;
            this.grbSadrzajPoruke.Text = "Sadržaj poruke";
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Location = new System.Drawing.Point(412, 431);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(101, 38);
            this.btnOsvjezi.TabIndex = 8;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // frmSkladistarPoruke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 478);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.grbSadrzajPoruke);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.grbPopisPoruka);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSkladistarPoruke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poruke";
            this.Load += new System.EventHandler(this.frmSkladistarPoruke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPoruke1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaPrikazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisPoruka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porukaPrikazBindingSource1)).EndInit();
            this.grbPopisPoruka.ResumeLayout(false);
            this.grbSadrzajPoruke.ResumeLayout(false);
            this.grbSadrzajPoruke.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private DataSetPorukeTableAdapters.porukaTableAdapter porukaTableAdapter1;
        private DataSetPorukeTableAdapters.porukaPrikazTableAdapter porukaPrikazTableAdapter1;
        private DataSetPoruke dataSetPoruke1;
        private DataSetPorukeTableAdapters.posiljatelj_porukaTableAdapter posiljatelj_porukaTableAdapter1;
        private DataSetPorukeTableAdapters.primatelj_porukaTableAdapter primatelj_porukaTableAdapter1;
        private System.Windows.Forms.BindingSource porukaBindingSource;
        private DataSetPorukeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource porukaPrikazBindingSource;
        private System.Windows.Forms.DataGridView dgvPopisPoruka;
        private System.Windows.Forms.BindingSource porukaPrikazBindingSource1;
        private System.Windows.Forms.TextBox outputSadrzajPoruke;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.GroupBox grbPopisPoruka;
        private System.Windows.Forms.GroupBox grbSadrzajPoruke;
        private System.Windows.Forms.DataGridViewTextBoxColumn idporukaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOsvjezi;
    }
}