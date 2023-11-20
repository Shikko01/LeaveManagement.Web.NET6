using LeaveManagement.Web.NET6.Constants;
using LeaveManagement.Web.NET6.Contracts;
using LeaveManagement.Web.NET6.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.NET6.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Employee> _userManager;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public LeaveAllocationRepository(ApplicationDbContext context, UserManager<Employee> userManager, 
               ILeaveTypeRepository leaveTypeRepository) : base(context)
        {
            this._context = context;
            this._userManager = userManager;
            this._leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await _context.LeaveAllocations.AnyAsync(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId && q.Period == period);
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var leaveType = await _leaveTypeRepository.GetAsync(leaveTypeId);
            var employees = await _userManager.GetUsersInRoleAsync(Roles.User);
            var allocations = new List<LeaveAllocation>();
            var period = DateTime.Now.Year;

            foreach (var employee in employees)
            {
                if (await AllocationExists(employee.Id, leaveTypeId, period))
                    continue;

                allocations.Add(new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                });
            }
            
            await AddRangeAsync(allocations);
        }
    }
}
