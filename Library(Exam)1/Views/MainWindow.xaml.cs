﻿using Library_Exam_1;
using Library_Exam_1.ViewModels;
using Library_Exam_1.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            mainVM = new MainVM(UCBorder);
            DataContext = mainVM;
        }

        
        private void Logout(object sender, MouseButtonEventArgs e)
        {
            this.Close();
            foreach (var item in ((App)Application.Current).Windows)
            {
                (item as Window).Show();
            }
        }
    }
}
