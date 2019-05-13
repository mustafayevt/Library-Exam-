using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Worker
    {
        public Worker(int id,int no, string name, string surname, string phone, Branch branch, string salary,bool isClone)
        {
            Id = id;
            No = no;
            Name = name;
            Surname = surname;
            Phone = phone;
            Branch = branch;
            Salary = salary;
            if (isClone)
            {
                No = ++NoGenerator;
                Id = NoGenerator;
            }
        }
        public Worker()
        {

        }
        public Worker Clone()
        {
            return new Worker(Id,No, Name, Surname, Phone, Branch, Salary,true);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public Branch Branch { get; set; }
        public string Salary { get; set; }

        static int NoGenerator = 0;
        public int No { get; set; }
    }
}
