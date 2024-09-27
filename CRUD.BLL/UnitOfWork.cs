using CRUD.BLL.Interfaces;
using CRUD.BLL.Repositories;
using CRUD.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.BLL
{
    public class UnitOfWork : IUnitOfWork 
    {
        private readonly AppDbContext _dbContext;

        public IEmployeeReposetory EmployeeReposetory { get; set ; }
        public IDepartmentReposetory DepartmentReposetory { get ; set; }

        public UnitOfWork(AppDbContext dbContext) //Ask Clr For Creating Object From DbContext
        {
            _dbContext = dbContext;
            EmployeeReposetory = new EmployeeReposetory(_dbContext);
            DepartmentReposetory = new DepartmentReposetory(_dbContext);
        } 
        public int Complete()
        {
            return _dbContext.SaveChanges();
        }
        public void Dispose()
        {
            _dbContext.Dispose();   
        }
    }
}
