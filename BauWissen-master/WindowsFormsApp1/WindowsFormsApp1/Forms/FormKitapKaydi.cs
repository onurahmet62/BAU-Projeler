using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;

namespace WindowsFormsApp1
{
    public partial class FormKitap : Form
    {
        public FormKitap()
        {
            InitializeComponent();
        }


        /// <summary>
        /// YazarListesi, KitapTürü comboları için veri girişi
        /// </summary>       
        private void FormKitap_Load(object sender, EventArgs e)
        {
            List<KitapTuru> kitapTuruList = new List<KitapTuru>()
            {
                new KitapTuru{TurAdi="Felsefe"},
                new KitapTuru{TurAdi="Sosyoloji"},
                new KitapTuru{TurAdi="Fantastik"}
            };
            
            List<Yazar> yazarList = new List<Yazar>()
            {
                new Yazar{Adi="Yaşar",Soyadi="Kemal" ,DogumTarihi=Convert.ToDateTime("10.10.1993")},
                new Yazar{Adi="Friederic",Soyadi="Nietzche" ,DogumTarihi=Convert.ToDateTime("09.10.1950")},
                new Yazar{Adi="Halide",Soyadi="Edip" ,DogumTarihi=Convert.ToDateTime("05.01.1960")},
            };
            
            Helper.Helper.ComboDoldur(cmbKitapTuru,kitapTuruList,"TurAdi","TurAdi");
            Helper.Helper.ComboDoldur(cmbYazar, yazarList, "YazarAdiSoyadi", "YazarAdiSoyadi");
        }

        private void txtKitapAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtKitapAdi != null)
            {
                txtKitapKodu.Text = Helper.Helper.KitapKoduUret((Yazar)cmbYazar.SelectedItem, (KitapTuru)cmbKitapTuru.SelectedItem, txtKitapAdi);
            }           
        }

        private void cmbKitapTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKitapTuru.SelectedItem != null && cmbYazar.SelectedItem != null)
            {
                txtKitapKodu.Text = Helper.Helper.KitapKoduUret((Yazar)cmbYazar.SelectedItem, (KitapTuru)cmbKitapTuru.SelectedItem, txtKitapAdi);
            }
        }

        private void cmbYazar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYazar.SelectedItem != null && cmbKitapTuru.SelectedItem != null)
            {
                txtKitapKodu.Text = Helper.Helper.KitapKoduUret((Yazar)cmbYazar.SelectedItem, (KitapTuru)cmbKitapTuru.SelectedItem, txtKitapAdi);
            }
        }

        static List<Kitap> kitapList = new List<Kitap>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.KitapAdi = txtKitapAdi.Text;
            kitap.KitapKodu = txtKitapKodu.Text;
            kitap.KitapTuru = (KitapTuru)cmbKitapTuru.SelectedItem;
            kitap.Yazar = (Yazar)cmbYazar.SelectedItem;

            kitapList.Add(kitap);

            Helper.Helper.FormKontrolleriniTemizle(this);
        }

    }
}
