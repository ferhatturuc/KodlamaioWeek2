using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {

        List<Instructor> instructors;
        public InstructorDal()
        {
            instructors = new List<Instructor>
        {
            new Instructor{Id=1,FirstName="Engin", LastName="Demiroğ"},
            new Instructor{Id=2,FirstName="Faruk", LastName="Karaaslan"},
            new Instructor{Id=3,FirstName="Ferhat", LastName="Turuç"}

        };
        }

        public void Create(Instructor entity)
        {
            instructors.Add(entity);
        }

        public void Delete(int id)
        {
            var instructorToDelete = instructors.SingleOrDefault(i => i.Id == id);
            if (instructorToDelete != null)
            {
                instructors.Remove(instructorToDelete);
            }
            Console.WriteLine("Eğitmen Bulunamadı");
        }

        public Instructor Get(int id)
        {
            return instructors.SingleOrDefault(i => i.Id == id);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor entity)
        {
            var instructorToUpdate = instructors.SingleOrDefault(i => i.Id == entity.Id);
            if (instructorToUpdate != null)
            {
                instructorToUpdate.FirstName = entity.FirstName;
                instructorToUpdate.LastName = entity.LastName;
            }
            Console.WriteLine("Eğitmen Bulunamadı");
        }
    }
}
