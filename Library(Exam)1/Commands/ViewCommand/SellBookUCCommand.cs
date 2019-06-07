using Library_Exam_1.ViewModels;
using Library_Exam_1.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library_Exam_1.Commands.ViewCommand
{
    public class SellBookUCCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        MainVM mainVM;

        public SellBookUCCommand(MainVM mainVM)
        {
            this.mainVM = mainVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mainVM.Books = new ObservableCollection<Library.Entities.Book>(App.UnitOfWork.Books.GetAll());
            mainVM.Clients = new ObservableCollection<Library.Entities.Client>(App.UnitOfWork.Clients.GetAll());
            mainVM.MainBorder.Child = new SellBookUC();
        }
    }
}
