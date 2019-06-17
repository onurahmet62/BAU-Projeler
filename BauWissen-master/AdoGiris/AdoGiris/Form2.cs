using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoGiris
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Tools.connectionString);
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "Insert Into Categories(CategoryName, Description)" +
                "Values('" + txtKategoriAdi.Text + "','" + txtAciklama.Text + "')" ,con);

               if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    int etkilenenSatir = cmd.ExecuteNonQuery();
                    MessageBox.Show(etkilenenSatir + " Kayıt Başarıyla eklenmiştir");
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Bir Hata oluştu");
                }
         
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "Update Categories set CategoryName='" + txtKategoriAdi.Text + "'," +
                "Description='" + txtAciklama.Text + "' " +
                "Where CategoryID=14", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                int etkilenenSatir = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(etkilenenSatir>0? "Başarılı":"Başarısız");
            }
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
               "Delete from Categories "+
               "Where CategoryID=15", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                int etkilenenSatir = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt silindi!");
            }

        }
    }
}
