namespace foy_5
{
    partial class index
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.fakulteEkle = new System.Windows.Forms.Button();
            this.bolumEkle = new System.Windows.Forms.Button();
            this.ogrenciEkle = new System.Windows.Forms.Button();
            this.ogrenciSorgula = new System.Windows.Forms.Button();
            this.ogrenciSorgulaWeb = new System.Windows.Forms.Button();
            this.dersEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fakulteEkle
            // 
            this.fakulteEkle.Location = new System.Drawing.Point(232, 40);
            this.fakulteEkle.Name = "fakulteEkle";
            this.fakulteEkle.Size = new System.Drawing.Size(338, 49);
            this.fakulteEkle.TabIndex = 0;
            this.fakulteEkle.Text = "FAKÜLTE EKLE";
            this.fakulteEkle.UseVisualStyleBackColor = true;
            this.fakulteEkle.Click += new System.EventHandler(this.fakulteEkle_Click);
            // 
            // bolumEkle
            // 
            this.bolumEkle.Location = new System.Drawing.Point(231, 97);
            this.bolumEkle.Name = "bolumEkle";
            this.bolumEkle.Size = new System.Drawing.Size(338, 49);
            this.bolumEkle.TabIndex = 1;
            this.bolumEkle.Text = "BÖLÜM EKLE";
            this.bolumEkle.UseVisualStyleBackColor = true;
            this.bolumEkle.Click += new System.EventHandler(this.bolumEkle_Click);
            // 
            // ogrenciEkle
            // 
            this.ogrenciEkle.Location = new System.Drawing.Point(231, 209);
            this.ogrenciEkle.Name = "ogrenciEkle";
            this.ogrenciEkle.Size = new System.Drawing.Size(338, 49);
            this.ogrenciEkle.TabIndex = 2;
            this.ogrenciEkle.Text = "ÖĞRENCİ EKLE";
            this.ogrenciEkle.UseVisualStyleBackColor = true;
            this.ogrenciEkle.Click += new System.EventHandler(this.ogrenciEkle_Click);
            // 
            // ogrenciSorgula
            // 
            this.ogrenciSorgula.Location = new System.Drawing.Point(231, 268);
            this.ogrenciSorgula.Name = "ogrenciSorgula";
            this.ogrenciSorgula.Size = new System.Drawing.Size(338, 49);
            this.ogrenciSorgula.TabIndex = 3;
            this.ogrenciSorgula.Text = "ÖĞRENCİ SORGULA";
            this.ogrenciSorgula.UseVisualStyleBackColor = true;
            // 
            // ogrenciSorgulaWeb
            // 
            this.ogrenciSorgulaWeb.Location = new System.Drawing.Point(231, 330);
            this.ogrenciSorgulaWeb.Name = "ogrenciSorgulaWeb";
            this.ogrenciSorgulaWeb.Size = new System.Drawing.Size(338, 49);
            this.ogrenciSorgulaWeb.TabIndex = 4;
            this.ogrenciSorgulaWeb.Text = "ÖĞRENCİ SORGULA(WEB SERVİSİ İLE)";
            this.ogrenciSorgulaWeb.UseVisualStyleBackColor = true;
            // 
            // dersEkle
            // 
            this.dersEkle.Location = new System.Drawing.Point(231, 152);
            this.dersEkle.Name = "dersEkle";
            this.dersEkle.Size = new System.Drawing.Size(338, 49);
            this.dersEkle.TabIndex = 5;
            this.dersEkle.Text = "DERS EKLE";
            this.dersEkle.UseVisualStyleBackColor = true;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dersEkle);
            this.Controls.Add(this.ogrenciSorgulaWeb);
            this.Controls.Add(this.ogrenciSorgula);
            this.Controls.Add(this.ogrenciEkle);
            this.Controls.Add(this.bolumEkle);
            this.Controls.Add(this.fakulteEkle);
            this.Name = "index";
            this.Text = "index";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fakulteEkle;
        private System.Windows.Forms.Button bolumEkle;
        private System.Windows.Forms.Button ogrenciEkle;
        private System.Windows.Forms.Button ogrenciSorgula;
        private System.Windows.Forms.Button ogrenciSorgulaWeb;
        private System.Windows.Forms.Button dersEkle;
    }
}

