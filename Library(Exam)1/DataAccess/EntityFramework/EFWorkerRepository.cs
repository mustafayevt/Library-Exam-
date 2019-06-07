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
            IEnumerable<Worker> workers;
            using (_context = new LibraryDB())
            {
                workers = new List<Worker>( _context.Workers.Include("Branch"));
            }
            return workers;
        }

        public Worker GetById(int id)
        {
            Worker worker;
            using (_context = new LibraryDB())
            {
                worker = _context.Workers.AsQueryable().FirstOrDefault(x => x.Id == id).Clone();
            }
            return worker;
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
