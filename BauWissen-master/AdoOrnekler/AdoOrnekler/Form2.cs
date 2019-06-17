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

namespace AdoOrnekler
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
            //Form yüklendiğinde employees tablosundaki firstname lastname country ve homephone alanları gridviewe dolsun Ama ülkesi USA olanların kolon rengi farklı olsun

            SqlDataAdapter da = new SqlDataAdapter(
                "Select FirstName,LastName,HomePhone, Country " +
                "From Employees", con);
            DataTable dset = new DataTable();
            da.Fill(dset);


            dataGridView1.DataSource = dset;
            foreach (DataGridViewRow satir in dataGridView1.Rows)
            {
                if (satir.Cells["Country"].Value != null && satir.Cells["Country"].Value.ToString()=="USA")
                {
                    satir.Cells["Country"].Style.BackColor = Color.SkyBlue;
                }
            }
        }
    }
}
