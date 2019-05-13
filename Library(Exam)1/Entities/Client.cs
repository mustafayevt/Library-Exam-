using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public DateTime JoinDate { get; set; }

        public Client(int id,int no, string name, string surname, string phone, DateTime joinDate, bool isClone)
        {
            Id = id;
            No = no;
            Name = name;
            Surname = surname;
            Phone = phone;
            JoinDate = joinDate;
            if (isClone)
            {
                No = ++NoGenerator;
                Id = NoGenerator;
            }
        }
        public Client()
        {

        }

        public Client Clone()
        {
            return new Client(Id,No, Name, Surname, Phone, JoinDate,true);
        }

        static int NoGenerator = 0;

        public int No { get; set; }
    }
}
