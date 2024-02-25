using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }
        public void Create(Category category)
        {
            categoryDal.Create(category);
        }

        public void Delete(int id)
        {
            categoryDal.Delete(id);
        }

        public List<Category> GetAll()
        {
            return categoryDal.GetAll();
        }

        public void Update(Category category)
        {
            categoryDal.Update(category);
        }
    }
}
