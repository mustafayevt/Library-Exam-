using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Book
    {
        public Book(int id,int no, string name, string author, string purchasePrice, string salePrice, string quantity, Branch branch,bool isClone)
        {
            Name = name;
            Author = author;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            Quantity = quantity;
            Branch = branch;
            Id = id;
            No = no;
            if (isClone)
            {
                No = ++NoGenerator;
                this.Id = NoGenerator;
            }
        }
        public Book Clone()
        {
            return new Book(Id,No, Name, Author, PurchasePrice, SalePrice, Quantity, Branch,true);
        }
        public Book()
        {

        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string PurchasePrice { get; set; }
        public string SalePrice { get; set; }
        public string Quantity { get; set; }
        public Branch Branch { get; set; }

        static int NoGenerator = 0;
        public int No { get; private set; }
    }
}
