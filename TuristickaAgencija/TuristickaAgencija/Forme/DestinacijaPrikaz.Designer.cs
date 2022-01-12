
namespace TuristickaAgencija.Forme
{
    partial class DestinacijaPrikaz
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
            this.lblDestinacija = new System.Windows.Forms.Label();
            this.lblDrzava = new System.Windows.Forms.Label();
            this.lblBrStanovnika = new System.Windows.Forms.Label();
            this.lblDuzinaPlaze = new System.Windows.Forms.Label();
            this.lblMore = new System.Windows.Forms.Label();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.lbHoteli = new System.Windows.Forms.ListBox();
            this.btnIzaberiHotel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajHotel = new System.Windows.Forms.Button();
            this.btnIzbrisiHotel = new System.Windows.Forms.Button();
            this.btnAzurirajDestinaciju = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDestinacija
            // 
            this.lblDestinacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblDestinacija.Location = new System.Drawing.Point(242, 28);
            this.lblDestinacija.Name = "lblDestinacija";
            this.lblDestinacija.Size = new System.Drawing.Size(320, 45);
            this.lblDestinacija.TabIndex = 0;
            this.lblDestinacija.Text = "Destinacija";
            this.lblDestinacija.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDrzava
            // 
            this.lblDrzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDrzava.Location = new System.Drawing.Point(32, 76);
            this.lblDrzava.Name = "lblDrzava";
            this.lblDrzava.Size = new System.Drawing.Size(157, 27);
            this.lblDrzava.TabIndex = 1;
            this.lblDrzava.Text = "Drzava";
            this.lblDrzava.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrStanovnika
            // 
            this.lblBrStanovnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBrStanovnika.Location = new System.Drawing.Point(32, 119);
            this.lblBrStanovnika.Name = "lblBrStanovnika";
            this.lblBrStanovnika.Size = new System.Drawing.Size(157, 22);
            this.lblBrStanovnika.TabIndex = 2;
            this.lblBrStanovnika.Text = "broj stanovnika";
            this.lblBrStanovnika.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuzinaPlaze
            // 
            this.lblDuzinaPlaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDuzinaPlaze.Location = new System.Drawing.Point(32, 157);
            this.lblDuzinaPlaze.Name = "lblDuzinaPlaze";
            this.lblDuzinaPlaze.Size = new System.Drawing.Size(157, 23);
            this.lblDuzinaPlaze.TabIndex = 3;
            this.lblDuzinaPlaze.Text = "duzina plaze";
            this.lblDuzinaPlaze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMore
            // 
            this.lblMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMore.Location = new System.Drawing.Point(32, 200);
            this.lblMore.Name = "lblMore";
            this.lblMore.Size = new System.Drawing.Size(157, 27);
            this.lblMore.TabIndex = 4;
            this.lblMore.Text = "ima more?";
            this.lblMore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(35, 255);
            this.tbOpis.Multiline = true;
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.ReadOnly = true;
            this.tbOpis.Size = new System.Drawing.Size(245, 183);
            this.tbOpis.TabIndex = 5;
            // 
            // lbHoteli
            // 
            this.lbHoteli.FormattingEnabled = true;
            this.lbHoteli.Location = new System.Drawing.Point(554, 76);
            this.lbHoteli.Name = "lbHoteli";
            this.lbHoteli.Size = new System.Drawing.Size(234, 173);
            this.lbHoteli.TabIndex = 6;
            // 
            // btnIzaberiHotel
            // 
            this.btnIzaberiHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnIzaberiHotel.Location = new System.Drawing.Point(589, 255);
            this.btnIzaberiHotel.Name = "btnIzaberiHotel";
            this.btnIzaberiHotel.Size = new System.Drawing.Size(185, 41);
            this.btnIzaberiHotel.TabIndex = 7;
            this.btnIzaberiHotel.Text = "Izaberi Hotel";
            this.btnIzaberiHotel.UseVisualStyleBackColor = true;
            this.btnIzaberiHotel.Click += new System.EventHandler(this.BtnIzaberiHotel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Opis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDodajHotel
            // 
            this.btnDodajHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDodajHotel.Location = new System.Drawing.Point(589, 312);
            this.btnDodajHotel.Name = "btnDodajHotel";
            this.btnDodajHotel.Size = new System.Drawing.Size(185, 41);
            this.btnDodajHotel.TabIndex = 9;
            this.btnDodajHotel.Text = "Dodaj hotel";
            this.btnDodajHotel.UseVisualStyleBackColor = true;
            this.btnDodajHotel.Click += new System.EventHandler(this.BtnDodajHotel_Click);
            // 
            // btnIzbrisiHotel
            // 
            this.btnIzbrisiHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnIzbrisiHotel.Location = new System.Drawing.Point(589, 369);
            this.btnIzbrisiHotel.Name = "btnIzbrisiHotel";
            this.btnIzbrisiHotel.Size = new System.Drawing.Size(185, 41);
            this.btnIzbrisiHotel.TabIndex = 10;
            this.btnIzbrisiHotel.Text = "Izbrisi Hotel";
            this.btnIzbrisiHotel.UseVisualStyleBackColor = true;
            this.btnIzbrisiHotel.Click += new System.EventHandler(this.BtnIzbrisiHotel_Click);
            // 
            // btnAzurirajDestinaciju
            // 
            this.btnAzurirajDestinaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAzurirajDestinaciju.Location = new System.Drawing.Point(343, 397);
            this.btnAzurirajDestinaciju.Name = "btnAzurirajDestinaciju";
            this.btnAzurirajDestinaciju.Size = new System.Drawing.Size(170, 41);
            this.btnAzurirajDestinaciju.TabIndex = 11;
            this.btnAzurirajDestinaciju.Text = "Azuriraj destinaciju";
            this.btnAzurirajDestinaciju.UseVisualStyleBackColor = true;
            this.btnAzurirajDestinaciju.Click += new System.EventHandler(this.BtnAzurirajDestinaciju_Click);
            // 
            // DestinacijaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAzurirajDestinaciju);
            this.Controls.Add(this.btnIzbrisiHotel);
            this.Controls.Add(this.btnDodajHotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzaberiHotel);
            this.Controls.Add(this.lbHoteli);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.lblMore);
            this.Controls.Add(this.lblDuzinaPlaze);
            this.Controls.Add(this.lblBrStanovnika);
            this.Controls.Add(this.lblDrzava);
            this.Controls.Add(this.lblDestinacija);
            this.Name = "DestinacijaPrikaz";
            this.Text = "Destinacija";
            this.Load += new System.EventHandler(this.DestinacijaPrikaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDestinacija;
        private System.Windows.Forms.Label lblDrzava;
        private System.Windows.Forms.Label lblBrStanovnika;
        private System.Windows.Forms.Label lblDuzinaPlaze;
        private System.Windows.Forms.Label lblMore;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.ListBox lbHoteli;
        private System.Windows.Forms.Button btnIzaberiHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajHotel;
        private System.Windows.Forms.Button btnIzbrisiHotel;
        private System.Windows.Forms.Button btnAzurirajDestinaciju;
    }
}