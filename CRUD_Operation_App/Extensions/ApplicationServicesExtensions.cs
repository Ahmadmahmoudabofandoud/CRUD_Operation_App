using CRUD.BLL;
using CRUD.BLL.Interfaces;
using CRUD.BLL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CRUD_Operation_App.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //services.AddScoped<IDepartmentReposetory, DepartmentReposetory>();

            //services.AddScoped<IEmployeeReposetory, EmployeeReposetory>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();


            return services;
        }
    }
}
 