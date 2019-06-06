using Library.Entities;
using Library_Exam_1.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Exam_1.DataAccess.EntityFramework
{
    public class EFWorkerRepository : IWorkerRepository
    {
        LibraryDB _context;


        public void Add(Worker entity)
        {
            using (_context = new LibraryDB())
            {
                _context.Workers.Add(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Worker> GetAll()
        {
            using (_context = new LibraryDB())
            {
                return _context.Workers;
            }
        }

        public Worker GetById(int id)
        {
            using (_context = new LibraryDB())
            {
                return _context.Workers.AsQueryable().FirstOrDefault(x => x.Id == id);
            }
        }

        public void Remove(Worker entity)
        {
            using (_context = new LibraryDB())
            {
                _context.Workers.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
