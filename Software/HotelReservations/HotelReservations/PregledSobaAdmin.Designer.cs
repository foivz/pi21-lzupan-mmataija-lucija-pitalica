
namespace Projekt_faza_1
{
    partial class PregledSobaAdmin
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
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            this.obrisiSobuButton = new System.Windows.Forms.Button();
            this.azurirajSobuButton = new System.Windows.Forms.Button();
            this.dodajSobuButton = new System.Windows.Forms.Button();
            this.dataGridViewSoba = new System.Windows.Forms.DataGridView();
            this.popisSobaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoba)).BeginInit();
            this.SuspendLayout();
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.SteelBlue;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.roundButtonNatrag.Location = new System.Drawing.Point(47, 300);
            this.roundButtonNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(41, 39);
            this.roundButtonNatrag.TabIndex = 124;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // obrisiSobuButton
            // 
            this.obrisiSobuButton.BackColor = System.Drawing.Color.SteelBlue;
            this.obrisiSobuButton.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.obrisiSobuButton.Location = new System.Drawing.Point(636, 293);
            this.obrisiSobuButton.Margin = new System.Windows.Forms.Padding(2);
            this.obrisiSobuButton.Name = "obrisiSobuButton";
            this.obrisiSobuButton.Size = new System.Drawing.Size(126, 52);
            this.obrisiSobuButton.TabIndex = 114;
            this.obrisiSobuButton.Text = "Obriši sobu";
            this.obrisiSobuButton.UseVisualStyleBackColor = false;
            this.obrisiSobuButton.Click += new System.EventHandler(this.obrisiSobuButton_Click);
            // 
            // azurirajSobuButton
            // 
            this.azurirajSobuButton.BackColor = System.Drawing.Color.SteelBlue;
            this.azurirajSobuButton.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.azurirajSobuButton.Location = new System.Drawing.Point(493, 293);
            this.azurirajSobuButton.Margin = new System.Windows.Forms.Padding(2);
            this.azurirajSobuButton.Name = "azurirajSobuButton";
            this.azurirajSobuButton.Size = new System.Drawing.Size(126, 52);
            this.azurirajSobuButton.TabIndex = 113;
            this.azurirajSobuButton.Text = "Ažuriraj sobu";
            this.azurirajSobuButton.UseVisualStyleBackColor = false;
            this.azurirajSobuButton.Click += new System.EventHandler(this.azurirajSobuButton_Click);
            // 
            // dodajSobuButton
            // 
            this.dodajSobuButton.BackColor = System.Drawing.Color.SteelBlue;
            this.dodajSobuButton.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.dodajSobuButton.Location = new System.Drawing.Point(338, 293);
            this.dodajSobuButton.Margin = new System.Windows.Forms.Padding(2);
            this.dodajSobuButton.Name = "dodajSobuButton";
            this.dodajSobuButton.Size = new System.Drawing.Size(126, 52);
            this.dodajSobuButton.TabIndex = 112;
            this.dodajSobuButton.Text = "Dodaj sobu";
            this.dodajSobuButton.UseVisualStyleBackColor = false;
            this.dodajSobuButton.Click += new System.EventHandler(this.dodajSobuButton_Click);
            // 
            // dataGridViewSoba
            // 
            this.dataGridViewSoba.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSoba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoba.Location = new System.Drawing.Point(47, 113);
            this.dataGridViewSoba.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSoba.Name = "dataGridViewSoba";
            this.dataGridViewSoba.RowHeadersWidth = 51;
            this.dataGridViewSoba.RowTemplate.Height = 24;
            this.dataGridViewSoba.Size = new System.Drawing.Size(715, 152);
            this.dataGridViewSoba.TabIndex = 111;
            // 
            // popisSobaLabel
            // 
            this.popisSobaLabel.AutoSize = true;
            this.popisSobaLabel.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold);
            this.popisSobaLabel.Location = new System.Drawing.Point(317, 41);
            this.popisSobaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.popisSobaLabel.Name = "popisSobaLabel";
            this.popisSobaLabel.Size = new System.Drawing.Size(147, 23);
            this.popisSobaLabel.TabIndex = 110;
            this.popisSobaLabel.Text = "Pregled soba";
            this.popisSobaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PregledSobaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.obrisiSobuButton);
            this.Controls.Add(this.azurirajSobuButton);
            this.Controls.Add(this.dodajSobuButton);
            this.Controls.Add(this.dataGridViewSoba);
            this.Controls.Add(this.popisSobaLabel);
            this.Name = "PregledSobaAdmin";
            this.Text = "PregledSobaAdmin";
            this.Load += new System.EventHandler(this.PregledSobaAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
        private System.Windows.Forms.Button obrisiSobuButton;
        private System.Windows.Forms.Button azurirajSobuButton;
        private System.Windows.Forms.Button dodajSobuButton;
        private System.Windows.Forms.DataGridView dataGridViewSoba;
        private System.Windows.Forms.Label popisSobaLabel;
    }
}