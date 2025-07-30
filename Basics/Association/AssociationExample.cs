using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Association
{
    public class AssociationExample
    {
        public void Main()
        {
            // Create a library
            Library library = new Library("City Library");
            // Create some books
            Book book1 = new Book("1984", "George Orwell", library);
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", library);
            // Add books to the library
            library.AddBook(book1);
            library.AddBook(book2);
            // Show details of the books
            book1.ShowDetails();
            book2.ShowDetails();
            // Show all books in the library
            library.ShowBooks();
        }
    }
}
