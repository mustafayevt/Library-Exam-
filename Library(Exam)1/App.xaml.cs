using Library_EXAM_;
using Library_EXAM_.Entities;
using Library_Exam_1.Views;
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
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            Users = new List<User>()
            {
                new User("admin","admin",true,true,true,true,true,true)
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
