
namespace Projekt_faza_1
{
    partial class FrmGlavnaFormaGost
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
            this.buttonNapraviRezervaciju = new System.Windows.Forms.Button();
            this.buttonPrikazRecenzija = new System.Windows.Forms.Button();
            this.buttonPregledKvarova = new System.Windows.Forms.Button();
            this.ButtonPretraziHotele = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNapraviRezervaciju
            // 
            this.buttonNapraviRezervaciju.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.buttonNapraviRezervaciju.Location = new System.Drawing.Point(481, 468);
            this.buttonNapraviRezervaciju.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNapraviRezervaciju.Name = "buttonNapraviRezervaciju";
            this.buttonNapraviRezervaciju.Size = new System.Drawing.Size(119, 59);
            this.buttonNapraviRezervaciju.TabIndex = 27;
            this.buttonNapraviRezervaciju.Text = "Napravi rezervaciju";
            this.buttonNapraviRezervaciju.UseVisualStyleBackColor = true;
            this.buttonNapraviRezervaciju.Click += new System.EventHandler(this.buttonNapraviRezervaciju_Click);
            // 
            // buttonPrikazRecenzija
            // 
            this.buttonPrikazRecenzija.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.buttonPrikazRecenzija.Location = new System.Drawing.Point(605, 468);
            this.buttonPrikazRecenzija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrikazRecenzija.Name = "buttonPrikazRecenzija";
            this.buttonPrikazRecenzija.Size = new System.Drawing.Size(116, 59);
            this.buttonPrikazRecenzija.TabIndex = 26;
            this.buttonPrikazRecenzija.Text = "Ostavi recenziju";
            this.buttonPrikazRecenzija.UseVisualStyleBackColor = true;
            this.buttonPrikazRecenzija.Click += new System.EventHandler(this.buttonPrikazRecenzija_Click);
            // 
            // buttonPregledKvarova
            // 
            this.buttonPregledKvarova.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.buttonPregledKvarova.Location = new System.Drawing.Point(727, 468);
            this.buttonPregledKvarova.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPregledKvarova.Name = "buttonPregledKvarova";
            this.buttonPregledKvarova.Size = new System.Drawing.Size(117, 59);
            this.buttonPregledKvarova.TabIndex = 25;
            this.buttonPregledKvarova.Text = "Prijavi kvar";
            this.buttonPregledKvarova.UseVisualStyleBackColor = true;
            this.buttonPregledKvarova.Click += new System.EventHandler(this.buttonPregledKvarova_Click);
            // 
            // ButtonPretraziHotele
            // 
            this.ButtonPretraziHotele.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.ButtonPretraziHotele.Location = new System.Drawing.Point(365, 468);
            this.ButtonPretraziHotele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonPretraziHotele.Name = "ButtonPretraziHotele";
            this.ButtonPretraziHotele.Size = new System.Drawing.Size(111, 59);
            this.ButtonPretraziHotele.TabIndex = 24;
            this.ButtonPretraziHotele.Text = "Pretraži hotele";
            this.ButtonPretraziHotele.UseVisualStyleBackColor = true;
            this.ButtonPretraziHotele.Click += new System.EventHandler(this.ButtonPretraziHotele_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projekt_faza_1.Properties.Resources.JadranHoteli;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 156);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.button1.Location = new System.Drawing.Point(207, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 59);
            this.button1.TabIndex = 30;
            this.button1.Text = "Prijavi se zaposlenik/admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Lucija\\Desktop\\HotelReservations\\HotelReservations\\HotelReservationsHelp" +
    ".chm";
            // 
            // FrmGlavnaFormaGost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_faza_1.Properties.Resources.SlikaHotelaJadran;
            this.ClientSize = new System.Drawing.Size(1023, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonNapraviRezervaciju);
            this.Controls.Add(this.buttonPrikazRecenzija);
            this.Controls.Add(this.buttonPregledKvarova);
            this.Controls.Add(this.ButtonPretraziHotele);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGlavnaFormaGost";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Početna";
            this.Load += new System.EventHandler(this.FrmGlavnaFormaGost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonNapraviRezervaciju;
        private System.Windows.Forms.Button buttonPrikazRecenzija;
        private System.Windows.Forms.Button buttonPregledKvarova;
        private System.Windows.Forms.Button ButtonPretraziHotele;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}