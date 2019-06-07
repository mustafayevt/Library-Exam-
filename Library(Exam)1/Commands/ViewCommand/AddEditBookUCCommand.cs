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
    public class AddEditBookUCCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        MainVM mainVM;

        public AddEditBookUCCommand(MainVM mainVM)
        {
            this.mainVM = mainVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            int choice = Convert.ToInt32(parameter);
            if (choice == 1)
            {
                mainVM.MainBorder.Child = new AddBookUC();
                mainVM.Branches = new System.Collections.ObjectModel.ObservableCollection<Library.Entities.Branch>(App.UnitOfWork.Branches.GetAll());
            }
            else if (choice == 2)
            {
                mainVM.Books = new System.Collections.ObjectModel.ObservableCollection<Library.Entities.Book>(App.UnitOfWork.Books.GetAll());
                mainVM.MainBorder.Child = new EditBookUC();
            }
        }
    }
}
