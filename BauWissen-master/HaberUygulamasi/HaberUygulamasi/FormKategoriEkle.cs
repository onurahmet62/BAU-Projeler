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
    public partial class FormKategoriEkle : Form
    {
        public FormKategoriEkle()
        {
            InitializeComponent();
        }

        HABERLERDBEntities db = new HABERLERDBEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kategoriler kategori = new Kategoriler
            {
                KategoriAdi=txtKategori.Text
            };

            if (string.IsNullOrEmpty(txtKategori.Text) )
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!");
            }
            else
            {
                db.Kategoriler.Add(kategori);
                db.SaveChanges();
                MessageBox.Show("Kategori eklendi");
                txtKategori.Text = "";
            }
        }
    }
}
