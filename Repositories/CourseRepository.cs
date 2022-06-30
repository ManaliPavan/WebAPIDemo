using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Entities;
using WebAPIDemo.Model;

namespace WebAPIDemo.Repositories
{
    public class CourseRepository: ICourseRepository
    {
        RepositoriesContext context;
        public CourseRepository(RepositoriesContext context) //DI
        {
            this.context = context;
        }

        public int AddCourse(Course c)
        {
            context.Course.Add(c);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteCourse(int cid)
        {
            var c = context.Course.Where(p => p.Cid == cid).SingleOrDefault();
            if (c != null)
            {
                context.Course.Remove(c);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return context.Course.ToList();
        }

        public int ModifyCourse(Course c)
        {
            var course = context.Course.Where(p => p.Cid == c.Cid).SingleOrDefault();
            if (course != null)
            {
                course.Cname = c.Cname;
                course.Fees = c.Fees;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}

