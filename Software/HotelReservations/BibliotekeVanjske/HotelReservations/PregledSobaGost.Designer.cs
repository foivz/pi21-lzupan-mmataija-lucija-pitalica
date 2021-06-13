
namespace Projekt_faza_1
{
    partial class PregledSobaGost
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
            this.buttonRezerviraj = new System.Windows.Forms.Button();
            this.dataGridViewSoba = new System.Windows.Forms.DataGridView();
            this.popisSobaLabel = new System.Windows.Forms.Label();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            this.buttonPostaviUpit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoba)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKapacitet
            // 
            this.labelKapacitet.AutoSize = true;
            this.labelKapacitet.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.labelKapacitet.Location = new System.Drawing.Point(29, 130);
            this.labelKapacitet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKapacitet.Name = "labelKapacitet";
            this.labelKapacitet.Size = new System.Drawing.Size(85, 18);
            this.labelKapacitet.TabIndex = 122;
            this.labelKapacitet.Text = "Kapacitet:";
            this.labelKapacitet.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonFiltriraj
            // 
            this.buttonFiltriraj.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonFiltriraj.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonFiltriraj.Location = new System.Drawing.Point(398, 124);
            this.buttonFiltriraj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFiltriraj.Name = "buttonFiltriraj";
            this.buttonFiltriraj.Size = new System.Drawing.Size(95, 31);
            this.buttonFiltriraj.TabIndex = 117;
            this.buttonFiltriraj.Text = "Filtriraj";
            this.buttonFiltriraj.UseVisualStyleBackColor = false;
            this.buttonFiltriraj.Click += new System.EventHandler(this.buttonFiltriraj_Click);
            // 
            // textBoxKapacitet
            // 
            this.textBoxKapacitet.Location = new System.Drawing.Point(165, 133);
            this.textBoxKapacitet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKapacitet.Name = "textBoxKapacitet";
            this.textBoxKapacitet.Size = new System.Drawing.Size(203, 20);
            this.textBoxKapacitet.TabIndex = 116;
            // 
            // buttonRezerviraj
            // 
            this.buttonRezerviraj.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonRezerviraj.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonRezerviraj.Location = new System.Drawing.Point(612, 485);
            this.buttonRezerviraj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRezerviraj.Name = "buttonRezerviraj";
            this.buttonRezerviraj.Size = new System.Drawing.Size(126, 52);
            this.buttonRezerviraj.TabIndex = 114;
            this.buttonRezerviraj.Text = "Rezerviraj sobu";
            this.buttonRezerviraj.UseVisualStyleBackColor = false;
            this.buttonRezerviraj.Click += new System.EventHandler(this.buttonRezerviraj_Click);
            // 
            // dataGridViewSoba
            // 
            this.dataGridViewSoba.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSoba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoba.Location = new System.Drawing.Point(23, 171);
            this.dataGridViewSoba.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSoba.Name = "dataGridViewSoba";
            this.dataGridViewSoba.RowHeadersWidth = 51;
            this.dataGridViewSoba.RowTemplate.Height = 24;
            this.dataGridViewSoba.Size = new System.Drawing.Size(715, 292);
            this.dataGridViewSoba.TabIndex = 110;
            // 
            // popisSobaLabel
            // 
            this.popisSobaLabel.AutoSize = true;
            this.popisSobaLabel.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold);
            this.popisSobaLabel.Location = new System.Drawing.Point(301, 55);
            this.popisSobaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.popisSobaLabel.Name = "popisSobaLabel";
            this.popisSobaLabel.Size = new System.Drawing.Size(147, 23);
            this.popisSobaLabel.TabIndex = 109;
            this.popisSobaLabel.Text = "Pregled soba";
            this.popisSobaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.SteelBlue;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.roundButtonNatrag.Location = new System.Drawing.Point(23, 498);
            this.roundButtonNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(41, 39);
            this.roundButtonNatrag.TabIndex = 124;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // buttonPostaviUpit
            // 
            this.buttonPostaviUpit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPostaviUpit.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonPostaviUpit.Location = new System.Drawing.Point(480, 485);
            this.buttonPostaviUpit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPostaviUpit.Name = "buttonPostaviUpit";
            this.buttonPostaviUpit.Size = new System.Drawing.Size(109, 52);
            this.buttonPostaviUpit.TabIndex = 125;
            this.buttonPostaviUpit.Text = "Postavi upit";
            this.buttonPostaviUpit.UseVisualStyleBackColor = false;
            this.buttonPostaviUpit.Click += new System.EventHandler(this.buttonPostaviUpit_Click);
            // 
            // PregledSobaGost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_faza_1.Properties.Resources.backgroundLogin;
            this.ClientSize = new System.Drawing.Size(770, 598);
            this.Controls.Add(this.buttonPostaviUpit);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.labelKapacitet);
            this.Controls.Add(this.buttonFiltriraj);
            this.Controls.Add(this.textBoxKapacitet);
            this.Controls.Add(this.buttonRezerviraj);
            this.Controls.Add(this.dataGridViewSoba);
            this.Controls.Add(this.popisSobaLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PregledSobaGost";
            this.Text = "Pregled soba";
            this.Load += new System.EventHandler(this.PregledSobaGost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelKapacitet;
        private System.Windows.Forms.Button buttonFiltriraj;
        private System.Windows.Forms.TextBox textBoxKapacitet;
        private System.Windows.Forms.Button buttonRezerviraj;
        private System.Windows.Forms.DataGridView dataGridViewSoba;
        private System.Windows.Forms.Label popisSobaLabel;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
        private System.Windows.Forms.Button buttonPostaviUpit;
    }
}