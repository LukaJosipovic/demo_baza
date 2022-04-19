using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDB.Model
{
    public class Context : DbContext
    {
        public DbSet<User> DbSetUsers { get; set; }
        public DbSet<Book> DbSetBooks { get; set; }
        public DbSet<RentBook> DbSetRentBooks { get; set; }
        public DbSet<SaleBook> DbSetSaleBooks { get; set; }
        public DbSet<Author> DbSetAuthorBooks { get; set; }
    }
}
