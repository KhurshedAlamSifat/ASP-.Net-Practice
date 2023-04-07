using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CategoryRepo
    {
        static NewsContext db;

        static CategoryRepo()
        {
            db = new NewsContext();
        }

        public static List<Category> GetCategories()
        {
            return db.Categories.ToList();
        }
        public static Category GetCategory(int id)
        {
            return db.Categories.Find(id);
        }
        public static bool Create(Category category)
        {
            db.Categories.Add(category);
            return db.SaveChanges()>0;
        }
        public static bool Update(Category category)
        {
            var ExCategory=GetCategory(category.Id);
            db.Entry(ExCategory).CurrentValues.SetValues(category);
            return db.SaveChanges() > 0;
        }
        public static bool Delete(int id)
        {
            var ExCategory=GetCategory(id);
            db.Categories.Remove(ExCategory);
            return db.SaveChanges() > 0;
        }
    }
}
