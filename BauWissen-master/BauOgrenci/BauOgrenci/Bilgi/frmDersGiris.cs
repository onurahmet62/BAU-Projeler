using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BauOgrenci.Model;

namespace BauOgrenci.Bilgi
{
    public partial class frmDersGiris : Form
    {
        OgrenciDBDataContext db = new OgrenciDBDataContext();
        public frmDersGiris()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
            //this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }
        void YeniKaydet()
        {
            try
            {
                tblDer ders = new tblDer();
                ders.DersAdi = txtDersAdi.Text;
                db.tblDers.InsertOnSubmit(ders);//Sanal bir tabloya eklenmiş gibi
                db.SubmitChanges();//Database e kaydetti
                MessageBox.Show("Kayıt başarılı");
                txtDersAdi.Clear();
               // txtDersAdi.Text = "";
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e);
            }
        }

        
    }
}
