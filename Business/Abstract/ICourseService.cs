using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        List<Course> GetAll();
        void Create(Course course);
        void Update(Course course);
        void Delete(int id);
    }
}
