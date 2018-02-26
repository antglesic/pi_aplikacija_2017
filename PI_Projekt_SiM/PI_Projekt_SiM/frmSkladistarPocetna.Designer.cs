namespace PI_Projekt_SiM
{
    partial class frmSkladistarPocetna
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
            this.btnZahtjevniceVlasnik = new System.Windows.Forms.Button();
            this.btnZahtjevniceGlPekare = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.grbGlavniMeni = new System.Windows.Forms.GroupBox();
            this.btnOtpisnice = new System.Windows.Forms.Button();
            this.btnPoruke = new System.Windows.Forms.Button();
            this.btnPopisIzdatnice = new System.Windows.Forms.Button();
            this.btnPrimke = new System.Windows.Forms.Button();
            this.grbGlavniMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSkladiste
            // 
            this.btnSkladiste.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSkladiste.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkladiste.Location = new System.Drawing.Point(6, 20);
            this.btnSkladiste.Name = "btnSkladiste";
            this.btnSkladiste.Size = new System.Drawing.Size(333, 89);
            this.btnSkladiste.TabIndex = 0;
            this.btnSkladiste.TabStop = false;
            this.btnSkladiste.Text = "Skladište";
            this.btnSkladiste.UseVisualStyleBackColor = false;
            this.btnSkladiste.Click += new System.EventHandler(this.btnSkladiste_Click);
            // 
            // btnZahtjevniceVlasnik
            // 
            this.btnZahtjevniceVlasnik.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZahtjevniceVlasnik.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZahtjevniceVlasnik.Location = new System.Drawing.Point(345, 20);
            this.btnZahtjevniceVlasnik.Name = "btnZahtjevniceVlasnik";
            this.btnZahtjevniceVlasnik.Size = new System.Drawing.Size(333, 89);
            this.btnZahtjevniceVlasnik.TabIndex = 1;
            this.btnZahtjevniceVlasnik.TabStop = false;
            this.btnZahtjevniceVlasnik.Text = "Zahtjevnice - vlasnik";
            this.btnZahtjevniceVlasnik.UseVisualStyleBackColor = false;
            this.btnZahtjevniceVlasnik.Click += new System.EventHandler(this.btnZahtjevnice_Click);
            // 
            // btnZahtjevniceGlPekare
            // 
            this.btnZahtjevniceGlPekare.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZahtjevniceGlPekare.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZahtjevniceGlPekare.Location = new System.Drawing.Point(6, 115);
            this.btnZahtjevniceGlPekare.Name = "btnZahtjevniceGlPekare";
            this.btnZahtjevniceGlPekare.Size = new System.Drawing.Size(333, 89);
            this.btnZahtjevniceGlPekare.TabIndex = 2;
            this.btnZahtjevniceGlPekare.TabStop = false;
            this.btnZahtjevniceGlPekare.Text = "Zahtjevnice - glavni pekar";
            this.btnZahtjevniceGlPekare.UseVisualStyleBackColor = false;
            this.btnZahtjevniceGlPekare.Click += new System.EventHandler(this.btnIzdatnice_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdjava.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.Location = new System.Drawing.Point(345, 305);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(333, 89);
            this.btnOdjava.TabIndex = 3;
            this.btnOdjava.TabStop = false;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // grbGlavniMeni
            // 
            this.grbGlavniMeni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbGlavniMeni.Controls.Add(this.btnOtpisnice);
            this.grbGlavniMeni.Controls.Add(this.btnPoruke);
            this.grbGlavniMeni.Controls.Add(this.btnPopisIzdatnice);
            this.grbGlavniMeni.Controls.Add(this.btnPrimke);
            this.grbGlavniMeni.Controls.Add(this.btnOdjava);
            this.grbGlavniMeni.Controls.Add(this.btnSkladiste);
            this.grbGlavniMeni.Controls.Add(this.btnZahtjevniceGlPekare);
            this.grbGlavniMeni.Controls.Add(this.btnZahtjevniceVlasnik);
            this.grbGlavniMeni.Location = new System.Drawing.Point(12, 12);
            this.grbGlavniMeni.Name = "grbGlavniMeni";
            this.grbGlavniMeni.Size = new System.Drawing.Size(687, 408);
            this.grbGlavniMeni.TabIndex = 4;
            this.grbGlavniMeni.TabStop = false;
            this.grbGlavniMeni.Text = "Glavni meni";
            // 
            // btnOtpisnice
            // 
            this.btnOtpisnice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOtpisnice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtpisnice.Location = new System.Drawing.Point(6, 305);
            this.btnOtpisnice.Name = "btnOtpisnice";
            this.btnOtpisnice.Size = new System.Drawing.Size(333, 89);
            this.btnOtpisnice.TabIndex = 7;
            this.btnOtpisnice.TabStop = false;
            this.btnOtpisnice.Text = "Otpisnice";
            this.btnOtpisnice.UseVisualStyleBackColor = false;
            this.btnOtpisnice.Click += new System.EventHandler(this.btnOtpisnice_Click);
            // 
            // btnPoruke
            // 
            this.btnPoruke.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPoruke.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoruke.Location = new System.Drawing.Point(345, 210);
            this.btnPoruke.Name = "btnPoruke";
            this.btnPoruke.Size = new System.Drawing.Size(333, 89);
            this.btnPoruke.TabIndex = 6;
            this.btnPoruke.TabStop = false;
            this.btnPoruke.Text = "Poruke";
            this.btnPoruke.UseVisualStyleBackColor = false;
            this.btnPoruke.Click += new System.EventHandler(this.btnPoruke_Click);
            // 
            // btnPopisIzdatnice
            // 
            this.btnPopisIzdatnice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPopisIzdatnice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopisIzdatnice.Location = new System.Drawing.Point(345, 115);
            this.btnPopisIzdatnice.Name = "btnPopisIzdatnice";
            this.btnPopisIzdatnice.Size = new System.Drawing.Size(333, 89);
            this.btnPopisIzdatnice.TabIndex = 5;
            this.btnPopisIzdatnice.TabStop = false;
            this.btnPopisIzdatnice.Text = "Izdatnice";
            this.btnPopisIzdatnice.UseVisualStyleBackColor = false;
            this.btnPopisIzdatnice.Click += new System.EventHandler(this.btnPopisIzdatnice_Click);
            // 
            // btnPrimke
            // 
            this.btnPrimke.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrimke.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimke.Location = new System.Drawing.Point(6, 210);
            this.btnPrimke.Name = "btnPrimke";
            this.btnPrimke.Size = new System.Drawing.Size(333, 89);
            this.btnPrimke.TabIndex = 4;
            this.btnPrimke.TabStop = false;
            this.btnPrimke.Text = "Primke";
            this.btnPrimke.UseVisualStyleBackColor = false;
            this.btnPrimke.Click += new System.EventHandler(this.btnPrimke_Click);
            // 
            // frmSkladistarPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 423);
            this.Controls.Add(this.grbGlavniMeni);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSkladistarPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna stranica";
            this.Load += new System.EventHandler(this.frmSkladistarPocetna_Load);
            this.grbGlavniMeni.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSkladiste;
        private System.Windows.Forms.Button btnZahtjevniceVlasnik;
        private System.Windows.Forms.Button btnZahtjevniceGlPekare;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.GroupBox grbGlavniMeni;
        private System.Windows.Forms.Button btnPrimke;
        private System.Windows.Forms.Button btnPopisIzdatnice;
        private System.Windows.Forms.Button btnPoruke;
        private System.Windows.Forms.Button btnOtpisnice;
    }
}