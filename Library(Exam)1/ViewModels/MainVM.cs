using Library.Entities;
using Library_EXAM_.Entities;
using Library_EXAM_.ViewModels;
using Library_Exam_1.Commands;
using Library_Exam_1.Commands.ViewCommand;
using Library_Exam_1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Library_Exam_1.ViewModels
{
    public class MainVM : BaseVM
    {
        public MainVM(Border UCBorder)
        {
            #region Create objects
            Users = new ObservableCollection<User>();
            Workers = new ObservableCollection<Worker>();
            Branches = new ObservableCollection<Branch>();
            Books = new ObservableCollection<Book>();
            Clients = new ObservableCollection<Client>();
            SoldedBooks = new ObservableCollection<SoldedBook>();
            RentedBooks = new ObservableCollection<RentedBook>();

            CurrentUser = ((App)Application.Current).CurrentUser;
            NewUser = new User();
            NewWorker = new Worker();
            NewBranch = new Branch();
            NewBook = new Book();
            NewClient = new Client();
            SelectedClient = new Client();
            SelectedBook = new Book();
            
            NewWorkerAcceptCMD = new NewWorkerAcceptCMD(this);
            NewBranchAcceptCMD = new NewBranchAcceptCMD(this);
            NewClientAcceptCMD = new NewClientAcceptCMD(this);
            NewBookAcceptCMD = new NewBookAcceptCMD(this);
            SellingOperationsCMD = new SellingOperationsCMD(this);


            AddEditBookUCCommand = new AddEditBookUCCommand(this);
            AddEditBranchUCCommand = new AddEditBranchUCCommand(this);
            AddEditClientUCCommand = new AddEditClientUCCommand(this);
            AddEditUserUCCommand = new AddEditUserUCCommand(this);
            AddEditWorkerUCCommand = new AddEditWorkerUCCommand(this);
            ReportUCCommand = new ReportUCCommand(this);
            SellBookUCCommand = new SellBookUCCommand(this);
            NewUserAcceptCMD = new NewUserAcceptCMD(this);

            EditUserViewCommand = new EditUserViewCommand(this);
            DeleteUserCommand = new DeleteUserCommand(this);
            EditBookViewCommand = new EditBookViewCommand(this);
            DeleteBookCommand = new DeleteBookCommand(this);

            MainBorder = UCBorder;
            #endregion
        }
        #region Models

        #region AddUser
        private ObservableCollection<User> users;

        public ObservableCollection<User> Users
        {
            get { return users; }
            set { users = value; OnPropertyChanged(nameof(Users)); }
        }
        public User CurrentUser { get; private set; }
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
        #region SellBook
        public Client SelectedClient { get; set;}
        public Book SelectedBook { get; set; }

        private ObservableCollection<SoldedBook> soldedBooks;

        public ObservableCollection<SoldedBook> SoldedBooks
        {
            get { return soldedBooks; }
            set { soldedBooks = value; OnPropertyChanged(nameof(SoldedBooks)); }
        }

        private ObservableCollection<RentedBook> rentedBooks;

        public ObservableCollection<RentedBook> RentedBooks
        {
            get { return rentedBooks; }
            set { rentedBooks = value; OnPropertyChanged(nameof(RentedBooks)); }
        }



        #endregion



        #region Commands
        public NewWorkerAcceptCMD NewWorkerAcceptCMD { get; set; }
        public NewBranchAcceptCMD NewBranchAcceptCMD { get; set; }
        public NewClientAcceptCMD NewClientAcceptCMD { get; set; }
        public NewBookAcceptCMD NewBookAcceptCMD { get; set; }
        public SellingOperationsCMD SellingOperationsCMD { get; set; }

        public EditUserViewCommand EditUserViewCommand { get; set; }
        #endregion

        #endregion

        public NewUserAcceptCMD NewUserAcceptCMD { get; set; }
        public DeleteUserCommand DeleteUserCommand { get; set; }
        public DeleteBookCommand DeleteBookCommand { get; set; }
        public EditBookViewCommand EditBookViewCommand { get; set; }
        public AddEditBookUCCommand AddEditBookUCCommand { get; set; }
        public AddEditBranchUCCommand AddEditBranchUCCommand { get; set; }
        public AddEditClientUCCommand AddEditClientUCCommand { get; set; }
        public AddEditUserUCCommand AddEditUserUCCommand { get; set; }
        public AddEditWorkerUCCommand AddEditWorkerUCCommand { get; set; }
        public ReportUCCommand ReportUCCommand { get; set; }
        public SellBookUCCommand SellBookUCCommand { get; set; }
        public Border MainBorder { get; set; }

        public Book selectedBook { get; set; } = new Book();
    }
}
