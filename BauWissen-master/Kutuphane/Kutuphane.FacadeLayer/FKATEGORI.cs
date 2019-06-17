using Kutuphane.EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.FacadeLayer
{
    public class FKATEGORI
    {
        /// <summary>
        /// KATEGORI_Insert prosedürüne kategori ekleme
        /// Referanslara Kutuphane.EntityLayer ekleyerek EKATEGORI sınıfındaki alanlarımıza eriştik
        /// </summary>
        /// <returns></returns>
        public static int Insert(EKATEGORI item)
        {
            int etkilenen = 0;
            try
            {
                SqlCommand com = new SqlCommand("KATEGORI_Insert", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("ADI", item.ADI);
                etkilenen = com.ExecuteNonQuery();
            }
            catch
            {
                etkilenen = -1;
            }

            return etkilenen;
        }//EndOfInsert()

        public static bool Update(EKATEGORI item)
        {
            bool sonuc = false;
            try
            {
                SqlCommand com = new SqlCommand("KATEGORI_Update", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("ID",item.ID);
                com.Parameters.AddWithValue("ADI", item.ADI);
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
                SqlCommand com = new SqlCommand("KATEGORI_Delete", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("ID",_ID);               
                sonuc = com.ExecuteNonQuery() > 0;//Sıfırdan büyükse sonuc=true
            }
            catch
            {
                sonuc = false;
            }

            return sonuc;
        }//EndOfDelete()

        /// <summary>
        /// Aldığımız ID ye göre kategori aldık
        /// </summary>
        /// <param name="_ID"></param>
        /// <returns></returns>
        public static EKATEGORI Select(int _ID)
        {
            EKATEGORI item = null;
            try
            {
                SqlCommand com = new SqlCommand("KATEGORI_Select", Baglanti.Con);
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
                        item = new EKATEGORI();
                        item.ID =int.Parse(rdr["ID"].ToString());
                        item.ADI = rdr["ADI"].ToString();
                    }
                    rdr.Close();
                }
            }
            catch
            {
                item=null;
            }

            return item;
        }//EndOfSelect()

        /// <summary>
        /// Kategori_SelectList 'ten liste döndürdük
        /// </summary>
        /// <param name="_ID"></param>
        /// <returns></returns>
        public static List<EKATEGORI> SelectList()
        {
            List<EKATEGORI> itemList = null;
            try
            {
                SqlCommand com = new SqlCommand("KATEGORI_SelectList", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
               
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EKATEGORI>();
                    while (rdr.Read())
                    {
                        EKATEGORI item = new EKATEGORI();
                        item.ID = int.Parse(rdr["ID"].ToString());
                        item.ADI = rdr["ADI"].ToString();
                        itemList.Add(item);
                    }
                }

                rdr.Close();
            }
            catch
            {
                itemList = null;
            }
            return itemList;

        }//EndOfSelectList()

    }//EndOfFkategoriClass
}
