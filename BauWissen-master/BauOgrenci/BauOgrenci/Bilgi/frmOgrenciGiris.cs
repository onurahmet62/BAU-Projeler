using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BauOgrenci.Bilgi;
using BauOgrenci.Model;

namespace BauOgrenci.Bilgi
{
    public partial class frmOgrenciGiris : Form
    {
        OgrenciDBDataContext db = new OgrenciDBDataContext();
        public frmOgrenciGiris()
        {
            InitializeComponent();
        }

        private void frmOgrenciGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        void YeniKaydet()
        {
            try
            {
                tblOgrenci ogrenci = new tblOgrenci();
                ogrenci.OgrAdi = txtOgrAdi.Text;
                ogrenci.OgrSoyadi = txtOgrSoyadi.Text;
                ogrenci.OgrNo = txtOgrNo.Text;
                ogrenci.DersId = db.tblDers.First(a=>a.DersAdi==cmbDersAdi.Text).Id;
                ogrenci.EgitmenId = db.tblEgitmens.First(a => a.EgitmenAdi == cmbEgitmenAdi.Text).Id;

                db.tblOgrencis.InsertOnSubmit(ogrenci);//Sanal bir tabloya eklenmiş gibi
                db.SubmitChanges();//Database e kaydetti
                MessageBox.Show("Kayıt başarılı");

                txtOgrAdi.Clear();
                txtOgrNo.Clear();
                txtOgrSoyadi.Clear();
                cmbDersAdi.SelectedIndex = -1;
                cmbEgitmenAdi.SelectedIndex = -1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e);
            }
        }

        void ComboDoldur()
        {
            cmbDersAdi.DataSource = db.tblDers.ToList();
            cmbDersAdi.DisplayMember = "DersAdi";
            cmbDersAdi.ValueMember = "Id";
            cmbDersAdi.SelectedIndex = -1;
            cmbDersAdi.SelectedText = "Seçiniz";
            

            cmbEgitmenAdi.DataSource = db.tblEgitmens.ToList();
            cmbEgitmenAdi.DisplayMember = "EgitmenAdi";
            cmbEgitmenAdi.ValueMember = "Id";
            cmbEgitmenAdi.SelectedIndex = -1;
            cmbEgitmenAdi.SelectedText="Seçiniz";
        }
    }
}
