namespace Hastane_Otomasyon_Projesi
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskTxtTc = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.BtnKayitYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = " Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "TC  Kimlik No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Şifre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cinsiyet:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(247, 63);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(163, 38);
            this.TxtAd.TabIndex = 1;
            // 
            // MskTxtTc
            // 
            this.MskTxtTc.Location = new System.Drawing.Point(247, 163);
            this.MskTxtTc.Mask = "00000000000";
            this.MskTxtTc.Name = "MskTxtTc";
            this.MskTxtTc.Size = new System.Drawing.Size(163, 38);
            this.MskTxtTc.TabIndex = 3;
            this.MskTxtTc.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 31);
            this.label10.TabIndex = 15;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(247, 116);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(163, 38);
            this.TxtSoyad.TabIndex = 2;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(247, 268);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(163, 38);
            this.TxtSifre.TabIndex = 5;
            // 
            // MskTxtTelefon
            // 
            this.MskTxtTelefon.Location = new System.Drawing.Point(247, 217);
            this.MskTxtTelefon.Mask = "(999) 000-0000";
            this.MskTxtTelefon.Name = "MskTxtTelefon";
            this.MskTxtTelefon.Size = new System.Drawing.Size(163, 38);
            this.MskTxtTelefon.TabIndex = 4;
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(247, 324);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(163, 39);
            this.CmbCinsiyet.TabIndex = 6;
            // 
            // BtnKayitYap
            // 
            this.BtnKayitYap.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnKayitYap.Location = new System.Drawing.Point(247, 386);
            this.BtnKayitYap.Name = "BtnKayitYap";
            this.BtnKayitYap.Size = new System.Drawing.Size(163, 49);
            this.BtnKayitYap.TabIndex = 7;
            this.BtnKayitYap.Text = "Kayıt Yap";
            this.BtnKayitYap.UseVisualStyleBackColor = false;
            this.BtnKayitYap.Click += new System.EventHandler(this.BtnKayitYap_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.BtnKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(564, 584);
            this.Controls.Add(this.BtnKayitYap);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.MskTxtTelefon);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MskTxtTc);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.Load += new System.EventHandler(this.FrmHastaKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskTxtTc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MskTxtTelefon;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.Button BtnKayitYap;
    }
}