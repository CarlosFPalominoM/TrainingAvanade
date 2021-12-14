using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;

namespace Training.Application.Books
{
    public class BookService:IBookService
    {
        private List<Book> books;

        public BookService()
        {
            books = new List<Book>();

            for (int i = 0; i < 5; i++)
            {
                books.Add(new Book { Id = i, Title = $"Book Title {i}", ISBN = $"BOOK{i}", Author = $"Author {i}" });
            }
        }

        public IEnumerable<Book> Get()
        {
            return books;
        }

        public void Update(Book book)
        {
            books = books.Where(x => x.Id != book.Id).ToList();
            books.Add(book);
        }
    }
}
