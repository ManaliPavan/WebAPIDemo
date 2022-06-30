using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Model;

namespace WebAPIDemo.Services
{
    public interface ICourseServices
    {
        IEnumerable<Course> GetAllCourses();
        int AddCourse(Course c);
        int ModifyCourse(Course c);
        int DeleteCourse(int id);
    }
}
