using DomainLayer.Models;
using ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class AuthorService:IAuthorService
    {
        public List<Author> GetAuthor(int age)
        {
            var authors = GetAll();
            return authors.FindAll(m=>m.Age >age);
        }

       

        List<Author> GetAll() 
        {

            List<Author> authors = new();
            Author author1 = new Author
            {
                Id = 1,
                Name = "Cahandar",
                Surname = "Velibeyli",
                Age = 45
            };
            Author author2 = new Author
            {
                Id = 2,
                Name = "Ismayil",
                Surname = "Yusifov",
                Age = 48
            };
            Author author3 = new Author
            {
                Id = 3,
                Name = "Ceyhun",
                Surname = "Ismayilov",
                Age = 39
            }; Author author4 = new Author
            {
                Id = 4,
                Name = "Nurlan",
                Surname = "Mecidli",
                Age = 36
            }; Author author5 = new Author
            {
                Id = 5,
                Name = "Elcin",
                Surname = "Abbasov",
                Age = 47
            };

            authors.Add(author1);
            authors.Add(author2);
            authors.Add(author3);
            authors.Add(author4);
            authors.Add(author5);

            return authors;


        }






    }
    
}

