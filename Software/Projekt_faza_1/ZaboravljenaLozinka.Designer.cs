
namespace Projekt_faza_1
{
    partial class ZaboravljenaLozinka
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.zaboravljenaLozinkalbl = new System.Windows.Forms.Label();
            this.posaljiButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 22);
            this.textBox1.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblEmail.Location = new System.Drawing.Point(32, 66);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 26);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // zaboravljenaLozinkalbl
            // 
            this.zaboravljenaLozinkalbl.AutoSize = true;
            this.zaboravljenaLozinkalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zaboravljenaLozinkalbl.Location = new System.Drawing.Point(124, 18);
            this.zaboravljenaLozinkalbl.Name = "zaboravljenaLozinkalbl";
            this.zaboravljenaLozinkalbl.Size = new System.Drawing.Size(274, 29);
            this.zaboravljenaLozinkalbl.TabIndex = 2;
            this.zaboravljenaLozinkalbl.Text = "Zaboravljena lozinka:";
            // 
            // posaljiButton
            // 
            this.posaljiButton.BackColor = System.Drawing.Color.DimGray;
            this.posaljiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.posaljiButton.Location = new System.Drawing.Point(129, 168);
            this.posaljiButton.Name = "posaljiButton";
            this.posaljiButton.Size = new System.Drawing.Size(176, 35);
            this.posaljiButton.TabIndex = 3;
            this.posaljiButton.Text = "Pošalji";
            this.posaljiButton.UseVisualStyleBackColor = false;
            // 
            // odustaniButton
            // 
            this.odustaniButton.BackColor = System.Drawing.Color.DimGray;
            this.odustaniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.odustaniButton.Location = new System.Drawing.Point(316, 168);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(179, 35);
            this.odustaniButton.TabIndex = 4;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = false;
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.Thistle;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonNatrag.Location = new System.Drawing.Point(46, 155);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(55, 48);
            this.roundButtonNatrag.TabIndex = 104;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            // 
            // ZaboravljenaLozinka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 277);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.posaljiButton);
            this.Controls.Add(this.zaboravljenaLozinkalbl);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.textBox1);
            this.Name = "ZaboravljenaLozinka";
            this.Text = "Zaboravljena lozinka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label zaboravljenaLozinkalbl;
        private System.Windows.Forms.Button posaljiButton;
        private System.Windows.Forms.Button odustaniButton;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
    }
}