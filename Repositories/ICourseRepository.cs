using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Model;

namespace WebAPIDemo.Repositories
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAllCourses();
        int AddCourse(Course c);
        int ModifyCourse(Course c);
        int DeleteCourse(int id);
    }
}
