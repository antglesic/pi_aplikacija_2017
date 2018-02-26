namespace PI_Projekt_SiM
{
    partial class frmGlavniPekarPocetna
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
            this.btnSkladiste = new System.Windows.Forms.Button();
            this.btnZahtjevnica = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.grbGlavniMeni = new System.Windows.Forms.GroupBox();
            this.btnPoruke = new System.Windows.Forms.Button();
            this.grbGlavniMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSkladiste
            // 
            this.btnSkladiste.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSkladiste.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkladiste.Location = new System.Drawing.Point(6, 19);
            this.btnSkladiste.Name = "btnSkladiste";
            this.btnSkladiste.Size = new System.Drawing.Size(333, 89);
            this.btnSkladiste.TabIndex = 1;
            this.btnSkladiste.Text = "Skladište";
            this.btnSkladiste.UseVisualStyleBackColor = false;
            this.btnSkladiste.Click += new System.EventHandler(this.btnSkladiste_Click);
            // 
            // btnZahtjevnica
            // 
            this.btnZahtjevnica.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZahtjevnica.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZahtjevnica.Location = new System.Drawing.Point(345, 19);
            this.btnZahtjevnica.Name = "btnZahtjevnica";
            this.btnZahtjevnica.Size = new System.Drawing.Size(333, 89);
            this.btnZahtjevnica.TabIndex = 2;
            this.btnZahtjevnica.Text = "Zahtjevnice";
            this.btnZahtjevnica.UseVisualStyleBackColor = false;
            this.btnZahtjevnica.Click += new System.EventHandler(this.btnZahtjevnica_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdjava.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Location = new System.Drawing.Point(345, 115);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(333, 89);
            this.btnOdjava.TabIndex = 3;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // grbGlavniMeni
            // 
            this.grbGlavniMeni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbGlavniMeni.Controls.Add(this.btnPoruke);
            this.grbGlavniMeni.Controls.Add(this.btnSkladiste);
            this.grbGlavniMeni.Controls.Add(this.btnOdjava);
            this.grbGlavniMeni.Controls.Add(this.btnZahtjevnica);
            this.grbGlavniMeni.Location = new System.Drawing.Point(12, 12);
            this.grbGlavniMeni.Name = "grbGlavniMeni";
            this.grbGlavniMeni.Size = new System.Drawing.Size(687, 216);
            this.grbGlavniMeni.TabIndex = 5;
            this.grbGlavniMeni.TabStop = false;
            this.grbGlavniMeni.Text = "Glavni meni";
            // 
            // btnPoruke
            // 
            this.btnPoruke.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPoruke.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoruke.Location = new System.Drawing.Point(6, 114);
            this.btnPoruke.Name = "btnPoruke";
            this.btnPoruke.Size = new System.Drawing.Size(333, 89);
            this.btnPoruke.TabIndex = 4;
            this.btnPoruke.Text = "Poruke";
            this.btnPoruke.UseVisualStyleBackColor = false;
            this.btnPoruke.Click += new System.EventHandler(this.btnPoruke_Click);
            // 
            // frmGlavniPekarPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 239);
            this.Controls.Add(this.grbGlavniMeni);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGlavniPekarPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna stranica";
            this.Load += new System.EventHandler(this.frmGlavniPekarPocetna_Load);
            this.grbGlavniMeni.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSkladiste;
        private System.Windows.Forms.Button btnZahtjevnica;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.GroupBox grbGlavniMeni;
        private System.Windows.Forms.Button btnPoruke;
    }
}