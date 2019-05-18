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

        private void EditUserUControl(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new EditUserUC();
        }

        private void AddWorkerUControl(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new AddWorkerUC();
        }

        private void EditWorkerUControl(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new EditWorkerUC();
        }

        private void AddBranchUControl(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new AddBranchUC();
        }

        private void EditBranchUControl(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new EditBranchUC();
        }

        private void AddClienthUControl(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new AddClientUC();
        }

        private void EditClienthUControl(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new EditClientUC();
        }

        private void AddBookUControl(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new AddBookUC();
        }

        private void EditBookUControl(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new EditBookUC();
        }

        private void SellBookUControl(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new SellBookUC();
        }

        private void SalesReportUControl(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new SalesReportUC();
        }
        private void RentsReportUcontrol(object sender, MouseButtonEventArgs e)
        {
            UCBorder.Child = new RentsReportUC();
        }
        





        private void Logout(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
