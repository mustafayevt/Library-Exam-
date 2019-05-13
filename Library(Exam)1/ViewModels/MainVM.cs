﻿using Library.Entities;
using Library_EXAM_.Entities;
using Library_EXAM_.ViewModels;
using Library_Exam_1.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library_Exam_1.ViewModels
{
    class MainVM : BaseVM
    {
        public MainVM()
        {
            Users = new ObservableCollection<User>(((App)Application.Current).Users);
            Workers = new ObservableCollection<Worker>();
            Branches = new ObservableCollection<Branch>();

            CurrentUser = ((App)Application.Current).CurrentUser;
            NewUser = new User();
            NewWorker = new Worker();
            NewBranch = new Branch();

            NewUserAcceptCMD = new NewUserAcceptCMD(this);
            NewWorkerAcceptCMD = new NewWorkerAcceptCMD(this);
            NewBranchAcceptCMD = new NewBranchAcceptCMD(this);
        }
        #region Models

        #region AddUser
        private ObservableCollection<User> users;

        public ObservableCollection<User> Users
        {
            get { return users; }
            set { users = value; }
        }
        public User CurrentUser { get; private set; }
        public User NewUser { get; set; }
        #endregion
        #region AddWorker
        private ObservableCollection<Worker> workers;

        public ObservableCollection<Worker> Workers
        {
            get { return workers; }
            set { workers = value;  OnPropertyChanged(nameof(Workers)); }
        }
        public Worker NewWorker { get; set; }

        #endregion
        #region AddBranch
        private ObservableCollection<Branch> branches;

        public ObservableCollection<Branch> Branches
        {
            get { return branches; }
            set { branches = value; OnPropertyChanged(nameof(Branches)); }
        }

        public Branch NewBranch { get; set; }
        #endregion
        #endregion



        #region Commands
        public NewUserAcceptCMD NewUserAcceptCMD { get; set; }
        public NewWorkerAcceptCMD NewWorkerAcceptCMD { get; set; }

        public NewBranchAcceptCMD NewBranchAcceptCMD { get; set; }
        #endregion


    }
}
