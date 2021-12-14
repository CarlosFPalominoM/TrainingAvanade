using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Core.Models;

namespace Training.Application.Books
{
    public interface IBookService
    {
        IEnumerable<Book> Get();
        Book Get(int id);
        void Update(Book book);
        void Create(Book book);
        void Remove(int id);
    }
}
