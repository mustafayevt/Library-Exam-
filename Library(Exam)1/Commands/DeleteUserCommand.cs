using Library_Exam_1.Tools;
using Library_Exam_1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library_Exam_1.Commands
{
    public class DeleteUserCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        MainVM mainVM;

        public DeleteUserCommand(MainVM mainVM)
        {
            this.mainVM = mainVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                App.UnitOfWork.Users.Remove(mainVM.NewUser);
                (new CustomMessageBox()).Show("Deleted!");
            }                

            catch (Exception)
            {
                (new CustomMessageBox()).Show("Error!");
            }
            mainVM.NewUser = new Library_EXAM_.Entities.User();
            mainVM.Users = new System.Collections.ObjectModel.ObservableCollection<Library_EXAM_.Entities.User>(App.UnitOfWork.Users.GetAll());
        }
    }
}
