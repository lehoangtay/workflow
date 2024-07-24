using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app01
{
    internal class Book: Publication
    {
        public string Author { get; set; }
        public Book(string title, decimal Price, int Copies, string author)
            : base(title, Price, Copies)
        {
            Author = author;
        }
        public void OrderCopies(int quantity)
        {
            Copies += quantity;
            Console.WriteLine($"Ordered{quantity} copies of '{Title}'. total copies:{Copies}");
        }
    }
}
