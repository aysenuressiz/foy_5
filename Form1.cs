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
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void fakulteEkle_Click(object sender, EventArgs e)
        {
            FakulteEkle form = new FakulteEkle();
            form.Show();
        }

        private void ogrenciEkle_Click(object sender, EventArgs e)
        {
            OgrenciEkle form = new OgrenciEkle();
            form.Show();
        }

        private void bolumEkle_Click(object sender, EventArgs e)
        {
            BolumEkle form = new BolumEkle();
            form.Show();
        }
    }
}
