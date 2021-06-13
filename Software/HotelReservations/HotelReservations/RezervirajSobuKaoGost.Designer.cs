
namespace Projekt_faza_1
{
    partial class RezervirajSobuKaoGost
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
            this.datumOdlaskadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datumDolaskadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datumOdlaskaLabel = new System.Windows.Forms.Label();
            this.datumDolaskaLabel = new System.Windows.Forms.Label();
            this.rezervirajSobuLabel = new System.Windows.Forms.Label();
            this.buttonPrikaziHotele = new System.Windows.Forms.Button();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            this.SuspendLayout();
            // 
            // datumOdlaskadateTimePicker
            // 
            this.datumOdlaskadateTimePicker.Location = new System.Drawing.Point(174, 133);
            this.datumOdlaskadateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datumOdlaskadateTimePicker.Name = "datumOdlaskadateTimePicker";
            this.datumOdlaskadateTimePicker.Size = new System.Drawing.Size(205, 20);
            this.datumOdlaskadateTimePicker.TabIndex = 115;
            // 
            // datumDolaskadateTimePicker
            // 
            this.datumDolaskadateTimePicker.Location = new System.Drawing.Point(174, 89);
            this.datumDolaskadateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datumDolaskadateTimePicker.Name = "datumDolaskadateTimePicker";
            this.datumDolaskadateTimePicker.Size = new System.Drawing.Size(205, 20);
            this.datumDolaskadateTimePicker.TabIndex = 114;
            // 
            // datumOdlaskaLabel
            // 
            this.datumOdlaskaLabel.AutoSize = true;
            this.datumOdlaskaLabel.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.datumOdlaskaLabel.Location = new System.Drawing.Point(40, 131);
            this.datumOdlaskaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datumOdlaskaLabel.Name = "datumOdlaskaLabel";
            this.datumOdlaskaLabel.Size = new System.Drawing.Size(127, 18);
            this.datumOdlaskaLabel.TabIndex = 111;
            this.datumOdlaskaLabel.Text = "Datum odlaska:";
            // 
            // datumDolaskaLabel
            // 
            this.datumDolaskaLabel.AutoSize = true;
            this.datumDolaskaLabel.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.datumDolaskaLabel.Location = new System.Drawing.Point(40, 86);
            this.datumDolaskaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datumDolaskaLabel.Name = "datumDolaskaLabel";
            this.datumDolaskaLabel.Size = new System.Drawing.Size(127, 18);
            this.datumDolaskaLabel.TabIndex = 110;
            this.datumDolaskaLabel.Text = "Datum dolaska:";
            // 
            // rezervirajSobuLabel
            // 
            this.rezervirajSobuLabel.AutoSize = true;
            this.rezervirajSobuLabel.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold);
            this.rezervirajSobuLabel.Location = new System.Drawing.Point(157, 31);
            this.rezervirajSobuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rezervirajSobuLabel.Name = "rezervirajSobuLabel";
            this.rezervirajSobuLabel.Size = new System.Drawing.Size(175, 23);
            this.rezervirajSobuLabel.TabIndex = 108;
            this.rezervirajSobuLabel.Text = "Rezerviraj sobu";
            // 
            // buttonPrikaziHotele
            // 
            this.buttonPrikaziHotele.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPrikaziHotele.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.buttonPrikaziHotele.Location = new System.Drawing.Point(174, 188);
            this.buttonPrikaziHotele.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrikaziHotele.Name = "buttonPrikaziHotele";
            this.buttonPrikaziHotele.Size = new System.Drawing.Size(154, 41);
            this.buttonPrikaziHotele.TabIndex = 121;
            this.buttonPrikaziHotele.Text = "Prikaži hotele";
            this.buttonPrikaziHotele.UseVisualStyleBackColor = false;
            this.buttonPrikaziHotele.Click += new System.EventHandler(this.buttonPrikaziHotele_Click);
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.SteelBlue;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.roundButtonNatrag.Location = new System.Drawing.Point(43, 190);
            this.roundButtonNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(41, 39);
            this.roundButtonNatrag.TabIndex = 122;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // RezervirajSobuKaoGost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_faza_1.Properties.Resources.backgroundLogin;
            this.ClientSize = new System.Drawing.Size(498, 276);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.buttonPrikaziHotele);
            this.Controls.Add(this.datumOdlaskadateTimePicker);
            this.Controls.Add(this.datumDolaskadateTimePicker);
            this.Controls.Add(this.datumOdlaskaLabel);
            this.Controls.Add(this.datumDolaskaLabel);
            this.Controls.Add(this.rezervirajSobuLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RezervirajSobuKaoGost";
            this.Text = "Rezerviraj sobu";
            this.Load += new System.EventHandler(this.RezervirajSobuKaoGost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datumOdlaskadateTimePicker;
        private System.Windows.Forms.DateTimePicker datumDolaskadateTimePicker;
        private System.Windows.Forms.Label datumOdlaskaLabel;
        private System.Windows.Forms.Label datumDolaskaLabel;
        private System.Windows.Forms.Label rezervirajSobuLabel;
        private System.Windows.Forms.Button buttonPrikaziHotele;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
    }
}