using CRUD.BLL.Interfaces;
using CRUD.DAL.Data;
using CRUD.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.BLL.Repositories
{
    public class EmployeeReposetory : GenericReposetory<Employee>, IEmployeeReposetory
    {

        public EmployeeReposetory(AppDbContext dbContext)//Ask CLR Creating Object From DbContext
            :base(dbContext)
        {
        }
        public IQueryable<Employee> GetEmployeeByAddress(string address)
        {
            return _dbContext.Employees.Where(E => E.Address.ToLower().Contains(address.ToLower()));   
        }

        public IQueryable<Employee> SearchByName(string name)
            => _dbContext.Employees.Where(E => E.Name.ToLower().Contains(name));
    }
}
