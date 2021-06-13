
namespace Projekt_faza_1
{
    partial class PregledRecenzija
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
            this.dataGridViewRecenzije = new System.Windows.Forms.DataGridView();
            this.labelRecenzije = new System.Windows.Forms.Label();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecenzije)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRecenzije
            // 
            this.dataGridViewRecenzije.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRecenzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecenzije.Location = new System.Drawing.Point(50, 84);
            this.dataGridViewRecenzije.Name = "dataGridViewRecenzije";
            this.dataGridViewRecenzije.Size = new System.Drawing.Size(705, 265);
            this.dataGridViewRecenzije.TabIndex = 7;
            // 
            // labelRecenzije
            // 
            this.labelRecenzije.AutoSize = true;
            this.labelRecenzije.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.labelRecenzije.Location = new System.Drawing.Point(46, 34);
            this.labelRecenzije.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRecenzije.Name = "labelRecenzije";
            this.labelRecenzije.Size = new System.Drawing.Size(83, 18);
            this.labelRecenzije.TabIndex = 6;
            this.labelRecenzije.Text = "Recenzije";
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.SteelBlue;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.roundButtonNatrag.Location = new System.Drawing.Point(50, 374);
            this.roundButtonNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(41, 39);
            this.roundButtonNatrag.TabIndex = 106;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // PregledRecenzija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_faza_1.Properties.Resources.backgroundLogin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.dataGridViewRecenzije);
            this.Controls.Add(this.labelRecenzije);
            this.Name = "PregledRecenzija";
            this.Text = "Pregled recenzija";
            this.Load += new System.EventHandler(this.PregledRecenzija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecenzije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRecenzije;
        private System.Windows.Forms.Label labelRecenzije;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
    }
}