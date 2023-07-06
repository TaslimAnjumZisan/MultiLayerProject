using BusinessObjectLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public interface ICategoryBs
    {
        IEnumerable<Categorys> GetAll();
        Categorys GetById(int id);
        bool Insert(Categorys obj);
        bool Update(Categorys obj);
        bool Delete(int id);
    }
    public class CategoryBs: ICategoryBs
    {
        //private CategoryDb objDb = new CategoryDb();
        private readonly CategoryDb objDb;
        public CategoryBs(CategoryDb _objDb)
        {
            objDb = _objDb;
        }

        public IEnumerable<Categorys> GetAll()
        {
            return objDb.GetAll();
        }
        public Categorys GetById(int id)
        {
            return objDb.GetById(id);
        }
        public bool Insert(Categorys obj)
        {
            return objDb.Insert(obj);
        }
        public bool Update(Categorys obj)
        {
            return objDb.Update(obj);
        }

        public bool Delete(int id)
        {
            return objDb.Delete(id);
        }
    }
}
