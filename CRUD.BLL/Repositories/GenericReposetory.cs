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
    public class GenericReposetory<T> :IGenericReposetory<T> where T :ModelBase
    {
        private protected readonly AppDbContext _dbContext;
        public GenericReposetory(AppDbContext dbContext) //ASk CLR For Creating Object From DbContext
        {
            _dbContext = dbContext; //The REFERENCE(_dbContext) will point to the REFERENCE that the clr created.
        }
        public void Add(T entity)
            =>_dbContext.Add(entity);

        public void Update(T entity)
            =>_dbContext.Update(entity);

        public void Delete(T entity)
            =>_dbContext.Remove(entity);

        public T Get(int id)
        {
            return _dbContext.Find<T>(id);

        }


        public IEnumerable<T> GetAll()
        {
            // دة عبارة عن مسكن ف الاحسن اعملها Specefication Design Battern
            if (typeof(T) == typeof(Employee))
                return (IEnumerable<T>)_dbContext.Employees.Include(E => E.Department).AsNoTracking().ToList();
            else
                return _dbContext.Set<T>().AsNoTracking().ToList();
        }

    }
}
