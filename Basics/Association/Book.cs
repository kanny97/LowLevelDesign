using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Association
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Library Library { get; set; }
        public Book(string title, string author, Library library)
        {
            Title = title;
            Author = author;
            Library = library;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Library : {Library.Name}");
        }        
    }
}
