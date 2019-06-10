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
    public class EditBookViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        MainVM MainVM;

        public EditBookViewCommand(MainVM mainVM)
        {
            MainVM = mainVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MainVM.Branches = new System.Collections.ObjectModel.ObservableCollection<Library.Entities.Branch>(App.UnitOfWork.Branches.GetAll());
            MainVM.MainBorder.Child = new AddBookUC();
        }
    }
}
