using Library_Exam_1.ViewModels;
using Library_Exam_1.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Library_Exam_1.Commands.ViewCommand
{
    public class ReportUCCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        MainVM mainVM;

        public ReportUCCommand(MainVM mainVM)
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
                mainVM.SoldedBooks = new System.Collections.ObjectModel.ObservableCollection<Models.SoldedBook>(App.UnitOfWork.SoldedBooks.GetAll());
                mainVM.MainBorder.Child = new SalesReportUC();
            }
            else if (choice == 2)
            {
                mainVM.RentedBooks = new System.Collections.ObjectModel.ObservableCollection<Models.RentedBook>(App.UnitOfWork.RentedBooks.GetAll());
                mainVM.MainBorder.Child = new RentsReportUC();
            }
        }
    }
}
