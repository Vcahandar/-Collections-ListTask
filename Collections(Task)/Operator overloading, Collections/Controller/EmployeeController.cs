using ServiceLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading__Collections.Controller
{
    public class EmployeeController
    {
        private readonly EmployeeService _service;


        public EmployeeController()
        {
            _service = new EmployeeService();
        }

        public void GetEmployees()
        {
            DateTime maxTime = new DateTime(1991, 01, 01);
            DateTime minTime = new DateTime(2000, 01, 01);
            int salary = 2000;

            var result = _service.GetEmployees(maxTime, minTime, salary);

            Console.WriteLine(result);
        }
    }

}

