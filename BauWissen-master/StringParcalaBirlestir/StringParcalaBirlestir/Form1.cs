using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringParcalaBirlestir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = BolBirlestir(textBox1.Text, textBox2.Text);
        }

        private string BolBirlestir(string str1, string str2)
        {
            string yeni = "";

            if (str1.Length == str2.Length)//Uzunluklar Eşitse
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    yeni += str1[i].ToString() + str2[i].ToString();
                }
                return yeni;
            }

            else if (str1.Length > str2.Length)//Birinci string daha uzunsa
            {
                for (int i = 0; i < str1.Length; i++)
                {      
                    if (i < str2.Length)// string2 uzunluğuna gelene kadar string2'den karakter ekle
                    {
                        yeni += str1[i].ToString() + str2[i].ToString();                        
                    }
                   else
                        yeni += str1[i].ToString();
                }

                return yeni;
            }


            else//İkinci string daha uzunsa
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    if (i < str1.Length)
                    {
                        yeni += str2[i].ToString() + str1[i].ToString();
                    }
                    else
                    yeni += str2[i];
                }

                return yeni;
            }

        }
    }
}
