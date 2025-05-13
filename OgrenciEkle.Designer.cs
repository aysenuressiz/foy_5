namespace foy_5
{
    partial class OgrenciEkle
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
            this.ekle = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.bolum = new System.Windows.Forms.Label();
            this.comboBoxbolum = new System.Windows.Forms.ComboBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.secme = new System.Windows.Forms.Label();
            this.comboBoxogrenci = new System.Windows.Forms.ComboBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(105, 98);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 65);
            this.ekle.TabIndex = 0;
            this.ekle.Text = "EKLE";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(257, 98);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(75, 65);
            this.listele.TabIndex = 1;
            this.listele.Text = "LİSTELE";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(419, 98);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(98, 65);
            this.guncelle.TabIndex = 2;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(601, 98);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 65);
            this.sil.TabIndex = 3;
            this.sil.Text = "SİL";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(571, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(338, 235);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(121, 22);
            this.textBoxAd.TabIndex = 5;
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(252, 238);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(80, 16);
            this.ad.TabIndex = 6;
            this.ad.Text = "Öğrenci Adı:";
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.Location = new System.Drawing.Point(229, 281);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(103, 16);
            this.soyad.TabIndex = 8;
            this.soyad.Text = "Öğrenci Soyadı:";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(338, 278);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(121, 22);
            this.textBoxSoyad.TabIndex = 7;
            // 
            // bolum
            // 
            this.bolum.AutoSize = true;
            this.bolum.Location = new System.Drawing.Point(274, 321);
            this.bolum.Name = "bolum";
            this.bolum.Size = new System.Drawing.Size(58, 16);
            this.bolum.TabIndex = 9;
            this.bolum.Text = "Bölümü: ";
            // 
            // comboBoxbolum
            // 
            this.comboBoxbolum.FormattingEnabled = true;
            this.comboBoxbolum.Location = new System.Drawing.Point(338, 313);
            this.comboBoxbolum.Name = "comboBoxbolum";
            this.comboBoxbolum.Size = new System.Drawing.Size(121, 24);
            this.comboBoxbolum.TabIndex = 10;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(349, 355);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 11;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // secme
            // 
            this.secme.AutoSize = true;
            this.secme.Location = new System.Drawing.Point(306, 182);
            this.secme.Name = "secme";
            this.secme.Size = new System.Drawing.Size(101, 16);
            this.secme.TabIndex = 12;
            this.secme.Text = "Öğrenci seçiniz.";
            // 
            // comboBoxogrenci
            // 
            this.comboBoxogrenci.FormattingEnabled = true;
            this.comboBoxogrenci.Location = new System.Drawing.Point(257, 201);
            this.comboBoxogrenci.Name = "comboBoxogrenci";
            this.comboBoxogrenci.Size = new System.Drawing.Size(202, 24);
            this.comboBoxogrenci.TabIndex = 13;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(338, 343);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(115, 23);
            this.btnguncelle.TabIndex = 14;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(349, 355);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 15;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // OgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.comboBoxogrenci);
            this.Controls.Add(this.secme);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.comboBoxbolum);
            this.Controls.Add(this.bolum);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.ekle);
            this.Name = "OgrenciEkle";
            this.Text = "OgrenciEkle";
            this.Load += new System.EventHandler(this.OgrenciEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label soyad;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Label bolum;
        private System.Windows.Forms.ComboBox comboBoxbolum;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label secme;
        private System.Windows.Forms.ComboBox comboBoxogrenci;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
    }
}