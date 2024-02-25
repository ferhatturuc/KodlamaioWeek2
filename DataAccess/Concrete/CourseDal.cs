using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {

        List<Course> courses;
        public CourseDal()
        {
            courses = new List<Course>
        {
           new Course
           {
               Id=1,
               CategoryId=2,
               InstructorId=1,
               CourseName ="2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
               CourseDescription="Sıfırdan başlayıp yepyeni bir metodolojiyle profesyonelleşeceksiniz",
               CoursePrice=0,
           },
           new Course
           {
                Id=2,
                CategoryId=2,
                InstructorId=1,
                CourseName ="Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)",
                CourseDescription="Ücretsiz ve profesyonel bir programla, ileri seviye yazılım geliştirme öğreniyoruz.",
                CoursePrice=0,
           },
           new Course
           {
                 Id=3,
                 CategoryId=1,
                 InstructorId=2,
                 CourseName ="Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",
                 CourseDescription="1,5 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
                 CoursePrice=0,
           },
        };
        }

        public void Create(Course entity)
        {
            courses.Add(entity);
        }

        public void Delete(int id)
        {
            var courseToDelete = courses.SingleOrDefault(c => c.Id == id);
            if (courseToDelete != null)
            {
                courses.Remove(courseToDelete);
            }
            else
            {
                Console.WriteLine("Kurs Bulunamadı");
            }
        }

        public Course Get(int id)
        {
            return courses.FirstOrDefault(c => c.Id == id);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Update(Course entity)
        {
            var courseToUpdate = courses.SingleOrDefault(c => c.Id == entity.Id);
            if (courseToUpdate != null)
            {
                courseToUpdate.CategoryId = entity.CategoryId;
                courseToUpdate.InstructorId = entity.InstructorId;
                courseToUpdate.CourseName = entity.CourseName;
                courseToUpdate.CourseDescription = entity.CourseDescription;
                courseToUpdate.CoursePrice = entity.CoursePrice;
            }
            else
            {
                Console.WriteLine("Böyle bir kurs bulunamadı.");

            }
        }
    }
}
