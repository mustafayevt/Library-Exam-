using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EXAM_.Entities
{
    public class User
    {
        public User()
        {
            
        }

        public User(string username, string password, bool canCreateBook, bool canCreateUser, bool canCreateBranch, bool canCreateClient, bool canRent)
        {
            Username = username;
            Password = password;
            CanCreateBook = canCreateBook;
            CanCreateUser = canCreateUser;
            CanCreateBranch = canCreateBranch;
            CanCreateClient = canCreateClient;
            CanRent = canRent;
        }

        public User(string username, string password, bool isAdmin)
        {
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
        }

        public User Clone()
        {
            return new User(Username, Password, CanCreateBook, CanCreateUser, CanCreateBranch, CanCreateClient, CanRent);
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CanCreateBook { get; set; }
        public bool CanCreateUser { get; set; }
        public bool CanCreateBranch { get; set; }
        public bool CanCreateClient { get; set; }
        public bool CanRent { get; set; }

        public bool IsAdmin
        {
            set
            {
                GetType()
          .GetProperties().Where(p => p.PropertyType == typeof(bool) && p.Name.ToLower().Contains("can"))
          .ToList().ForEach(x => x.SetValue(this, true, null));
            }
        }

    }
}
