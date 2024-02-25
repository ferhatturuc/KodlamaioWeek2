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
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            this.courseDal = courseDal;
        }
        public void Create(Course course)
        {
            courseDal.Create(course);
        }

        public void Delete(int id)
        {
            courseDal.Delete(id);
        }

        public List<Course> GetAll()
        {
            return courseDal.GetAll();
        }

        public void Update(Course course)
        {
            courseDal.Update(course);
        }
    }
}
