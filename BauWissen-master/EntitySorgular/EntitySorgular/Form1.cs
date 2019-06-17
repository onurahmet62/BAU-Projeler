using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySorgular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            //Fiyatı 20 ile 50 arasında olan ürünlerin Idi,adi,fiyatı stok miktarı ve kategori adını getiren sorgu

            //var query = from p in db.Products
            //            where p.UnitPrice > 20 && p.UnitPrice < 50
            //            select new {
            //                UrunID =p.ProductID,
            //                UrunAdi=p.ProductName,
            //                Fiyat=p.UnitPrice,
            //                StokMiktari=p.UnitsInStock,
            //                KategoriAdi=p.Categories.CategoryName
            //            };
            //dataGridView1.DataSource = query.ToList();

            dataGridView1.DataSource = db.Products.Where(a => a.UnitPrice > 20 && a.UnitPrice < 50).Select(p => new
            {
                UrunID = p.ProductID,
                UrunAdi = p.ProductName,
                Fiyat = p.UnitPrice,
                StokMiktari = p.UnitsInStock,
                KategoriAdi = p.Categories.CategoryName
            }
            ).ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Orders.Select(o => new
            {
                MusteriSirketAdi=o.Customers.CompanyName,
                Calisan=o.Employees.FirstName+" "+ o.Employees.LastName,
                SiparisTarihi=o.OrderDate,
                KargoSirketi=o.Shippers.CompanyName
            }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = db.Customers.Where(a => a.CompanyName.Contains("Restaurant")).ToList();

            dataGridView1.DataSource = (from c in db.Customers
                                       where c.CompanyName.Contains("Restaurant")
                                       select c).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.Select(o => new
            {
                 CalisanAdiSoyadi = o.FirstName + " " + o.LastName,
                 DogumTarihi=o.BirthDate,
                 Yas=DateTime.Now.Year-o.BirthDate.Value.Year
            }).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = db.Categories.FirstOrDefault(a => a.CategoryName == "Beverages").CategoryID;

            Products p = new Products
            {
                ProductID = id,
                ProductName= "Kola",
                UnitPrice=5,
                UnitsInStock=500
            };

            db.Products.Add(p);
            db.SaveChanges();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Linq
            //dataGridView1.DataSource = (from t in db.Products
            //                           group t by t.Categories.CategoryName into g
            //                           select new
            //                           {
            //                               KategoriAdi = g.Key,
            //                               ToplamStok = g.Sum(p=>p.UnitsInStock)
            //                           }).ToList();

            //Lambda
            dataGridView1.DataSource=db.Products.GroupBy(p=>p.Categories.CategoryName).Select(g=> new
            {
                KategoriAdi = g.Key,
                ToplamStok = g.Sum(p => p.UnitsInStock)
            }).ToList();
        }
    }
}
