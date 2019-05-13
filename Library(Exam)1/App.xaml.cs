using Library_EXAM_.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Library_Exam_1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Users = new List<User>()
            {
                new User(1,"admin","admin",true,true,true,true,true,true)
            };
        }
        public User CurrentUser { get; set; }

        private List<User> users;

        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }
    }
}
