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
    public class AddEditBranchUCCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        MainVM mainVM;

        public AddEditBranchUCCommand(MainVM mainVM)
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
                mainVM.MainBorder.Child = new AddBranchUC();
            }
            else if (choice == 2)
            {
                mainVM.Branches = new System.Collections.ObjectModel.ObservableCollection<Library.Entities.Branch>(App.UnitOfWork.Branches.GetAll());
                mainVM.MainBorder.Child = new EditBranchUC();
            }
        }
    }
}
