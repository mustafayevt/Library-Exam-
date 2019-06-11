using Library_EXAM_;
using Library_EXAM_.Entities;
using Library_Exam_1.DataAccess;
using Library_Exam_1.Domain.Abstraction;
using Library_Exam_1.Views;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
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
            UnitOfWork = new EFUnitOfWork();
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            using (LibraryDB db = new LibraryDB())
            {
                if (db.Users.AsQueryable().FirstOrDefault(x => x.Username == "admin") == null)
                {
                    db.Users.Add(new User("admin", "admin", true));
                    db.SaveChanges();
                }
            }
        }
        public User CurrentUser { get; set; }
        public static IUnitOfWork UnitOfWork { get; set; } 
    }
    public class Inject : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<EFUnitOfWork>();
        }
    }
}
