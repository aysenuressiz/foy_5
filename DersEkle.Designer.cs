namespace foy_5
{
    partial class DersEkle
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
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.comboBoxogrenci = new System.Windows.Forms.ComboBox();
            this.secme = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.ad = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(368, 342);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 57;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(339, 259);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(115, 23);
            this.btnguncelle.TabIndex = 56;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // comboBoxogrenci
            // 
            this.comboBoxogrenci.FormattingEnabled = true;
            this.comboBoxogrenci.Location = new System.Drawing.Point(267, 188);
            this.comboBoxogrenci.Name = "comboBoxogrenci";
            this.comboBoxogrenci.Size = new System.Drawing.Size(202, 24);
            this.comboBoxogrenci.TabIndex = 55;
            // 
            // secme
            // 
            this.secme.AutoSize = true;
            this.secme.Location = new System.Drawing.Point(316, 169);
            this.secme.Name = "secme";
            this.secme.Size = new System.Drawing.Size(83, 16);
            this.secme.TabIndex = 54;
            this.secme.Text = "Ders seçiniz.";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(348, 250);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 53;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(262, 225);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(62, 16);
            this.ad.TabIndex = 52;
            this.ad.Text = "Ders Adı:";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(348, 222);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(121, 22);
            this.textBoxAd.TabIndex = 51;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(115, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(571, 150);
            this.dataGridView1.TabIndex = 50;
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(611, 85);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 65);
            this.sil.TabIndex = 49;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(429, 85);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(98, 65);
            this.guncelle.TabIndex = 48;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(267, 85);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(75, 65);
            this.listele.TabIndex = 47;
            this.listele.Text = "LİSTELE";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(115, 85);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 65);
            this.ekle.TabIndex = 46;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 33);
            this.button1.TabIndex = 58;
            this.button1.Text = "DERS İŞLEMLERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DersEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.comboBoxogrenci);
            this.Controls.Add(this.secme);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.ekle);
            this.Name = "DersEkle";
            this.Text = "DersEkle";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.ComboBox comboBoxogrenci;
        private System.Windows.Forms.Label secme;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button button1;
    }
}