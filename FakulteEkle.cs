using foy_5.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace foy_5
{
    public partial class FakulteEkle : Form
    {
        public FakulteEkle()
        {
            InitializeComponent();
            TumKontrolleriGizle();
        }

        private void TumKontrolleriGizle()
        {
            secme.Visible = false;
            comboBoxogrenci.Visible = false;
            ad.Visible = false;
            textBoxAd.Visible = false;
            dataGridView1.Visible = false;
            btnekle.Visible = false;
            btnguncelle.Visible = false;
            btnsil.Visible = false;
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            TumKontrolleriGizle();
            ad.Visible = true;
            textBoxAd.Visible = true;
            btnekle.Visible = true;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            using (var context = new Foy5Context())
            {
                var fakulte = new Fakulte
                {
                    fakulteAd = textBoxAd.Text,
                };

                context.Fakulte.Add(fakulte);
                context.SaveChanges();
                MessageBox.Show("Fakülte başarıyla eklendi!");
                ListeleFakulteleri();
            }
        }

        private void listele_Click(object sender, EventArgs e)
        {
            TumKontrolleriGizle();
            dataGridView1.Visible = true;
            ListeleFakulteleri();
        }

        private void ListeleFakulteleri()
        {
            using (var context = new Foy5Context())
            {
                var fakulteListesi = context.Fakulte.ToList();
                dataGridView1.DataSource = fakulteListesi;
            }
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            TumKontrolleriGizle();
            secme.Visible = true;
            comboBoxogrenci.Visible = true;
            ad.Visible = true;
            textBoxAd.Visible = true;
            btnguncelle.Visible = true;

            FakulteleriComboBoxaYukle();
        }

        private void FakulteleriComboBoxaYukle()
        {
            using (var context = new Foy5Context())
            {
                var fakulteList = context.Fakulte.ToList();
                comboBoxogrenci.DataSource = fakulteList;
                comboBoxogrenci.DisplayMember = "fakulteAd";
                comboBoxogrenci.ValueMember = "fakulteID";
            }

            comboBoxogrenci.SelectedIndexChanged -= ComboBoxogrenci_SelectedIndexChanged; // tekrar eklenmesini önle
            comboBoxogrenci.SelectedIndexChanged += ComboBoxogrenci_SelectedIndexChanged;
        }

        private void ComboBoxogrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxogrenci.SelectedItem is Fakulte secilen)
            {
                textBoxAd.Text = secilen.fakulteAd;
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (comboBoxogrenci.SelectedValue == null) return;

            int fakulteID = Convert.ToInt32(comboBoxogrenci.SelectedValue);
            using (var context = new Foy5Context())
            {
                var fakulte = context.Fakulte.Find(fakulteID);
                if (fakulte != null)
                {
                    fakulte.fakulteAd = textBoxAd.Text;
                    context.SaveChanges();
                    MessageBox.Show("Fakülte başarıyla güncellendi!");
                    ListeleFakulteleri();
                }
                else
                {
                    MessageBox.Show("Fakülte bulunamadı!");
                }
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            TumKontrolleriGizle();
            dataGridView1.Visible = true;
            btnsil.Visible = true;
            ListeleFakulteleri();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int fakulteID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["fakulteID"].Value);
                using (var context = new Foy5Context())
                {
                    var fakulte = context.Fakulte.Find(fakulteID);
                    if (fakulte != null)
                    {
                        context.Fakulte.Remove(fakulte);
                        context.SaveChanges();
                        MessageBox.Show("Fakülte başarıyla silindi!");
                        ListeleFakulteleri();
                    }
                    else
                    {
                        MessageBox.Show("Fakülte bulunamadı!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek fakülteyi seçin.");
            }
        }
    }
}
