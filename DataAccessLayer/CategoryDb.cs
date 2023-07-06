using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface ICategoryDb
    {
        IEnumerable<Categorys> GetAll();
        Categorys GetById(int id);
        bool Insert(Categorys obj);
        bool Update(Categorys obj); 
        bool Delete(int id);
    }
    public class CategoryDb:ICategoryDb
    {
        //standard -->Pattern(Repository)
        //private AppDbContext context=new AppDbContext();
       

        private readonly AppDbContext context;
        public CategoryDb(AppDbContext _context)
        {
            context = _context;
        }
        public CategoryDb()
        {
            
        }
        public IEnumerable<Categorys> GetAll()
        {
            return context.Categories;
        }
        public Categorys GetById(int id)
        {
            var obj = context.Categories.Find(id);
            return obj;
        }

        public bool Insert(Categorys obj)
        {
            context.Categories.Add(obj);
            context.SaveChanges();
            return true;
        }

        public bool Update(Categorys obj)
        {
            context.Categories.Update(obj);
            context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var obj = context.Categories.Find(id);
            context.Categories.Remove(obj);
            context.SaveChanges();
            return true;
        }

    }
}
