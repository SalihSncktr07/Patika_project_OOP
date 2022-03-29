namespace Metni_tersten_yazdırma
{
    partial class Form1
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
            this.metinGir = new System.Windows.Forms.TextBox();
            this.metinSonuc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metinGir
            // 
            this.metinGir.Location = new System.Drawing.Point(65, 78);
            this.metinGir.Name = "metinGir";
            this.metinGir.Size = new System.Drawing.Size(100, 22);
            this.metinGir.TabIndex = 0;
            // 
            // metinSonuc
            // 
            this.metinSonuc.Location = new System.Drawing.Point(65, 136);
            this.metinSonuc.Name = "metinSonuc";
            this.metinSonuc.Size = new System.Drawing.Size(100, 22);
            this.metinSonuc.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tersten Yaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metinSonuc);
            this.Controls.Add(this.metinGir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox metinGir;
        private System.Windows.Forms.TextBox metinSonuc;
        private System.Windows.Forms.Button button1;
    }
}

