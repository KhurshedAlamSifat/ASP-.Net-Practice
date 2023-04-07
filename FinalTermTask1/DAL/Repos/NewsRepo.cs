using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class NewsRepo
    {
        static NewsContext db;

        static NewsRepo()
        {
            db = new NewsContext();
        }

        public static List<News> Get()
        {
            return db.Newses.ToList();
        }
        public static News Get(int id)
        {
            return db.Newses.Find(id);
        }
        public static bool Create(News news)
        {
            db.Newses.Add(news);
            return db.SaveChanges() > 0;
        }
        public static bool Update(News news)
        {
            var ExNews = Get(news.Id);
            db.Entry(ExNews).CurrentValues.SetValues(news);
            return db.SaveChanges() > 0;
        }
        public static bool Delete(int id)
        {
            var ExNews = Get(id);
            db.Newses.Remove(ExNews);
            return db.SaveChanges() > 0;
        }
    }
}
