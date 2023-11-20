using LeaveManagement.Web.NET6.Data;
using LeaveManagement.Web.NET6.Models;

namespace LeaveManagement.Web.NET6.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocationVM(string employeeId);
    }
}
