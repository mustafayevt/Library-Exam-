using Library.Entities;
using Library_EXAM_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Exam_1.Models
{
    public class RentedBook
    {
        public RentedBook()
        {

        }

        public RentedBook(int bookId, int clientId, int userId, DateTime dateTime)
        {
            BookId = bookId;
            ClientId = clientId;
            UserId = userId;
            DateTime = dateTime;
        }
        public int Id { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime DateTime { get; set; }
    }
}
