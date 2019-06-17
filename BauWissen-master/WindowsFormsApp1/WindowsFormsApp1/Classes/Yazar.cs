using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Yazar
    {
        public string Adi { get; set; }//property
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }

        private string _yazarAdiSoyadi;

        public string YazarAdiSoyadi //Field
        {
            get
            {
                _yazarAdiSoyadi = Adi + " " + Soyadi;
                return _yazarAdiSoyadi;
            }
        }
    }
}
