using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDB.Model
{
    public class SaleBook
    {
        public int Id { get; set; }
        public List<Book> Book { get; set; }
        public DateTime SaleDate { get; set; }
        public double Price { get; set; }
    }
}
