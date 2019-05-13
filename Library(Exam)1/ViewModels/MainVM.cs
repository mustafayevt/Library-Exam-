using Library.Entities;
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
            Books = new ObservableCollection<Book>();
            Clients = new ObservableCollection<Client>();

            CurrentUser = ((App)Application.Current).CurrentUser;
            NewUser = new User();
            NewWorker = new Worker();
            NewBranch = new Branch();
            NewBook = new Book();
            NewClient = new Client();

            NewUserAcceptCMD = new NewUserAcceptCMD(this);
            NewWorkerAcceptCMD = new NewWorkerAcceptCMD(this);
            NewBranchAcceptCMD = new NewBranchAcceptCMD(this);
            NewClientAcceptCMD = new NewClientAcceptCMD(this);
            NewBookAcceptCMD = new NewBookAcceptCMD(this);
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
        #region AddBook
        private ObservableCollection<Book> books;

        public ObservableCollection<Book> Books
        {
            get { return books; }
            set { books = value; OnPropertyChanged(nameof(Books)); }
        }

        public Book NewBook { get; set; }
        #endregion
        #region AddClient
        private ObservableCollection<Client> clients;

        public ObservableCollection<Client> Clients
        {
            get { return clients; }
            set { clients = value; OnPropertyChanged(nameof(Clients)); }
        }

        public Client NewClient { get; set; }
        #endregion
        #endregion



        #region Commands
        public NewUserAcceptCMD NewUserAcceptCMD { get; set; }
        public NewWorkerAcceptCMD NewWorkerAcceptCMD { get; set; }
        public NewBranchAcceptCMD NewBranchAcceptCMD { get; set; }
        public NewClientAcceptCMD NewClientAcceptCMD { get; set; }
        public NewBookAcceptCMD NewBookAcceptCMD { get; set; }
        #endregion


    }
}
