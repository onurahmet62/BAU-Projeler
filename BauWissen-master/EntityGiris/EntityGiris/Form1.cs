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

namespace EntityGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            ////SqlDatareader ile Northwind veri tabanını kullanarak müşterileri çekelim 

            ////////////Connected/////////////
            //SqlConnection con = new SqlConnection("Server=WISSEN; Database=Northwind; UID=sa; PWD=12345");
            //SqlCommand cmd = new SqlCommand(
            //    "Select * " +
            //    "From Customers", con);

            //if (con.State == ConnectionState.Closed)
            //    con.Open();

            ////Birden fazla satır etkilenecekse ExecuteReader kullanılır
            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //con.Close();
            //dataGridView1.DataSource = dt;

            //////////Disconnected ise////////////////////
            //SqlDataAdapter dap = new SqlDataAdapter("Select *from Customers",con);
            //DataTable dt2 = new DataTable();
            //dap.Fill(dt2);
            //dataGridView1.DataSource = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NorthwindEntities db = new NorthwindEntities();
            dataGridView1.DataSource = db.Customers.ToList();
        }
    }
}
