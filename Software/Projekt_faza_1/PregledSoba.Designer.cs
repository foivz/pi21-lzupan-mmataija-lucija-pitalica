
namespace Projekt_faza_1
{
    partial class PregledSoba
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
            this.popisSobaLabel = new System.Windows.Forms.Label();
            this.dataGridViewSoba = new System.Windows.Forms.DataGridView();
            this.azurirajSobuButton = new System.Windows.Forms.Button();
            this.dodajSobuButton = new System.Windows.Forms.Button();
            this.obrisiSobuButton = new System.Windows.Forms.Button();
            this.buttonRezerviraj = new System.Windows.Forms.Button();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.textBoxKapacitet = new System.Windows.Forms.TextBox();
            this.buttonFiltriraj = new System.Windows.Forms.Button();
            this.datumOdlaskadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datumDolaskadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datumOdlaskaLabel = new System.Windows.Forms.Label();
            this.datumDolaskaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpit = new System.Windows.Forms.Button();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoba)).BeginInit();
            this.SuspendLayout();
            // 
            // popisSobaLabel
            // 
            this.popisSobaLabel.AutoSize = true;
            this.popisSobaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popisSobaLabel.Location = new System.Drawing.Point(399, 46);
            this.popisSobaLabel.Name = "popisSobaLabel";
            this.popisSobaLabel.Size = new System.Drawing.Size(174, 29);
            this.popisSobaLabel.TabIndex = 0;
            this.popisSobaLabel.Text = "Pregled soba";
            this.popisSobaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewSoba
            // 
            this.dataGridViewSoba.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridViewSoba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoba.Location = new System.Drawing.Point(29, 362);
            this.dataGridViewSoba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSoba.Name = "dataGridViewSoba";
            this.dataGridViewSoba.RowHeadersWidth = 51;
            this.dataGridViewSoba.RowTemplate.Height = 24;
            this.dataGridViewSoba.Size = new System.Drawing.Size(953, 187);
            this.dataGridViewSoba.TabIndex = 2;
            // 
            // azurirajSobuButton
            // 
            this.azurirajSobuButton.BackColor = System.Drawing.Color.DimGray;
            this.azurirajSobuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.azurirajSobuButton.Location = new System.Drawing.Point(236, 582);
            this.azurirajSobuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.azurirajSobuButton.Name = "azurirajSobuButton";
            this.azurirajSobuButton.Size = new System.Drawing.Size(168, 64);
            this.azurirajSobuButton.TabIndex = 6;
            this.azurirajSobuButton.Text = "Ažuriraj sobu";
            this.azurirajSobuButton.UseVisualStyleBackColor = false;
            this.azurirajSobuButton.Click += new System.EventHandler(this.azurirajSobuButton_Click);
            // 
            // dodajSobuButton
            // 
            this.dodajSobuButton.BackColor = System.Drawing.Color.DimGray;
            this.dodajSobuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dodajSobuButton.Location = new System.Drawing.Point(29, 582);
            this.dodajSobuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dodajSobuButton.Name = "dodajSobuButton";
            this.dodajSobuButton.Size = new System.Drawing.Size(168, 64);
            this.dodajSobuButton.TabIndex = 5;
            this.dodajSobuButton.Text = "Dodaj sobu";
            this.dodajSobuButton.UseVisualStyleBackColor = false;
            this.dodajSobuButton.Click += new System.EventHandler(this.dodajSobuButton_Click);
            // 
            // obrisiSobuButton
            // 
            this.obrisiSobuButton.BackColor = System.Drawing.Color.DimGray;
            this.obrisiSobuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.obrisiSobuButton.Location = new System.Drawing.Point(426, 582);
            this.obrisiSobuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obrisiSobuButton.Name = "obrisiSobuButton";
            this.obrisiSobuButton.Size = new System.Drawing.Size(168, 64);
            this.obrisiSobuButton.TabIndex = 8;
            this.obrisiSobuButton.Text = "Obriši sobu";
            this.obrisiSobuButton.UseVisualStyleBackColor = false;
            this.obrisiSobuButton.Click += new System.EventHandler(this.obrisiSobuButton_Click);
            // 
            // buttonRezerviraj
            // 
            this.buttonRezerviraj.BackColor = System.Drawing.Color.DimGray;
            this.buttonRezerviraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRezerviraj.Location = new System.Drawing.Point(626, 582);
            this.buttonRezerviraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRezerviraj.Name = "buttonRezerviraj";
            this.buttonRezerviraj.Size = new System.Drawing.Size(168, 64);
            this.buttonRezerviraj.TabIndex = 9;
            this.buttonRezerviraj.Text = "Rezerviraj sobu";
            this.buttonRezerviraj.UseVisualStyleBackColor = false;
            this.buttonRezerviraj.Click += new System.EventHandler(this.buttonRezerviraj_Click);
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.BackColor = System.Drawing.Color.DimGray;
            this.buttonOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOdustani.Location = new System.Drawing.Point(826, 582);
            this.buttonOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(168, 64);
            this.buttonOdustani.TabIndex = 10;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = false;
            this.buttonOdustani.Click += new System.EventHandler(this.buttonOdustani_Click);
            // 
            // textBoxKapacitet
            // 
            this.textBoxKapacitet.Location = new System.Drawing.Point(218, 142);
            this.textBoxKapacitet.Name = "textBoxKapacitet";
            this.textBoxKapacitet.Size = new System.Drawing.Size(269, 22);
            this.textBoxKapacitet.TabIndex = 11;
            // 
            // buttonFiltriraj
            // 
            this.buttonFiltriraj.BackColor = System.Drawing.Color.DimGray;
            this.buttonFiltriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonFiltriraj.Location = new System.Drawing.Point(360, 288);
            this.buttonFiltriraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFiltriraj.Name = "buttonFiltriraj";
            this.buttonFiltriraj.Size = new System.Drawing.Size(127, 38);
            this.buttonFiltriraj.TabIndex = 12;
            this.buttonFiltriraj.Text = "Filtriraj";
            this.buttonFiltriraj.UseVisualStyleBackColor = false;
            this.buttonFiltriraj.Click += new System.EventHandler(this.buttonFiltriraj_Click);
            // 
            // datumOdlaskadateTimePicker
            // 
            this.datumOdlaskadateTimePicker.Location = new System.Drawing.Point(215, 244);
            this.datumOdlaskadateTimePicker.Name = "datumOdlaskadateTimePicker";
            this.datumOdlaskadateTimePicker.Size = new System.Drawing.Size(272, 22);
            this.datumOdlaskadateTimePicker.TabIndex = 106;
            // 
            // datumDolaskadateTimePicker
            // 
            this.datumDolaskadateTimePicker.Location = new System.Drawing.Point(215, 190);
            this.datumDolaskadateTimePicker.Name = "datumDolaskadateTimePicker";
            this.datumDolaskadateTimePicker.Size = new System.Drawing.Size(272, 22);
            this.datumDolaskadateTimePicker.TabIndex = 105;
            // 
            // datumOdlaskaLabel
            // 
            this.datumOdlaskaLabel.AutoSize = true;
            this.datumOdlaskaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datumOdlaskaLabel.Location = new System.Drawing.Point(37, 242);
            this.datumOdlaskaLabel.Name = "datumOdlaskaLabel";
            this.datumOdlaskaLabel.Size = new System.Drawing.Size(148, 25);
            this.datumOdlaskaLabel.TabIndex = 104;
            this.datumOdlaskaLabel.Text = "Datum odlaska:";
            // 
            // datumDolaskaLabel
            // 
            this.datumDolaskaLabel.AutoSize = true;
            this.datumDolaskaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datumDolaskaLabel.Location = new System.Drawing.Point(37, 187);
            this.datumDolaskaLabel.Name = "datumDolaskaLabel";
            this.datumDolaskaLabel.Size = new System.Drawing.Size(148, 25);
            this.datumDolaskaLabel.TabIndex = 103;
            this.datumDolaskaLabel.Text = "Datum dolaska:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(37, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 107;
            this.label1.Text = "Kapacitet:";
            // 
            // buttonUpit
            // 
            this.buttonUpit.BackColor = System.Drawing.Color.DimGray;
            this.buttonUpit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonUpit.Location = new System.Drawing.Point(805, 275);
            this.buttonUpit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpit.Name = "buttonUpit";
            this.buttonUpit.Size = new System.Drawing.Size(168, 64);
            this.buttonUpit.TabIndex = 108;
            this.buttonUpit.Text = "Postavi upit";
            this.buttonUpit.UseVisualStyleBackColor = false;
            this.buttonUpit.Click += new System.EventHandler(this.buttonUpit_Click);
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.Thistle;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonNatrag.Location = new System.Drawing.Point(29, 651);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(55, 48);
            this.roundButtonNatrag.TabIndex = 109;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // PregledSoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 716);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.buttonUpit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datumOdlaskadateTimePicker);
            this.Controls.Add(this.datumDolaskadateTimePicker);
            this.Controls.Add(this.datumOdlaskaLabel);
            this.Controls.Add(this.datumDolaskaLabel);
            this.Controls.Add(this.buttonFiltriraj);
            this.Controls.Add(this.textBoxKapacitet);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonRezerviraj);
            this.Controls.Add(this.obrisiSobuButton);
            this.Controls.Add(this.azurirajSobuButton);
            this.Controls.Add(this.dodajSobuButton);
            this.Controls.Add(this.dataGridViewSoba);
            this.Controls.Add(this.popisSobaLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PregledSoba";
            this.Text = "Pregled soba";
            this.Load += new System.EventHandler(this.PregledSoba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisSobaLabel;
        private System.Windows.Forms.DataGridView dataGridViewSoba;
        private System.Windows.Forms.Button azurirajSobuButton;
        private System.Windows.Forms.Button dodajSobuButton;
        private System.Windows.Forms.Button obrisiSobuButton;
        private System.Windows.Forms.Button buttonRezerviraj;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.TextBox textBoxKapacitet;
        private System.Windows.Forms.Button buttonFiltriraj;
        private System.Windows.Forms.DateTimePicker datumOdlaskadateTimePicker;
        private System.Windows.Forms.DateTimePicker datumDolaskadateTimePicker;
        private System.Windows.Forms.Label datumOdlaskaLabel;
        private System.Windows.Forms.Label datumDolaskaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpit;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
    }
}