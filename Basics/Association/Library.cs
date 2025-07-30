using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Association
{
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public Library(string name)
        {
            Name = name;
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void ShowBooks()
        {
            Console.WriteLine($"Books in {Name}:");
            foreach (var book in Books)
            {
                Console.WriteLine($"{book.Title} by {book.Author}");
            }
        }
    }
}
