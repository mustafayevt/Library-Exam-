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
    public class DeleteBookCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        MainVM MainVM;

        public DeleteBookCommand(MainVM mainVM)
        {
            MainVM = mainVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                App.UnitOfWork.Books.Remove(MainVM.NewBook);
                (new CustomMessageBox()).Show("Deleted!");
                MainVM.Books = new System.Collections.ObjectModel.ObservableCollection<Library.Entities.Book>(App.UnitOfWork.Books.GetAll());
                MainVM.NewBook = new Library.Entities.Book();
            }
            catch (Exception)
            {
                (new CustomMessageBox()).Show("Error!");
            }    
        }
    }
}
