
namespace Projekt_faza_1
{
    partial class PrijavaKvara
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
            this.btnPosalji = new System.Windows.Forms.Button();
            this.naslovLabel = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.labelBrojSobe = new System.Windows.Forms.Label();
            this.textBoxOIB = new System.Windows.Forms.TextBox();
            this.labelOIBGosta = new System.Windows.Forms.Label();
            this.textBoxBrojSobe = new System.Windows.Forms.TextBox();
            this.labelHotel = new System.Windows.Forms.Label();
            this.comboBoxHotel = new System.Windows.Forms.ComboBox();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPosalji.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.btnPosalji.Location = new System.Drawing.Point(282, 457);
            this.btnPosalji.Margin = new System.Windows.Forms.Padding(2);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(134, 48);
            this.btnPosalji.TabIndex = 13;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // naslovLabel
            // 
            this.naslovLabel.AutoSize = true;
            this.naslovLabel.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold);
            this.naslovLabel.Location = new System.Drawing.Point(34, 51);
            this.naslovLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.naslovLabel.Name = "naslovLabel";
            this.naslovLabel.Size = new System.Drawing.Size(136, 23);
            this.naslovLabel.TabIndex = 12;
            this.naslovLabel.Text = "Prijavi kvar:";
            this.naslovLabel.Click += new System.EventHandler(this.naslovLabel_Click);
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.labelOpis.Location = new System.Drawing.Point(35, 333);
            this.labelOpis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(244, 21);
            this.labelOpis.TabIndex = 11;
            this.labelOpis.Text = "Ovdje napišite opis kvara:";
            // 
            // opisTextBox
            // 
            this.opisTextBox.Location = new System.Drawing.Point(283, 333);
            this.opisTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(282, 84);
            this.opisTextBox.TabIndex = 10;
            // 
            // labelBrojSobe
            // 
            this.labelBrojSobe.AutoSize = true;
            this.labelBrojSobe.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.labelBrojSobe.Location = new System.Drawing.Point(35, 298);
            this.labelBrojSobe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBrojSobe.Name = "labelBrojSobe";
            this.labelBrojSobe.Size = new System.Drawing.Size(99, 21);
            this.labelBrojSobe.TabIndex = 15;
            this.labelBrojSobe.Text = "Broj sobe:";
            // 
            // textBoxOIB
            // 
            this.textBoxOIB.Location = new System.Drawing.Point(282, 207);
            this.textBoxOIB.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOIB.Name = "textBoxOIB";
            this.textBoxOIB.Size = new System.Drawing.Size(249, 20);
            this.textBoxOIB.TabIndex = 16;
            // 
            // labelOIBGosta
            // 
            this.labelOIBGosta.AutoSize = true;
            this.labelOIBGosta.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.labelOIBGosta.Location = new System.Drawing.Point(35, 204);
            this.labelOIBGosta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOIBGosta.Name = "labelOIBGosta";
            this.labelOIBGosta.Size = new System.Drawing.Size(106, 21);
            this.labelOIBGosta.TabIndex = 17;
            this.labelOIBGosta.Text = "OIB  gosta:";
            // 
            // textBoxBrojSobe
            // 
            this.textBoxBrojSobe.Location = new System.Drawing.Point(283, 299);
            this.textBoxBrojSobe.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBrojSobe.Name = "textBoxBrojSobe";
            this.textBoxBrojSobe.Size = new System.Drawing.Size(88, 20);
            this.textBoxBrojSobe.TabIndex = 18;
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.labelHotel.Location = new System.Drawing.Point(35, 256);
            this.labelHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(63, 21);
            this.labelHotel.TabIndex = 105;
            this.labelHotel.Text = "Hotel:";
            // 
            // comboBoxHotel
            // 
            this.comboBoxHotel.FormattingEnabled = true;
            this.comboBoxHotel.Location = new System.Drawing.Point(283, 257);
            this.comboBoxHotel.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxHotel.Name = "comboBoxHotel";
            this.comboBoxHotel.Size = new System.Drawing.Size(237, 21);
            this.comboBoxHotel.TabIndex = 106;
            this.comboBoxHotel.SelectedIndexChanged += new System.EventHandler(this.comboBoxHotel_SelectedIndexChanged);
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.SteelBlue;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
            this.roundButtonNatrag.Location = new System.Drawing.Point(25, 466);
            this.roundButtonNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(41, 39);
            this.roundButtonNatrag.TabIndex = 104;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projekt_faza_1.Properties.Resources.prijavaKvara;
            this.pictureBox1.Location = new System.Drawing.Point(270, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 190);
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // PrijavaKvara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_faza_1.Properties.Resources.backgroundLogin;
            this.ClientSize = new System.Drawing.Size(600, 541);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxHotel);
            this.Controls.Add(this.labelHotel);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.textBoxBrojSobe);
            this.Controls.Add(this.labelOIBGosta);
            this.Controls.Add(this.textBoxOIB);
            this.Controls.Add(this.labelBrojSobe);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.naslovLabel);
            this.Controls.Add(this.labelOpis);
            this.Controls.Add(this.opisTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PrijavaKvara";
            this.Text = "Prijava kvara";
            this.Load += new System.EventHandler(this.PrijavaKvara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Label naslovLabel;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.Label labelBrojSobe;
        private System.Windows.Forms.TextBox textBoxOIB;
        private System.Windows.Forms.Label labelOIBGosta;
        private System.Windows.Forms.TextBox textBoxBrojSobe;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.ComboBox comboBoxHotel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}