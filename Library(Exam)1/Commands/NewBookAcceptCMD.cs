using Library_Exam_1.Tools;
using Library_Exam_1.ViewModels;
using Library_Exam_1.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library_Exam_1.Commands
{
    public class NewBookAcceptCMD : ICommand
    {
        public event EventHandler CanExecuteChanged;
        MainVM mainVM;
        public NewBookAcceptCMD(MainVM mainVM)
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
                App.UnitOfWork.Books.Add(mainVM.NewBook);
                if (mainVM.NewBook.Id == 0)
                {
                    new CustomMessageBox().Show("Book Added!");
                }
                else
                {
                    new CustomMessageBox().Show("Book Updated!");
                    mainVM.MainBorder.Child = new EditBookUC();
                }
            }
            catch (Exception)
            {
                new CustomMessageBox().Show("Error!");
            }
            mainVM.NewBook = new Library.Entities.Book();
            mainVM.Books = new System.Collections.ObjectModel.ObservableCollection<Library.Entities.Book>(App.UnitOfWork.Books.GetAll());
        }
    }
}
