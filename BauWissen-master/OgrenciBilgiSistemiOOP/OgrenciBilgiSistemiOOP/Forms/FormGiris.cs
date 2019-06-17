using OgrenciBilgiSistemiOOP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemiOOP.Forms
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (Form1.ogrenciList.Count > 0)
            {
                foreach (OgrenciKayit item in Form1.ogrenciList)
                {
                    if (item.Sifre == txtOgrSifre.Text&&item.OgrenciNo==txtOgrNo.Text)
                    {                        
                        MessageBox.Show("Giriş Başarılı");
                    }
                    else if (item.Sifre != txtOgrSifre.Text || item.OgrenciNo!= txtOgrNo.Text)
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kullanıcı bulunamadı!");
                    }
                }
            }

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }
    }
}
