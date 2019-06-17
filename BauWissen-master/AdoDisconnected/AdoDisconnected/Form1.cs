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

namespace AdoDisconnected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Tools.connectionString);

        private void Form1_Load(object sender, EventArgs e)
        {
            //Disconnected mimari 
            /* 
               Connectedtan farkı bağlantıları biz açıp kapatmıyoruz 
               Bütün açma kapatma işlemlerini SqlDataAdapter yapıyor
               Sadece sorgu yazıyoruz
             */

            SqlDataAdapter da = new SqlDataAdapter(
                "Select CategoryName,CategoryID " +
                "From Categories",con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
           
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlDataAdapter dadap = new SqlDataAdapter(
              "Select ProductName,ProductID,UnitPrice " +
              "From Products " +
              "Where CategoryID=@id", con);

            dadap.SelectCommand.Parameters.AddWithValue("@id", comboBox1.SelectedValue);
            DataSet dset = new DataSet();
            dadap.Fill(dset);

            listBox1.DataSource = dset.Tables[0];
            listBox1.DisplayMember = "ProductName";
            listBox1.ValueMember = "UnitPrice";
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex!=1)
            {
                label1.Text = "UnitPrice: "+listBox1.SelectedValue.ToString();
            }
        }
    }
}
