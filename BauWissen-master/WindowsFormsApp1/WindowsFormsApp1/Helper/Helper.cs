using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1.Helper
{
    class Helper
    {
        /// <summary>
        /// Comboları doldurma
        /// </summary>
        public static void ComboDoldur(ComboBox cmb, ICollection list, string displayMember, string valueMember)
        {
            cmb.DataSource = list;
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
        }

        /// <summary>
        /// YazarAdıSoyadı ilk harflerinden ve kitap türünün ilk harflerinden oluşan bir kod üretelim
        /// </summary>
        public static string KitapKoduUret(Yazar yazar,KitapTuru kitapTuru,TextBox txt)
        {
            string[] kitapKelimeleri = txt.Text.Split(' ');

            string kitapKodu = yazar.Adi.Substring(0, 3) +
                    yazar.Soyadi.Substring(0, 3) +
                    kitapTuru.TurAdi.Substring(0, 3) + "-";

            for (int i = 0; i < kitapKelimeleri.Length; i++)
            {
                if (!string.IsNullOrEmpty(kitapKelimeleri[i]))
                {
                    kitapKodu = kitapKodu + kitapKelimeleri[i][0];
                }
            }

            return kitapKodu;
        }

        /// <summary>
        /// TextBox temizle
        /// </summary>
        public static void Temizle(params TextBox[] txt)
        {
            foreach (TextBox item in txt)
            {
                item.Clear();
            }
        }

        public static void FormKontrolleriniTemizle(Form form)
        {
            foreach (var item in form.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }

                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex=0;
                }
              
            }
        }

    }
}
