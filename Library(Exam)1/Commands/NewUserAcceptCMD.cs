using Library_EXAM_.Entities;
using Library_Exam_1.Tools;
using Library_Exam_1.ViewModels;
using Library_Exam_1.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Library_Exam_1.Commands
{
    public class NewUserAcceptCMD : ICommand
    {
        public event EventHandler CanExecuteChanged;
        MainVM UserVM;
        public NewUserAcceptCMD(MainVM mainVM)
        {
            this.UserVM = mainVM;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                if (UserVM.NewUser.Id == 0)
                {
                    if (App.UnitOfWork.Users.GetAll().AsQueryable().FirstOrDefault(x => x.Username == UserVM.NewUser.Username) != null)
                    {
                        (new CustomMessageBox()).Show("This Username Already Taken!");
                        return;
                    }
                    App.UnitOfWork.Users.Add(UserVM.NewUser);
                    (new CustomMessageBox()).Show("User Added!");
                }
                else if (UserVM.NewUser.Id > 0)
                {
                    App.UnitOfWork.Users.Add(UserVM.NewUser);
                    (new CustomMessageBox()).Show("User Updated!");
                    UserVM.MainBorder.Child = new EditUserUC();
                }
                UserVM.NewUser = new User();
            }
            catch (Exception)
            {
                (new CustomMessageBox()).Show("Error!");
            }
        }
    }
}
