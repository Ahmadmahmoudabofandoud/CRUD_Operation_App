using CRUD.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.BLL.Interfaces
{
    public interface IEmployeeReposetory:IGenericReposetory<Employee>
    {
        IQueryable<Employee> GetEmployeeByAddress(string address);

        IQueryable<Employee> SearchByName(string name);
    }
}
