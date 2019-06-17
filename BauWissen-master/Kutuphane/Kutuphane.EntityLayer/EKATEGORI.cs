using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.EntityLayer
{
    public class EKATEGORI:IDisposable
    {
        private int _ID; //ctrl+E+R ile get set 
        private string _ADI;
        public int ID { get => _ID; set => _ID = value; }
        public string ADI { get => _ADI; set => _ADI = value; }

       
        public void Dispose()//Ramde yer tutan veriler bir listede tutuluyor ve ihtiyacımız yokken silinir// Ramda silinmesi için listenin en başına EKategoriyi alıyor 
        {
            GC.SuppressFinalize(this);
        }
    }
}
