using LeaveManagement.Web.NET6.Data;

namespace LeaveManagement.Web.NET6.Models
{
    public class LeaveAllocationEditVM : LeaveAllocationVM
    {
        public string EmployeeId { get; set; }
        public int LeaveTypeID { get; set; }
        public EmployeeListVM Employee { get; set; }
    }
}
