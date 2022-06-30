using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Model;
using WebAPIDemo.Services;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseServices _cservice;
        public CourseController(ICourseServices cservice)
        {
            _cservice = cservice;
        }
        [HttpGet]

        [Route("GetCourse")]
        public IActionResult GetCourse()
        {
            return new ObjectResult(_cservice.GetAllCourses());
            // test code
        }
        [HttpPost]
        [Route("AddCourse")]
        public IActionResult AddCourse(Course c)
        {
            return new ObjectResult(_cservice.AddCourse(c));
        }

        [HttpPost]
        [Route("ModifyCourse")]
        public IActionResult ModifyCourse(Course c)
        {
            return new ObjectResult(_cservice.ModifyCourse(c));
        }

        [HttpGet]
        [Route("DeleteCourse/{id}")]
        public IActionResult DeleteCourse(int id)
        {
            return new ObjectResult(_cservice.DeleteCourse(id));
        }
    }
}
