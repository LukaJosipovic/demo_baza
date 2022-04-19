using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDB.Model
{
    public class RentBook
    {
        public int Id { get; set; }
        public List<Book> Book { get; set; }
        [Required]
        public DateTime RentDate { get; set; }
        [Required]
        public DateTime ReturningDeadline { get; set; }
        [Required]
        public DateTime ReturningDate { get; set; }
        public int Dalay { get; set; }
        public double Price { get; set; }
    }
}
