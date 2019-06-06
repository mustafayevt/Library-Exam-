using Library.Entities;
using Library_Exam_1.DataAccess.EntityFramework;
using Library_Exam_1.Domain.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Exam_1.DataAccess
{
    public class EFUnitOfWork : IUnitOfWork
    {

        public IBookRepository Books => new EFBookRepository();

        public IBranchRepository Branches => new EFBranchRepository();

        public IClientRepository Clients => new EFClientRepository();

        public IUserRepository Users => new EFUserRepository();

        public IWorkerRepository Workers => new EFWorkerRepository();
    }
}
