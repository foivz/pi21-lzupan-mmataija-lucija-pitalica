
namespace Projekt_faza_1
{
    partial class RecenzijaForma
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
            this.textBoxBrojSobe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOIB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.naslovLabel = new System.Windows.Forms.Label();
            this.upitLabel = new System.Windows.Forms.Label();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownOcjena = new System.Windows.Forms.NumericUpDown();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAdresaiNaziv = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOcjena)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBrojSobe
            // 
            this.textBoxBrojSobe.Location = new System.Drawing.Point(339, 192);
            this.textBoxBrojSobe.Name = "textBoxBrojSobe";
            this.textBoxBrojSobe.Size = new System.Drawing.Size(116, 22);
            this.textBoxBrojSobe.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(59, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "OIB :";
            // 
            // textBoxOIB
            // 
            this.textBoxOIB.Location = new System.Drawing.Point(339, 116);
            this.textBoxOIB.Name = "textBoxOIB";
            this.textBoxOIB.Size = new System.Drawing.Size(331, 22);
            this.textBoxOIB.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(59, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Broj sobe:";
            // 
            // odustaniButton
            // 
            this.odustaniButton.BackColor = System.Drawing.Color.DimGray;
            this.odustaniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.odustaniButton.Location = new System.Drawing.Point(535, 584);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(179, 59);
            this.odustaniButton.TabIndex = 23;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = false;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.Color.DimGray;
            this.btnPosalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPosalji.Location = new System.Drawing.Point(339, 584);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(179, 59);
            this.btnPosalji.TabIndex = 22;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // naslovLabel
            // 
            this.naslovLabel.AutoSize = true;
            this.naslovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslovLabel.Location = new System.Drawing.Point(253, 38);
            this.naslovLabel.Name = "naslovLabel";
            this.naslovLabel.Size = new System.Drawing.Size(134, 29);
            this.naslovLabel.TabIndex = 21;
            this.naslovLabel.Text = "Recenzija";
            // 
            // upitLabel
            // 
            this.upitLabel.AutoSize = true;
            this.upitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.upitLabel.Location = new System.Drawing.Point(59, 271);
            this.upitLabel.Name = "upitLabel";
            this.upitLabel.Size = new System.Drawing.Size(63, 26);
            this.upitLabel.TabIndex = 20;
            this.upitLabel.Text = "Opis:";
            // 
            // opisTextBox
            // 
            this.opisTextBox.Location = new System.Drawing.Point(339, 276);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(421, 103);
            this.opisTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(59, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ocjena";
            // 
            // numericUpDownOcjena
            // 
            this.numericUpDownOcjena.Location = new System.Drawing.Point(339, 491);
            this.numericUpDownOcjena.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownOcjena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOcjena.Name = "numericUpDownOcjena";
            this.numericUpDownOcjena.Size = new System.Drawing.Size(141, 22);
            this.numericUpDownOcjena.TabIndex = 29;
            this.numericUpDownOcjena.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.Thistle;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonNatrag.Location = new System.Drawing.Point(41, 595);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(55, 48);
            this.roundButtonNatrag.TabIndex = 104;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(59, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 33);
            this.label4.TabIndex = 105;
            this.label4.Text = "Naziv hotela:";
            // 
            // comboBoxAdresaiNaziv
            // 
            this.comboBoxAdresaiNaziv.FormattingEnabled = true;
            this.comboBoxAdresaiNaziv.Location = new System.Drawing.Point(339, 416);
            this.comboBoxAdresaiNaziv.Name = "comboBoxAdresaiNaziv";
            this.comboBoxAdresaiNaziv.Size = new System.Drawing.Size(247, 24);
            this.comboBoxAdresaiNaziv.TabIndex = 107;
            // 
            // RecenzijaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 785);
            this.Controls.Add(this.comboBoxAdresaiNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.numericUpDownOcjena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBrojSobe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOIB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.naslovLabel);
            this.Controls.Add(this.upitLabel);
            this.Controls.Add(this.opisTextBox);
            this.Name = "RecenzijaForma";
            this.Text = "RecenzijaForma";
            this.Load += new System.EventHandler(this.RecenzijaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOcjena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBrojSobe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOIB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Label naslovLabel;
        private System.Windows.Forms.Label upitLabel;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownOcjena;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAdresaiNaziv;
    }
}