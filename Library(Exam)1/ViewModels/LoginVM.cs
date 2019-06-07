using Library_EXAM_.Commands;
using Library_EXAM_.Entities;
using Library_Exam_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library_EXAM_.ViewModels
{
    class LoginVM:BaseVM
    {
        public LoginVM()
        {
            Users = App.UnitOfWork.Users.GetAll().ToList();
            logInCMD = new LogInCMD(this);
            Loginned = new User();
        }

        private List<User> users;

        public List<User> Users
        {
            get { return users; }
            set { users = value; OnPropertyChanged(nameof(Users)); }
        }

        public LogInCMD logInCMD { get; set; }

        private User logInned;

        public User Loginned
        {
            get { return logInned; }
            set { logInned = value; ((App)Application.Current).CurrentUser = Loginned; }
        }


        public string Username { get; set;}
        public string Password { get; set; }
    }
}
