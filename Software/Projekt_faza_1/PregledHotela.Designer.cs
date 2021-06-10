
namespace Projekt_faza_1
{
    partial class PregledHotela
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
            this.popisHotelaLabel = new System.Windows.Forms.Label();
            this.dataGridViewHoteli = new System.Windows.Forms.DataGridView();
            this.dodajHotelButton = new System.Windows.Forms.Button();
            this.azurirajHotelButton = new System.Windows.Forms.Button();
            this.obrisiHotelButton = new System.Windows.Forms.Button();
            this.buttonPregledSobe = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.buttonPregledajZaposlenika = new System.Windows.Forms.Button();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoteli)).BeginInit();
            this.SuspendLayout();
            // 
            // popisHotelaLabel
            // 
            this.popisHotelaLabel.AutoSize = true;
            this.popisHotelaLabel.BackColor = System.Drawing.Color.White;
            this.popisHotelaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popisHotelaLabel.Location = new System.Drawing.Point(560, 36);
            this.popisHotelaLabel.Name = "popisHotelaLabel";
            this.popisHotelaLabel.Size = new System.Drawing.Size(165, 29);
            this.popisHotelaLabel.TabIndex = 0;
            this.popisHotelaLabel.Text = "Popis hotela";
            // 
            // dataGridViewHoteli
            // 
            this.dataGridViewHoteli.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridViewHoteli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoteli.Location = new System.Drawing.Point(26, 97);
            this.dataGridViewHoteli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHoteli.Name = "dataGridViewHoteli";
            this.dataGridViewHoteli.RowHeadersWidth = 51;
            this.dataGridViewHoteli.RowTemplate.Height = 24;
            this.dataGridViewHoteli.Size = new System.Drawing.Size(1204, 187);
            this.dataGridViewHoteli.TabIndex = 1;
            // 
            // dodajHotelButton
            // 
            this.dodajHotelButton.BackColor = System.Drawing.Color.DimGray;
            this.dodajHotelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dodajHotelButton.Location = new System.Drawing.Point(110, 307);
            this.dodajHotelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodajHotelButton.Name = "dodajHotelButton";
            this.dodajHotelButton.Size = new System.Drawing.Size(168, 64);
            this.dodajHotelButton.TabIndex = 2;
            this.dodajHotelButton.Text = "Dodaj hotel";
            this.dodajHotelButton.UseVisualStyleBackColor = false;
            this.dodajHotelButton.Click += new System.EventHandler(this.dodajHotelButton_Click);
            // 
            // azurirajHotelButton
            // 
            this.azurirajHotelButton.BackColor = System.Drawing.Color.DimGray;
            this.azurirajHotelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.azurirajHotelButton.Location = new System.Drawing.Point(297, 307);
            this.azurirajHotelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.azurirajHotelButton.Name = "azurirajHotelButton";
            this.azurirajHotelButton.Size = new System.Drawing.Size(168, 64);
            this.azurirajHotelButton.TabIndex = 3;
            this.azurirajHotelButton.Text = "Ažuriraj hotel";
            this.azurirajHotelButton.UseVisualStyleBackColor = false;
            this.azurirajHotelButton.Click += new System.EventHandler(this.azurirajHotelButton_Click);
            // 
            // obrisiHotelButton
            // 
            this.obrisiHotelButton.BackColor = System.Drawing.Color.DimGray;
            this.obrisiHotelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.obrisiHotelButton.Location = new System.Drawing.Point(493, 307);
            this.obrisiHotelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obrisiHotelButton.Name = "obrisiHotelButton";
            this.obrisiHotelButton.Size = new System.Drawing.Size(168, 64);
            this.obrisiHotelButton.TabIndex = 4;
            this.obrisiHotelButton.Text = "Obriši hotel";
            this.obrisiHotelButton.UseVisualStyleBackColor = false;
            this.obrisiHotelButton.Click += new System.EventHandler(this.obrisiHotelButton_Click);
            // 
            // buttonPregledSobe
            // 
            this.buttonPregledSobe.BackColor = System.Drawing.Color.DimGray;
            this.buttonPregledSobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonPregledSobe.Location = new System.Drawing.Point(694, 307);
            this.buttonPregledSobe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPregledSobe.Name = "buttonPregledSobe";
            this.buttonPregledSobe.Size = new System.Drawing.Size(168, 64);
            this.buttonPregledSobe.TabIndex = 5;
            this.buttonPregledSobe.Text = "Pregledaj sobe";
            this.buttonPregledSobe.UseVisualStyleBackColor = false;
            this.buttonPregledSobe.Click += new System.EventHandler(this.buttonPregledSobe_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.BackColor = System.Drawing.Color.DimGray;
            this.buttonOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOdustani.Location = new System.Drawing.Point(1062, 307);
            this.buttonOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(168, 64);
            this.buttonOdustani.TabIndex = 6;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = false;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // buttonPregledajZaposlenika
            // 
            this.buttonPregledajZaposlenika.BackColor = System.Drawing.Color.DimGray;
            this.buttonPregledajZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonPregledajZaposlenika.Location = new System.Drawing.Point(876, 307);
            this.buttonPregledajZaposlenika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPregledajZaposlenika.Name = "buttonPregledajZaposlenika";
            this.buttonPregledajZaposlenika.Size = new System.Drawing.Size(168, 64);
            this.buttonPregledajZaposlenika.TabIndex = 7;
            this.buttonPregledajZaposlenika.Text = "Pregledaj zaposlenike";
            this.buttonPregledajZaposlenika.UseVisualStyleBackColor = false;
            this.buttonPregledajZaposlenika.Click += new System.EventHandler(this.buttonPregledajZaposlenika_Click);
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.Thistle;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonNatrag.Location = new System.Drawing.Point(26, 316);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(55, 48);
            this.roundButtonNatrag.TabIndex = 104;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // PregledHotela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 528);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.buttonPregledajZaposlenika);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonPregledSobe);
            this.Controls.Add(this.obrisiHotelButton);
            this.Controls.Add(this.azurirajHotelButton);
            this.Controls.Add(this.dodajHotelButton);
            this.Controls.Add(this.dataGridViewHoteli);
            this.Controls.Add(this.popisHotelaLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PregledHotela";
            this.Text = "PregledHotela";
            this.Load += new System.EventHandler(this.PregledHotela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoteli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisHotelaLabel;
        private System.Windows.Forms.DataGridView dataGridViewHoteli;
        private System.Windows.Forms.Button dodajHotelButton;
        private System.Windows.Forms.Button azurirajHotelButton;
        private System.Windows.Forms.Button obrisiHotelButton;
        private System.Windows.Forms.Button buttonPregledSobe;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Button buttonPregledajZaposlenika;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
    }
}