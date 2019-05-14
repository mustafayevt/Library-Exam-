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
    class NewBranchAcceptCMD : ICommand
    {
        public event EventHandler CanExecuteChanged;
        MainVM mainVM;
        public NewBranchAcceptCMD(MainVM mainVM)
        {
            this.mainVM = mainVM;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mainVM.Branches.Add(mainVM.NewBranch.Clone());
            (new CustomMessageBox()).Show("Branch Added!");
        }
    }
}
