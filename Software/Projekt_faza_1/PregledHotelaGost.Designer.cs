
namespace Projekt_faza_1
{
    partial class PregledHotelaGost
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
            this.buttonPregledSobe = new System.Windows.Forms.Button();
            this.dataGridViewHoteli = new System.Windows.Forms.DataGridView();
            this.popisHotelaLabel = new System.Windows.Forms.Label();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoteli)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPregledSobe
            // 
            this.buttonPregledSobe.BackColor = System.Drawing.Color.DimGray;
            this.buttonPregledSobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonPregledSobe.Location = new System.Drawing.Point(1015, 347);
            this.buttonPregledSobe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPregledSobe.Name = "buttonPregledSobe";
            this.buttonPregledSobe.Size = new System.Drawing.Size(168, 64);
            this.buttonPregledSobe.TabIndex = 13;
            this.buttonPregledSobe.Text = "Pregledaj sobe";
            this.buttonPregledSobe.UseVisualStyleBackColor = false;
            this.buttonPregledSobe.Click += new System.EventHandler(this.buttonPregledSobe_Click);
            // 
            // dataGridViewHoteli
            // 
            this.dataGridViewHoteli.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridViewHoteli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoteli.Location = new System.Drawing.Point(76, 123);
            this.dataGridViewHoteli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHoteli.Name = "dataGridViewHoteli";
            this.dataGridViewHoteli.RowHeadersWidth = 51;
            this.dataGridViewHoteli.RowTemplate.Height = 24;
            this.dataGridViewHoteli.Size = new System.Drawing.Size(1107, 187);
            this.dataGridViewHoteli.TabIndex = 9;
            this.dataGridViewHoteli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoteli_CellContentClick);
            // 
            // popisHotelaLabel
            // 
            this.popisHotelaLabel.AutoSize = true;
            this.popisHotelaLabel.BackColor = System.Drawing.Color.White;
            this.popisHotelaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popisHotelaLabel.Location = new System.Drawing.Point(530, 62);
            this.popisHotelaLabel.Name = "popisHotelaLabel";
            this.popisHotelaLabel.Size = new System.Drawing.Size(165, 29);
            this.popisHotelaLabel.TabIndex = 8;
            this.popisHotelaLabel.Text = "Popis hotela";
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.Thistle;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonNatrag.Location = new System.Drawing.Point(76, 356);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(55, 48);
            this.roundButtonNatrag.TabIndex = 104;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // PregledHotelaGost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 466);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.buttonPregledSobe);
            this.Controls.Add(this.dataGridViewHoteli);
            this.Controls.Add(this.popisHotelaLabel);
            this.Name = "PregledHotelaGost";
            this.Text = "PregledHotelaGost";
            this.Load += new System.EventHandler(this.PregledHotelaGost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoteli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPregledSobe;
        private System.Windows.Forms.DataGridView dataGridViewHoteli;
        private System.Windows.Forms.Label popisHotelaLabel;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
    }
}