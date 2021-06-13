
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
            this.pregledZaposlenikaLabel = new System.Windows.Forms.Label();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposlenik)).BeginInit();
            this.SuspendLayout();
            // 
            // obrisiZaposlenikaButton
            // 
            this.obrisiZaposlenikaButton.BackColor = System.Drawing.Color.SteelBlue;
            this.obrisiZaposlenikaButton.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.obrisiZaposlenikaButton.Location = new System.Drawing.Point(755, 337);
            this.obrisiZaposlenikaButton.Margin = new System.Windows.Forms.Padding(2);
            this.obrisiZaposlenikaButton.Name = "obrisiZaposlenikaButton";
            this.obrisiZaposlenikaButton.Size = new System.Drawing.Size(126, 52);
            this.obrisiZaposlenikaButton.TabIndex = 13;
            this.obrisiZaposlenikaButton.Text = "Obriši zaposlenika";
            this.obrisiZaposlenikaButton.UseVisualStyleBackColor = false;
            this.obrisiZaposlenikaButton.Click += new System.EventHandler(this.obrisiZaposlenikaButton_Click);
            // 
            // azurirajPodatkeButton
            // 
            this.azurirajPodatkeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.azurirajPodatkeButton.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.azurirajPodatkeButton.Location = new System.Drawing.Point(611, 337);
            this.azurirajPodatkeButton.Margin = new System.Windows.Forms.Padding(2);
            this.azurirajPodatkeButton.Name = "azurirajPodatkeButton";
            this.azurirajPodatkeButton.Size = new System.Drawing.Size(126, 52);
            this.azurirajPodatkeButton.TabIndex = 12;
            this.azurirajPodatkeButton.Text = "Ažuriraj podatke";
            this.azurirajPodatkeButton.UseVisualStyleBackColor = false;
            this.azurirajPodatkeButton.Click += new System.EventHandler(this.azurirajPodatkeButton_Click);
            // 
            // buttonDodajZaposlenika
            // 
            this.buttonDodajZaposlenika.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDodajZaposlenika.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonDodajZaposlenika.Location = new System.Drawing.Point(465, 337);
            this.buttonDodajZaposlenika.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodajZaposlenika.Name = "buttonDodajZaposlenika";
            this.buttonDodajZaposlenika.Size = new System.Drawing.Size(126, 52);
            this.buttonDodajZaposlenika.TabIndex = 11;
            this.buttonDodajZaposlenika.Text = "Dodaj zaposlenika";
            this.buttonDodajZaposlenika.UseVisualStyleBackColor = false;
            this.buttonDodajZaposlenika.Click += new System.EventHandler(this.buttonDodajZaposlenika_Click);
            // 
            // dataGridViewZaposlenik
            // 
            this.dataGridViewZaposlenik.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewZaposlenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZaposlenik.Location = new System.Drawing.Point(20, 105);
            this.dataGridViewZaposlenik.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewZaposlenik.Name = "dataGridViewZaposlenik";
            this.dataGridViewZaposlenik.RowHeadersWidth = 51;
            this.dataGridViewZaposlenik.RowTemplate.Height = 24;
            this.dataGridViewZaposlenik.Size = new System.Drawing.Size(861, 199);
            this.dataGridViewZaposlenik.TabIndex = 10;
            this.dataGridViewZaposlenik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSoba_CellContentClick);
            // 
            // pregledZaposlenikaLabel
            // 
            this.pregledZaposlenikaLabel.AutoSize = true;
            this.pregledZaposlenikaLabel.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold);
            this.pregledZaposlenikaLabel.Location = new System.Drawing.Point(343, 41);
            this.pregledZaposlenikaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pregledZaposlenikaLabel.Name = "pregledZaposlenikaLabel";
            this.pregledZaposlenikaLabel.Size = new System.Drawing.Size(224, 23);
            this.pregledZaposlenikaLabel.TabIndex = 9;
            this.pregledZaposlenikaLabel.Text = "Pregled zaposlenika";
            this.pregledZaposlenikaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.SteelBlue;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.roundButtonNatrag.Location = new System.Drawing.Point(20, 344);
            this.roundButtonNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(41, 39);
            this.roundButtonNatrag.TabIndex = 104;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // PregledZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_faza_1.Properties.Resources.backgroundLogin;
            this.ClientSize = new System.Drawing.Size(892, 427);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.obrisiZaposlenikaButton);
            this.Controls.Add(this.azurirajPodatkeButton);
            this.Controls.Add(this.buttonDodajZaposlenika);
            this.Controls.Add(this.dataGridViewZaposlenik);
            this.Controls.Add(this.pregledZaposlenikaLabel);
            this.Name = "PregledZaposlenika";
            this.Text = "Pregled zaposlenika";
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
        private System.Windows.Forms.Label pregledZaposlenikaLabel;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
    }
}