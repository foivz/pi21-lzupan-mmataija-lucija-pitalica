
namespace Projekt_faza_1
{
    partial class OdgovorNaUpit
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
            this.groupBoxPodatciPoslijatelj = new System.Windows.Forms.GroupBox();
            this.checkBoxPrikaziLozinku = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPošiljatelj = new System.Windows.Forms.Label();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.textBoxPosiljateljMail = new System.Windows.Forms.TextBox();
            this.groupBoxPodaciPrimatelj = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrimateljMail = new System.Windows.Forms.TextBox();
            this.groupBoxEmailDetalji = new System.Windows.Forms.GroupBox();
            this.labelPrivitak = new System.Windows.Forms.Label();
            this.buttonIzaberi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNaslov = new System.Windows.Forms.TextBox();
            this.buttonPosalji = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSadrzaj = new System.Windows.Forms.TextBox();
            this.groupBoxPitanje = new System.Windows.Forms.GroupBox();
            this.textBoxPitanje = new System.Windows.Forms.TextBox();
            this.roundButtonNatrag = new WindowsFormsApplication1.RoundButton();
            this.groupBoxPodatciPoslijatelj.SuspendLayout();
            this.groupBoxPodaciPrimatelj.SuspendLayout();
            this.groupBoxEmailDetalji.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxPitanje.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPodatciPoslijatelj
            // 
            this.groupBoxPodatciPoslijatelj.Controls.Add(this.checkBoxPrikaziLozinku);
            this.groupBoxPodatciPoslijatelj.Controls.Add(this.label1);
            this.groupBoxPodatciPoslijatelj.Controls.Add(this.labelPošiljatelj);
            this.groupBoxPodatciPoslijatelj.Controls.Add(this.textBoxLozinka);
            this.groupBoxPodatciPoslijatelj.Controls.Add(this.textBoxPosiljateljMail);
            this.groupBoxPodatciPoslijatelj.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.groupBoxPodatciPoslijatelj.Location = new System.Drawing.Point(65, 30);
            this.groupBoxPodatciPoslijatelj.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPodatciPoslijatelj.Name = "groupBoxPodatciPoslijatelj";
            this.groupBoxPodatciPoslijatelj.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPodatciPoslijatelj.Size = new System.Drawing.Size(450, 148);
            this.groupBoxPodatciPoslijatelj.TabIndex = 0;
            this.groupBoxPodatciPoslijatelj.TabStop = false;
            this.groupBoxPodatciPoslijatelj.Text = "Podaci o pošiljatelju:";
            this.groupBoxPodatciPoslijatelj.Enter += new System.EventHandler(this.groupBoxPodatciPoslijatelj_Enter);
            // 
            // checkBoxPrikaziLozinku
            // 
            this.checkBoxPrikaziLozinku.AutoSize = true;
            this.checkBoxPrikaziLozinku.Location = new System.Drawing.Point(233, 115);
            this.checkBoxPrikaziLozinku.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxPrikaziLozinku.Name = "checkBoxPrikaziLozinku";
            this.checkBoxPrikaziLozinku.Size = new System.Drawing.Size(119, 19);
            this.checkBoxPrikaziLozinku.TabIndex = 6;
            this.checkBoxPrikaziLozinku.Text = "Prikaži lozinku";
            this.checkBoxPrikaziLozinku.UseVisualStyleBackColor = true;
            this.checkBoxPrikaziLozinku.CheckedChanged += new System.EventHandler(this.checkBoxPrikaziLozinku_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lozinka:";
            // 
            // labelPošiljatelj
            // 
            this.labelPošiljatelj.AutoSize = true;
            this.labelPošiljatelj.Location = new System.Drawing.Point(56, 43);
            this.labelPošiljatelj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPošiljatelj.Name = "labelPošiljatelj";
            this.labelPošiljatelj.Size = new System.Drawing.Size(109, 14);
            this.labelPošiljatelj.TabIndex = 4;
            this.labelPošiljatelj.Text = "Pošiljateljov e-mail:";
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(233, 79);
            this.textBoxLozinka.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(178, 20);
            this.textBoxLozinka.TabIndex = 1;
            this.textBoxLozinka.UseSystemPasswordChar = true;
            // 
            // textBoxPosiljateljMail
            // 
            this.textBoxPosiljateljMail.Location = new System.Drawing.Point(233, 43);
            this.textBoxPosiljateljMail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPosiljateljMail.Name = "textBoxPosiljateljMail";
            this.textBoxPosiljateljMail.Size = new System.Drawing.Size(178, 20);
            this.textBoxPosiljateljMail.TabIndex = 0;
            // 
            // groupBoxPodaciPrimatelj
            // 
            this.groupBoxPodaciPrimatelj.Controls.Add(this.label3);
            this.groupBoxPodaciPrimatelj.Controls.Add(this.textBoxPrimateljMail);
            this.groupBoxPodaciPrimatelj.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.groupBoxPodaciPrimatelj.Location = new System.Drawing.Point(65, 193);
            this.groupBoxPodaciPrimatelj.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPodaciPrimatelj.Name = "groupBoxPodaciPrimatelj";
            this.groupBoxPodaciPrimatelj.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPodaciPrimatelj.Size = new System.Drawing.Size(450, 65);
            this.groupBoxPodaciPrimatelj.TabIndex = 9;
            this.groupBoxPodaciPrimatelj.TabStop = false;
            this.groupBoxPodaciPrimatelj.Text = "Podaci o primatelju:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Primateljov e-mail:";
            // 
            // textBoxPrimateljMail
            // 
            this.textBoxPrimateljMail.Location = new System.Drawing.Point(233, 32);
            this.textBoxPrimateljMail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrimateljMail.Name = "textBoxPrimateljMail";
            this.textBoxPrimateljMail.Size = new System.Drawing.Size(178, 20);
            this.textBoxPrimateljMail.TabIndex = 9;
            // 
            // groupBoxEmailDetalji
            // 
            this.groupBoxEmailDetalji.Controls.Add(this.labelPrivitak);
            this.groupBoxEmailDetalji.Controls.Add(this.buttonIzaberi);
            this.groupBoxEmailDetalji.Controls.Add(this.label4);
            this.groupBoxEmailDetalji.Controls.Add(this.textBoxNaslov);
            this.groupBoxEmailDetalji.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.groupBoxEmailDetalji.Location = new System.Drawing.Point(65, 274);
            this.groupBoxEmailDetalji.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEmailDetalji.Name = "groupBoxEmailDetalji";
            this.groupBoxEmailDetalji.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEmailDetalji.Size = new System.Drawing.Size(450, 139);
            this.groupBoxEmailDetalji.TabIndex = 10;
            this.groupBoxEmailDetalji.TabStop = false;
            this.groupBoxEmailDetalji.Text = "E-mail detalji:";
            // 
            // labelPrivitak
            // 
            this.labelPrivitak.AutoSize = true;
            this.labelPrivitak.Location = new System.Drawing.Point(58, 68);
            this.labelPrivitak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrivitak.Name = "labelPrivitak";
            this.labelPrivitak.Size = new System.Drawing.Size(49, 14);
            this.labelPrivitak.TabIndex = 11;
            this.labelPrivitak.Text = "Privitak:";
            // 
            // buttonIzaberi
            // 
            this.buttonIzaberi.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonIzaberi.Location = new System.Drawing.Point(233, 68);
            this.buttonIzaberi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIzaberi.Name = "buttonIzaberi";
            this.buttonIzaberi.Size = new System.Drawing.Size(87, 36);
            this.buttonIzaberi.TabIndex = 10;
            this.buttonIzaberi.Text = "Izaberi";
            this.buttonIzaberi.UseVisualStyleBackColor = false;
            this.buttonIzaberi.Click += new System.EventHandler(this.buttonIzaberi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Naslov:";
            // 
            // textBoxNaslov
            // 
            this.textBoxNaslov.Location = new System.Drawing.Point(233, 32);
            this.textBoxNaslov.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNaslov.Name = "textBoxNaslov";
            this.textBoxNaslov.Size = new System.Drawing.Size(178, 20);
            this.textBoxNaslov.TabIndex = 9;
            // 
            // buttonPosalji
            // 
            this.buttonPosalji.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonPosalji.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.buttonPosalji.Location = new System.Drawing.Point(766, 479);
            this.buttonPosalji.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPosalji.Name = "buttonPosalji";
            this.buttonPosalji.Size = new System.Drawing.Size(121, 43);
            this.buttonPosalji.TabIndex = 11;
            this.buttonPosalji.Text = "Pošalji";
            this.buttonPosalji.UseVisualStyleBackColor = false;
            this.buttonPosalji.Click += new System.EventHandler(this.buttonPosalji_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSadrzaj);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(554, 193);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(343, 220);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odgovor:";
            // 
            // textBoxSadrzaj
            // 
            this.textBoxSadrzaj.Location = new System.Drawing.Point(20, 18);
            this.textBoxSadrzaj.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSadrzaj.Multiline = true;
            this.textBoxSadrzaj.Name = "textBoxSadrzaj";
            this.textBoxSadrzaj.Size = new System.Drawing.Size(318, 197);
            this.textBoxSadrzaj.TabIndex = 0;
            // 
            // groupBoxPitanje
            // 
            this.groupBoxPitanje.Controls.Add(this.textBoxPitanje);
            this.groupBoxPitanje.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.groupBoxPitanje.Location = new System.Drawing.Point(554, 30);
            this.groupBoxPitanje.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPitanje.Name = "groupBoxPitanje";
            this.groupBoxPitanje.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPitanje.Size = new System.Drawing.Size(338, 156);
            this.groupBoxPitanje.TabIndex = 13;
            this.groupBoxPitanje.TabStop = false;
            this.groupBoxPitanje.Text = "Pitanje:";
            // 
            // textBoxPitanje
            // 
            this.textBoxPitanje.Location = new System.Drawing.Point(20, 18);
            this.textBoxPitanje.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPitanje.Multiline = true;
            this.textBoxPitanje.Name = "textBoxPitanje";
            this.textBoxPitanje.Size = new System.Drawing.Size(313, 133);
            this.textBoxPitanje.TabIndex = 0;
            // 
            // roundButtonNatrag
            // 
            this.roundButtonNatrag.BackColor = System.Drawing.Color.SteelBlue;
            this.roundButtonNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonNatrag.Location = new System.Drawing.Point(51, 479);
            this.roundButtonNatrag.Margin = new System.Windows.Forms.Padding(2);
            this.roundButtonNatrag.Name = "roundButtonNatrag";
            this.roundButtonNatrag.Size = new System.Drawing.Size(41, 39);
            this.roundButtonNatrag.TabIndex = 104;
            this.roundButtonNatrag.Text = "<";
            this.roundButtonNatrag.UseVisualStyleBackColor = false;
            this.roundButtonNatrag.Click += new System.EventHandler(this.roundButtonNatrag_Click);
            // 
            // OdgovorNaUpit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_faza_1.Properties.Resources.backgroundLogin;
            this.ClientSize = new System.Drawing.Size(912, 548);
            this.Controls.Add(this.roundButtonNatrag);
            this.Controls.Add(this.groupBoxPitanje);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonPosalji);
            this.Controls.Add(this.groupBoxEmailDetalji);
            this.Controls.Add(this.groupBoxPodaciPrimatelj);
            this.Controls.Add(this.groupBoxPodatciPoslijatelj);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OdgovorNaUpit";
            this.Text = "Odgovori na upit";
            this.Load += new System.EventHandler(this.OdgovorNaUpit_Load);
            this.groupBoxPodatciPoslijatelj.ResumeLayout(false);
            this.groupBoxPodatciPoslijatelj.PerformLayout();
            this.groupBoxPodaciPrimatelj.ResumeLayout(false);
            this.groupBoxPodaciPrimatelj.PerformLayout();
            this.groupBoxEmailDetalji.ResumeLayout(false);
            this.groupBoxEmailDetalji.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxPitanje.ResumeLayout(false);
            this.groupBoxPitanje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPodatciPoslijatelj;
        private System.Windows.Forms.TextBox textBoxLozinka;
        private System.Windows.Forms.TextBox textBoxPosiljateljMail;
        private System.Windows.Forms.Label labelPošiljatelj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPodaciPrimatelj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrimateljMail;
        private System.Windows.Forms.GroupBox groupBoxEmailDetalji;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNaslov;
        private System.Windows.Forms.Button buttonPosalji;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSadrzaj;
        private System.Windows.Forms.Button buttonIzaberi;
        private System.Windows.Forms.Label labelPrivitak;
        private System.Windows.Forms.CheckBox checkBoxPrikaziLozinku;
        private System.Windows.Forms.GroupBox groupBoxPitanje;
        private System.Windows.Forms.TextBox textBoxPitanje;
        private WindowsFormsApplication1.RoundButton roundButtonNatrag;
    }
}