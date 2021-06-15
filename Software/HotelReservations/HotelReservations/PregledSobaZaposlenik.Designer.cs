
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
            this.dataGridViewSoba = new System.Windows.Forms.DataGridView();
            this.popisSobaLabel = new System.Windows.Forms.Label();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            this.comboBoxHotel = new System.Windows.Forms.ComboBox();
            this.labelNazivHotela = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoba)).BeginInit();
            this.SuspendLayout();
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
            this.Controls.Add(this.roundButtonNatrag);
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
        private System.Windows.Forms.DataGridView dataGridViewSoba;
        private System.Windows.Forms.Label popisSobaLabel;
        private System.Windows.Forms.ComboBox comboBoxHotel;
        private System.Windows.Forms.Label labelNazivHotela;
    }
}