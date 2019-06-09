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
    public class EditUserViewCommand : ICommand
    {
        public EditUserViewCommand(MainVM mainVM)
        {
            this.mainVM = mainVM;
        }

        public event EventHandler CanExecuteChanged;
        public MainVM mainVM{ get; set; }


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mainVM.MainBorder.Child = new AddUserUC();
        }
    }
}
