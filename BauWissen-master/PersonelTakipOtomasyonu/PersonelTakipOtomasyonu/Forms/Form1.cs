using PersonelTakipOtomasyonu.Classes;
using PersonelTakipOtomasyonu.Forms;
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

namespace PersonelTakipOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string cnn = ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString;
        //List<Girisler> girislistesi = new List<Girisler>();
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
                if (ctl is TextBox)
                {
                    
                    if (ctl.Text == String.Empty)
                    {
                        MessageBox.Show(Convert.ToString(((TextBox)ctl).Text + " Bu alan boş geçilemez!"));
                    }

                }
            SqlConnection con = new SqlConnection(cnn);
            SqlCommand cmd = new SqlCommand("Select KullaniciAdi,KullaniciSifre from Girisler",con);
            if (con.State == ConnectionState.Closed) 
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (txtUser.Text == dr[0].ToString() && txtPassword.Text == dr[1].ToString())
                    {
                        Form Detayli = new Form();
                        Detayli.Show();
                    }
                }
            }
            con.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Form frm = new Form();
            //frm.Show();
        }
    }

        
}
    