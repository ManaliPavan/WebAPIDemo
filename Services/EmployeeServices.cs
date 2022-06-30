using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Model;
using WebAPIDemo.Repositories;

namespace WebAPIDemo.Services
{
    public class EmployeeServices:IEmployeeServices
    {
        private readonly IEmployeeRepository _iEmployeeRepo;
        // Injecition of Dependancy using constructor
        public EmployeeServices(IEmployeeRepository iEmployeeRepo)
        {
            _iEmployeeRepo = iEmployeeRepo;
        }
        public int AddEmployee(Employee emp)
        {
            return _iEmployeeRepo.AddEmployee(emp);
        }
        public int DeleteEmployee(int id)
        {
            return _iEmployeeRepo.DeleteEmployee(id);
        }
        public IEnumerable<Employee> GetAllEmployee()
        {
            return _iEmployeeRepo.GetAllEmployee();
        }
        public int ModifyEmployee(Employee emp)
        {
            return _iEmployeeRepo.ModifyEmployee(emp);

        }
    }
}

