using EmployeeManagementAPI.Dtos;
using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Mappings
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
        }

        private void CreateMap<T1, T2>()
        {
            throw new NotImplementedException();
        }
    }

    public class Profile
    {
    }
}
