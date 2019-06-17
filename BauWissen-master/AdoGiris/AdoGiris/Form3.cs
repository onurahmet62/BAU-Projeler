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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Tools.connectionString);
        private void btnGetir_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "Select FirstName, LastName " +
                "From Employees", con);

            if (con.State == ConnectionState.Closed)            
                con.Open();

            //Birden fazla satır etkilenecekse ExecuteReader kullanılır
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 1;
                while (dr.Read())
                {
                    string ad = dr["FirstName"].ToString();
                    string soyad = dr["LastName"].ToString();
                    listBox1.Items.Add(i+". "+ad + " " + soyad);
                    i++;
                }
            }

           con.Close();
            
            
        }
    }
}
