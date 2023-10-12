using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulam6_1
{
    internal class Book
    {
        int Id { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        string Publisher { get; set; }
        int Year { get; set; }
        int Price { get; set; }

        public Book(int id, string title, string author, string publisher, int year, int price)
        {
            this.Id = id;
            Title = title;
            Author = author;
            Publisher = publisher;
            Year = year;
            Price = price;
        }
        public override string ToString()
        {
            return $"{this.Id} - {this.Title} - {this.Author} - {this.Publisher} - {this.Year} - {this.Price}";
        }
    }
}
