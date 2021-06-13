
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoteli)).BeginInit();
            this.SuspendLayout();
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.SteelBlue;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.roundButtonNatrag.Location = new System.Drawing.Point(52, 320);
            this.roundButtonNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(41, 39);
            this.roundButtonNatrag.TabIndex = 112;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // buttonPregledSobe
            // 
            this.buttonPregledSobe.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPregledSobe.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonPregledSobe.Location = new System.Drawing.Point(817, 307);
            this.buttonPregledSobe.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPregledSobe.Name = "buttonPregledSobe";
            this.buttonPregledSobe.Size = new System.Drawing.Size(126, 52);
            this.buttonPregledSobe.TabIndex = 110;
            this.buttonPregledSobe.Text = "Pregledaj sobe";
            this.buttonPregledSobe.UseVisualStyleBackColor = false;
            this.buttonPregledSobe.Click += new System.EventHandler(this.buttonPregledSobe_Click);
            // 
            // dataGridViewHoteli
            // 
            this.dataGridViewHoteli.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHoteli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoteli.Location = new System.Drawing.Point(40, 129);
            this.dataGridViewHoteli.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewHoteli.Name = "dataGridViewHoteli";
            this.dataGridViewHoteli.RowHeadersWidth = 51;
            this.dataGridViewHoteli.RowTemplate.Height = 24;
            this.dataGridViewHoteli.Size = new System.Drawing.Size(903, 152);
            this.dataGridViewHoteli.TabIndex = 106;
            // 
            // popisHotelaLabel
            // 
            this.popisHotelaLabel.AutoSize = true;
            this.popisHotelaLabel.BackColor = System.Drawing.Color.White;
            this.popisHotelaLabel.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold);
            this.popisHotelaLabel.Location = new System.Drawing.Point(440, 79);
            this.popisHotelaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.popisHotelaLabel.Name = "popisHotelaLabel";
            this.popisHotelaLabel.Size = new System.Drawing.Size(141, 23);
            this.popisHotelaLabel.TabIndex = 105;
            this.popisHotelaLabel.Text = "Popis hotela";
            // 
            // PregledSvihHotelaGost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 396);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.buttonPregledSobe);
            this.Controls.Add(this.dataGridViewHoteli);
            this.Controls.Add(this.popisHotelaLabel);
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
    }
}