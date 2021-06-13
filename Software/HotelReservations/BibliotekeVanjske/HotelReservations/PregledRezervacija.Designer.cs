
namespace Projekt_faza_1
{
    partial class PregledRezervacija
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
            this.dataGridViewRezervacije = new System.Windows.Forms.DataGridView();
            this.labelPopisRezervacija = new System.Windows.Forms.Label();
            this.buttonPrijaviGosta = new System.Windows.Forms.Button();
            this.buttonOdjaviGosta = new System.Windows.Forms.Button();
            this.buttonPregledNeprijavljenih = new System.Windows.Forms.Button();
            this.buttonPrijavljeniGosti = new System.Windows.Forms.Button();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRezervacije
            // 
            this.dataGridViewRezervacije.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervacije.Location = new System.Drawing.Point(249, 98);
            this.dataGridViewRezervacije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRezervacije.Name = "dataGridViewRezervacije";
            this.dataGridViewRezervacije.RowHeadersWidth = 51;
            this.dataGridViewRezervacije.RowTemplate.Height = 24;
            this.dataGridViewRezervacije.Size = new System.Drawing.Size(879, 265);
            this.dataGridViewRezervacije.TabIndex = 0;
            // 
            // labelPopisRezervacija
            // 
            this.labelPopisRezervacija.AutoSize = true;
            this.labelPopisRezervacija.Font = new System.Drawing.Font("Lucida Sans", 13.8F);
            this.labelPopisRezervacija.Location = new System.Drawing.Point(523, 43);
            this.labelPopisRezervacija.Name = "labelPopisRezervacija";
            this.labelPopisRezervacija.Size = new System.Drawing.Size(212, 27);
            this.labelPopisRezervacija.TabIndex = 1;
            this.labelPopisRezervacija.Text = "Popis rezervacija";
            // 
            // buttonPrijaviGosta
            // 
            this.buttonPrijaviGosta.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPrijaviGosta.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonPrijaviGosta.Location = new System.Drawing.Point(269, 396);
            this.buttonPrijaviGosta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrijaviGosta.Name = "buttonPrijaviGosta";
            this.buttonPrijaviGosta.Size = new System.Drawing.Size(159, 57);
            this.buttonPrijaviGosta.TabIndex = 2;
            this.buttonPrijaviGosta.Text = "Prijavi gosta ";
            this.buttonPrijaviGosta.UseVisualStyleBackColor = false;
            this.buttonPrijaviGosta.Click += new System.EventHandler(this.buttonPrijaviGosta_Click);
            // 
            // buttonOdjaviGosta
            // 
            this.buttonOdjaviGosta.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOdjaviGosta.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonOdjaviGosta.Location = new System.Drawing.Point(451, 396);
            this.buttonOdjaviGosta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOdjaviGosta.Name = "buttonOdjaviGosta";
            this.buttonOdjaviGosta.Size = new System.Drawing.Size(159, 57);
            this.buttonOdjaviGosta.TabIndex = 3;
            this.buttonOdjaviGosta.Text = "Odjavi gosta";
            this.buttonOdjaviGosta.UseVisualStyleBackColor = false;
            this.buttonOdjaviGosta.Click += new System.EventHandler(this.buttonOdjaviGosta_Click);
            // 
            // buttonPregledNeprijavljenih
            // 
            this.buttonPregledNeprijavljenih.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPregledNeprijavljenih.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonPregledNeprijavljenih.Location = new System.Drawing.Point(15, 98);
            this.buttonPregledNeprijavljenih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPregledNeprijavljenih.Name = "buttonPregledNeprijavljenih";
            this.buttonPregledNeprijavljenih.Size = new System.Drawing.Size(199, 57);
            this.buttonPregledNeprijavljenih.TabIndex = 5;
            this.buttonPregledNeprijavljenih.Text = "Neprijavljeni gosti";
            this.buttonPregledNeprijavljenih.UseVisualStyleBackColor = false;
            this.buttonPregledNeprijavljenih.Click += new System.EventHandler(this.buttonPregledNeprijavljenih_Click);
            // 
            // buttonPrijavljeniGosti
            // 
            this.buttonPrijavljeniGosti.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPrijavljeniGosti.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonPrijavljeniGosti.Location = new System.Drawing.Point(15, 201);
            this.buttonPrijavljeniGosti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrijavljeniGosti.Name = "buttonPrijavljeniGosti";
            this.buttonPrijavljeniGosti.Size = new System.Drawing.Size(199, 52);
            this.buttonPrijavljeniGosti.TabIndex = 6;
            this.buttonPrijavljeniGosti.Text = "Prijavljeni gosti";
            this.buttonPrijavljeniGosti.UseVisualStyleBackColor = false;
            this.buttonPrijavljeniGosti.Click += new System.EventHandler(this.buttonPrijavljeniGosti_Click);
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.SteelBlue;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.roundButtonNatrag.Location = new System.Drawing.Point(27, 405);
            this.roundButtonNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(55, 48);
            this.roundButtonNatrag.TabIndex = 107;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // PregledRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_faza_1.Properties.Resources.backgroundLogin;
            this.ClientSize = new System.Drawing.Size(1215, 508);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.buttonPrijavljeniGosti);
            this.Controls.Add(this.buttonPregledNeprijavljenih);
            this.Controls.Add(this.buttonOdjaviGosta);
            this.Controls.Add(this.buttonPrijaviGosta);
            this.Controls.Add(this.labelPopisRezervacija);
            this.Controls.Add(this.dataGridViewRezervacije);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PregledRezervacija";
            this.Text = "Pregled rezervacija";
            this.Load += new System.EventHandler(this.PregledRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRezervacije;
        private System.Windows.Forms.Label labelPopisRezervacija;
        private System.Windows.Forms.Button buttonPrijaviGosta;
        private System.Windows.Forms.Button buttonOdjaviGosta;
        private System.Windows.Forms.Button buttonPregledNeprijavljenih;
        private System.Windows.Forms.Button buttonPrijavljeniGosti;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
    }
}