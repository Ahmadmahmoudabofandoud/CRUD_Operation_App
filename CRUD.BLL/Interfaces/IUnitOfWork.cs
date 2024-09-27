using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.BLL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IEmployeeReposetory EmployeeReposetory { get; set; }

        public IDepartmentReposetory DepartmentReposetory { get; set; }

        int Complete();

    }
}
