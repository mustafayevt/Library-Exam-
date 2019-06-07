using Library_EXAM_.Entities;
using Library_Exam_1.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Exam_1.DataAccess.EntityFramework
{
    public class EFUserRepository : IUserRepository
    {
        LibraryDB _context;


        public void Add(User entity)
        {
            using (_context = new LibraryDB())
            {
                _context.Users.Add(entity);
                _context.SaveChanges();
            }
        }

        public IEnumerable<User> GetAll()
        {
            IEnumerable<User> users;
            using (_context = new LibraryDB())
            {
                users = new List<User>( _context.Users);
            }
            return users;
        }

        public User GetById(int id)
        {
            User user;
            using (_context = new LibraryDB())
            {
                user =  _context.Users.AsQueryable().FirstOrDefault(x => x.Id == id).Clone();
            }
            return user;
        }

        public void Remove(User entity)
        {
            using (_context = new LibraryDB())
            {
                _context.Users.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
