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
                if (entity.Id == 0)
                {
                    _context.Books.Add(entity);
                    _context.SaveChanges();
                }
                else
                {
                    Book book = _context.Books.FirstOrDefault(x => x.Id == entity.Id);
                    book.Name = entity.Name;
                    book.PurchasePrice = entity.PurchasePrice;
                    book.Quantity = entity.Quantity;
                    book.SalePrice = entity.SalePrice;
                    book.Author = entity.Author;
                    book.BranchId = entity.Branch.Id;
                    _context.Entry(book.Branch).State = System.Data.Entity.EntityState.Unchanged;
                    _context.SaveChanges();
                }
            }
        }

        public IEnumerable<Book> GetAll()
        {
            IEnumerable<Book> books;
            using (_context = new LibraryDB())
            {
                books = new List<Book>(_context.Books.Include("Branch"));
            }
            return books;
        }

        public Book GetById(int id)
        {
            Book book;
            using (_context = new LibraryDB())
            {
                book = _context.Books.AsQueryable().FirstOrDefault(x => x.Id == id);
            }
            return book;
        }

        public void Remove(Book entity)
        {
            using (_context = new LibraryDB())
            {
                Book book = _context.Books.FirstOrDefault(x => x.Id == entity.Id);
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }
    }
}
