using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HASTANEDBEntities db = new HASTANEDBEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBolumler.DataSource = db.Bolumler.Select(a => a.BolumAdi).ToList();
            cmbBolumler.DisplayMember = "BolumID";
         //  cmbBolumler.ValueMember = "BolumAdi";
            
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            Hastalar hasta = new Hastalar();
            var id = (from t in db.Bolumler
                     where t.BolumAdi == cmbBolumler.SelectedValue.ToString()
                     select new { 
                         id=t.ID
                    }).ToList();


            hasta.TC = txtTC.Text;
            hasta.Ad = txtAd.Text;
            hasta.Soyad = txtSoyad.Text;
            hasta.BolumID =Convert.ToInt32(id);

            db.Hastalar.Add(hasta);
            db.SaveChanges();
        }
    }
}
