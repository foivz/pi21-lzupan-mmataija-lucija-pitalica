
namespace Projekt_faza_1
{
    partial class PregledSvihHotelaGost
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
            this.buttonPregledSobe = new System.Windows.Forms.Button();
            this.dataGridViewHoteli = new System.Windows.Forms.DataGridView();
            this.popisHotelaLabel = new System.Windows.Forms.Label();
            this.buttonPostaviUpit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoteli)).BeginInit();
            this.SuspendLayout();
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.SteelBlue;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.roundButtonNatrag.Location = new System.Drawing.Point(69, 394);
            this.roundButtonNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(55, 48);
            this.roundButtonNatrag.TabIndex = 112;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // buttonPregledSobe
            // 
            this.buttonPregledSobe.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPregledSobe.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonPregledSobe.Location = new System.Drawing.Point(1089, 378);
            this.buttonPregledSobe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPregledSobe.Name = "buttonPregledSobe";
            this.buttonPregledSobe.Size = new System.Drawing.Size(168, 64);
            this.buttonPregledSobe.TabIndex = 110;
            this.buttonPregledSobe.Text = "Pregledaj sobe";
            this.buttonPregledSobe.UseVisualStyleBackColor = false;
            this.buttonPregledSobe.Click += new System.EventHandler(this.buttonPregledSobe_Click);
            // 
            // dataGridViewHoteli
            // 
            this.dataGridViewHoteli.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHoteli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoteli.Location = new System.Drawing.Point(53, 159);
            this.dataGridViewHoteli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHoteli.Name = "dataGridViewHoteli";
            this.dataGridViewHoteli.RowHeadersWidth = 51;
            this.dataGridViewHoteli.RowTemplate.Height = 24;
            this.dataGridViewHoteli.Size = new System.Drawing.Size(1204, 187);
            this.dataGridViewHoteli.TabIndex = 106;
            // 
            // popisHotelaLabel
            // 
            this.popisHotelaLabel.AutoSize = true;
            this.popisHotelaLabel.BackColor = System.Drawing.Color.White;
            this.popisHotelaLabel.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold);
            this.popisHotelaLabel.Location = new System.Drawing.Point(587, 97);
            this.popisHotelaLabel.Name = "popisHotelaLabel";
            this.popisHotelaLabel.Size = new System.Drawing.Size(167, 28);
            this.popisHotelaLabel.TabIndex = 105;
            this.popisHotelaLabel.Text = "Popis hotela";
            // 
            // buttonPostaviUpit
            // 
            this.buttonPostaviUpit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPostaviUpit.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonPostaviUpit.Location = new System.Drawing.Point(895, 382);
            this.buttonPostaviUpit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPostaviUpit.Name = "buttonPostaviUpit";
            this.buttonPostaviUpit.Size = new System.Drawing.Size(171, 57);
            this.buttonPostaviUpit.TabIndex = 125;
            this.buttonPostaviUpit.Text = "Postavi upit";
            this.buttonPostaviUpit.UseVisualStyleBackColor = false;
            this.buttonPostaviUpit.Click += new System.EventHandler(this.buttonPostaviUpit_Click);
            // 
            // PregledSvihHotelaGost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 487);
            this.Controls.Add(this.buttonPostaviUpit);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.buttonPregledSobe);
            this.Controls.Add(this.dataGridViewHoteli);
            this.Controls.Add(this.popisHotelaLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PregledSvihHotelaGost";
            this.Text = "PregledSvihHotelaGost";
            this.Load += new System.EventHandler(this.PregledSvihHotelaGost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoteli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
        private System.Windows.Forms.Button buttonPregledSobe;
        private System.Windows.Forms.DataGridView dataGridViewHoteli;
        private System.Windows.Forms.Label popisHotelaLabel;
        private System.Windows.Forms.Button buttonPostaviUpit;
    }
}