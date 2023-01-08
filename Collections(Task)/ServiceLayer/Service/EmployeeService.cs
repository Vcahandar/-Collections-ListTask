using DomainLayer.Models;
using ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class EmployeeService : IEmployeeService

    {
        public int GetEmployeesCount(DateTime maxTime, DateTime minTime, int salary)
        {
            
            var result = GetAllEmployees();
            List<Employee>employees=GetAllEmployees().FindAll(m => m.Birthday > maxTime && m.Birthday < minTime && m.Salary > salary);

            return employees.Count;
        }

        List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new();

            Employee employee1 = new Employee
            {
                Id = 1,
                Name = "Zaur",
                Surname = "Mammedov",
                Salary = 2500,
                Birthday = new DateTime(1996, 08, 26)

            };
            Employee employee2 = new Employee
            {
                Id = 2,
                Name = "Elcan",
                Surname = "Mammedov",
                Salary = 1800,
                Birthday = new DateTime(1998, 02, 15)

            }; Employee employee3 = new Employee
            {
                Id = 3,
                Name = "Nurlan",
                Surname = "Mammedov",
                Salary = 2300,
                Birthday = new DateTime(2000, 07, 23)

            }; Employee employee4 = new Employee
            {
                Id = 4,
                Name = "Hikmet",
                Surname = "Mammedov",
                Salary = 2000,
                Birthday = new DateTime(1992, 12, 14)

            }; Employee employee5 = new Employee
            {
                Id = 5,
                Name = "Nurcan",
                Surname = "Mammedov",
                Salary = 1950,
                Birthday = new DateTime(2001, 04, 05)
            };

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);

            return employees;



        }


    }
}
