
namespace Projekt_faza_1
{
    partial class Prijava
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
            this.dodajSliku = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.checkBoxPrikaziLozinku = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajSliku
            // 
            this.dodajSliku.FileName = "DodajSliku";
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKorisnickoIme.Font = new System.Drawing.Font("Lucida Sans", 15F);
            this.labelKorisnickoIme.Location = new System.Drawing.Point(77, 333);
            this.labelKorisnickoIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(159, 23);
            this.labelKorisnickoIme.TabIndex = 2;
            this.labelKorisnickoIme.Text = "Korisničko ime:";
            // 
            // textBoxKorisnickoIme
            // 
            this.textBoxKorisnickoIme.Location = new System.Drawing.Point(267, 333);
            this.textBoxKorisnickoIme.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            this.textBoxKorisnickoIme.Size = new System.Drawing.Size(182, 20);
            this.textBoxKorisnickoIme.TabIndex = 3;
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Font = new System.Drawing.Font("Lucida Sans", 15F);
            this.labelLozinka.Location = new System.Drawing.Point(141, 372);
            this.labelLozinka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(92, 23);
            this.labelLozinka.TabIndex = 4;
            this.labelLozinka.Text = "Lozinka:";
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(267, 375);
            this.textBoxLozinka.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(182, 20);
            this.textBoxLozinka.TabIndex = 5;
            this.textBoxLozinka.UseSystemPasswordChar = true;
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPrijava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrijava.Font = new System.Drawing.Font("Lucida Sans", 15F);
            this.buttonPrijava.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPrijava.Location = new System.Drawing.Point(176, 445);
            this.buttonPrijava.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(274, 46);
            this.buttonPrijava.TabIndex = 6;
            this.buttonPrijava.Text = "Prijava";
            this.buttonPrijava.UseVisualStyleBackColor = false;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click_1);
            // 
            // odustaniButton
            // 
            this.odustaniButton.BackColor = System.Drawing.Color.SteelBlue;
            this.odustaniButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.odustaniButton.Font = new System.Drawing.Font("Lucida Sans", 15F);
            this.odustaniButton.Location = new System.Drawing.Point(176, 495);
            this.odustaniButton.Margin = new System.Windows.Forms.Padding(2);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(274, 50);
            this.odustaniButton.TabIndex = 8;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = false;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // checkBoxPrikaziLozinku
            // 
            this.checkBoxPrikaziLozinku.AutoSize = true;
            this.checkBoxPrikaziLozinku.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.checkBoxPrikaziLozinku.Location = new System.Drawing.Point(471, 372);
            this.checkBoxPrikaziLozinku.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxPrikaziLozinku.Name = "checkBoxPrikaziLozinku";
            this.checkBoxPrikaziLozinku.Size = new System.Drawing.Size(102, 18);
            this.checkBoxPrikaziLozinku.TabIndex = 9;
            this.checkBoxPrikaziLozinku.Text = "Prikaži lozinku";
            this.checkBoxPrikaziLozinku.UseVisualStyleBackColor = true;
            this.checkBoxPrikaziLozinku.CheckedChanged += new System.EventHandler(this.checkBoxPrikaziLozinku_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projekt_faza_1.Properties.Resources.user_profile;
            this.pictureBox2.Location = new System.Drawing.Point(191, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 215);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_faza_1.Properties.Resources.backgroundLogin;
            this.ClientSize = new System.Drawing.Size(632, 622);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkBoxPrikaziLozinku);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.labelLozinka);
            this.Controls.Add(this.textBoxKorisnickoIme);
            this.Controls.Add(this.labelKorisnickoIme);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Prijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog dodajSliku;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.CheckBox checkBoxPrikaziLozinku;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

