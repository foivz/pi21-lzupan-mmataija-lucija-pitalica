
namespace Projekt_faza_1
{
    partial class PregledUpita
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
            this.dataGridViewUpiti = new System.Windows.Forms.DataGridView();
            this.buttonNeodgovoreni = new System.Windows.Forms.Button();
            this.buttonOdgovoreniUpiti = new System.Windows.Forms.Button();
            this.labelUpiti = new System.Windows.Forms.Label();
            this.buttonOdgovori = new System.Windows.Forms.Button();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpiti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUpiti
            // 
            this.dataGridViewUpiti.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUpiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpiti.Location = new System.Drawing.Point(169, 78);
            this.dataGridViewUpiti.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUpiti.Name = "dataGridViewUpiti";
            this.dataGridViewUpiti.RowHeadersWidth = 51;
            this.dataGridViewUpiti.RowTemplate.Height = 24;
            this.dataGridViewUpiti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUpiti.Size = new System.Drawing.Size(665, 191);
            this.dataGridViewUpiti.TabIndex = 0;
            // 
            // buttonNeodgovoreni
            // 
            this.buttonNeodgovoreni.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonNeodgovoreni.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonNeodgovoreni.Location = new System.Drawing.Point(23, 78);
            this.buttonNeodgovoreni.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNeodgovoreni.Name = "buttonNeodgovoreni";
            this.buttonNeodgovoreni.Size = new System.Drawing.Size(122, 51);
            this.buttonNeodgovoreni.TabIndex = 1;
            this.buttonNeodgovoreni.Text = "Neodgovoreni upiti";
            this.buttonNeodgovoreni.UseVisualStyleBackColor = false;
            this.buttonNeodgovoreni.Click += new System.EventHandler(this.buttonNeodgovoreni_Click);
            // 
            // buttonOdgovoreniUpiti
            // 
            this.buttonOdgovoreniUpiti.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOdgovoreniUpiti.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonOdgovoreniUpiti.Location = new System.Drawing.Point(23, 133);
            this.buttonOdgovoreniUpiti.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOdgovoreniUpiti.Name = "buttonOdgovoreniUpiti";
            this.buttonOdgovoreniUpiti.Size = new System.Drawing.Size(122, 49);
            this.buttonOdgovoreniUpiti.TabIndex = 2;
            this.buttonOdgovoreniUpiti.Text = "Odgovoreni upiti";
            this.buttonOdgovoreniUpiti.UseVisualStyleBackColor = false;
            this.buttonOdgovoreniUpiti.Click += new System.EventHandler(this.buttonOdgovoreniUpiti_Click);
            // 
            // labelUpiti
            // 
            this.labelUpiti.AutoSize = true;
            this.labelUpiti.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.labelUpiti.Location = new System.Drawing.Point(165, 29);
            this.labelUpiti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUpiti.Name = "labelUpiti";
            this.labelUpiti.Size = new System.Drawing.Size(50, 18);
            this.labelUpiti.TabIndex = 3;
            this.labelUpiti.Text = "Upiti:";
            // 
            // buttonOdgovori
            // 
            this.buttonOdgovori.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOdgovori.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonOdgovori.Location = new System.Drawing.Point(169, 292);
            this.buttonOdgovori.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOdgovori.Name = "buttonOdgovori";
            this.buttonOdgovori.Size = new System.Drawing.Size(111, 49);
            this.buttonOdgovori.TabIndex = 4;
            this.buttonOdgovori.Text = "Odgovori";
            this.buttonOdgovori.UseVisualStyleBackColor = false;
            this.buttonOdgovori.Click += new System.EventHandler(this.buttonOdgovori_Click);
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.SteelBlue;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.roundButtonNatrag.Location = new System.Drawing.Point(34, 297);
            this.roundButtonNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(34, 35);
            this.roundButtonNatrag.TabIndex = 109;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // PregledUpita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_faza_1.Properties.Resources.backgroundLogin;
            this.ClientSize = new System.Drawing.Size(932, 384);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.buttonOdgovori);
            this.Controls.Add(this.labelUpiti);
            this.Controls.Add(this.buttonOdgovoreniUpiti);
            this.Controls.Add(this.buttonNeodgovoreni);
            this.Controls.Add(this.dataGridViewUpiti);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PregledUpita";
            this.Text = "Pregled upita";
            this.Load += new System.EventHandler(this.PregledUpita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpiti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUpiti;
        private System.Windows.Forms.Button buttonNeodgovoreni;
        private System.Windows.Forms.Button buttonOdgovoreniUpiti;
        private System.Windows.Forms.Label labelUpiti;
        private System.Windows.Forms.Button buttonOdgovori;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
    }
}