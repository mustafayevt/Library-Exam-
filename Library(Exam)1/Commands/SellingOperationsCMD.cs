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
    public class SellingOperationsCMD : ICommand
    {
        public event EventHandler CanExecuteChanged;
        MainVM mainVM;
        public SellingOperationsCMD(MainVM mainVM)
        {
            this.mainVM = mainVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            int.TryParse((string)parameter, out int param);
            try
            {
                if (param == 1)
                {
                    App.UnitOfWork.SoldedBooks.Add(new Models.SoldedBook(mainVM.SelectedBook.Id, mainVM.SelectedClient.Id, mainVM.CurrentUser.Id, DateTime.Now));
                    new CustomMessageBox().Show("Solded!");
                }
                else if (param == 2)
                {
                    App.UnitOfWork.RentedBooks.Add(new Models.RentedBook(mainVM.SelectedBook.Id, mainVM.SelectedClient.Id, mainVM.CurrentUser.Id, DateTime.Now));
                    new CustomMessageBox().Show("Rented!");
                }
            }
            catch (Exception e)
            {
                new CustomMessageBox().Show("Error!");
            }
            
        }
    }
}
