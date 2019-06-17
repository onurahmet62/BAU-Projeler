﻿using Kutuphane.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.FacadeLayer
{
    public class FKITAP
    {
        /// <summary>
        /// KITAP_Insert prosedürüne kategori ekleme
        /// Referanslara Kutuphane.EntityLayer ekleyerek EKITAP sınıfındaki alanlarımıza eriştik
        /// </summary>
        /// <returns></returns>
        public static int Insert(EKITAP item)
        {
            int etkilenen = 0;
            try
            {
                SqlCommand com = new SqlCommand("KITAP_Insert", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("ADI", item.ADI);
                com.Parameters.AddWithValue("YAZAR", item.YAZAR);
                com.Parameters.AddWithValue("SAYFASAYISI", item.SAYFASAYISI);
                com.Parameters.AddWithValue("KATEGORIID", item.KATEGORIID);

                etkilenen = com.ExecuteNonQuery();
            }
            catch
            {
                etkilenen = -1;
            }

            return etkilenen;
        }//EndOfInsert()
        public static bool Update(EKITAP item)
        {
            bool sonuc = false;
            try
            {
                SqlCommand com = new SqlCommand("KITAP_Update", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("ADI", item.ADI);
                com.Parameters.AddWithValue("YAZAR", item.YAZAR);
                com.Parameters.AddWithValue("SAYFASAYISI", item.SAYFASAYISI);
                com.Parameters.AddWithValue("KATEGORIID", item.KATEGORIID);

                sonuc = com.ExecuteNonQuery() > 0;//Sıfırdan büyükse sonuc=true
            }
            catch
            {
                sonuc = false;
            }

            return sonuc;
        }//EndOfUpdate()
        public static bool Delete(int _ID)
        {
            bool sonuc = false;
            try
            {
                SqlCommand com = new SqlCommand("KITAP_Delete", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("ID", _ID);
                sonuc = com.ExecuteNonQuery() > 0;//Sıfırdan büyükse sonuc=true
            }
            catch
            {
                sonuc = false;
            }

            return sonuc;
        }//EndOfDelete()

        /// <summary>
        /// Aldığımız ID ye göre kitap çektik
        /// </summary>
        /// <param name="_ID"></param>
        /// <returns></returns>
        public static EKITAP Select(int _ID)
        {
            EKITAP item = null;
            try
            {
                SqlCommand com = new SqlCommand("KITAP_Select", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("ID", _ID);
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new EKITAP();
                        item.ID = int.Parse(rdr["ID"].ToString());
                        item.ADI = rdr["ADI"].ToString();
                        item.YAZAR = rdr["YAZAR"].ToString();
                        item.SAYFASAYISI = short.Parse(rdr["SAYFASAYISI"].ToString());
                        item.GMT = DateTime.Parse(rdr["GMT"].ToString());
                        item.HOSTNAME = rdr["HOSTNAME"].ToString();
                        item.KATEGORIID = int.Parse(rdr["KATEGORIID"].ToString());
                        item.KATEGORIADI = rdr["KATEGORIADI"].ToString();
                    }
                }
            }
            catch
            {
                item = null;
            }

            return item;
        }//EndOfSelect()

        /// <summary>
        /// Kategori_SelectList 'ten liste döndürdük
        /// </summary>
        /// <param name="_ID"></param>
        /// <returns></returns>
        public static List<EKITAP> SelectList()
        {
            List<EKITAP> itemList = null;
            try
            {
                SqlCommand com = new SqlCommand("KITAP_SelectList", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EKITAP>();
                    while (rdr.Read())
                    {
                        EKITAP item = new EKITAP();
                        item.ID = int.Parse(rdr["ID"].ToString());
                        item.ADI = rdr["ADI"].ToString();
                        item.YAZAR = rdr["YAZAR"].ToString();
                        item.SAYFASAYISI = short.Parse(rdr["SAYFASAYISI"].ToString());
                        item.GMT = DateTime.Parse(rdr["GMT"].ToString());
                        item.HOSTNAME = rdr["HOSTNAME"].ToString();
                        item.KATEGORIID = int.Parse(rdr["KATEGORIID"].ToString());
                        item.KATEGORIADI = rdr["KATEGORIADI"].ToString();

                        itemList.Add(item);
                    }
                    rdr.Close();
                }
            }
            catch
            {
                itemList = null;
            }
            return itemList;

        }//EndOfSelectList()

    }
}
