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
    public class CategoryService
    {
        static Category Convert(CategoryDTO category)
        {
            return new Category() 
            { 
                Id=category.Id,
                Name=category.Name,
            };
        }
        static CategoryDTO Convert(Category category)
        {
            return new CategoryDTO()
            {
                Id = category.Id,
                Name = category.Name,
            };
        }
        static List<CategoryDTO> Convert(List<Category>categories)
        {
            var data = new List<CategoryDTO>();
            foreach (var category in categories)
            {
                data.Add(Convert(category));
            }
            return data;
        }

        public static List<CategoryDTO> Get()
        {
            return Convert(CategoryRepo.GetCategories());
        }
        public static CategoryDTO Get(int id)
        {
            return Convert(CategoryRepo.GetCategory(id));   
        }
        public static bool Insert(CategoryDTO category)
        {
            return CategoryRepo.Create(Convert(category));
        }
        public static bool Update(CategoryDTO category)
        {
            return CategoryRepo.Update(Convert(category));
        }
        public static bool Delete(int id)
        {
            return CategoryRepo.Delete(id);
        }
    }
}
