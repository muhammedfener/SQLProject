namespace SQLProject
{
    partial class Form2
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
            this.txtGunlukUcret = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtModelYil = new System.Windows.Forms.TextBox();
            this.txtKoltukSayisi = new System.Windows.Forms.TextBox();
            this.txtDepoHacim = new System.Windows.Forms.TextBox();
            this.txtKapiSayisi = new System.Windows.Forms.TextBox();
            this.cmbMarkalar = new System.Windows.Forms.ComboBox();
            this.cmbRenkler = new System.Windows.Forms.ComboBox();
            this.cmbModeller = new System.Windows.Forms.ComboBox();
            this.cmbEhliyetler = new System.Windows.Forms.ComboBox();
            this.cmbVites = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGunlukUcret
            // 
            this.txtGunlukUcret.Location = new System.Drawing.Point(111, 93);
            this.txtGunlukUcret.Name = "txtGunlukUcret";
            this.txtGunlukUcret.Size = new System.Drawing.Size(100, 20);
            this.txtGunlukUcret.TabIndex = 0;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(111, 119);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(100, 20);
            this.txtPlaka.TabIndex = 0;
            // 
            // txtModelYil
            // 
            this.txtModelYil.Location = new System.Drawing.Point(111, 145);
            this.txtModelYil.Name = "txtModelYil";
            this.txtModelYil.Size = new System.Drawing.Size(100, 20);
            this.txtModelYil.TabIndex = 0;
            // 
            // txtKoltukSayisi
            // 
            this.txtKoltukSayisi.Location = new System.Drawing.Point(111, 171);
            this.txtKoltukSayisi.Name = "txtKoltukSayisi";
            this.txtKoltukSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtKoltukSayisi.TabIndex = 0;
            // 
            // txtDepoHacim
            // 
            this.txtDepoHacim.Location = new System.Drawing.Point(111, 197);
            this.txtDepoHacim.Name = "txtDepoHacim";
            this.txtDepoHacim.Size = new System.Drawing.Size(100, 20);
            this.txtDepoHacim.TabIndex = 0;
            // 
            // txtKapiSayisi
            // 
            this.txtKapiSayisi.Location = new System.Drawing.Point(111, 250);
            this.txtKapiSayisi.Name = "txtKapiSayisi";
            this.txtKapiSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtKapiSayisi.TabIndex = 0;
            // 
            // cmbMarkalar
            // 
            this.cmbMarkalar.FormattingEnabled = true;
            this.cmbMarkalar.Location = new System.Drawing.Point(111, 12);
            this.cmbMarkalar.Name = "cmbMarkalar";
            this.cmbMarkalar.Size = new System.Drawing.Size(121, 21);
            this.cmbMarkalar.TabIndex = 1;
            this.cmbMarkalar.SelectionChangeCommitted += new System.EventHandler(this.ModelGetir);
            // 
            // cmbRenkler
            // 
            this.cmbRenkler.FormattingEnabled = true;
            this.cmbRenkler.Location = new System.Drawing.Point(111, 66);
            this.cmbRenkler.Name = "cmbRenkler";
            this.cmbRenkler.Size = new System.Drawing.Size(121, 21);
            this.cmbRenkler.TabIndex = 1;
            // 
            // cmbModeller
            // 
            this.cmbModeller.FormattingEnabled = true;
            this.cmbModeller.Location = new System.Drawing.Point(111, 40);
            this.cmbModeller.Name = "cmbModeller";
            this.cmbModeller.Size = new System.Drawing.Size(121, 21);
            this.cmbModeller.TabIndex = 1;
            // 
            // cmbEhliyetler
            // 
            this.cmbEhliyetler.FormattingEnabled = true;
            this.cmbEhliyetler.Location = new System.Drawing.Point(111, 223);
            this.cmbEhliyetler.Name = "cmbEhliyetler";
            this.cmbEhliyetler.Size = new System.Drawing.Size(121, 21);
            this.cmbEhliyetler.TabIndex = 1;
            // 
            // cmbVites
            // 
            this.cmbVites.FormattingEnabled = true;
            this.cmbVites.Location = new System.Drawing.Point(111, 276);
            this.cmbVites.Name = "cmbVites";
            this.cmbVites.Size = new System.Drawing.Size(121, 21);
            this.cmbVites.TabIndex = 1;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(111, 303);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(100, 20);
            this.txtAciklama.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Araç Markası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Araç Rengi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Araç Modeli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Günlük Ücreti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Plaka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Model Yılı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Koltuk Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Depo Hacmi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ehliyet Tipi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Kapı Sayısı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Vites Tipi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Açıklama";
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Location = new System.Drawing.Point(157, 348);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(75, 23);
            this.btnAracEkle.TabIndex = 3;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 389);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVites);
            this.Controls.Add(this.cmbEhliyetler);
            this.Controls.Add(this.cmbModeller);
            this.Controls.Add(this.cmbRenkler);
            this.Controls.Add(this.cmbMarkalar);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKapiSayisi);
            this.Controls.Add(this.txtDepoHacim);
            this.Controls.Add(this.txtKoltukSayisi);
            this.Controls.Add(this.txtModelYil);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtGunlukUcret);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGunlukUcret;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtModelYil;
        private System.Windows.Forms.TextBox txtKoltukSayisi;
        private System.Windows.Forms.TextBox txtDepoHacim;
        private System.Windows.Forms.TextBox txtKapiSayisi;
        private System.Windows.Forms.ComboBox cmbMarkalar;
        private System.Windows.Forms.ComboBox cmbRenkler;
        private System.Windows.Forms.ComboBox cmbModeller;
        private System.Windows.Forms.ComboBox cmbEhliyetler;
        private System.Windows.Forms.ComboBox cmbVites;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAracEkle;
    }
}