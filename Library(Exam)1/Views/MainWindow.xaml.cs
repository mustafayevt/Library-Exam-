using Library_Exam_1.ViewModels;
using Library_Exam_1.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library_EXAM_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainVM mainVM;
        public MainWindow()
        {
            InitializeComponent();
            mainVM = new MainVM();
            DataContext = mainVM;
        }

        private void AddUserUControl(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new AddUserUC();
        }

        private void AddWorkerUControl(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new AddWorkerUC();
        }

        private void AddBranchUControl(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new AddBranchUC();
        }

        private void AddClienthUControl(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new AddClientUC();
        }

        private void AddBookUControl(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new AddBookUC();
        }

        private void Logout(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
