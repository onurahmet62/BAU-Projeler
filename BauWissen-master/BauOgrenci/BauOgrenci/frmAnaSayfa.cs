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
using BauOgrenci.Bilgi;

namespace BauOgrenci
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        Formlar f = new Formlar();//Ram'de bir yer açıyoruz, heapte tutulur, Form kadar yer açılır. Static olunca daha büyük yer açılır ve daha yavaştır
        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnDersGiris_Click(object sender, EventArgs e)
        {
            frmDersGiris frm = new frmDersGiris();
            f.Giris(frm);
        }

        private void btnOgrenciGiris_Click(object sender, EventArgs e)
        {
            frmOgrenciGiris frm = new frmOgrenciGiris();
            f.Giris(frm);
        }

        private void btnEgitmenGiris_Click(object sender, EventArgs e)
        {
            //f.EgitmenGiris();
            frmEgitmenGiris frm = new frmEgitmenGiris();
            f.Giris(frm);
        }
    }
}
