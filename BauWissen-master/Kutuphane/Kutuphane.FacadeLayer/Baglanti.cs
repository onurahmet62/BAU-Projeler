using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.FacadeLayer
{
    public class Baglanti 
    {
        public static readonly SqlConnection Con = new SqlConnection
            ("SERVER=WISSEN;DATABASE=Kutuphane; USER ID=sa; PASSWORD=12345;");
        
    }
}
