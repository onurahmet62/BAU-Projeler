using Kutuphane.BLL;
using Kutuphane.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.PL
{
    public partial class frmKitap : Form
    {
        public frmKitap()
        {
            InitializeComponent();
        }

        private void KitapListele()
        {
            List<EKITAP> kitapListesi = BLLKITAP.SelectList();

            Liste.DataSource = kitapListesi;

        }

        private void frmKitap_Load(object sender, EventArgs e)
        {
            KitapListele();
            KategoriListele();
        }

        private void KategoriListele()
        {
            List<EKATEGORI> kategoriListesi = BLLKATEGORI.SelectList();

            txtKategori.DataSource = kategoriListesi;
            txtKategori.DisplayMember = "ADI";
            txtKategori.ValueMember = "ID";
        }

        //void YeniKaydet()
        //{
        //    EKITAP kitap = new EKITAP();
        //    {
        //        kitap.ADI = txtKitap.Text;
        //        kitap.HOSTNAME
        //    }
        //}
        private void btnEkle_Click(object sender, EventArgs e)
        {
            EKITAP kitapItem = new EKITAP();
            kitapItem.KATEGORIID = Convert.ToInt32(txtKategori.SelectedValue);
            kitapItem.SAYFASAYISI = short.Parse(txtSayfaSayisi.Text);
            kitapItem.ADI = txtKitapAdi.Text;
            kitapItem.YAZAR = txtYazar.Text;
            if (BLLKITAP.Insert(kitapItem) > 0)
            {
                MessageBox.Show("Kitap ekleme işlemi başarılı");
                txtYazar.Text = "";
                txtKitapAdi.Text = "";
                txtSayfaSayisi.Text = "";
            }
            else
            {
                MessageBox.Show("Kitap ekleme işlemi hatalı.");
            }
        }
    }
}
