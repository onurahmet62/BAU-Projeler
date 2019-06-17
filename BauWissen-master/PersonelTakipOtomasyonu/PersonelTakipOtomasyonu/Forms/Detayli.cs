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

namespace PersonelTakipOtomasyonu.Forms
{
    public partial class Detayli : Form
    {
        public Detayli()
        {
            InitializeComponent();
        }
        string cnn = ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString;
        private void btnİnsert_Click(object sender, EventArgs e)
        {
        //    Form İnsert = new İnsert();
        //    İnsert.Show();

        //    SqlConnection con = new SqlConnection(cnn);
        //    SqlCommand cmd = new SqlCommand(
        //       "Insert Into Personeller set, con);

        //    if (con.State == ConnectionState.Closed)
        //    {
        //        con.Open();
        //        int etkilenenSatir = cmd.ExecuteNonQuery();
        //        con.Close();
        //        MessageBox.Show(etkilenenSatir > 0 ? "Başarılı" : "Başarısız");
        //    }

        //}

    }
}
}
