using foy_5.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foy_5
{
    public partial class DersEkle : Form
    {
        public DersEkle()
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
                var ders = new Ders
                {
                    DersAd = textBoxAd.Text,
                };

                context.Ders.Add(ders);
                context.SaveChanges();
                MessageBox.Show("Ders başarıyla eklendi!");
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
                var dersListesi = context.Ders.ToList();
                dataGridView1.DataSource = dersListesi;
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
                var dersList = context.Ders.ToList();
                comboBoxogrenci.DataSource = dersList;
                comboBoxogrenci.DisplayMember = "DersAd";
                comboBoxogrenci.ValueMember = "DersID";
            }

            comboBoxogrenci.SelectedIndexChanged -= ComboBoxogrenci_SelectedIndexChanged; // tekrar eklenmesini önle
            comboBoxogrenci.SelectedIndexChanged += ComboBoxogrenci_SelectedIndexChanged;
        }

        private void ComboBoxogrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxogrenci.SelectedItem is Ders secilen)
            {
                textBoxAd.Text = secilen.DersAd;
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (comboBoxogrenci.SelectedValue == null) return;

            int DersID = Convert.ToInt32(comboBoxogrenci.SelectedValue);
            using (var context = new Foy5Context())
            {
                var ders = context.Ders.Find(DersID);
                if (ders != null)
                {
                    ders.DersAd = textBoxAd.Text;
                    context.SaveChanges();
                    MessageBox.Show("Ders başarıyla güncellendi!");
                    ListeleFakulteleri();
                }
                else
                {
                    MessageBox.Show("Ders bulunamadı!");
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
                int DersID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["DersID"].Value);
                using (var context = new Foy5Context())
                {
                    var ders = context.Ders.Find(DersID);
                    if (ders != null)
                    {
                        context.Ders.Remove(ders);
                        context.SaveChanges();
                        MessageBox.Show("Ders başarıyla silindi!");
                        ListeleFakulteleri();
                    }
                    else
                    {
                        MessageBox.Show("Ders bulunamadı!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek dersi seçin.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dersislemleri form = new Dersislemleri();
            form.ShowDialog();
        }
    }
}

