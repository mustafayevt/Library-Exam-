using Library.Entities;
using Library_Exam_1.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Exam_1.DataAccess.EntityFramework
{
    public class EFBookRepository : IBookRepository
    {
        LibraryDB _context;

        public void Add(Book entity)
        {
            using (_context = new LibraryDB())
            {
                _context.Books.Add(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Book> GetAll()
        {
            IEnumerable<Book> books;
            using (_context = new LibraryDB())
            {
                books = new List<Book>( _context.Books);
            }
            return books;
        }

        public Book GetById(int id)
        {
            Book book;
            using (_context = new LibraryDB())
            {
                book = _context.Books.AsQueryable().FirstOrDefault(x => x.Id == id).Clone();
            }
            return book;
        }

        public void Remove(Book entity)
        {
            using (_context = new LibraryDB())
            {
                _context.Books.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
