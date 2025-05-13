using foy_5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace foy_5
{
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();

            secme.Visible = false;
            comboBoxogrenci.Visible = false;
            ad.Visible = false;
            textBoxAd.Visible = false;
            soyad.Visible = false;
            textBoxSoyad.Visible = false;
            bolum.Visible = false;
            comboBoxbolum.Visible = false;
            dataGridView1.Visible = false;
            btnekle.Visible = false;
            btnguncelle.Visible = false;
            btnsil.Visible = false;
        }

        public void gizle(object sender, EventArgs e)
        {
            secme.Visible = false;
            comboBoxogrenci.Visible = false;
            ad.Visible = false;
            textBoxAd.Visible = false;
            soyad.Visible = false;
            textBoxSoyad.Visible = false;
            bolum.Visible = false;
            comboBoxbolum.Visible = false;
            dataGridView1.Visible = false;
            btnekle.Visible = false;
            btnguncelle.Visible = false;
            btnsil.Visible = false;
        }
        private void ekle_Click(object sender, EventArgs e)
        {
            gizle(sender, e);
            ad.Visible = true;
            textBoxAd.Visible = true;
            soyad.Visible = true;
            textBoxSoyad.Visible = true;
            bolum.Visible = true;
            comboBoxbolum.Visible = true;
            btnekle.Visible = true;
            VerileriYukle();
        }

        private void listele_Click(object sender, EventArgs e)
        {
            gizle(sender, e);
            dataGridView1.Visible = true;

            using (var context = new Foy5Context())
            {
                var ogrenci = context.Ogrenci.ToList();
                dataGridView1.DataSource = ogrenci;
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            gizle(sender, e);
            secme.Visible = true;
            comboBoxogrenci.Visible = true;
            ad.Visible = true;
            textBoxAd.Visible = true;
            soyad.Visible = true;
            textBoxSoyad.Visible = true;
            bolum.Visible = true;
            comboBoxbolum.Visible = true;
            btnguncelle.Visible = true;
            VerileriYukle();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            gizle(sender, e);
            dataGridView1.Visible = true;
            btnsil.Visible = true;

            using (var context = new Foy5Context())
            {
                var ogrenci = context.Ogrenci.ToList();
                dataGridView1.DataSource = ogrenci;
            }

        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            using (var context = new Foy5Context())
            {
                var ogrenci = new Ogrenci
                {
                    ad = textBoxAd.Text,
                    soyad = textBoxSoyad.Text,
                    bolumID = (int)comboBoxbolum.SelectedValue,
                };

                context.Ogrenci.Add(ogrenci);
                context.SaveChanges();
                MessageBox.Show("Öğrenci başarıyla eklendi!");
                VerileriYukle();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int ogrenciID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ogrenciID"].Value);
                using (var context = new Foy5Context())
                {
                    var ogrenci = context.Ogrenci.Find(ogrenciID);
                    if (ogrenci != null)
                    {
                        context.Ogrenci.Remove(ogrenci);
                        context.SaveChanges();
                        MessageBox.Show("Öğrenci başarıyla silindi!");
                        listele_Click(null, null);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek öğrenciyi seçin.");
            }
        }

        private void ComboBoxogrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen öğe anonim tür olduğundan, öncelikle bunu doğru bir şekilde almak gerek
            if (comboBoxogrenci.SelectedItem != null)
            {
                var secilen = comboBoxogrenci.SelectedItem as dynamic; // anonim tür olarak işleme
                if (secilen != null)
                {
                    int ogrenciID = secilen.ogrenciID;
                    using (var context = new Foy5Context())
                    {
                        var ogrenci = context.Ogrenci.Find(ogrenciID);
                        if (ogrenci != null)
                        {
                            textBoxAd.Text = ogrenci.ad;
                            textBoxSoyad.Text = ogrenci.soyad;
                            comboBoxbolum.SelectedValue = ogrenci.bolumID;
                        }
                    }
                }
            }
        }


        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int ogrenciID = Convert.ToInt32(comboBoxogrenci.SelectedValue);
            using (var context = new Foy5Context())
            {
                var ogrenci = context.Ogrenci.Find(ogrenciID);
                if (ogrenci != null)
                {
                    ogrenci.ad = textBoxAd.Text;
                    ogrenci.soyad = textBoxSoyad.Text;
                    ogrenci.bolumID = (int)comboBoxbolum.SelectedValue;

                    context.SaveChanges();
                    MessageBox.Show("Öğrenci başarıyla güncellendi!");
                    VerileriYukle();
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı!");
                }
            }
        }
        private void VerileriYukle()
        {
            using (var context = new Foy5Context())
            {
                // Bölümleri yükle
                comboBoxbolum.DataSource = context.Bolum.ToList();
                comboBoxbolum.DisplayMember = "bolumAd";
                comboBoxbolum.ValueMember = "bolumID";

                // Öğrencileri yükle ve ad + soyad birleştir
                var ogrenciler = context.Ogrenci.ToList();

                // Öğrencileri ad ve soyadla birleştirip yeni bir liste oluştur
                var ogrenciListesi = ogrenciler.Select(o => new
                {
                    ogrenciID = o.ogrenciID,
                    AdSoyad = o.ad + " " + o.soyad
                }).ToList();

                // ComboBox'a ad + soyad'ı göster
                comboBoxogrenci.DataSource = ogrenciListesi;
                comboBoxogrenci.DisplayMember = "AdSoyad";
                comboBoxogrenci.ValueMember = "ogrenciID";
            }

            // Öğrenci seçildiğinde bilgileri getir
            comboBoxogrenci.SelectedIndexChanged -= ComboBoxogrenci_SelectedIndexChanged;
            comboBoxogrenci.SelectedIndexChanged += ComboBoxogrenci_SelectedIndexChanged;
        }

    }
}
