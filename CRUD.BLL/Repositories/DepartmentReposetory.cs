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
    public class DepartmentReposetory : GenericReposetory<Department>, IDepartmentReposetory
    {

        public DepartmentReposetory(AppDbContext dbContext)//Ask CLR Creating Object From DbContext
            : base(dbContext)
        {

        }
    }
}
