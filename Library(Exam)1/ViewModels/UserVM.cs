using Library_EXAM_.Entities;
using Library_EXAM_.ViewModels;
using Library_Exam_1.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Library_Exam_1.ViewModels
{
    public class UserVM : BaseVM
    {
        public UserVM(MainVM mainVM)
        {
            MainVM = mainVM;
        }
        public NewUserAcceptCMD NewUserAcceptCMD { get; set; }


        public MainVM MainVM { get; set; }
        private User _user;
        public User NewUser
        {
            get => _user;
            set
            {
                _user = value;
                OnPropertyChanged(nameof(NewUser));
            }
        }
    }
}
