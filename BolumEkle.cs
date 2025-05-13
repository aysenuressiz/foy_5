using foy_5.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace foy_5
{
    public partial class BolumEkle : Form
    {
        public BolumEkle()
        {
            InitializeComponent();
            TumKontrolleriGizle();
        }

        private void TumKontrolleriGizle()
        {
            var kontroller = new Control[]
            {
                secme, comboBoxogrenci, ad, textBoxAd, bolum,
                comboBoxbolum, dataGridView1, btnekle, btnguncelle, btnsil
            };

            foreach (var kontrol in kontroller)
                kontrol.Visible = false;
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            TumKontrolleriGizle();
            ad.Visible = true;
            textBoxAd.Visible = true;
            bolum.Visible = true;
            comboBoxbolum.Visible = true;
            btnekle.Visible = true;

            FakulteleriYukle();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            using (var context = new Foy5Context())
            {
                var bolum = new Bolum
                {
                    bolumAd = textBoxAd.Text,
                    FakulteID = (int)comboBoxbolum.SelectedValue,
                };

                context.Bolum.Add(bolum);
                context.SaveChanges();
                MessageBox.Show("Bölüm başarıyla eklendi!");

                textBoxAd.Clear();
                comboBoxbolum.SelectedIndex = -1;
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            TumKontrolleriGizle();

            secme.Visible = true;
            comboBoxogrenci.Visible = true;
            ad.Visible = true;
            textBoxAd.Visible = true;
            bolum.Visible = true;
            comboBoxbolum.Visible = true;
            btnguncelle.Visible = true;

            BolumleriYukle();
            FakulteleriYukle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (comboBoxogrenci.SelectedItem != null)
            {
                int bolumID = (int)comboBoxogrenci.SelectedValue;
                using (var context = new Foy5Context())
                {
                    var bolum = context.Bolum.Find(bolumID);
                    if (bolum != null)
                    {
                        bolum.bolumAd = textBoxAd.Text;
                        bolum.FakulteID = (int)comboBoxbolum.SelectedValue;
                        context.SaveChanges();

                        MessageBox.Show("Bölüm başarıyla güncellendi!");
                    }
                    else
                    {
                        MessageBox.Show("Bölüm bulunamadı!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir bölüm seçin.");
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            TumKontrolleriGizle();
            dataGridView1.Visible = true;
            btnsil.Visible = true;

            using (var context = new Foy5Context())
            {
                var bolumler = context.Bolum.ToList();
                dataGridView1.DataSource = bolumler;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int bolumID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["bolumID"].Value);

                var onay = MessageBox.Show("Bu bölümü silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                if (onay == DialogResult.No)
                    return;

                using (var context = new Foy5Context())
                {
                    var bolum = context.Bolum.Find(bolumID);
                    if (bolum != null)
                    {
                        context.Bolum.Remove(bolum);
                        context.SaveChanges();
                        MessageBox.Show("Bölüm başarıyla silindi!");

                        // Listeyi güncelle
                        var bolumler = context.Bolum.ToList();
                        dataGridView1.DataSource = bolumler;
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bölümü seçin.");
            }
        }

        private void listele_Click(object sender, EventArgs e)
        {
            TumKontrolleriGizle();
            dataGridView1.Visible = true;

            using (var context = new Foy5Context())
            {
                var bolumler = context.Bolum.ToList();
                dataGridView1.DataSource = bolumler;
            }
        }

        private void BolumleriYukle()
        {
            using (var context = new Foy5Context())
            {
                var bolumListesi = context.Bolum.ToList();
                comboBoxogrenci.DataSource = bolumListesi;
                comboBoxogrenci.DisplayMember = "bolumAd";
                comboBoxogrenci.ValueMember = "bolumID";
            }

            comboBoxogrenci.SelectedIndexChanged -= ComboBoxogrenci_SelectedIndexChanged;
            comboBoxogrenci.SelectedIndexChanged += ComboBoxogrenci_SelectedIndexChanged;
        }

        private void FakulteleriYukle()
        {
            using (var context = new Foy5Context())
            {
                var fakulteler = context.Fakulte.ToList();
                comboBoxbolum.DataSource = fakulteler;
                comboBoxbolum.DisplayMember = "fakulteAd";
                comboBoxbolum.ValueMember = "FakulteID";
            }
        }

        private void ComboBoxogrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxogrenci.SelectedItem is Bolum secilen)
            {
                textBoxAd.Text = secilen.bolumAd;
                comboBoxbolum.SelectedValue = secilen.FakulteID;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gerekirse detay eklenebilir.
        }
    }
}
