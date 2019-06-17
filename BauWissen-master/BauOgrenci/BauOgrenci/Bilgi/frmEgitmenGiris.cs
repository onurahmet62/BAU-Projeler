using BauOgrenci.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BauOgrenci.Bilgi
{
    public partial class frmEgitmenGiris : Form
    {
        OgrenciDBDataContext db = new OgrenciDBDataContext();
        public frmEgitmenGiris()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }
        void YeniKaydet()
        {
            try
            {
                tblEgitmen egitmen = new tblEgitmen();
                egitmen.EgitmenAdi = txtEgitmenAdi.Text;
                db.tblEgitmens.InsertOnSubmit(egitmen);//Sanal bir tabloya eklenmiş gibi
                db.SubmitChanges();//Database e kaydetti
                MessageBox.Show("Kayıt başarılı");
                txtEgitmenAdi.Clear();
                // txtDersAdi.Text = "";
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
            //this.Close();
        }
    }
}
