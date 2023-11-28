using AutoMapper;
using LearnManagement.Web.Data;
using LearnManagement.Web.Models;

namespace LearnManagement.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            // source is LeaveType, destination is LeaveTypeVM
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<Employee, EmployeeListVM>().ReverseMap();
            CreateMap<Employee, EmployeeAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationEditVM>().ReverseMap();
        }
    }
}
