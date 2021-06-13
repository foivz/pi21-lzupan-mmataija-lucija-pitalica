
namespace Projekt_faza_1
{
    partial class FrmGlavnaFormaAdmin
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
            this.pretraziButton = new System.Windows.Forms.Button();
            this.buttonDodajHotel = new System.Windows.Forms.Button();
            this.buttonPregledRezervacija = new System.Windows.Forms.Button();
            this.buttonPrijaviSe = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pretraziButton
            // 
            this.pretraziButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pretraziButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pretraziButton.Location = new System.Drawing.Point(169, 288);
            this.pretraziButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pretraziButton.Name = "pretraziButton";
            this.pretraziButton.Size = new System.Drawing.Size(117, 65);
            this.pretraziButton.TabIndex = 3;
            this.pretraziButton.Text = "Pretraži hotele";
            this.pretraziButton.UseVisualStyleBackColor = true;
            this.pretraziButton.Click += new System.EventHandler(this.pretraziButton_Click);
            // 
            // buttonDodajHotel
            // 
            this.buttonDodajHotel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDodajHotel.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.buttonDodajHotel.Location = new System.Drawing.Point(292, 288);
            this.buttonDodajHotel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDodajHotel.Name = "buttonDodajHotel";
            this.buttonDodajHotel.Size = new System.Drawing.Size(108, 65);
            this.buttonDodajHotel.TabIndex = 5;
            this.buttonDodajHotel.Text = "Dodaj hotel";
            this.buttonDodajHotel.UseVisualStyleBackColor = true;
            this.buttonDodajHotel.Click += new System.EventHandler(this.buttonDodajHotel_Click);
            // 
            // buttonPregledRezervacija
            // 
            this.buttonPregledRezervacija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPregledRezervacija.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.buttonPregledRezervacija.Location = new System.Drawing.Point(405, 291);
            this.buttonPregledRezervacija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPregledRezervacija.Name = "buttonPregledRezervacija";
            this.buttonPregledRezervacija.Size = new System.Drawing.Size(107, 65);
            this.buttonPregledRezervacija.TabIndex = 11;
            this.buttonPregledRezervacija.Text = "Pregled rezervacija";
            this.buttonPregledRezervacija.UseVisualStyleBackColor = true;
            this.buttonPregledRezervacija.Click += new System.EventHandler(this.buttonPregledRezervacija_Click);
            // 
            // buttonPrijaviSe
            // 
            this.buttonPrijaviSe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrijaviSe.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrijaviSe.Location = new System.Drawing.Point(517, 289);
            this.buttonPrijaviSe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrijaviSe.Name = "buttonPrijaviSe";
            this.buttonPrijaviSe.Size = new System.Drawing.Size(120, 65);
            this.buttonPrijaviSe.TabIndex = 12;
            this.buttonPrijaviSe.Text = "Odjavi se";
            this.buttonPrijaviSe.UseVisualStyleBackColor = true;
            this.buttonPrijaviSe.Click += new System.EventHandler(this.buttonPrijaviSe_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projekt_faza_1.Properties.Resources.JadranHoteli;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 156);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGlavnaFormaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_faza_1.Properties.Resources.SlikaHotelaJadran;
            this.ClientSize = new System.Drawing.Size(763, 369);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPrijaviSe);
            this.Controls.Add(this.buttonPregledRezervacija);
            this.Controls.Add(this.buttonDodajHotel);
            this.Controls.Add(this.pretraziButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGlavnaFormaAdmin";
            this.Text = "Glavna forma";
            this.Load += new System.EventHandler(this.FrmGlavnaFormaAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button pretraziButton;
        private System.Windows.Forms.Button buttonDodajHotel;
        private System.Windows.Forms.Button buttonPregledRezervacija;
        private System.Windows.Forms.Button buttonPrijaviSe;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}