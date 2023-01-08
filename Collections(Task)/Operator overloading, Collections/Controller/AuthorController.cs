using ServiceLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading__Collections.Controller
{
    public class AuthorController
    {
        private readonly AuthorService _service;
        public AuthorController()
        {
            _service= new AuthorService();
        }

       
        public void GetAuthor()
        {
            int age = 40;
            var result=_service.GetAuthor(age);
            foreach (var item in result)
            {
                if (item.Age>age)
                {
                    Console.WriteLine($"{item.Name}  {item.Surname}");
                }
            }
            
        }
    }
}
