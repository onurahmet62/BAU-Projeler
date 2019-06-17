using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * Ado: Activex Data Object veri tabanı işlemleri için kullanacağımız yapıdır.
            - Connected mimari
            - Disconnected mimari

                  Veri Çekme Adımları
                    -Bağlantı oluştur
                    -Sorguyu oluştur
                    -Bağlantı aç 
                    -Sorguyu çalıştır ve ve veriyi elde et/gönder
                    -Bağlantıyı kapat
             */           
        }
        //1.Yöntem
        //SqlConnection con = new SqlConnection("Server=WISSEN; Database=Northwind; UID=sa; PWD=12345");

        //2.Yöntem
        //SqlConnection con = new SqlConnection(Tools.connectionString);

        //3.Yöntem
        SqlConnection con = new SqlConnection(
            ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
         
        private void btnSqlBagla_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                    MessageBox.Show("Bağlantı Başarılı!");
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Bağlantı kapatıldı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+" ");
            }
        }
    }
}
