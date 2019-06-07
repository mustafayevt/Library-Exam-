using Library_Exam_1.ViewModels;
using Library_Exam_1.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library_Exam_1.Commands.ViewCommand
{
    public class AddEditUserUCCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        MainVM MainVM;

        public AddEditUserUCCommand(MainVM mainVM)
        {
            MainVM = mainVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            int choice = Convert.ToInt32(parameter);
            if (choice == 1)
                MainVM.MainBorder.Child = new AddUserUC();
            else if (choice == 2)
            {
                MainVM.Users = new System.Collections.ObjectModel.ObservableCollection<Library_EXAM_.Entities.User>(App.UnitOfWork.Users.GetAll());
                MainVM.MainBorder.Child = new EditUserUC();
            }
        }
    }
}
