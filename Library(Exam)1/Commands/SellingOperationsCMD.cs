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
    class SellingOperationsCMD : ICommand
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

            if (param == 1)
            {
                mainVM.SoldedBooks.Add(new Models.SoldedBook(mainVM.SelectedBook.Clone(), mainVM.SelectedClient.Clone(), mainVM.CurrentUser.Clone(), DateTime.Now));
            }
            else if (param == 2)
            {
                mainVM.RentedBooks.Add(new Models.SoldedBook(mainVM.SelectedBook.Clone(), mainVM.SelectedClient.Clone(), mainVM.CurrentUser.Clone(), DateTime.Now));
            }
        }
    }
}
