
namespace Projekt_faza_1
{
    partial class PopravioKvar
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
            this.labelOIB = new System.Windows.Forms.Label();
            this.textBoxImePrezime = new System.Windows.Forms.TextBox();
            this.labelDatum = new System.Windows.Forms.Label();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.naslovLabel = new System.Windows.Forms.Label();
            this.upitLabel = new System.Windows.Forms.Label();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCijena = new System.Windows.Forms.TextBox();
            this.numericUpDownVrijeme = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            this.textBoxBrojKvara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVrijeme)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOIB
            // 
            this.labelOIB.AutoSize = true;
            this.labelOIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelOIB.Location = new System.Drawing.Point(73, 77);
            this.labelOIB.Name = "labelOIB";
            this.labelOIB.Size = new System.Drawing.Size(177, 26);
            this.labelOIB.TabIndex = 26;
            this.labelOIB.Text = "OIB zaposlenika:";
            // 
            // textBoxImePrezime
            // 
            this.textBoxImePrezime.Location = new System.Drawing.Point(353, 82);
            this.textBoxImePrezime.Name = "textBoxImePrezime";
            this.textBoxImePrezime.Size = new System.Drawing.Size(375, 22);
            this.textBoxImePrezime.TabIndex = 25;
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelDatum.Location = new System.Drawing.Point(73, 154);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(178, 26);
            this.labelDatum.TabIndex = 24;
            this.labelDatum.Text = "Datum popravka:";
            // 
            // odustaniButton
            // 
            this.odustaniButton.BackColor = System.Drawing.Color.DimGray;
            this.odustaniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.odustaniButton.Location = new System.Drawing.Point(549, 388);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(179, 59);
            this.odustaniButton.TabIndex = 23;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = false;
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.Color.DimGray;
            this.btnPosalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPosalji.Location = new System.Drawing.Point(353, 388);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(179, 59);
            this.btnPosalji.TabIndex = 22;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            // 
            // naslovLabel
            // 
            this.naslovLabel.AutoSize = true;
            this.naslovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslovLabel.Location = new System.Drawing.Point(172, 9);
            this.naslovLabel.Name = "naslovLabel";
            this.naslovLabel.Size = new System.Drawing.Size(311, 29);
            this.naslovLabel.TabIndex = 21;
            this.naslovLabel.Text = "Redni broj prijave kvara:";
            this.naslovLabel.Click += new System.EventHandler(this.naslovLabel_Click);
            // 
            // upitLabel
            // 
            this.upitLabel.AutoSize = true;
            this.upitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.upitLabel.Location = new System.Drawing.Point(73, 286);
            this.upitLabel.Name = "upitLabel";
            this.upitLabel.Size = new System.Drawing.Size(80, 26);
            this.upitLabel.TabIndex = 20;
            this.upitLabel.Text = "Cijena:";
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(353, 154);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(251, 22);
            this.dateTimePickerDatum.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(73, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "Vrijeme trajanja popravka:";
            // 
            // textBoxCijena
            // 
            this.textBoxCijena.Location = new System.Drawing.Point(353, 291);
            this.textBoxCijena.Name = "textBoxCijena";
            this.textBoxCijena.Size = new System.Drawing.Size(375, 22);
            this.textBoxCijena.TabIndex = 32;
            // 
            // numericUpDownVrijeme
            // 
            this.numericUpDownVrijeme.Location = new System.Drawing.Point(353, 228);
            this.numericUpDownVrijeme.Name = "numericUpDownVrijeme";
            this.numericUpDownVrijeme.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownVrijeme.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "h";
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.Thistle;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonNatrag.Location = new System.Drawing.Point(28, 390);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(55, 48);
            this.roundButtonNatrag.TabIndex = 104;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            // 
            // textBoxBrojKvara
            // 
            this.textBoxBrojKvara.Location = new System.Drawing.Point(501, 16);
            this.textBoxBrojKvara.Name = "textBoxBrojKvara";
            this.textBoxBrojKvara.Size = new System.Drawing.Size(72, 22);
            this.textBoxBrojKvara.TabIndex = 28;
            // 
            // PopravioKvar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownVrijeme);
            this.Controls.Add(this.textBoxCijena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.textBoxBrojKvara);
            this.Controls.Add(this.labelOIB);
            this.Controls.Add(this.textBoxImePrezime);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.naslovLabel);
            this.Controls.Add(this.upitLabel);
            this.Name = "PopravioKvar";
            this.Text = "PopravioKvar";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVrijeme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelOIB;
        private System.Windows.Forms.TextBox textBoxImePrezime;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Label naslovLabel;
        private System.Windows.Forms.Label upitLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCijena;
        private System.Windows.Forms.NumericUpDown numericUpDownVrijeme;
        private System.Windows.Forms.Label label2;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
        private System.Windows.Forms.TextBox textBoxBrojKvara;
    }
}