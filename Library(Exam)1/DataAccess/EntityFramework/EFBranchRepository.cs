using Library.Entities;
using Library_Exam_1.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Exam_1.DataAccess.EntityFramework
{
    public class EFBranchRepository : IBranchRepository
    {
        LibraryDB _context;

        public void Add(Branch entity)
        {
            using (_context = new LibraryDB())
            {
                _context.Branches.Add(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Branch> GetAll()
        {
            using (_context = new LibraryDB())
            {
                return _context.Branches;
            }
        }

        public Branch GetById(int id)
        {
            using (_context = new LibraryDB())
            {
                return _context.Branches.AsQueryable().FirstOrDefault(x=>x.Id==id);
            }
        }

        public void Remove(Branch entity)
        {
            using (_context = new LibraryDB())
            {
                _context.Branches.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
