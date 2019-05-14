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
        public Branch(int id,int no, string name, string adress,bool isClone)
        {
            Id = id;
            No = no;
            Name = name;
            Adress = adress;
            if (isClone)
            {
                No = ++NoGenerator;
                Id = NoGenerator;
            }
        }
        public Branch()
        {

        }
        static int NoGenerator = 0;

        public Branch Clone()
        {
            return new Branch(Id,No, Name, Adress,true);
        }
        public int No { get;private set; }
    }
}
