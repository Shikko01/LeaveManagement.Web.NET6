namespace LeaveManagement.Common.Models
{
    public class LeaveAllocationEditVM : LeaveAllocationVM
    {
        public string EmployeeId { get; set; }
        public int LeaveTypeID { get; set; }
        public EmployeeListVM Employee { get; set; }
    }
}
