using Library_Exam_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Exam_1.Domain.Abstraction
{
    public interface IRentedBookRepository:IRepository<RentedBook>
    {
    }
}
