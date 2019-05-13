using Library_EXAM_.ViewModels;
using Library_Exam_1;
using Library_Exam_1.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Library_EXAM_.Commands
{
    class LogInCMD : ICommand
    {
        public event EventHandler CanExecuteChanged;
        LoginVM loginVM;
        public LogInCMD(LoginVM loginVM)
        {
            this.loginVM = loginVM;
        }
        
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            loginVM.Users = ((App)Application.Current).Users;
            try
            {
                loginVM.Password = (parameter as PasswordBox).Password;
                if (loginVM.Users.Single(x => x.Username == loginVM.Username).Password == loginVM.Password)
                {
                    loginVM.LogInned = loginVM.Users.Single(x => x.Username == loginVM.Username).Clone();
                    (new MainWindow()).ShowDialog();
                    return;
                }
                else
                {
                    (new CustomMessageBox()).Show("Password is Incorrect!");
                    return;
                }
            }
            catch (Exception)
            {
                (new CustomMessageBox()).Show("Username Does Not Exists");
            }
        }
    }
}
