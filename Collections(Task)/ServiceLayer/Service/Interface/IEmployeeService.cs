using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Interface
{
    public interface IEmployeeService
    {
       int GetEmployeesCount(DateTime maxTime, DateTime minTime, int salary);
    }
}
