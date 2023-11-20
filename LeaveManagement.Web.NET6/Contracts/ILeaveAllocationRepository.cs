using LeaveManagement.Web.NET6.Data;

namespace LeaveManagement.Web.NET6.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
    }
}
