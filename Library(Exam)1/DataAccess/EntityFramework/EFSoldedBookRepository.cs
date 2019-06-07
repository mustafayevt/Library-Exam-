using Library_Exam_1.Domain.Abstraction;
using Library_Exam_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Exam_1.DataAccess.EntityFramework
{
    public class EFSoldedBookRepository : ISoldedBookRepository
    {
        LibraryDB _context;
        public void Add(SoldedBook entity)
        {
            using (_context = new LibraryDB())
            {
                _context.SoldedBooks.Add(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<SoldedBook> GetAll()
        {
            IEnumerable<SoldedBook> soldedBooks;
            using (_context = new LibraryDB())
            {
                soldedBooks = new List<SoldedBook>(_context.SoldedBooks);
            }
            return soldedBooks;
        }

        public SoldedBook GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(SoldedBook entity)
        {
            throw new NotImplementedException();
        }
    }
}
