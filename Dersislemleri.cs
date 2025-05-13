using foy_5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;


namespace foy_5
{
    public partial class Dersislemleri : Form
    {
        public Dersislemleri()
        {
            InitializeComponent();
            VerileriYukle();
        }

        private void Dersislemleri_Load(object sender, EventArgs e)
        {
            using (var context = new Foy5Context())
            {
                // Öğrencileri ComboBox'a ekle
                var ogrenciler = context.Ogrenci.ToList();

                var ogrenciListesi = ogrenciler.Select(o => new
                {
                    ogrenciID = o.ogrenciID,
                    AdSoyad = o.ad + " " + o.soyad
                }).ToList();

                // ComboBox'a ad + soyad'ı göster
                comboBox1.DataSource = ogrenciListesi;
                comboBox1.DisplayMember = "AdSoyad";
                comboBox1.ValueMember = "ogrenciID";

                // Dersleri ComboBox'a ekle
                comboBox2.DataSource = context.Ders.ToList();
                comboBox2.DisplayMember = "DersAd";
                comboBox2.ValueMember = "DersID";

                // Yarıyıl seçimlerini ComboBox'a ekle
                comboBox3.Items.Add("Bahar");
                comboBox3.Items.Add("Güz");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yil = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(yil))
            {
                MessageBox.Show("Yıl bilgisini giriniz.");
                return;
            }

            if (comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir yarıyıl seçin.");
                return;
            }

            string yariyil = comboBox3.SelectedItem.ToString();

            using (var context = new Foy5Context())
            {
                var ogrenciDers = new OgrenciDers
                {
                    ogrenciID = (int)comboBox1.SelectedValue,
                    dersID = (int)comboBox2.SelectedValue,
                    yil = yil,
                    yariyil = yariyil,
                    vize = null,
                    final = null
                };

                context.OgrenciDers.Add(ogrenciDers);
                context.SaveChanges();
                MessageBox.Show("Ders başarıyla atandı!");
                VerileriYukle();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int ogrenciDersID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["OgrenciDersID"].Value);
                using (var context = new Foy5Context())
                {
                    var ogrenciDers = context.OgrenciDers.Find(ogrenciDersID);
                    if (ogrenciDers != null)
                    {
                        context.OgrenciDers.Remove(ogrenciDers);
                        context.SaveChanges();
                        MessageBox.Show("Ders başarıyla silindi!");
                        VerileriYukle();  // Silinen veriyi DataGridView'den kaldır
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek dersi seçin.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int ogrenciDersID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["OgrenciDersID"].Value);

                string yil = textBox1.Text.Trim();

                if (string.IsNullOrEmpty(yil))
                {
                    MessageBox.Show("Yıl bilgisini giriniz.");
                    return;
                }

                if (comboBox3.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir yarıyıl seçin.");
                    return;
                }

                string yariyil = comboBox3.SelectedItem.ToString();

                using (var context = new Foy5Context())
                {
                    var ogrenciDers = context.OgrenciDers.Find(ogrenciDersID);
                    if (ogrenciDers != null)
                    {
                        ogrenciDers.dersID = (int)comboBox2.SelectedValue;
                        ogrenciDers.yil = yil;
                        ogrenciDers.yariyil = yariyil;

                        context.SaveChanges();
                        MessageBox.Show("Ders başarıyla güncellendi!");
                        VerileriYukle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek dersi seçin.");
            }
        }


        private void VerileriYukle()
        {
            using (var context = new Foy5Context())
            {
                var veriler = context.OgrenciDers
                    .Include(od => od.Ogrenci)
                    .Include(od => od.Ders)
                    .Select(od => new
                    {
                        od.ogrenciDersID,
                        OgrenciAd = od.Ogrenci.ad + " " + od.Ogrenci.soyad,
                        DersAd = od.Ders.DersAd,
                        od.yil,
                        od.yariyil,
                    })
                    .ToList();

                dataGridView1.DataSource = veriler;
            }
        }



    }
}
