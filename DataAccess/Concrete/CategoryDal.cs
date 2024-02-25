using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> categories;
        public CategoryDal()
        {
            categories = new List<Category>
        {
            new Category{Id=1,CategoryName="Programlama"},
            new Category{Id=2,CategoryName="FrontEnd"},
        };
        }

        public void Create(Category entity)
        {
            categories.Add(entity);
        }

        public void Delete(int id)
        {
            var categoryToDelete = categories.SingleOrDefault(c => c.Id == id);
            if (categoryToDelete != null)
            {
                categories.Remove(categoryToDelete);
            }
            else
            {
                Console.WriteLine("Kategori Bulunamadı");
            }
        }

        public Category Get(int id)
        {
            return categories.SingleOrDefault(category => category.Id == id);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category entity)
        {
            var categoryToUpdate = categories.SingleOrDefault(c => c.Id == entity.Id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.CategoryName = entity.CategoryName;
            }
            else
            {
                Console.WriteLine("Kategori Bulunamadı");

            }
        }
    }
}
