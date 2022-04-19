using ConsoleDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using(var context = new Context())
            //{
            //    var user = new User()
            //    {
            //        FirstName = "Luka",
            //        LastName = "Josipovic",
            //        Email = "luka@gmail.com",
            //        Address = "ulica Zagreb",
            //        Password = "1234"
            //    };
            //    context.DbSetUsers.Add(user);
            //    context.SaveChanges();
            //}

            //AddAuthor();
            //AddBook();
        }

        private static void AddAuthor()
        {
            Console.WriteLine("Author name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Author lastname: ");
            string lastName = Console.ReadLine();

            using(var context = new Context())
            {
                var author = new Author()
                {
                    FirstName = firstName,
                    LastName = lastName,
                };
                context.DbSetAuthorBooks.Add(author);
                context.SaveChanges();
            }
        }

        private static void AddBook()
        {
            Console.WriteLine("Insert title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Insert description: ");
            string description = Console.ReadLine();
            
            Console.WriteLine("Insert publisher: ");
            string publisher = Console.ReadLine();
            
            Console.WriteLine("Insert rent price: ");
            double.TryParse(Console.ReadLine(), out double rentPrice);
            
            Console.WriteLine("Insert sale price: ");
            double.TryParse(Console.ReadLine(), out double salePrice);

            using (var context = new Context())
            {
                var book = new Book()
                {
                    Title = title,
                    Description = description,
                    Publisher = publisher,
                    RentPrice = rentPrice,
                    SalePrice = salePrice
                };
                context.DbSetBooks.Add(book);
                context.SaveChanges();
            }
        }
    }
}
