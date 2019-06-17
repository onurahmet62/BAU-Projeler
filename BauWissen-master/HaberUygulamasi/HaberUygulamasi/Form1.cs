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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HABERLERDBEntities db = new HABERLERDBEntities();
        private void yeniYazarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYazarEkle frm = new FormYazarEkle();
            frm.Show();
        }

        private void yeniKategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKategoriEkle frm = new FormKategoriEkle();
            frm.Show();
        }

        private void yazarlarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();

            var list = db.Yazarlar.ToList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var listHaber = (from t in db.Haberler
                             select t
                           ).ToList();

            foreach (var item in listHaber)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Baslik;
                lvi.SubItems.Add(item.Icerik);
                lvi.SubItems.Add(Convert.ToString(item.Tarih));
                listView1.Items.Add(lvi);
                //lvi.SubItems.Add(item.Resim);
            }

            
        }

        private void yeniHaberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHaberEkle frm = new FormHaberEkle();
            frm.Show();
        }
    }
}
