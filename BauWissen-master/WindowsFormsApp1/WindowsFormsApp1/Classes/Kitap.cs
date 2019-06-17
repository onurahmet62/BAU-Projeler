using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Kitap
    {
        public KitapTuru KitapTuru { get; set; }
        public string KitapAdi { get; set; }
        public Yazar Yazar { get; set; }
        public string KitapKodu { get; set; }

    }
}
