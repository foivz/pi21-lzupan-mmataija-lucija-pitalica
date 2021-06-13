
namespace Projekt_faza_1
{
    partial class FrmUpozorenje
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.upozorenjeTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // upozorenjeTextBox
            // 
            this.upozorenjeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.upozorenjeTextBox.Location = new System.Drawing.Point(121, 2);
            this.upozorenjeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.upozorenjeTextBox.Name = "upozorenjeTextBox";
            this.upozorenjeTextBox.Size = new System.Drawing.Size(280, 179);
            this.upozorenjeTextBox.TabIndex = 2;
            this.upozorenjeTextBox.Text = "";
            // 
            // FrmUpozorenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekt_faza_1.Properties.Resources.upozorenje;
            this.ClientSize = new System.Drawing.Size(406, 181);
            this.Controls.Add(this.upozorenjeTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUpozorenje";
            this.Text = "Upozorenje";
            this.Load += new System.EventHandler(this.FrmUpozorenje_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox upozorenjeTextBox;
    }
}