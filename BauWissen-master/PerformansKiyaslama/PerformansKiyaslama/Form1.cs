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

namespace PerformansKiyaslama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server = WISSEN; Database = Northwind; UID = sa; PWD = 12345");
        private void btnConnected_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;

            SqlCommand cmd = new SqlCommand("Select CustomerID From Orders",con);
            if (con.State == ConnectionState.Closed)
                con.Open();

            //Birden fazla satır etkilenecekse ExecuteReader kullanılır
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {                
                while (dr.Read())
                {                    
                    listConnected.Items.Add(dr["CustomerID"]);                   
                }
            }
            con.Close();

            DateTime finish = DateTime.Now;
            TimeSpan fark = finish - start;
            lblConnected.Text = fark.Milliseconds.ToString();
        }

        private void btnDisconnected_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;

            SqlDataAdapter dap = new SqlDataAdapter("Select CustomerID From Orders", con);            
            DataSet dset = new DataSet();
            dap.Fill(dset);

            listDisconnected.DataSource = dset.Tables[0];
            listDisconnected.DisplayMember = "CustomerID";
            
            DateTime finish = DateTime.Now;
            TimeSpan fark = finish - start;
            lblDisconnected.Text = fark.Milliseconds.ToString();
        }

        private void btnEntity_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;

            NorthwindEntities db = new NorthwindEntities();
            listEntity.DataSource = db.Orders.Select(a => a.CustomerID).ToList();

            DateTime finish = DateTime.Now;
            TimeSpan fark = finish - start;
            lblEntity.Text = fark.Milliseconds.ToString();
            
        }
}
}
