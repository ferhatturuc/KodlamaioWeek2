// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

Console.WriteLine("--Kurslar--");
CourseManager courseManager = new(new CourseDal());
List<Course> courses = courseManager.GetAll();
foreach (var course in courses)
{
    Console.WriteLine(course.CourseName);
}

Console.WriteLine(" \n");

Console.WriteLine("--Kategoriler--");
CategoryManager categoryManager = new(new CategoryDal());
List<Category> categories = categoryManager.GetAll();
foreach (var category in categories)
{
    Console.WriteLine(category.CategoryName);
}

Console.WriteLine(" \n");

Console.WriteLine("--Eğitmenler--");
InstructerManager instructerManager = new(new InstructorDal());
List<Instructor> instructors = instructerManager.GetAll();
foreach (var instructor in instructors)
{
    Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
}

Console.WriteLine(" \n");

Console.WriteLine("--Kurs Ekle--");
Course course1 = new()
{
    Id = 4,
    CategoryId = 1,
    InstructorId = 1,
    CourseName = "Mobil Programlama Flutter",
    CourseDescription = "1.5 ay sürecek Mobil Programlama Kampı",
    CoursePrice = 100
};
courseManager.Create(course1);
List<Course> courses1 = courseManager.GetAll();
foreach (var course in courses1)
{
    Console.WriteLine(course.CourseName);
}

Console.WriteLine(" \n");

Console.WriteLine("--Kategori Ekle--");
Category category1 = new()
{
    Id = 4,
    CategoryName = "Mobil"
};
categoryManager.Create(category1);
List<Category> categories1 = categoryManager.GetAll();
foreach (var category in categories1)
{
    Console.WriteLine(category.CategoryName);
}

Console.WriteLine(" \n");

Console.WriteLine("--Kurs Güncelle--");
Course course2 = new()
{
    Id = 4,
    CategoryId = 1,
    InstructorId = 1,
    CourseName = "Mobil Programlama Flutter",
    CourseDescription = "1.5 ay sürecek Mobil Programlama Kampı",
    CoursePrice = 200
};
courseManager.Update(course2);
List<Course> courses2 = courseManager.GetAll();
foreach (var course in courses2)
{
    Console.WriteLine(course.CourseName);
}

Console.WriteLine("--Kurs Sil--");
courseManager.Delete(4);
List<Course> courses3 = courseManager.GetAll();
foreach (var course in courses3)
{
    Console.WriteLine(course.CourseName);
}