
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
            this.odustaniButton = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.naslovLabel = new System.Windows.Forms.Label();
            this.upitLabel = new System.Windows.Forms.Label();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOIB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBrojSobe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxHotel = new System.Windows.Forms.ComboBox();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            this.SuspendLayout();
            // 
            // odustaniButton
            // 
            this.odustaniButton.BackColor = System.Drawing.Color.DimGray;
            this.odustaniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.odustaniButton.Location = new System.Drawing.Point(555, 405);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(179, 59);
            this.odustaniButton.TabIndex = 14;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = false;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.Color.DimGray;
            this.btnPosalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPosalji.Location = new System.Drawing.Point(359, 405);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(179, 59);
            this.btnPosalji.TabIndex = 13;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // naslovLabel
            // 
            this.naslovLabel.AutoSize = true;
            this.naslovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslovLabel.Location = new System.Drawing.Point(317, 28);
            this.naslovLabel.Name = "naslovLabel";
            this.naslovLabel.Size = new System.Drawing.Size(158, 29);
            this.naslovLabel.TabIndex = 12;
            this.naslovLabel.Text = "Prijavi kvar:";
            this.naslovLabel.Click += new System.EventHandler(this.naslovLabel_Click);
            // 
            // upitLabel
            // 
            this.upitLabel.AutoSize = true;
            this.upitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.upitLabel.Location = new System.Drawing.Point(45, 254);
            this.upitLabel.Name = "upitLabel";
            this.upitLabel.Size = new System.Drawing.Size(261, 26);
            this.upitLabel.TabIndex = 11;
            this.upitLabel.Text = "Ovdje napišite opis kvara:";
            // 
            // opisTextBox
            // 
            this.opisTextBox.Location = new System.Drawing.Point(359, 259);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(375, 103);
            this.opisTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(45, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Broj sobe:";
            // 
            // textBoxOIB
            // 
            this.textBoxOIB.Location = new System.Drawing.Point(359, 99);
            this.textBoxOIB.Name = "textBoxOIB";
            this.textBoxOIB.Size = new System.Drawing.Size(331, 22);
            this.textBoxOIB.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(45, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "OIB  gosta:";
            // 
            // textBoxBrojSobe
            // 
            this.textBoxBrojSobe.Location = new System.Drawing.Point(359, 215);
            this.textBoxBrojSobe.Name = "textBoxBrojSobe";
            this.textBoxBrojSobe.Size = new System.Drawing.Size(116, 22);
            this.textBoxBrojSobe.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(45, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 105;
            this.label3.Text = "Hotel:";
            // 
            // comboBoxHotel
            // 
            this.comboBoxHotel.FormattingEnabled = true;
            this.comboBoxHotel.Location = new System.Drawing.Point(359, 161);
            this.comboBoxHotel.Name = "comboBoxHotel";
            this.comboBoxHotel.Size = new System.Drawing.Size(315, 24);
            this.comboBoxHotel.TabIndex = 106;
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.Thistle;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonNatrag.Location = new System.Drawing.Point(37, 416);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(55, 48);
            this.roundButtonNatrag.TabIndex = 104;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // PrijavaKvara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.comboBoxHotel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.textBoxBrojSobe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOIB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.naslovLabel);
            this.Controls.Add(this.upitLabel);
            this.Controls.Add(this.opisTextBox);
            this.Name = "PrijavaKvara";
            this.Text = "PrijavaKvara";
            this.Load += new System.EventHandler(this.PrijavaKvara_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Label naslovLabel;
        private System.Windows.Forms.Label upitLabel;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOIB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBrojSobe;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxHotel;
    }
}