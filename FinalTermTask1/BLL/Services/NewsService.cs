using BLL.DTOs;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class NewsService
    {
        static News Convet(NewsDTO news)
        {
            return new News()
            {
                Id= news.Id,
                Title=news.Title,
                Description=news.Description,
                Date=news.Date,
                CategoryId=news.CategoryId,
            };
        }
        static NewsDTO Convet(News news)
        {
            return new NewsDTO()
            {
                Id = news.Id,
                Title = news.Title,
                Description = news.Description,
                Date = news.Date,
                CategoryId = news.CategoryId,
            };
        }
        static List<NewsDTO> Convert(List<News> news) 
        {
            var data = new List<NewsDTO>();
            foreach (var item in news)
            {
                data.Add(Convet(item));
            }
            return data;
        }

        public static List<NewsDTO> Getall()
        {
            var data = NewsRepo.Get();
            return Convert(data);
        }
       /* public static NewsDTO Get(int id)
        {
            var data = NewsRepo.Get(id);
            return Convert(data);
        }*/
        public static bool Insert(NewsDTO news)
        {
            return NewsRepo.Create(Convet(news));
        }
        public static bool Update(NewsDTO news)
        {
            return NewsRepo.Update(Convet(news));
        }
        public static bool Delete(int id)
        {
            return NewsRepo.Delete(id);
        }
    }
}
