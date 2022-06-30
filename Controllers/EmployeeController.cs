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
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _empservice;
        public EmployeeController(IEmployeeServices empservice)
        {
            _empservice = empservice;
        }
        [HttpGet]

        [Route("GetEmployee")]
        public IActionResult GetEmployee()
        {
            return new ObjectResult(_empservice.GetAllEmployee());
            // test code
        }
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(Employee emp)
        {
            return new ObjectResult(_empservice.AddEmployee(emp));
        }

        [HttpPost]
        [Route("ModifyEmployee")]
        public IActionResult ModifyEmployee(Employee emp)
        {
            return new ObjectResult(_empservice.ModifyEmployee(emp));
        }

        [HttpGet]
        [Route("DeleteEmployee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            return new ObjectResult(_empservice.DeleteEmployee(id));
        }
    }
}
