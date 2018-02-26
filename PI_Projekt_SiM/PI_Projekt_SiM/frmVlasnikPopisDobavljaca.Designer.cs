namespace PI_Projekt_SiM
{
    partial class frmVlasnikPopisDobavljaca
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDobavljaci = new System.Windows.Forms.DataGridView();
            this.dobavljac2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSirovine = new PI_Projekt_SiM.DataSetSirovine();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnIzmjena = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnDodajNovog = new System.Windows.Forms.Button();
            this.dobavljac2TableAdapter = new PI_Projekt_SiM.DataSetSirovineTableAdapters.dobavljac2TableAdapter();
            this.btnPdf = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.iddobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivdobavljacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojtelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.dgvDobavljaci);
            this.groupBox1.Location = new System.Drawing.Point(198, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 275);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dobavljači";
            // 
            // dgvDobavljaci
            // 
            this.dgvDobavljaci.AllowUserToAddRows = false;
            this.dgvDobavljaci.AllowUserToDeleteRows = false;
            this.dgvDobavljaci.AutoGenerateColumns = false;
            this.dgvDobavljaci.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDobavljaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDobavljaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddobavljacDataGridViewTextBoxColumn,
            this.nazivdobavljacaDataGridViewTextBoxColumn,
            this.gradDataGridViewTextBoxColumn,
            this.brojtelefonaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvDobavljaci.DataSource = this.dobavljac2BindingSource;
            this.dgvDobavljaci.Location = new System.Drawing.Point(6, 20);
            this.dgvDobavljaci.Name = "dgvDobavljaci";
            this.dgvDobavljaci.ReadOnly = true;
            this.dgvDobavljaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDobavljaci.Size = new System.Drawing.Size(584, 249);
            this.dgvDobavljaci.TabIndex = 12;
            this.dgvDobavljaci.SelectionChanged += new System.EventHandler(this.dgvDobavljaci_SelectionChanged);
            // 
            // dobavljac2BindingSource
            // 
            this.dobavljac2BindingSource.DataMember = "dobavljac2";
            this.dobavljac2BindingSource.DataSource = this.dataSetSirovine;
            // 
            // dataSetSirovine
            // 
            this.dataSetSirovine.DataSetName = "DataSetSirovine";
            this.dataSetSirovine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsvjezi.Location = new System.Drawing.Point(571, 365);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(100, 38);
            this.btnOsvjezi.TabIndex = 30;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnIzmjena
            // 
            this.btnIzmjena.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIzmjena.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmjena.Location = new System.Drawing.Point(446, 365);
            this.btnIzmjena.Name = "btnIzmjena";
            this.btnIzmjena.Size = new System.Drawing.Size(119, 38);
            this.btnIzmjena.TabIndex = 29;
            this.btnIzmjena.Text = "Izmijeni podatke";
            this.btnIzmjena.UseVisualStyleBackColor = false;
            this.btnIzmjena.Click += new System.EventHandler(this.btnIzmjena_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIzbrisi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisi.Location = new System.Drawing.Point(321, 365);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(119, 38);
            this.btnIzbrisi.TabIndex = 28;
            this.btnIzbrisi.Text = "Obriši dobavljača";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnDodajNovog
            // 
            this.btnDodajNovog.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodajNovog.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNovog.Location = new System.Drawing.Point(196, 365);
            this.btnDodajNovog.Name = "btnDodajNovog";
            this.btnDodajNovog.Size = new System.Drawing.Size(119, 38);
            this.btnDodajNovog.TabIndex = 27;
            this.btnDodajNovog.Text = "Dodaj dobavljača";
            this.btnDodajNovog.UseVisualStyleBackColor = false;
            this.btnDodajNovog.Click += new System.EventHandler(this.btnDodajNovog_Click);
            // 
            // dobavljac2TableAdapter
            // 
            this.dobavljac2TableAdapter.ClearBeforeFill = true;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPdf.Location = new System.Drawing.Point(677, 365);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(81, 38);
            this.btnPdf.TabIndex = 31;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTrazi);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(198, 293);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 66);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tražilica";
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
            // iddobavljacDataGridViewTextBoxColumn
            // 
            this.iddobavljacDataGridViewTextBoxColumn.DataPropertyName = "id_dobavljac";
            this.iddobavljacDataGridViewTextBoxColumn.HeaderText = "Sifra dobavljaca";
            this.iddobavljacDataGridViewTextBoxColumn.Name = "iddobavljacDataGridViewTextBoxColumn";
            this.iddobavljacDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddobavljacDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nazivdobavljacaDataGridViewTextBoxColumn
            // 
            this.nazivdobavljacaDataGridViewTextBoxColumn.DataPropertyName = "naziv_dobavljaca";
            this.nazivdobavljacaDataGridViewTextBoxColumn.HeaderText = "Naziv dobavljaca";
            this.nazivdobavljacaDataGridViewTextBoxColumn.Name = "nazivdobavljacaDataGridViewTextBoxColumn";
            this.nazivdobavljacaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivdobavljacaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gradDataGridViewTextBoxColumn
            // 
            this.gradDataGridViewTextBoxColumn.DataPropertyName = "grad";
            this.gradDataGridViewTextBoxColumn.HeaderText = "Grad";
            this.gradDataGridViewTextBoxColumn.Name = "gradDataGridViewTextBoxColumn";
            this.gradDataGridViewTextBoxColumn.ReadOnly = true;
            this.gradDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // brojtelefonaDataGridViewTextBoxColumn
            // 
            this.brojtelefonaDataGridViewTextBoxColumn.DataPropertyName = "broj_telefona";
            this.brojtelefonaDataGridViewTextBoxColumn.HeaderText = "Broj telefona";
            this.brojtelefonaDataGridViewTextBoxColumn.Name = "brojtelefonaDataGridViewTextBoxColumn";
            this.brojtelefonaDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojtelefonaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmVlasnikPopisDobavljaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(810, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnIzmjena);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnDodajNovog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNatrag);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmVlasnikPopisDobavljaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis dobavljača";
            this.Load += new System.EventHandler(this.frmVlasnikPopisDobavljaca_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDobavljaci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljac2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSirovine)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDobavljaci;
        private DataSetSirovine dataSetSirovine;
        private System.Windows.Forms.BindingSource dobavljac2BindingSource;
        private DataSetSirovineTableAdapters.dobavljac2TableAdapter dobavljac2TableAdapter;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnIzmjena;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnDodajNovog;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrazi;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivdobavljacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojtelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}