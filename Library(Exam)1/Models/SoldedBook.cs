using Library.Entities;
using Library_EXAM_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Exam_1.Models
{
    class SoldedBook
    {
        public Book Book { get; set; }
        public Client Client { get; set; }
        public User MyProperty { get; set; }
    }
}
