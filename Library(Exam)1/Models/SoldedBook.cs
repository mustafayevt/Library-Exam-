using Library.Entities;
using Library_EXAM_.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Exam_1.Models
{
    public class SoldedBook
    {
        public SoldedBook()
        {

        }

        public SoldedBook(int bookId, int clientId, int userId, DateTime dateTime)
        {
            BookId = bookId;
            ClientId = clientId;
            UserId = userId;
            DateTime = dateTime;
        }


        public int Id { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public DateTime DateTime { get; set; }
    }
}
