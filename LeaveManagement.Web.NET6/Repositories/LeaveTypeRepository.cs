using LeaveManagement.Web.NET6.Contracts;
using LeaveManagement.Web.NET6.Data;

namespace LeaveManagement.Web.NET6.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
