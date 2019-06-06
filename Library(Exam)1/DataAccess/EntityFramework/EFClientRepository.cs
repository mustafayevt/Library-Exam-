using Library.Entities;
using Library_Exam_1.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Exam_1.DataAccess.EntityFramework
{
    public class EFClientRepository : IClientRepository
    {
        LibraryDB _context;

        public void Add(Client entity)
        {
            using (_context = new LibraryDB())
            {
                _context.Clients.Add(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Client> GetAll()
        {
            using (_context = new LibraryDB())
            {
                return _context.Clients;
            }
        }

        public Client GetById(int id)
        {
            using (_context = new LibraryDB())
            {
                return _context.Clients.AsQueryable().FirstOrDefault(x => x.Id == id);
            }
        }

        public void Remove(Client entity)
        {
            using (_context = new LibraryDB())
            {
                _context.Clients.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
