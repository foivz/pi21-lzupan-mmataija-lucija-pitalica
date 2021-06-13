
namespace Projekt_faza_1
{
    partial class PregledSobaZaposlenik
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
            this.labelKapacitet = new System.Windows.Forms.Label();
            this.buttonFiltriraj = new System.Windows.Forms.Button();
            this.textBoxKapacitet = new System.Windows.Forms.TextBox();
            this.dataGridViewSoba = new System.Windows.Forms.DataGridView();
            this.popisSobaLabel = new System.Windows.Forms.Label();
            this.obrisiSobuButton = new System.Windows.Forms.Button();
            this.azurirajSobuButton = new System.Windows.Forms.Button();
            this.dodajSobuButton = new System.Windows.Forms.Button();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            this.comboBoxHotel = new System.Windows.Forms.ComboBox();
            this.labelNazivHotela = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoba)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKapacitet
            // 
            this.labelKapacitet.AutoSize = true;
            this.labelKapacitet.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.labelKapacitet.Location = new System.Drawing.Point(43, 166);
            this.labelKapacitet.Name = "labelKapacitet";
            this.labelKapacitet.Size = new System.Drawing.Size(108, 23);
            this.labelKapacitet.TabIndex = 132;
            this.labelKapacitet.Text = "Kapacitet:";
            this.labelKapacitet.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonFiltriraj
            // 
            this.buttonFiltriraj.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonFiltriraj.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonFiltriraj.Location = new System.Drawing.Point(445, 155);
            this.buttonFiltriraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFiltriraj.Name = "buttonFiltriraj";
            this.buttonFiltriraj.Size = new System.Drawing.Size(127, 38);
            this.buttonFiltriraj.TabIndex = 131;
            this.buttonFiltriraj.Text = "Filtriraj";
            this.buttonFiltriraj.UseVisualStyleBackColor = false;
            this.buttonFiltriraj.Click += new System.EventHandler(this.buttonFiltriraj_Click);
            // 
            // textBoxKapacitet
            // 
            this.textBoxKapacitet.Location = new System.Drawing.Point(161, 166);
            this.textBoxKapacitet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKapacitet.Name = "textBoxKapacitet";
            this.textBoxKapacitet.Size = new System.Drawing.Size(269, 22);
            this.textBoxKapacitet.TabIndex = 130;
            // 
            // dataGridViewSoba
            // 
            this.dataGridViewSoba.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSoba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoba.Location = new System.Drawing.Point(35, 217);
            this.dataGridViewSoba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSoba.Name = "dataGridViewSoba";
            this.dataGridViewSoba.RowHeadersWidth = 51;
            this.dataGridViewSoba.RowTemplate.Height = 24;
            this.dataGridViewSoba.Size = new System.Drawing.Size(972, 359);
            this.dataGridViewSoba.TabIndex = 127;
            // 
            // popisSobaLabel
            // 
            this.popisSobaLabel.AutoSize = true;
            this.popisSobaLabel.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold);
            this.popisSobaLabel.Location = new System.Drawing.Point(405, 74);
            this.popisSobaLabel.Name = "popisSobaLabel";
            this.popisSobaLabel.Size = new System.Drawing.Size(175, 28);
            this.popisSobaLabel.TabIndex = 126;
            this.popisSobaLabel.Text = "Pregled soba";
            this.popisSobaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // obrisiSobuButton
            // 
            this.obrisiSobuButton.BackColor = System.Drawing.Color.SteelBlue;
            this.obrisiSobuButton.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.obrisiSobuButton.Location = new System.Drawing.Point(820, 610);
            this.obrisiSobuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obrisiSobuButton.Name = "obrisiSobuButton";
            this.obrisiSobuButton.Size = new System.Drawing.Size(168, 64);
            this.obrisiSobuButton.TabIndex = 136;
            this.obrisiSobuButton.Text = "Obriši sobu";
            this.obrisiSobuButton.UseVisualStyleBackColor = false;
            this.obrisiSobuButton.Click += new System.EventHandler(this.obrisiSobuButton_Click);
            // 
            // azurirajSobuButton
            // 
            this.azurirajSobuButton.BackColor = System.Drawing.Color.SteelBlue;
            this.azurirajSobuButton.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.azurirajSobuButton.Location = new System.Drawing.Point(631, 610);
            this.azurirajSobuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.azurirajSobuButton.Name = "azurirajSobuButton";
            this.azurirajSobuButton.Size = new System.Drawing.Size(168, 64);
            this.azurirajSobuButton.TabIndex = 135;
            this.azurirajSobuButton.Text = "Ažuriraj sobu";
            this.azurirajSobuButton.UseVisualStyleBackColor = false;
            this.azurirajSobuButton.Click += new System.EventHandler(this.azurirajSobuButton_Click);
            // 
            // dodajSobuButton
            // 
            this.dodajSobuButton.BackColor = System.Drawing.Color.SteelBlue;
            this.dodajSobuButton.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.dodajSobuButton.Location = new System.Drawing.Point(423, 610);
            this.dodajSobuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodajSobuButton.Name = "dodajSobuButton";
            this.dodajSobuButton.Size = new System.Drawing.Size(168, 64);
            this.dodajSobuButton.TabIndex = 134;
            this.dodajSobuButton.Text = "Dodaj sobu";
            this.dodajSobuButton.UseVisualStyleBackColor = false;
            this.dodajSobuButton.Click += new System.EventHandler(this.dodajSobuButton_Click);
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.SteelBlue;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.roundButtonNatrag.Location = new System.Drawing.Point(35, 619);
            this.roundButtonNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(55, 48);
            this.roundButtonNatrag.TabIndex = 133;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // comboBoxHotel
            // 
            this.comboBoxHotel.FormattingEnabled = true;
            this.comboBoxHotel.Location = new System.Drawing.Point(743, 162);
            this.comboBoxHotel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxHotel.Name = "comboBoxHotel";
            this.comboBoxHotel.Size = new System.Drawing.Size(263, 24);
            this.comboBoxHotel.TabIndex = 137;
            // 
            // labelNazivHotela
            // 
            this.labelNazivHotela.AutoSize = true;
            this.labelNazivHotela.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.labelNazivHotela.Location = new System.Drawing.Point(593, 162);
            this.labelNazivHotela.Name = "labelNazivHotela";
            this.labelNazivHotela.Size = new System.Drawing.Size(138, 23);
            this.labelNazivHotela.TabIndex = 138;
            this.labelNazivHotela.Text = "Naziv hotela:";
            // 
            // PregledSobaZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_faza_1.Properties.Resources.backgroundLogin;
            this.ClientSize = new System.Drawing.Size(1021, 750);
            this.Controls.Add(this.labelNazivHotela);
            this.Controls.Add(this.comboBoxHotel);
            this.Controls.Add(this.obrisiSobuButton);
            this.Controls.Add(this.azurirajSobuButton);
            this.Controls.Add(this.dodajSobuButton);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.labelKapacitet);
            this.Controls.Add(this.buttonFiltriraj);
            this.Controls.Add(this.textBoxKapacitet);
            this.Controls.Add(this.dataGridViewSoba);
            this.Controls.Add(this.popisSobaLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PregledSobaZaposlenik";
            this.Text = "Pregled soba";
            this.Load += new System.EventHandler(this.PregledSobaZaposlenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
        private System.Windows.Forms.Label labelKapacitet;
        private System.Windows.Forms.Button buttonFiltriraj;
        private System.Windows.Forms.TextBox textBoxKapacitet;
        private System.Windows.Forms.DataGridView dataGridViewSoba;
        private System.Windows.Forms.Label popisSobaLabel;
        private System.Windows.Forms.Button obrisiSobuButton;
        private System.Windows.Forms.Button azurirajSobuButton;
        private System.Windows.Forms.Button dodajSobuButton;
        private System.Windows.Forms.ComboBox comboBoxHotel;
        private System.Windows.Forms.Label labelNazivHotela;
    }
}