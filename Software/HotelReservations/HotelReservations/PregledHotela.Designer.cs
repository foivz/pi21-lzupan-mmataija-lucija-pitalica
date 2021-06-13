
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
            this.buttonPregledajZaposlenika = new System.Windows.Forms.Button();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoteli)).BeginInit();
            this.SuspendLayout();
            // 
            // popisHotelaLabel
            // 
            this.popisHotelaLabel.AutoSize = true;
            this.popisHotelaLabel.BackColor = System.Drawing.Color.White;
            this.popisHotelaLabel.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold);
            this.popisHotelaLabel.Location = new System.Drawing.Point(420, 29);
            this.popisHotelaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.popisHotelaLabel.Name = "popisHotelaLabel";
            this.popisHotelaLabel.Size = new System.Drawing.Size(141, 23);
            this.popisHotelaLabel.TabIndex = 0;
            this.popisHotelaLabel.Text = "Popis hotela";
            // 
            // dataGridViewHoteli
            // 
            this.dataGridViewHoteli.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHoteli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoteli.Location = new System.Drawing.Point(20, 79);
            this.dataGridViewHoteli.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewHoteli.Name = "dataGridViewHoteli";
            this.dataGridViewHoteli.RowHeadersWidth = 51;
            this.dataGridViewHoteli.RowTemplate.Height = 24;
            this.dataGridViewHoteli.Size = new System.Drawing.Size(903, 152);
            this.dataGridViewHoteli.TabIndex = 1;
            // 
            // dodajHotelButton
            // 
            this.dodajHotelButton.BackColor = System.Drawing.Color.SteelBlue;
            this.dodajHotelButton.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.dodajHotelButton.Location = new System.Drawing.Point(220, 257);
            this.dodajHotelButton.Margin = new System.Windows.Forms.Padding(2);
            this.dodajHotelButton.Name = "dodajHotelButton";
            this.dodajHotelButton.Size = new System.Drawing.Size(126, 52);
            this.dodajHotelButton.TabIndex = 2;
            this.dodajHotelButton.Text = "Dodaj hotel";
            this.dodajHotelButton.UseVisualStyleBackColor = false;
            this.dodajHotelButton.Click += new System.EventHandler(this.dodajHotelButton_Click);
            // 
            // azurirajHotelButton
            // 
            this.azurirajHotelButton.BackColor = System.Drawing.Color.SteelBlue;
            this.azurirajHotelButton.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.azurirajHotelButton.Location = new System.Drawing.Point(361, 257);
            this.azurirajHotelButton.Margin = new System.Windows.Forms.Padding(2);
            this.azurirajHotelButton.Name = "azurirajHotelButton";
            this.azurirajHotelButton.Size = new System.Drawing.Size(126, 52);
            this.azurirajHotelButton.TabIndex = 3;
            this.azurirajHotelButton.Text = "Ažuriraj hotel";
            this.azurirajHotelButton.UseVisualStyleBackColor = false;
            this.azurirajHotelButton.Click += new System.EventHandler(this.azurirajHotelButton_Click);
            // 
            // obrisiHotelButton
            // 
            this.obrisiHotelButton.BackColor = System.Drawing.Color.SteelBlue;
            this.obrisiHotelButton.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.obrisiHotelButton.Location = new System.Drawing.Point(508, 257);
            this.obrisiHotelButton.Margin = new System.Windows.Forms.Padding(2);
            this.obrisiHotelButton.Name = "obrisiHotelButton";
            this.obrisiHotelButton.Size = new System.Drawing.Size(126, 52);
            this.obrisiHotelButton.TabIndex = 4;
            this.obrisiHotelButton.Text = "Obriši hotel";
            this.obrisiHotelButton.UseVisualStyleBackColor = false;
            this.obrisiHotelButton.Click += new System.EventHandler(this.obrisiHotelButton_Click);
            // 
            // buttonPregledSobe
            // 
            this.buttonPregledSobe.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPregledSobe.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonPregledSobe.Location = new System.Drawing.Point(658, 257);
            this.buttonPregledSobe.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPregledSobe.Name = "buttonPregledSobe";
            this.buttonPregledSobe.Size = new System.Drawing.Size(126, 52);
            this.buttonPregledSobe.TabIndex = 5;
            this.buttonPregledSobe.Text = "Pregledaj sobe";
            this.buttonPregledSobe.UseVisualStyleBackColor = false;
            this.buttonPregledSobe.Click += new System.EventHandler(this.buttonPregledSobe_Click);
            // 
            // buttonPregledajZaposlenika
            // 
            this.buttonPregledajZaposlenika.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPregledajZaposlenika.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonPregledajZaposlenika.Location = new System.Drawing.Point(795, 257);
            this.buttonPregledajZaposlenika.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPregledajZaposlenika.Name = "buttonPregledajZaposlenika";
            this.buttonPregledajZaposlenika.Size = new System.Drawing.Size(126, 52);
            this.buttonPregledajZaposlenika.TabIndex = 7;
            this.buttonPregledajZaposlenika.Text = "Pregledaj zaposlenike";
            this.buttonPregledajZaposlenika.UseVisualStyleBackColor = false;
            this.buttonPregledajZaposlenika.Click += new System.EventHandler(this.buttonPregledajZaposlenika_Click);
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.SteelBlue;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.roundButtonNatrag.Location = new System.Drawing.Point(32, 270);
            this.roundButtonNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(41, 39);
            this.roundButtonNatrag.TabIndex = 104;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // PregledHotela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Projekt_faza_1.Properties.Resources.backgroundLogin;
            this.ClientSize = new System.Drawing.Size(968, 344);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.buttonPregledajZaposlenika);
            this.Controls.Add(this.buttonPregledSobe);
            this.Controls.Add(this.obrisiHotelButton);
            this.Controls.Add(this.azurirajHotelButton);
            this.Controls.Add(this.dodajHotelButton);
            this.Controls.Add(this.dataGridViewHoteli);
            this.Controls.Add(this.popisHotelaLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PregledHotela";
            this.Text = "Pregled hotela";
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
        private System.Windows.Forms.Button buttonPregledajZaposlenika;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
    }
}