using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Book
    {
        public Book(int id, string name, string author, decimal purchasePrice, decimal salePrice, int quantity, Branch branch,bool isClone)
        {
            Name = name;
            Author = author;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            Quantity = quantity;
            Branch = branch;
            Id = id;
        }
        public Book Clone()
        {
            return new Book(Id, Name, Author, PurchasePrice, SalePrice, Quantity, Branch,true);
        }
        public Book()
        {

        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Quantity { get; set; }
        public Branch Branch { get; set; }
    }
}
