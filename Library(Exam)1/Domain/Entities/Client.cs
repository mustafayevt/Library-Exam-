using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Client
    {
        public int Id { get;private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public DateTime JoinDate { get; set; }

        public Client(int id, string name, string surname, string phone, DateTime joinDate, bool isClone)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Phone = phone;
            JoinDate = joinDate;
        }
        public Client()
        {
            JoinDate = DateTime.Now;
        }

        public Client Clone()
        {
            return new Client(Id, Name, Surname, Phone, JoinDate,true);
        }

    }
}
