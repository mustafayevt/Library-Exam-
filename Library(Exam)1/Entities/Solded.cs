using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    class Solded
    {
        public Solded(Client client, Book book)
        {
            Client = client;
            Book = book;
        }

        public int Id { get; set; }
        public Client Client { get; set; }
        public Book Book { get; set; }
    }
}
