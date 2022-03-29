namespace Üs_alma
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIsle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(34, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "ÜS ALMA";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(114, 241);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(14, 16);
            this.lblSonuc.TabIndex = 10;
            this.lblSonuc.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sonuç: ";
            // 
            // btnIsle
            // 
            this.btnIsle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsle.Location = new System.Drawing.Point(206, 224);
            this.btnIsle.Name = "btnIsle";
            this.btnIsle.Size = new System.Drawing.Size(124, 50);
            this.btnIsle.TabIndex = 9;
            this.btnIsle.Text = "Karesini Al";
            this.btnIsle.UseVisualStyleBackColor = true;
            this.btnIsle.Click += new System.EventHandler(this.btnIsle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sayı 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sayı 1";
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(117, 164);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 22);
            this.txtSayi2.TabIndex = 5;
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(117, 92);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 22);
            this.txtSayi1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 309);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIsle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIsle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
    }
}

