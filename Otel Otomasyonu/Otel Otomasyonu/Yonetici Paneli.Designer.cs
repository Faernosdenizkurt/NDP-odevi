namespace Otel_Otomasyonu
{
    partial class Yonetici_Paneli
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
            this.button_gelensikayet = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_gelensikayet
            // 
            this.button_gelensikayet.Location = new System.Drawing.Point(12, 12);
            this.button_gelensikayet.Name = "button_gelensikayet";
            this.button_gelensikayet.Size = new System.Drawing.Size(168, 41);
            this.button_gelensikayet.TabIndex = 13;
            this.button_gelensikayet.Text = "Gelen şikayetler";
            this.button_gelensikayet.UseVisualStyleBackColor = true;
            this.button_gelensikayet.Click += new System.EventHandler(this.button_gelensikayet_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(168, 219);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // Yonetici_Paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(199, 291);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_gelensikayet);
            this.MinimizeBox = false;
            this.Name = "Yonetici_Paneli";
            this.Text = "Yönetici Paneli";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_gelensikayet;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}