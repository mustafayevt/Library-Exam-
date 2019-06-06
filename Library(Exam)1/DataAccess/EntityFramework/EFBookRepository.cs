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
            using (_context = new LibraryDB())
            {
                return _context.Books;
            }
        }

        public Book GetById(int id)
        {
            using (_context = new LibraryDB())
            {
                return _context.Books.AsQueryable().FirstOrDefault(x => x.Id == id);
            }
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
