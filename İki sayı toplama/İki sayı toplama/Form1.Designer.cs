namespace İki_sayı_toplama
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
            this.txtSayi_1 = new System.Windows.Forms.TextBox();
            this.txtSayi_2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTpl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSayi_1
            // 
            this.txtSayi_1.Location = new System.Drawing.Point(55, 118);
            this.txtSayi_1.Name = "txtSayi_1";
            this.txtSayi_1.Size = new System.Drawing.Size(100, 22);
            this.txtSayi_1.TabIndex = 0;
            // 
            // txtSayi_2
            // 
            this.txtSayi_2.Location = new System.Drawing.Point(55, 171);
            this.txtSayi_2.Name = "txtSayi_2";
            this.txtSayi_2.Size = new System.Drawing.Size(100, 22);
            this.txtSayi_2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "SAYI YOPLAMA";
            // 
            // btnTpl
            // 
            this.btnTpl.Location = new System.Drawing.Point(55, 236);
            this.btnTpl.Name = "btnTpl";
            this.btnTpl.Size = new System.Drawing.Size(117, 42);
            this.btnTpl.TabIndex = 3;
            this.btnTpl.Text = "TOPLA";
            this.btnTpl.UseVisualStyleBackColor = true;
            this.btnTpl.Click += new System.EventHandler(this.btnTpl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sonuç: ";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(281, 174);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(14, 16);
            this.lblSonuc.TabIndex = 4;
            this.lblSonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 324);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTpl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayi_2);
            this.Controls.Add(this.txtSayi_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi_1;
        private System.Windows.Forms.TextBox txtSayi_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTpl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSonuc;
    }
}

