using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberiEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TelReberiEntities db = new TelReberiEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            #region 1.Yöntem
            Kisiler kisi = new Kisiler();

            if (string.IsNullOrEmpty(txtAd.Text) && string.IsNullOrEmpty(txtSoyad.Text) && string.IsNullOrEmpty(txtTelNo.Text))
            {
                MessageBox.Show("Alanlar boş bırakılamaz!");

            }
            else
            {
                kisi.Adi = txtAd.Text;
                kisi.Soyadi = txtSoyad.Text;
                kisi.TelefonNumarasi = txtTelNo.Text;
                db.Kisiler.Add(kisi);
                db.SaveChanges();                
                MessageBox.Show("Kişi eklendi!");
                Temizle();
                VeriCek();
               
            }


            //db.Kisiler.Add(kisi);
            //db.SaveChanges();
            //MessageBox.Show("Kişi eklendi!");
            //txtAd.Text = "";
            //txtSoyad.Text = "";
            //txtTelNo.Text = "";
            #endregion

            //#region 2.Yöntem
            ////Kisiler yeniKisi = new Kisiler
            ////{
            ////    Adi = txtAd.Text,
            ////    Soyadi = txtSoyad.Text,
            ////    TelefonNumarasi = txtTelNo.Text
            ////};
            //////Object initialize
            ////db.Kisiler.Add(yeniKisi);
            ////db.SaveChanges();

            //#endregion

            #region 3.Yöntem
            //db.Kisiler.Add(new Kisiler
            //{
            //    Adi = txtAd.Text,
            //    Soyadi = txtSoyad.Text,
            //    TelefonNumarasi = txtTelNo.Text
            //});

            #endregion

        }

        void VeriCek()
        {
            if (db.Kisiler.Count() > 0)
            {
                dataGridView1.DataSource = db.Kisiler.ToList();
            }
            else
            {
                MessageBox.Show("Kişi bulunamadı!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VeriCek();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(item.Cells[0].Value);

                    db.Kisiler.Remove(db.Kisiler.Find(id));
                }
                db.SaveChanges();
                Temizle();
                VeriCek();
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Kisiler.Where(a => a.Adi.Contains(txtAra.Text) || a.Soyadi.Contains(txtAra.Text)).ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            guncellenecek.Adi = txtAd.Text;
            guncellenecek.Soyadi = txtSoyad.Text;
            guncellenecek.TelefonNumarasi = txtTelNo.Text;
            db.SaveChanges();
            MessageBox.Show("Kişi güncellendi!");
            Temizle();
            VeriCek(); 
        }

        Kisiler guncellenecek;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    int id = Convert.ToInt32(item.Cells[0].Value);

                    guncellenecek = db.Kisiler.Find(id);

                    txtAd.Text = guncellenecek.Adi;
                    txtSoyad.Text = guncellenecek.Soyadi;
                    txtTelNo.Text = guncellenecek.TelefonNumarasi;
                }
                
                db.SaveChanges();
                VeriCek();
            }
        }

        void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelNo.Text = "";
            txtAra.Text = "";
        }
    }
}
