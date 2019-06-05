using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Branch
    {
        public int Id { get;private set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public Branch(int id, string name, string adress,bool isClone)
        {
            Id = id;
            Name = name;
            Adress = adress;
        }
        public Branch()
        {

        }

        public Branch Clone()
        {
            return new Branch(Id, Name, Adress,true);
        }
    }
}
