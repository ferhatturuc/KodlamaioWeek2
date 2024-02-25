using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class InstructerManager : IInstructorService
    {
        private readonly IInstructorDal instructorDal;
        public InstructerManager(IInstructorDal instructorDal)
        {
            this.instructorDal = instructorDal;
        }

        public void Create(Instructor instructor)
        {
            instructorDal.Create(instructor);
        }

        public void Delete(int id)
        {
            instructorDal.Delete(id);
        }

        public List<Instructor> GetAll()
        {
            return instructorDal.GetAll();
        }

        public void Update(Instructor instructor)
        {
            instructorDal.Update(instructor);
        }
    }
}
