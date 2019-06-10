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
                if (entity.Id == 0)
                {
                    _context.Users.Add(entity);
                    _context.SaveChanges();
                }
                else
                {
                    User user = _context.Users.FirstOrDefault(x => x.Id == entity.Id);
                    user.Username = entity.Username;
                    user.Password = entity.Password;
                    user.CanRent = entity.CanRent;
                    user.CanCreateUser = entity.CanCreateUser;
                    user.CanCreateClient = entity.CanCreateClient;
                    user.CanCreateBranch = entity.CanCreateBranch;
                    user.CanCreateBook = entity.CanCreateBook;
                    _context.SaveChanges();
                }
            }
        }

        public IEnumerable<User> GetAll()
        {
            IEnumerable<User> users;
            using (_context = new LibraryDB())
            {
                users = new List<User>(_context.Users);
            }
            return users;
        }

        public User GetById(int id)
        {
            User user;
            using (_context = new LibraryDB())
            {
                user = _context.Users.AsQueryable().FirstOrDefault(x => x.Id == id);
            }
            return user;
        }

        public void Remove(User entity)
        {
            using (_context = new LibraryDB())
            {
                User user = _context.Users.FirstOrDefault(x => x.Id == entity.Id);
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}
