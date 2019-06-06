using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Exam_1.Domain.Abstraction
{
    public interface IUnitOfWork
    {
        IBookRepository Books { get; }
        IBranchRepository Branches { get; }
        IClientRepository Clients { get;  }
        IUserRepository Users { get; }
        IWorkerRepository Workers { get; }
    }
}
