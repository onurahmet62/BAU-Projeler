using OgrenciBilgiSistemiOOP.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciBilgiSistemiOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Bolum> bolumList = new List<Bolum>();
        List<Fakulte> fakulteList = new List<Fakulte>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Fakülte Listesi verileri ekleme
            fakulteList.Add(new Fakulte { FakulteAdi = "Fen Edebiyat Fakültesi", FakulteKodu = "FEF" });
            fakulteList.Add(new Fakulte { FakulteAdi = "Mühendislik Fakültesi", FakulteKodu = "MUH" });
            fakulteList.Add(new Fakulte { FakulteAdi = "Güzel Sanatlar Fakültesi", FakulteKodu = "GSF" });
            
            //Bolum Listesi verileri ekleme
            bolumList.Add(new Bolum { BolumAdi = "Bilgisayar Mühendisliği",FakulteAdi="Mühendislik Fakültesi",FakulteKodu="MUH" });
            bolumList.Add(new Bolum { BolumAdi = "Yazılım Mühendisliği", FakulteAdi = "Mühendislik Fakültesi", FakulteKodu = "MUH" });
            bolumList.Add(new Bolum { BolumAdi = "Jeoloji Mühendisliği", FakulteAdi = "Mühendislik Fakültesi", FakulteKodu = "MUH" });
            bolumList.Add(new Bolum { BolumAdi = "Makina Mühendisliği", FakulteAdi = "Mühendislik Fakültesi", FakulteKodu = "MUH" });
            bolumList.Add(new Bolum { BolumAdi = "Elektrik Elektronik Mühendisliği", FakulteAdi = "Mühendislik Fakültesi", FakulteKodu = "MUH" });
            bolumList.Add(new Bolum { BolumAdi = "Endüstri Mühendisliği", FakulteAdi = "Mühendislik Fakültesi", FakulteKodu = "MUH" });

            bolumList.Add(new Bolum { BolumAdi = "Matematik Bölümü", FakulteAdi = "Fen Edebiyat Fakültesi", FakulteKodu = "FEF" });
            bolumList.Add(new Bolum { BolumAdi = "Tarih Bölümü", FakulteAdi = "Fen Edebiyat Fakültesi", FakulteKodu = "FEF" });
            bolumList.Add(new Bolum { BolumAdi = "Fizik Bölümü", FakulteAdi = "Fen Edebiyat Fakültesi", FakulteKodu = "FEF" });
            bolumList.Add(new Bolum { BolumAdi = "Coğrafya Bölümü", FakulteAdi = "Fen Edebiyat Fakültesi", FakulteKodu = "FEF" });
            bolumList.Add(new Bolum { BolumAdi = "İngiliz Edebiyatı", FakulteAdi = "Fen Edebiyat Fakültesi", FakulteKodu = "FEF" });

            bolumList.Add(new Bolum { BolumAdi = "Konservatuar", FakulteAdi = "Güzel Sanatlar Fakültesi", FakulteKodu = "GSF" });
            bolumList.Add(new Bolum { BolumAdi = "Tiyatro", FakulteAdi = "Güzel Sanatlar Fakültesi", FakulteKodu = "GSF" });
            bolumList.Add(new Bolum { BolumAdi = "İç Mimarlık", FakulteAdi = "Güzel Sanatlar Fakültesi", FakulteKodu = "GSF" });
            bolumList.Add(new Bolum { BolumAdi = "Resim", FakulteAdi = "Güzel Sanatlar Fakültesi", FakulteKodu = "GSF" });
            bolumList.Add(new Bolum { BolumAdi = "Heykel", FakulteAdi = "Güzel Sanatlar Fakültesi", FakulteKodu = "GSF" });

            //Fakülte comboBoxını doldur
            Helper.Helper.ComboDoldur(cmbFakulte, fakulteList, "FakulteAdi", "FakulteKodu");
           
        }//EndOfForm_Load

        private void cmbFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçilen Fakülteye ait baölümleri getirmek için
            Fakulte seciliFakulte = (Fakulte)cmbFakulte.SelectedItem;

            //Seçili fakültenin bölümlerini getir
            List<Bolum> gelenBolumler= Helper.Helper.BolumGetir(seciliFakulte, bolumList);

            //Seçili fakültenin iligili bölümlerini comboDoldura gönder
            Helper.Helper.ComboDoldur(cmbBolum, gelenBolumler, "BolumAdi", "BolumAdi");

            string ogrenciNo =  DateTime.Now.Year +((Bolum)cmbBolum.SelectedItem).BolumAdi.Substring(0, 3) +
                           ((Fakulte)cmbFakulte.SelectedItem).FakulteAdi.Substring(0, 3) +
                            (ogrenciList.Count() + 1);
            txtOgrenciNo.Text = ogrenciNo;
        }

        public static List<OgrenciKayit> ogrenciList = new List<OgrenciKayit>();

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            eklemeBasarili = true;
            //Kayıt listesi için Listeyi oluşturucam, classımdan instance alıcam
            //textBoxlarımdan aldığım değerleri classımdan türettiğim nesneme atıcam

            try
            {
                OgrenciKayit ogr = new OgrenciKayit();
                ogr.Ad = txtAdi.Text;
                ogr.Soyad = txtSoyadi.Text;
                ogr.KimlikNo = txtTC.Text;
                ogr.OgrenciNo = txtOgrenciNo.Text;
                ogr.DogumTarihi = dtimeDogum.Value;
                ogr.Bolum = ((Bolum)cmbBolum.SelectedItem).BolumAdi;
                ogr.Fakulte = ((Fakulte)cmbFakulte.SelectedItem).FakulteAdi;

                if (rdKadin.Checked)
                {
                    ogr.Cinsiyet = true;
                }
                else
                {
                    ogr.Cinsiyet = false;
                }

                ogr.Sifre = txtSifre.Text;             

                BosKontrol(this);
                ogrenciList.Add(ogr);
                if (eklemeBasarili == true)
                {
                    MessageBox.Show("Ekleme başarılı");
                    Helper.Helper.FormKontrolleriniTemizle(this);
                }
                Forms.FormGiris fg = new Forms.FormGiris();
                fg.Show();

            }
            catch (Exception)
            {
                throw;
            }

           
        }//EndOfbtnKaydet_Click

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ogrenciNo = DateTime.Now.Year + ((Bolum)cmbBolum.SelectedItem).BolumAdi.Substring(0, 3) +
                           ((Fakulte)cmbFakulte.SelectedItem).FakulteAdi.Substring(0, 3) +
                             (ogrenciList.Count() + 1);
            txtOgrenciNo.Text = ogrenciNo;
        }

        private void btnSifreGoster_MouseDown(object sender, MouseEventArgs e)
        {
            txtSifre.PasswordChar = '\0';
        }

        private void btnSifreGoster_MouseUp(object sender, MouseEventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void btnSifreTekrar_MouseDown(object sender, MouseEventArgs e)
        {
            txtSifreTekrar.PasswordChar = '\0';
        }

        private void btnSifreTekrar_MouseUp(object sender, MouseEventArgs e)
        {
            txtSifreTekrar.PasswordChar = '*';
        }

        bool eklemeBasarili = true;
        /// <summary>
        /// Boş ve Şifre Kontrolü yapan metod
        /// </summary>
        /// <param name="form"></param>
        public  void BosKontrol(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == String.Empty)
                    {
                        MessageBox.Show(Convert.ToString(((TextBox)item).Name) + "boş geçilemez!");
                        eklemeBasarili = false;
                    }
                }
                
            }//EndOfForeach

            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmamaktadır");
                eklemeBasarili = false;
            }
           
        }//EndOf BoşKontrol()

    }//EndOfForm
}
