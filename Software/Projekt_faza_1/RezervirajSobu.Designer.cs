
namespace Projekt_faza_1
{
    partial class RezervirajSobu
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
            this.brojSobeTextBox = new System.Windows.Forms.TextBox();
            this.cijenaLabel = new System.Windows.Forms.Label();
            this.datumOdlaskaLabel = new System.Windows.Forms.Label();
            this.datumDolaskaLabel = new System.Windows.Forms.Label();
            this.brojSobeLabel = new System.Windows.Forms.Label();
            this.rezervirajSobuLabel = new System.Windows.Forms.Label();
            this.datumDolaskadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datumOdlaskadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rezervirajSobuButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.labelCijena = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            this.SuspendLayout();
            // 
            // brojSobeTextBox
            // 
            this.brojSobeTextBox.Enabled = false;
            this.brojSobeTextBox.Location = new System.Drawing.Point(398, 128);
            this.brojSobeTextBox.Name = "brojSobeTextBox";
            this.brojSobeTextBox.Size = new System.Drawing.Size(272, 22);
            this.brojSobeTextBox.TabIndex = 87;
            // 
            // cijenaLabel
            // 
            this.cijenaLabel.AutoSize = true;
            this.cijenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cijenaLabel.Location = new System.Drawing.Point(220, 287);
            this.cijenaLabel.Name = "cijenaLabel";
            this.cijenaLabel.Size = new System.Drawing.Size(74, 25);
            this.cijenaLabel.TabIndex = 86;
            this.cijenaLabel.Text = "Cijena:";
            this.cijenaLabel.Click += new System.EventHandler(this.cijenaLabel_Click);
            // 
            // datumOdlaskaLabel
            // 
            this.datumOdlaskaLabel.AutoSize = true;
            this.datumOdlaskaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datumOdlaskaLabel.Location = new System.Drawing.Point(220, 237);
            this.datumOdlaskaLabel.Name = "datumOdlaskaLabel";
            this.datumOdlaskaLabel.Size = new System.Drawing.Size(148, 25);
            this.datumOdlaskaLabel.TabIndex = 85;
            this.datumOdlaskaLabel.Text = "Datum odlaska:";
            // 
            // datumDolaskaLabel
            // 
            this.datumDolaskaLabel.AutoSize = true;
            this.datumDolaskaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.datumDolaskaLabel.Location = new System.Drawing.Point(220, 182);
            this.datumDolaskaLabel.Name = "datumDolaskaLabel";
            this.datumDolaskaLabel.Size = new System.Drawing.Size(148, 25);
            this.datumDolaskaLabel.TabIndex = 83;
            this.datumDolaskaLabel.Text = "Datum dolaska:";
            // 
            // brojSobeLabel
            // 
            this.brojSobeLabel.AutoSize = true;
            this.brojSobeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.brojSobeLabel.Location = new System.Drawing.Point(220, 128);
            this.brojSobeLabel.Name = "brojSobeLabel";
            this.brojSobeLabel.Size = new System.Drawing.Size(100, 25);
            this.brojSobeLabel.TabIndex = 80;
            this.brojSobeLabel.Text = "Broj sobe:";
            // 
            // rezervirajSobuLabel
            // 
            this.rezervirajSobuLabel.AutoSize = true;
            this.rezervirajSobuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezervirajSobuLabel.Location = new System.Drawing.Point(347, 41);
            this.rezervirajSobuLabel.Name = "rezervirajSobuLabel";
            this.rezervirajSobuLabel.Size = new System.Drawing.Size(204, 29);
            this.rezervirajSobuLabel.TabIndex = 79;
            this.rezervirajSobuLabel.Text = "Rezerviraj sobu";
            // 
            // datumDolaskadateTimePicker
            // 
            this.datumDolaskadateTimePicker.Location = new System.Drawing.Point(398, 185);
            this.datumDolaskadateTimePicker.Name = "datumDolaskadateTimePicker";
            this.datumDolaskadateTimePicker.Size = new System.Drawing.Size(272, 22);
            this.datumDolaskadateTimePicker.TabIndex = 101;
            // 
            // datumOdlaskadateTimePicker
            // 
            this.datumOdlaskadateTimePicker.Location = new System.Drawing.Point(398, 239);
            this.datumOdlaskadateTimePicker.Name = "datumOdlaskadateTimePicker";
            this.datumOdlaskadateTimePicker.Size = new System.Drawing.Size(272, 22);
            this.datumOdlaskadateTimePicker.TabIndex = 102;
            // 
            // rezervirajSobuButton
            // 
            this.rezervirajSobuButton.BackColor = System.Drawing.Color.Thistle;
            this.rezervirajSobuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rezervirajSobuButton.Location = new System.Drawing.Point(414, 387);
            this.rezervirajSobuButton.Name = "rezervirajSobuButton";
            this.rezervirajSobuButton.Size = new System.Drawing.Size(206, 50);
            this.rezervirajSobuButton.TabIndex = 103;
            this.rezervirajSobuButton.Text = "Rezerviraj sobu";
            this.rezervirajSobuButton.UseVisualStyleBackColor = false;
            this.rezervirajSobuButton.Click += new System.EventHandler(this.rezervirajSobuButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.BackColor = System.Drawing.Color.DimGray;
            this.odustaniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.odustaniButton.Location = new System.Drawing.Point(642, 387);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(206, 50);
            this.odustaniButton.TabIndex = 104;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = false;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // labelCijena
            // 
            this.labelCijena.AutoSize = true;
            this.labelCijena.Location = new System.Drawing.Point(395, 287);
            this.labelCijena.Name = "labelCijena";
            this.labelCijena.Size = new System.Drawing.Size(77, 17);
            this.labelCijena.TabIndex = 105;
            this.labelCijena.Text = "labelCijena";
            this.labelCijena.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 106;
            this.label1.Text = "kn";
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.BackColor = System.Drawing.Color.Thistle;
            this.buttonPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonPrikazi.Location = new System.Drawing.Point(180, 387);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(206, 50);
            this.buttonPrikazi.TabIndex = 107;
            this.buttonPrikazi.Text = "Prikaži ponudu";
            this.buttonPrikazi.UseVisualStyleBackColor = false;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.Thistle;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonNatrag.Location = new System.Drawing.Point(91, 387);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(55, 48);
            this.roundButtonNatrag.TabIndex = 108;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            // 
            // RezervirajSobu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 505);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.buttonPrikazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCijena);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.rezervirajSobuButton);
            this.Controls.Add(this.datumOdlaskadateTimePicker);
            this.Controls.Add(this.datumDolaskadateTimePicker);
            this.Controls.Add(this.brojSobeTextBox);
            this.Controls.Add(this.cijenaLabel);
            this.Controls.Add(this.datumOdlaskaLabel);
            this.Controls.Add(this.datumDolaskaLabel);
            this.Controls.Add(this.brojSobeLabel);
            this.Controls.Add(this.rezervirajSobuLabel);
            this.Name = "RezervirajSobu";
            this.Text = "Rezerviraj sobu";
            this.Load += new System.EventHandler(this.RezervirajSobu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox brojSobeTextBox;
        private System.Windows.Forms.Label cijenaLabel;
        private System.Windows.Forms.Label datumOdlaskaLabel;
        private System.Windows.Forms.Label datumDolaskaLabel;
        private System.Windows.Forms.Label brojSobeLabel;
        private System.Windows.Forms.Label rezervirajSobuLabel;
        private System.Windows.Forms.DateTimePicker datumDolaskadateTimePicker;
        private System.Windows.Forms.DateTimePicker datumOdlaskadateTimePicker;
        private System.Windows.Forms.Button rezervirajSobuButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Label labelCijena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrikazi;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
    }
}