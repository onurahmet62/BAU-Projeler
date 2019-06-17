using North.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace North.BLL.Repositories
{
    public class CategoriesRepositories
    {
        //Ekleme, silme, listeleme, güncelleme
        NorthwindEntities db = new NorthwindEntities();
        public void Insert(Categories item)
        {
            db.Categories.Add(item);
            db.SaveChanges();
        }
    }
}
