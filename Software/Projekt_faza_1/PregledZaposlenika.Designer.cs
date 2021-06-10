
namespace Projekt_faza_1
{
    partial class PregledZaposlenika
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
            this.obrisiZaposlenikaButton = new System.Windows.Forms.Button();
            this.azurirajPodatkeButton = new System.Windows.Forms.Button();
            this.buttonDodajZaposlenika = new System.Windows.Forms.Button();
            this.dataGridViewZaposlenik = new System.Windows.Forms.DataGridView();
            this.popisSobaLabel = new System.Windows.Forms.Label();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposlenik)).BeginInit();
            this.SuspendLayout();
            // 
            // obrisiZaposlenikaButton
            // 
            this.obrisiZaposlenikaButton.BackColor = System.Drawing.Color.DimGray;
            this.obrisiZaposlenikaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.obrisiZaposlenikaButton.Location = new System.Drawing.Point(820, 294);
            this.obrisiZaposlenikaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obrisiZaposlenikaButton.Name = "obrisiZaposlenikaButton";
            this.obrisiZaposlenikaButton.Size = new System.Drawing.Size(168, 64);
            this.obrisiZaposlenikaButton.TabIndex = 13;
            this.obrisiZaposlenikaButton.Text = "Obriši zaposlenika";
            this.obrisiZaposlenikaButton.UseVisualStyleBackColor = false;
            this.obrisiZaposlenikaButton.Click += new System.EventHandler(this.obrisiZaposlenikaButton_Click);
            // 
            // azurirajPodatkeButton
            // 
            this.azurirajPodatkeButton.BackColor = System.Drawing.Color.DimGray;
            this.azurirajPodatkeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.azurirajPodatkeButton.Location = new System.Drawing.Point(628, 294);
            this.azurirajPodatkeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.azurirajPodatkeButton.Name = "azurirajPodatkeButton";
            this.azurirajPodatkeButton.Size = new System.Drawing.Size(168, 64);
            this.azurirajPodatkeButton.TabIndex = 12;
            this.azurirajPodatkeButton.Text = "Ažuriraj podatke";
            this.azurirajPodatkeButton.UseVisualStyleBackColor = false;
            this.azurirajPodatkeButton.Click += new System.EventHandler(this.azurirajPodatkeButton_Click);
            // 
            // buttonDodajZaposlenika
            // 
            this.buttonDodajZaposlenika.BackColor = System.Drawing.Color.DimGray;
            this.buttonDodajZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDodajZaposlenika.Location = new System.Drawing.Point(433, 294);
            this.buttonDodajZaposlenika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDodajZaposlenika.Name = "buttonDodajZaposlenika";
            this.buttonDodajZaposlenika.Size = new System.Drawing.Size(168, 64);
            this.buttonDodajZaposlenika.TabIndex = 11;
            this.buttonDodajZaposlenika.Text = "Dodaj zaposlenika";
            this.buttonDodajZaposlenika.UseVisualStyleBackColor = false;
            this.buttonDodajZaposlenika.Click += new System.EventHandler(this.buttonDodajZaposlenika_Click);
            // 
            // dataGridViewZaposlenik
            // 
            this.dataGridViewZaposlenik.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridViewZaposlenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZaposlenik.Location = new System.Drawing.Point(27, 81);
            this.dataGridViewZaposlenik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewZaposlenik.Name = "dataGridViewZaposlenik";
            this.dataGridViewZaposlenik.RowHeadersWidth = 51;
            this.dataGridViewZaposlenik.RowTemplate.Height = 24;
            this.dataGridViewZaposlenik.Size = new System.Drawing.Size(1148, 187);
            this.dataGridViewZaposlenik.TabIndex = 10;
            this.dataGridViewZaposlenik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSoba_CellContentClick);
            // 
            // popisSobaLabel
            // 
            this.popisSobaLabel.AutoSize = true;
            this.popisSobaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popisSobaLabel.Location = new System.Drawing.Point(415, 28);
            this.popisSobaLabel.Name = "popisSobaLabel";
            this.popisSobaLabel.Size = new System.Drawing.Size(261, 29);
            this.popisSobaLabel.TabIndex = 9;
            this.popisSobaLabel.Text = "Pregled zaposlenika";
            this.popisSobaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.BackColor = System.Drawing.Color.DimGray;
            this.buttonOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOdustani.Location = new System.Drawing.Point(1009, 294);
            this.buttonOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(168, 64);
            this.buttonOdustani.TabIndex = 14;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = false;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.Thistle;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonNatrag.Location = new System.Drawing.Point(27, 303);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(55, 48);
            this.roundButtonNatrag.TabIndex = 104;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // PregledZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 400);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.obrisiZaposlenikaButton);
            this.Controls.Add(this.azurirajPodatkeButton);
            this.Controls.Add(this.buttonDodajZaposlenika);
            this.Controls.Add(this.dataGridViewZaposlenik);
            this.Controls.Add(this.popisSobaLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PregledZaposlenika";
            this.Text = "PregledZaposlenika";
            this.Load += new System.EventHandler(this.PregledZaposlenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposlenik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button obrisiZaposlenikaButton;
        private System.Windows.Forms.Button azurirajPodatkeButton;
        private System.Windows.Forms.Button buttonDodajZaposlenika;
        private System.Windows.Forms.DataGridView dataGridViewZaposlenik;
        private System.Windows.Forms.Label popisSobaLabel;
        private System.Windows.Forms.Button buttonOdustani;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
    }
}