
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
            this.odustaniButton = new System.Windows.Forms.Button();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.naslovLabel = new System.Windows.Forms.Label();
            this.upitLabel = new System.Windows.Forms.Label();
            this.upitTextBox = new System.Windows.Forms.TextBox();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            this.SuspendLayout();
            // 
            // odustaniButton
            // 
            this.odustaniButton.BackColor = System.Drawing.Color.DimGray;
            this.odustaniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.odustaniButton.Location = new System.Drawing.Point(491, 194);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(179, 59);
            this.odustaniButton.TabIndex = 9;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = false;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.Color.DimGray;
            this.btnPosalji.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPosalji.Location = new System.Drawing.Point(295, 194);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(179, 59);
            this.btnPosalji.TabIndex = 8;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // naslovLabel
            // 
            this.naslovLabel.AutoSize = true;
            this.naslovLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslovLabel.Location = new System.Drawing.Point(182, 9);
            this.naslovLabel.Name = "naslovLabel";
            this.naslovLabel.Size = new System.Drawing.Size(165, 29);
            this.naslovLabel.TabIndex = 7;
            this.naslovLabel.Text = "Postavi upit:";
            // 
            // upitLabel
            // 
            this.upitLabel.AutoSize = true;
            this.upitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.upitLabel.Location = new System.Drawing.Point(12, 57);
            this.upitLabel.Name = "upitLabel";
            this.upitLabel.Size = new System.Drawing.Size(242, 26);
            this.upitLabel.TabIndex = 6;
            this.upitLabel.Text = "Ovdje napišite svoj upit:";
            // 
            // upitTextBox
            // 
            this.upitTextBox.Location = new System.Drawing.Point(295, 57);
            this.upitTextBox.Multiline = true;
            this.upitTextBox.Name = "upitTextBox";
            this.upitTextBox.Size = new System.Drawing.Size(375, 103);
            this.upitTextBox.TabIndex = 5;
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.Thistle;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonNatrag.Location = new System.Drawing.Point(17, 200);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(55, 48);
            this.roundButtonNatrag.TabIndex = 104;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            // 
            // PostaviUpit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 277);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.naslovLabel);
            this.Controls.Add(this.upitLabel);
            this.Controls.Add(this.upitTextBox);
            this.Name = "PostaviUpit";
            this.Text = "Postavi upit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Label naslovLabel;
        private System.Windows.Forms.Label upitLabel;
        private System.Windows.Forms.TextBox upitTextBox;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
    }
}