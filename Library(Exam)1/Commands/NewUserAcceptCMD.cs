using Library_EXAM_.Entities;
using Library_Exam_1.Tools;
using Library_Exam_1.ViewModels;
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
        MainVM mainVM;
        public NewUserAcceptCMD(MainVM mainVM)
        {
            this.mainVM = mainVM;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(mainVM.Users.Where(x=>x.Username == mainVM.NewUser.Username).FirstOrDefault()==null)
            {
                App.UnitOfWork.Users.Add(mainVM.NewUser);
                (new CustomMessageBox()).Show("User Added!");
            }
            else
            {
                (new CustomMessageBox()).Show("This Username Already Taken!");
            }
        }
    }
}
