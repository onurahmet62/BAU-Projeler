using North.BLL.Repositories;
using North.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace North.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CategoriesRepositories cr = new CategoriesRepositories();
        private void btnKategori_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            cr.Insert(new Categories
            {
                CategoryName = txtKategoriAdi.Text,
                Description=txtAciklama.Text
            });
        }
    }
}
