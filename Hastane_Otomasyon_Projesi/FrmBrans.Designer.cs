namespace Hastane_Otomasyon_Projesi
{
    partial class FrmBrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrans));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.TxtBransAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtBransid = new System.Windows.Forms.TextBox();
            this.LblBransAd = new System.Windows.Forms.Label();
            this.LblBransid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(495, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(612, 266);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.Blue;
            this.BtnEkle.Location = new System.Drawing.Point(132, 150);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(125, 62);
            this.BtnEkle.TabIndex = 78;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Red;
            this.BtnSil.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(265, 150);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(125, 62);
            this.BtnSil.TabIndex = 77;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.Lime;
            this.BtnGuncelle.Location = new System.Drawing.Point(132, 222);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(258, 48);
            this.BtnGuncelle.TabIndex = 76;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            // 
            // TxtBransAd
            // 
            this.TxtBransAd.Location = new System.Drawing.Point(187, 95);
            this.TxtBransAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBransAd.Name = "TxtBransAd";
            this.TxtBransAd.Size = new System.Drawing.Size(203, 38);
            this.TxtBransAd.TabIndex = 73;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(442, 359);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 31);
            this.label10.TabIndex = 72;
            // 
            // TxtBransid
            // 
            this.TxtBransid.Location = new System.Drawing.Point(187, 47);
            this.TxtBransid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBransid.Name = "TxtBransid";
            this.TxtBransid.Size = new System.Drawing.Size(203, 38);
            this.TxtBransid.TabIndex = 70;
            // 
            // LblBransAd
            // 
            this.LblBransAd.AutoSize = true;
            this.LblBransAd.Location = new System.Drawing.Point(66, 102);
            this.LblBransAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBransAd.Name = "LblBransAd";
            this.LblBransAd.Size = new System.Drawing.Size(113, 31);
            this.LblBransAd.TabIndex = 66;
            this.LblBransAd.Text = "Branş Ad:";
            // 
            // LblBransid
            // 
            this.LblBransid.AutoSize = true;
            this.LblBransid.Location = new System.Drawing.Point(69, 47);
            this.LblBransid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBransid.Name = "LblBransid";
            this.LblBransid.Size = new System.Drawing.Size(110, 31);
            this.LblBransid.TabIndex = 65;
            this.LblBransid.Text = " Branş id:";
            // 
            // FrmBrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1138, 332);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.TxtBransAd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtBransid);
            this.Controls.Add(this.LblBransAd);
            this.Controls.Add(this.LblBransid);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmBrans";
            this.Text = "FrmBrans";
            this.Load += new System.EventHandler(this.FrmBrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.TextBox TxtBransAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtBransid;
        private System.Windows.Forms.Label LblBransAd;
        private System.Windows.Forms.Label LblBransid;
    }
}