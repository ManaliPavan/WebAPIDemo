using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemo.Entities;
using WebAPIDemo.Model;

namespace WebAPIDemo.Repositories
{
    public class EmployeeRepository:IEmployeeRepository
    {
        RepositoriesContext context;
        public EmployeeRepository(RepositoriesContext context) //DI
        {
            this.context = context;
        }

        public int AddEmployee(Employee emp)
        {
            context.Employee.Add(emp);            ///s
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteEmployee(int id)
        {
            var emp = context.Employee.Where(p => p.Id == id).SingleOrDefault();
            if (emp != null)
            {
                context.Employee.Remove(emp);   //s
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employee.ToList();    //s
        }

        public int ModifyEmployee(Employee emp)
        {
            var employee = context.Employee.Where(p => p.Id == emp.Id).SingleOrDefault();   //s
            if (employee != null)
            {
                employee.Name = emp.Name;
                employee.Salary = emp.Salary;
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

