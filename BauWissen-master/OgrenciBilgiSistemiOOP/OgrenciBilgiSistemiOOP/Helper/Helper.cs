using OgrenciBilgiSistemiOOP.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemiOOP.Helper
{
    class Helper
    {
        /// <summary>
        /// Fakulte ve Bolum comboBoxlarını doldur
        /// </summary>     
        public static void ComboDoldur(ComboBox cmb, ICollection list, string displayMember, string valueMember)
        {
            cmb.DataSource = list;
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
        }

        /// <summary>
        /// Seçili Fakülte adına göre ilgili bölümleri döndür
        /// </summary>
        public static List<Bolum> BolumGetir(Fakulte seciliFakulte,List<Bolum> bolumList)
        {
            List<Bolum> seciliFakulteBolumleri = new List<Bolum>();

            foreach (var item in bolumList)
            {
                if (item.FakulteAdi==seciliFakulte.FakulteAdi)
                {
                    seciliFakulteBolumleri.Add(item);
                }
            }
            return seciliFakulteBolumleri;
        }

        /// <summary>
        /// Form üzerindeki elemanları temizleme
        /// </summary>
        /// <param name="form"></param>
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
                    ((ComboBox)item).SelectedIndex = 0;
                }
                else if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }
    
    }
}
