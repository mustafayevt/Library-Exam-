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
            Users = new List<User>(((App)Application.Current).Users);
            logInCMD = new LogInCMD(this);
            LogInned = new User();
        }
        public Visibility Visible { get; set; } = Visibility.Collapsed;

        private List<User> users;

        public List<User> Users
        {
            get { return users; }
            set { users = value; OnPropertyChanged(nameof(Users)); }
        }

        public LogInCMD logInCMD { get; set; }

        private User logInned;

        public User LogInned
        {
            get { return logInned; }
            set { logInned = value; ((App)Application.Current).CurrentUser = LogInned.Clone(); }
        }


        public string Username { get; set;}
        public string Password { get; set; }
    }
}
