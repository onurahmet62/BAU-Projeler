using Kutuphane.EntityLayer;
using Kutuphane.FacadeLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.BLL
{
    public class BLLKATEGORI    {
        public static int Insert(EKATEGORI item)
        {
            if (item.ADI!=null && item.ADI.Trim().Length>0)
            {
                return FKATEGORI.Insert(item);
            }
            return -1;
        }//EndOfInsert()
        public static bool Update(EKATEGORI item)
        {
            if (item.ID>0 && item.ADI != null && item.ADI.Trim().Length > 0)
            {
                return FKATEGORI.Update(item);
            }
            return false;

        }//EndOfUpdate()
        public static bool Delete(int _ID)
        {
            if (_ID > 0)
            {
                return FKATEGORI.Delete(_ID);
            }
            return false;
        }//EndOfDelete()        
        public static EKATEGORI Select(int _ID)
        {
            if (_ID > 0)
            {
                return FKATEGORI.Select(_ID);
            }
            return null;
        }//EndOfSelect()        
        public static List<EKATEGORI> SelectList()
        {
            return FKATEGORI.SelectList();
        }//EndOfSelectList()
    }
}
