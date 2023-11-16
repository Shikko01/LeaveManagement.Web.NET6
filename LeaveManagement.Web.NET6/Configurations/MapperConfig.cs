using AutoMapper;
using LeaveManagement.Web.NET6.Data;
using LeaveManagement.Web.NET6.Models;

namespace LeaveManagement.Web.NET6.Configurations
{
    public class MapperConfig : Profile                             
    {
        public MapperConfig()
        {
           CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
