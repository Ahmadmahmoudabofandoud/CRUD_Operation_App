using AutoMapper;
using CRUD.DAL.Models;
using CRUD_Operation_App.ViewModels;

namespace CRUD_Operation_App.Helpers
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<EmployeeViewModel, Employee>().ReverseMap();
        }
    }
}
