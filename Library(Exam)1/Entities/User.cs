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

        public User(int id, string username, string password, bool canCreateBook, bool canCreateUser, bool canCreateBranch, bool canCreateClient, bool canRent,bool isClone)
        {
            Id = id;
            Username = username;
            Password = password;
            CanCreateBook = canCreateBook;
            CanCreateUser = canCreateUser;
            CanCreateBranch = canCreateBranch;
            CanCreateClient = canCreateClient;
            CanRent = canRent;
            if (isClone)
            {
                No = ++NoGenerator;
                Id = NoGenerator;
            }
        }

        public User Clone()
        {
            return new User(Id, Username,Password,CanCreateBook,CanCreateUser,CanCreateBranch,CanCreateClient,CanRent, true);
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CanCreateBook { get; set; }
        public bool CanCreateUser { get; set; }
        public bool CanCreateBranch { get; set; }
        public bool CanCreateClient { get; set; }
        public bool CanRent { get; set; }

        static int NoGenerator = 0;
        public int No { get; set; }
    }
}
