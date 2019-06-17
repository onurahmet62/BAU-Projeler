using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Forms
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        
        static List<Kisi> kisiList = new List<Kisi>();
        private void linklblKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnGiris.Text=="Giriş Yap")
            {
                this.Text = "Kayıt Ol";
                linklblKayit.Text = "Giriş Yap";
                btnGiris.Text = "Kayıt Ol";
            }
            else if (btnGiris.Text == "Kayıt Ol")
            {
                this.Text = "Giriş Yap";
                linklblKayit.Text = "Kayıt Ol";
                btnGiris.Text = "Giriş Yap";
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (btnGiris.Text=="Kayıt Ol")
            {
                bool kisiVarMi = false;
                foreach (Kisi item in kisiList)
                {
                    if (item.KullaniciAdi==txtKullaniciAdi.Text)
                    {
                        kisiVarMi = true;
                        MessageBox.Show(txtKullaniciAdi.Text+" isimli kullanıcı mevcut," +
                                        " Lütfen farklı bir isim giriniz ");
                    }
                }

                if (!kisiVarMi)
                {
                    kisiList.Add(new Kisi
                            { KullaniciAdi=txtKullaniciAdi.Text,Sifre=txtSifre.Text });
                }

                Helper.Helper.Temizle(txtKullaniciAdi, txtSifre);
            }
            else if (btnGiris.Text=="Giriş Yap")
	        {
                bool kisiVarMi = false;
                foreach (Kisi item in kisiList)
                {
                    if (item.KullaniciAdi == txtKullaniciAdi.Text && txtSifre.Text == item.Sifre)
                    {
                        FormKitap formKitap = new FormKitap();
                        formKitap.Show();
                    }
                }
            }
        }

       
    }
}
