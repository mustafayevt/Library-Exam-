using Library_Exam_1.Domain.Abstraction;
using Library_Exam_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Exam_1.DataAccess.EntityFramework
{
    public class EFRentedBookRepository : IRentedBookRepository
    {
        LibraryDB _context;
        public void Add(RentedBook entity)
        {
            using (_context = new LibraryDB())
            {
                _context.RentedBooks.Add(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<RentedBook> GetAll()
        {
            IEnumerable<RentedBook> rentedBooks;
            using (_context = new LibraryDB())
            {
                rentedBooks = new List<RentedBook>(_context.RentedBooks);
            }
            return rentedBooks;
        }

        public RentedBook GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(RentedBook entity)
        {
            throw new NotImplementedException();
        }
    }
}
