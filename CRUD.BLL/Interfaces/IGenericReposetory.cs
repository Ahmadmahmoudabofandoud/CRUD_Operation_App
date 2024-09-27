using CRUD.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.BLL.Interfaces
{
    public interface IGenericReposetory<T> where T : ModelBase
    {
        IEnumerable<T> GetAll();
        T Get(int id);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
