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
    public partial class FormHaberEkle : Form
    {
        public FormHaberEkle()
        {
            InitializeComponent();
        }

        HABERLERDBEntities db = new HABERLERDBEntities();
        private void FormHaberEkle_Load(object sender, EventArgs e)
        {
            cmbKategori.DataSource = db.Kategoriler.ToList();
            cmbKategori.DisplayMember ="KategoriAdi";
            cmbKategori.ValueMember = "KategoriID";

            cmbYazar.DataSource = db.Yazarlar.ToList();
            cmbYazar.DisplayMember = "YazarAdiSoyadi";
            cmbYazar.ValueMember = "YazarID";
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Resim Seç";
            of.Filter = "Resim(.png,.jpg,.|*.png,*.jpg)";
            DialogResult dr = of.ShowDialog();
            if (dr==DialogResult.OK)
            {
                pictureBox1.ImageLocation = of.FileName;
                txtResim.Text = of.FileName;
            }
        }

        private void btnHaberEkle_Click(object sender, EventArgs e)
        {
            Haberler haber = new Haberler
            {
                Baslik = txtBaslik.Text,
                Icerik = txtAciklama.Text,
                Tarih=dateTimeTarih.Value,
                Resim =txtResim.Text,
                YazarID=(int)cmbYazar.SelectedValue,
                KategoriID=(int)cmbKategori.SelectedValue
            };

            if (string.IsNullOrEmpty(txtAciklama.Text)||string.IsNullOrEmpty(txtBaslik.Text)||string.IsNullOrEmpty(txtResim.Text))
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz");
            }
            else
            {
                db.Haberler.Add(haber);
                db.SaveChanges();
                MessageBox.Show("Haber eklendi");
                txtAciklama.Text = "";
                txtBaslik.Text = "";
                txtResim.Text = "";
            }
        }
    }
}
