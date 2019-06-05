using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Worker
    {
        public Worker(int id,string name, string surname, string phone, Branch branch, decimal salary,bool isClone)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Phone = phone;
            Branch = branch;
            Salary = salary;
        }
        public Worker()
        {

        }
        public Worker Clone()
        {
            return new Worker(Id, Name, Surname, Phone, Branch, Salary,true);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public Branch Branch { get; set; }
        public decimal Salary { get; set; }

    }
}
