using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course : Entity
    {
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public int CoursePrice { get; set; }

    }
}
