
namespace TuristickaAgencija.Forme
{
    partial class TuristickiVodicAzuriranje
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
            this.btnAzurirajVodica = new System.Windows.Forms.Button();
            this.tbNaDestinaciji = new System.Windows.Forms.TextBox();
            this.tbUTurizmu = new System.Windows.Forms.TextBox();
            this.tbJezici = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.lblOcena = new System.Windows.Forms.Label();
            this.lblUTurzimu = new System.Windows.Forms.Label();
            this.lblJezici = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAzurirajVodica
            // 
            this.btnAzurirajVodica.Location = new System.Drawing.Point(456, 92);
            this.btnAzurirajVodica.Name = "btnAzurirajVodica";
            this.btnAzurirajVodica.Size = new System.Drawing.Size(147, 42);
            this.btnAzurirajVodica.TabIndex = 51;
            this.btnAzurirajVodica.Text = "Azuriraj drzavu";
            this.btnAzurirajVodica.UseVisualStyleBackColor = true;
            this.btnAzurirajVodica.Click += new System.EventHandler(this.BtnAzurirajVodica_Click);
            // 
            // tbNaDestinaciji
            // 
            this.tbNaDestinaciji.Location = new System.Drawing.Point(552, 47);
            this.tbNaDestinaciji.Name = "tbNaDestinaciji";
            this.tbNaDestinaciji.Size = new System.Drawing.Size(51, 20);
            this.tbNaDestinaciji.TabIndex = 50;
            // 
            // tbUTurizmu
            // 
            this.tbUTurizmu.Location = new System.Drawing.Point(528, 10);
            this.tbUTurizmu.Name = "tbUTurizmu";
            this.tbUTurizmu.Size = new System.Drawing.Size(75, 20);
            this.tbUTurizmu.TabIndex = 49;
            // 
            // tbJezici
            // 
            this.tbJezici.Location = new System.Drawing.Point(108, 70);
            this.tbJezici.Multiline = true;
            this.tbJezici.Name = "tbJezici";
            this.tbJezici.Size = new System.Drawing.Size(305, 64);
            this.tbJezici.TabIndex = 48;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(123, 44);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.ReadOnly = true;
            this.tbPrezime.Size = new System.Drawing.Size(290, 20);
            this.tbPrezime.TabIndex = 47;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(123, 8);
            this.tbIme.Name = "tbIme";
            this.tbIme.ReadOnly = true;
            this.tbIme.Size = new System.Drawing.Size(290, 20);
            this.tbIme.TabIndex = 46;
            // 
            // lblOcena
            // 
            this.lblOcena.AutoSize = true;
            this.lblOcena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOcena.Location = new System.Drawing.Point(419, 47);
            this.lblOcena.Name = "lblOcena";
            this.lblOcena.Size = new System.Drawing.Size(127, 17);
            this.lblOcena.TabIndex = 45;
            this.lblOcena.Text = "Radi na destinaciji:";
            this.lblOcena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUTurzimu
            // 
            this.lblUTurzimu.AutoSize = true;
            this.lblUTurzimu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUTurzimu.Location = new System.Drawing.Point(419, 11);
            this.lblUTurzimu.Name = "lblUTurzimu";
            this.lblUTurzimu.Size = new System.Drawing.Size(103, 17);
            this.lblUTurzimu.TabIndex = 44;
            this.lblUTurzimu.Text = "Radi u turizmu:";
            this.lblUTurzimu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJezici
            // 
            this.lblJezici.AutoSize = true;
            this.lblJezici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblJezici.Location = new System.Drawing.Point(7, 92);
            this.lblJezici.Name = "lblJezici";
            this.lblJezici.Size = new System.Drawing.Size(94, 17);
            this.lblJezici.TabIndex = 43;
            this.lblJezici.Text = "Govori jezike:";
            this.lblJezici.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrezime.Location = new System.Drawing.Point(12, 44);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(108, 17);
            this.lblPrezime.TabIndex = 42;
            this.lblPrezime.Text = "Prezime vodica:";
            this.lblPrezime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIme.Location = new System.Drawing.Point(12, 9);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(79, 17);
            this.lblIme.TabIndex = 41;
            this.lblIme.Text = "Ime vodica:";
            this.lblIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TuristickiVodicAzuriranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 142);
            this.Controls.Add(this.btnAzurirajVodica);
            this.Controls.Add(this.tbNaDestinaciji);
            this.Controls.Add(this.tbUTurizmu);
            this.Controls.Add(this.tbJezici);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.lblOcena);
            this.Controls.Add(this.lblUTurzimu);
            this.Controls.Add(this.lblJezici);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Name = "TuristickiVodicAzuriranje";
            this.Text = "TuristickiVodicAzuriranje";
            this.Load += new System.EventHandler(this.TuristickiVodicAzuriranje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAzurirajVodica;
        private System.Windows.Forms.TextBox tbNaDestinaciji;
        private System.Windows.Forms.TextBox tbUTurizmu;
        private System.Windows.Forms.TextBox tbJezici;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label lblOcena;
        private System.Windows.Forms.Label lblUTurzimu;
        private System.Windows.Forms.Label lblJezici;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
    }
}