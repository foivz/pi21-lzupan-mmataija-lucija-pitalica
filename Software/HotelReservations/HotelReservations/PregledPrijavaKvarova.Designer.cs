
namespace Projekt_faza_1
{
    partial class PregledPrijavaKvarova
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
            this.labelPrijavljeniKvarovi = new System.Windows.Forms.Label();
            this.dataGridViewPrijavljeniKvarovi = new System.Windows.Forms.DataGridView();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrijavljeniKvarovi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrijavljeniKvarovi
            // 
            this.labelPrijavljeniKvarovi.AutoSize = true;
            this.labelPrijavljeniKvarovi.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.labelPrijavljeniKvarovi.Location = new System.Drawing.Point(46, 35);
            this.labelPrijavljeniKvarovi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrijavljeniKvarovi.Name = "labelPrijavljeniKvarovi";
            this.labelPrijavljeniKvarovi.Size = new System.Drawing.Size(144, 18);
            this.labelPrijavljeniKvarovi.TabIndex = 4;
            this.labelPrijavljeniKvarovi.Text = "Prijavljeni kvarovi";
            // 
            // dataGridViewPrijavljeniKvarovi
            // 
            this.dataGridViewPrijavljeniKvarovi.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPrijavljeniKvarovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrijavljeniKvarovi.Location = new System.Drawing.Point(50, 79);
            this.dataGridViewPrijavljeniKvarovi.Name = "dataGridViewPrijavljeniKvarovi";
            this.dataGridViewPrijavljeniKvarovi.Size = new System.Drawing.Size(705, 265);
            this.dataGridViewPrijavljeniKvarovi.TabIndex = 5;
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.SteelBlue;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.roundButtonNatrag.Location = new System.Drawing.Point(50, 374);
            this.roundButtonNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(41, 39);
            this.roundButtonNatrag.TabIndex = 105;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // PregledPrijavaKvarova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_faza_1.Properties.Resources.backgroundLogin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.dataGridViewPrijavljeniKvarovi);
            this.Controls.Add(this.labelPrijavljeniKvarovi);
            this.Name = "PregledPrijavaKvarova";
            this.Text = "Pregled prijavljenih kvarova";
            this.Load += new System.EventHandler(this.PregledPrijavaKvarova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrijavljeniKvarovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrijavljeniKvarovi;
        private System.Windows.Forms.DataGridView dataGridViewPrijavljeniKvarovi;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
    }
}