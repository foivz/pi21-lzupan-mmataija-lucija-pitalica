
namespace Projekt_faza_1
{
    partial class PostaviUpit
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
            this.upitLabel = new System.Windows.Forms.Label();
            this.upitTextBox = new System.Windows.Forms.TextBox();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPosalji.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.btnPosalji.Location = new System.Drawing.Point(258, 313);
            this.btnPosalji.Margin = new System.Windows.Forms.Padding(2);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(134, 48);
            this.btnPosalji.TabIndex = 8;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // naslovLabel
            // 
            this.naslovLabel.AutoSize = true;
            this.naslovLabel.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold);
            this.naslovLabel.Location = new System.Drawing.Point(178, 22);
            this.naslovLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.naslovLabel.Name = "naslovLabel";
            this.naslovLabel.Size = new System.Drawing.Size(143, 23);
            this.naslovLabel.TabIndex = 7;
            this.naslovLabel.Text = "Postavi upit:";
            // 
            // upitLabel
            // 
            this.upitLabel.AutoSize = true;
            this.upitLabel.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.upitLabel.Location = new System.Drawing.Point(30, 103);
            this.upitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.upitLabel.Name = "upitLabel";
            this.upitLabel.Size = new System.Drawing.Size(229, 21);
            this.upitLabel.TabIndex = 6;
            this.upitLabel.Text = "Ovdje napišite svoj upit:";
            // 
            // upitTextBox
            // 
            this.upitTextBox.Location = new System.Drawing.Point(274, 103);
            this.upitTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.upitTextBox.Multiline = true;
            this.upitTextBox.Name = "upitTextBox";
            this.upitTextBox.Size = new System.Drawing.Size(263, 91);
            this.upitTextBox.TabIndex = 5;
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.SteelBlue;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonNatrag.Location = new System.Drawing.Point(191, 318);
            this.roundButtonNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(41, 39);
            this.roundButtonNatrag.TabIndex = 104;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label1.Location = new System.Drawing.Point(30, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 21);
            this.label1.TabIndex = 105;
            this.label1.Text = "Ostavite svoj kontakt:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(274, 211);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(263, 20);
            this.textBoxEmail.TabIndex = 106;
            // 
            // PostaviUpit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Projekt_faza_1.Properties.Resources.upitSlika;
            this.ClientSize = new System.Drawing.Size(581, 421);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.naslovLabel);
            this.Controls.Add(this.upitLabel);
            this.Controls.Add(this.upitTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PostaviUpit";
            this.Text = "Postavi upit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Label naslovLabel;
        private System.Windows.Forms.Label upitLabel;
        private System.Windows.Forms.TextBox upitTextBox;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}