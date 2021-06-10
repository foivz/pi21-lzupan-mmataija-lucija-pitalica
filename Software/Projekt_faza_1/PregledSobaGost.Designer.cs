
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
            this.buttonUpit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFiltriraj = new System.Windows.Forms.Button();
            this.textBoxKapacitet = new System.Windows.Forms.TextBox();
            this.buttonOdustani = new System.Windows.Forms.Button();
            this.buttonRezerviraj = new System.Windows.Forms.Button();
            this.dataGridViewSoba = new System.Windows.Forms.DataGridView();
            this.popisSobaLabel = new System.Windows.Forms.Label();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoba)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpit
            // 
            this.buttonUpit.BackColor = System.Drawing.Color.DimGray;
            this.buttonUpit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonUpit.Location = new System.Drawing.Point(443, 604);
            this.buttonUpit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpit.Name = "buttonUpit";
            this.buttonUpit.Size = new System.Drawing.Size(168, 64);
            this.buttonUpit.TabIndex = 123;
            this.buttonUpit.Text = "Postavi upit";
            this.buttonUpit.UseVisualStyleBackColor = false;
            this.buttonUpit.Click += new System.EventHandler(this.buttonUpit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(39, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 122;
            this.label1.Text = "Kapacitet:";
            // 
            // buttonFiltriraj
            // 
            this.buttonFiltriraj.BackColor = System.Drawing.Color.DimGray;
            this.buttonFiltriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonFiltriraj.Location = new System.Drawing.Point(531, 153);
            this.buttonFiltriraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFiltriraj.Name = "buttonFiltriraj";
            this.buttonFiltriraj.Size = new System.Drawing.Size(127, 38);
            this.buttonFiltriraj.TabIndex = 117;
            this.buttonFiltriraj.Text = "Filtriraj";
            this.buttonFiltriraj.UseVisualStyleBackColor = false;
            this.buttonFiltriraj.Click += new System.EventHandler(this.buttonFiltriraj_Click);
            // 
            // textBoxKapacitet
            // 
            this.textBoxKapacitet.Location = new System.Drawing.Point(220, 164);
            this.textBoxKapacitet.Name = "textBoxKapacitet";
            this.textBoxKapacitet.Size = new System.Drawing.Size(269, 22);
            this.textBoxKapacitet.TabIndex = 116;
            // 
            // buttonOdustani
            // 
            this.buttonOdustani.BackColor = System.Drawing.Color.DimGray;
            this.buttonOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOdustani.Location = new System.Drawing.Point(816, 604);
            this.buttonOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOdustani.Name = "buttonOdustani";
            this.buttonOdustani.Size = new System.Drawing.Size(168, 64);
            this.buttonOdustani.TabIndex = 115;
            this.buttonOdustani.Text = "Odustani";
            this.buttonOdustani.UseVisualStyleBackColor = false;
            // 
            // buttonRezerviraj
            // 
            this.buttonRezerviraj.BackColor = System.Drawing.Color.DimGray;
            this.buttonRezerviraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonRezerviraj.Location = new System.Drawing.Point(628, 604);
            this.buttonRezerviraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRezerviraj.Name = "buttonRezerviraj";
            this.buttonRezerviraj.Size = new System.Drawing.Size(168, 64);
            this.buttonRezerviraj.TabIndex = 114;
            this.buttonRezerviraj.Text = "Rezerviraj sobu";
            this.buttonRezerviraj.UseVisualStyleBackColor = false;
            this.buttonRezerviraj.Click += new System.EventHandler(this.buttonRezerviraj_Click);
            // 
            // dataGridViewSoba
            // 
            this.dataGridViewSoba.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridViewSoba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoba.Location = new System.Drawing.Point(31, 211);
            this.dataGridViewSoba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSoba.Name = "dataGridViewSoba";
            this.dataGridViewSoba.RowHeadersWidth = 51;
            this.dataGridViewSoba.RowTemplate.Height = 24;
            this.dataGridViewSoba.Size = new System.Drawing.Size(953, 360);
            this.dataGridViewSoba.TabIndex = 110;
            // 
            // popisSobaLabel
            // 
            this.popisSobaLabel.AutoSize = true;
            this.popisSobaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popisSobaLabel.Location = new System.Drawing.Point(401, 68);
            this.popisSobaLabel.Name = "popisSobaLabel";
            this.popisSobaLabel.Size = new System.Drawing.Size(174, 29);
            this.popisSobaLabel.TabIndex = 109;
            this.popisSobaLabel.Text = "Pregled soba";
            this.popisSobaLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.Thistle;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonNatrag.Location = new System.Drawing.Point(31, 613);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(55, 48);
            this.roundButtonNatrag.TabIndex = 124;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // PregledSobaGost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 736);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.buttonUpit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFiltriraj);
            this.Controls.Add(this.textBoxKapacitet);
            this.Controls.Add(this.buttonOdustani);
            this.Controls.Add(this.buttonRezerviraj);
            this.Controls.Add(this.dataGridViewSoba);
            this.Controls.Add(this.popisSobaLabel);
            this.Name = "PregledSobaGost";
            this.Text = "PregledSobaGost";
            this.Load += new System.EventHandler(this.PregledSobaGost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFiltriraj;
        private System.Windows.Forms.TextBox textBoxKapacitet;
        private System.Windows.Forms.Button buttonOdustani;
        private System.Windows.Forms.Button buttonRezerviraj;
        private System.Windows.Forms.DataGridView dataGridViewSoba;
        private System.Windows.Forms.Label popisSobaLabel;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
    }
}