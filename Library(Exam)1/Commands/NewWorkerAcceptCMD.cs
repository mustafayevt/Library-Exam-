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
    class NewWorkerAcceptCMD : ICommand
    {
        public event EventHandler CanExecuteChanged;
        MainVM mainVM;
        public NewWorkerAcceptCMD(MainVM mainVM)
        {
            this.mainVM = mainVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mainVM.Workers.Add(mainVM.NewWorker.Clone());
            (new CustomMessageBox()).Show("Worker Added!");
        }
    }
}
