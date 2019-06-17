using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaberUygulamasi
{
    public partial class FormYazarEkle : Form
    {
        public FormYazarEkle()
        {
            InitializeComponent();
        }

        HABERLERDBEntities db = new HABERLERDBEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Yazarlar yazar = new Yazarlar
            {
                YazarAdi = txtYazarAdi.Text,
                YazarSoyadi = txtYazarSoyadi.Text,
                YazarAdiSoyadi=txtYazarAdi.Text+" "+txtYazarSoyadi.Text
            };

            if (string.IsNullOrEmpty(txtYazarAdi.Text) || string.IsNullOrEmpty(txtYazarSoyadi.Text))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!");
            }
            else
            {
                db.Yazarlar.Add(yazar);
                db.SaveChanges();
                MessageBox.Show("Kişi eklendi");
                txtYazarAdi.Text = "";
                txtYazarSoyadi.Text = "";
            }

        }
    }
}
