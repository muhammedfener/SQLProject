namespace SQLProject
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
            this.btnBaglantiTest = new System.Windows.Forms.Button();
            this.lblBaglanti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBaglantiTest
            // 
            this.btnBaglantiTest.Location = new System.Drawing.Point(13, 12);
            this.btnBaglantiTest.Name = "btnBaglantiTest";
            this.btnBaglantiTest.Size = new System.Drawing.Size(100, 23);
            this.btnBaglantiTest.TabIndex = 0;
            this.btnBaglantiTest.Text = "Bağlantı Test";
            this.btnBaglantiTest.UseVisualStyleBackColor = true;
            this.btnBaglantiTest.Click += new System.EventHandler(this.btnBaglantiTest_Click);
            // 
            // lblBaglanti
            // 
            this.lblBaglanti.AutoSize = true;
            this.lblBaglanti.Location = new System.Drawing.Point(133, 17);
            this.lblBaglanti.Name = "lblBaglanti";
            this.lblBaglanti.Size = new System.Drawing.Size(0, 13);
            this.lblBaglanti.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBaglanti);
            this.Controls.Add(this.btnBaglantiTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaglantiTest;
        private System.Windows.Forms.Label lblBaglanti;
    }
}

