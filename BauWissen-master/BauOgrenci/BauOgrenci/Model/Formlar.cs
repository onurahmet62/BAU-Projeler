using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BauOgrenci.Bilgi;
using System.Windows.Forms;

namespace BauOgrenci.Model
{
    class Formlar
    {
        //public void DersGiris()
        //{
        //    frmDersGiris frm = new frmDersGiris();
        //    frm.MdiParent = Form.ActiveForm;
        //    frm.WindowState = FormWindowState.Maximized; //Form açılırken tam ekran olması için
        //    frm.Show();
        //}
        //public void EgitmenGiris()
        //{
        //    frmEgitmenGiris frm = new frmEgitmenGiris();
        //    frm.MdiParent = Form.ActiveForm;
        //    frm.WindowState = FormWindowState.Maximized; //Form açılırken tam ekran olması için
        //    frm.Show();
        //}

        //public void OgrenciGiris()
        //{
        //   frmEgitmenGiris frm = new frmEgitmenGiris();
        //    frm.MdiParent = Form.ActiveForm;
        //    frm.WindowState = FormWindowState.Maximized; //Form açılırken tam ekran olması için
        //    frm.Show();
        //}
        public void Giris(Form frm)
        {
           
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized; //Form açılırken tam ekran olması için
            frm.Show();
        }
    }
}
