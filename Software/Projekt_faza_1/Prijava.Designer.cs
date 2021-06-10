
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dodajSliku = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.textBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.checkBoxPrikaziLozinku = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projekt_faza_1.Properties.Resources.JadranHoteli;
            this.pictureBox2.Location = new System.Drawing.Point(268, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(616, 176);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // dodajSliku
            // 
            this.dodajSliku.FileName = "DodajSliku";
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelKorisnickoIme.Location = new System.Drawing.Point(48, 172);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(187, 29);
            this.labelKorisnickoIme.TabIndex = 2;
            this.labelKorisnickoIme.Text = "Korisničko ime:";
            // 
            // textBoxKorisnickoIme
            // 
            this.textBoxKorisnickoIme.Location = new System.Drawing.Point(253, 180);
            this.textBoxKorisnickoIme.Name = "textBoxKorisnickoIme";
            this.textBoxKorisnickoIme.Size = new System.Drawing.Size(195, 22);
            this.textBoxKorisnickoIme.TabIndex = 3;
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelLozinka.Location = new System.Drawing.Point(48, 223);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(108, 29);
            this.labelLozinka.TabIndex = 4;
            this.labelLozinka.Text = "Lozinka:";
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(253, 231);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(195, 22);
            this.textBoxLozinka.TabIndex = 5;
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.BackColor = System.Drawing.Color.DimGray;
            this.buttonPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonPrijava.Location = new System.Drawing.Point(27, 305);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(263, 62);
            this.buttonPrijava.TabIndex = 6;
            this.buttonPrijava.Text = "Prijava";
            this.buttonPrijava.UseVisualStyleBackColor = false;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(296, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 62);
            this.button2.TabIndex = 7;
            this.button2.Text = "Zaboravljena lozinka";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // odustaniButton
            // 
            this.odustaniButton.BackColor = System.Drawing.Color.DimGray;
            this.odustaniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.odustaniButton.Location = new System.Drawing.Point(565, 305);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(263, 62);
            this.odustaniButton.TabIndex = 8;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = false;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // checkBoxPrikaziLozinku
            // 
            this.checkBoxPrikaziLozinku.AutoSize = true;
            this.checkBoxPrikaziLozinku.Location = new System.Drawing.Point(503, 230);
            this.checkBoxPrikaziLozinku.Name = "checkBoxPrikaziLozinku";
            this.checkBoxPrikaziLozinku.Size = new System.Drawing.Size(120, 21);
            this.checkBoxPrikaziLozinku.TabIndex = 9;
            this.checkBoxPrikaziLozinku.Text = "Prikazi lozinku";
            this.checkBoxPrikaziLozinku.UseVisualStyleBackColor = true;
            this.checkBoxPrikaziLozinku.CheckedChanged += new System.EventHandler(this.checkBoxPrikaziLozinku_CheckedChanged);
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 416);
            this.Controls.Add(this.checkBoxPrikaziLozinku);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonPrijava);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.labelLozinka);
            this.Controls.Add(this.textBoxKorisnickoIme);
            this.Controls.Add(this.labelKorisnickoIme);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Prijava";
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.Prijava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.OpenFileDialog dodajSliku;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.TextBox textBoxKorisnickoIme;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.CheckBox checkBoxPrikaziLozinku;
    }
}

